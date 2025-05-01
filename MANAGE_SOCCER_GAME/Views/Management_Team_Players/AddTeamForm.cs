using MANAGE_SOCCER_GAME.Data;
using MANAGE_SOCCER_GAME.Models;
using MANAGE_SOCCER_GAME.Services;

namespace MANAGE_SOCCER_GAME.Views.Management_Team_Players
{
    public partial class AddTeamForm : Form
    {
        private readonly TournamentService _tournamentService;
        private readonly CoachService _coachService;
        private readonly TeamService _teamService;
        private IEnumerable<Tournament> _tournaments;
        private List<Coach> _coaches;
        public AddTeamForm(TournamentService tournamentService, CoachService coachService, TeamService teamService)
        {
            InitializeComponent();
            _tournamentService = tournamentService;
            _coachService = coachService;
            _teamService = teamService;
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txbUpload_Click(object sender, EventArgs e)
        {

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
                var savedCourse = await _teamService.CreateTeamAsync(team);


                AppService.ShowSuccess("Thêm đội thành công!");
                this.Close();
            }
            catch (Exception ex)
            {
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
