using MANAGE_SOCCER_GAME.Models;
using MANAGE_SOCCER_GAME.Services;

namespace MANAGE_SOCCER_GAME.Views.Management_Team_Players
{
    public partial class AddTeamForm : Form
    {
        private readonly TournamentService _tournamentService;
        private readonly CoachService _coachService;
        private readonly TeamService _teamService;
        private readonly CloudService _cloudService;
        private readonly ImageTeamService _imageTeamService;
        private IEnumerable<Tournament> _tournaments;
        private List<Coach> _coaches;
        private ImageTeam _tempImage;


        public AddTeamForm(TournamentService tournamentService, 
            CoachService coachService, TeamService teamService, 
            CloudService cloudService, ImageTeamService imageTeamService)
        {
            InitializeComponent();
            _tournamentService = tournamentService;
            _coachService = coachService;
            _teamService = teamService;
            _cloudService = cloudService;
            _imageTeamService = imageTeamService;
            _tournaments = new List<Tournament>();
            _coaches = new List<Coach>();
        }

        private void txbTeamname_MouseLeave(object sender, EventArgs e)
        {
            txbTeamname.BorderColor = Color.FromArgb(52, 52, 116);
        }

        private void txbTeamname_MouseHover(object sender, EventArgs e)
        {
            txbTeamname.BorderColor = Color.FromArgb(60, 211, 252);
        }

        private void txbTeamname_Leave(object sender, EventArgs e)
        {
            if (txbTeamname.Text == string.Empty)
            {
                txbTeamname.Text = "Team name";
                txbTeamname.ForeColor = Color.Silver;
            }
        }

        private void txbTeamname_Click(object sender, EventArgs e)
        {
            if (txbTeamname.Text == "Team name")
            {
                txbTeamname.Text = string.Empty;
                txbTeamname.ForeColor = Color.FromArgb(60, 211, 252);
                txbTeamname.BorderColor = Color.FromArgb(60, 211, 252);
            }
        }

        private void txbProvince_MouseLeave(object sender, EventArgs e)
        {
            txbProvince.BorderColor = Color.FromArgb(52, 52, 116);
        }

        private void txbProvince_MouseHover(object sender, EventArgs e)
        {
            txbProvince.BorderColor = Color.FromArgb(60, 211, 252);
        }

        private void txbProvince_Leave(object sender, EventArgs e)
        {
            if (txbProvince.Text == string.Empty)
            {
                txbProvince.Text = "Province";
                txbProvince.ForeColor = Color.Silver;
            }
        }

        private void txbProvince_Click(object sender, EventArgs e)
        {
            if (txbProvince.Text == "Province")
            {
                txbProvince.Text = string.Empty;
                txbProvince.ForeColor = Color.FromArgb(60, 211, 252);
                txbProvince.BorderColor = Color.FromArgb(60, 211, 252);
            }
        }

        private async void btnCancel_Click(object sender, EventArgs e)
        {
            if (_tempImage != null)
                await _cloudService.DeleteImageAsync(_tempImage.PublicId);
            this.Close();
        }

        private async void txbUpload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif";
                openFileDialog.Title = "Chọn ảnh đội";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    string altText = "Ảnh đại diện đội";

                    try
                    {
                        var imageDTO = await _cloudService.UploadImageAsync(filePath, null, altText);
                        if (imageDTO != null)
                        {
                            picAvatar.ImageLocation = imageDTO.Url;
                            _tempImage = new ImageTeam
                            {
                                PublicId = imageDTO.PublicId,
                                Url = imageDTO.Url,
                                AltText = altText
                            };
                        }
                        else
                        {
                            MessageBox.Show("Không thể tải ảnh lên.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi tải ảnh: {ex.Message}");
                    }
                }
            }
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!ValidateTeamInput())
                return;

            if (MessageBox.Show("Bạn có chắc chắn muốn thêm đội này?", "Xác nhận", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            var team = new Team
            {
                Name = txbTeamname.Text.Trim(),
                Province = txbProvince.Text.Trim(),
                IdTournament = (Guid)cbbTournament.SelectedValue,
                IdCoach = (Guid)cbbCoach.SelectedValue,
                IdImage = null
            };

            try
            {
                var createdTeam = await _teamService.CreateTeamAsync(team);
                if (_tempImage != null)
                {
                    _tempImage.TeamId = createdTeam.Id;
                    var savedImage = await _imageTeamService.CreateImageAsync(_tempImage);
                    createdTeam.IdImage = savedImage.Id;
                    await _teamService.UpdateTeamAsync(createdTeam.Id, createdTeam);
                }

                AppService.ShowSuccess("Thêm đội thành công!");
                this.Close();
            }
            catch (Exception ex)
            {
                if (_tempImage != null)
                    await _cloudService.DeleteImageAsync(_tempImage.PublicId);
                AppService.ShowError("Lỗi khi thêm đội: " + ex.Message);
            }
        }

        private async void AddTeamForm_Load(object sender, EventArgs e)
        {
            await LoadTournament();
            await LoadCoach();
        }

        private async Task LoadTournament()
        {
            _tournaments = await _tournamentService.GetAllTournamentsAsync();
            cbbTournament.DataSource = _tournaments;
            cbbTournament.DisplayMember = "Name";
            cbbTournament.ValueMember = "Id";
        }

        private async Task LoadCoach()
        {
            _coaches = await _coachService.GetAllCoachesAsync();
            cbbCoach.DataSource = _coaches;
            cbbCoach.DisplayMember = "Name";
            cbbCoach.ValueMember = "Id";
        }

        private bool ValidateTeamInput()
        {
            if (AppService.IsEmptyInput(txbTeamname, txbProvince))
                return false;

            return true;
        }
    }
}
