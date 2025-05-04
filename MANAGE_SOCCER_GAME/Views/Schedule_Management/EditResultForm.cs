using MANAGE_SOCCER_GAME.Models;
using MANAGE_SOCCER_GAME.Services;
namespace MANAGE_SOCCER_GAME.Views.Schedule_Management
{
    public partial class EditResultForm : Form
    {
        private readonly PlayerService _playerService;
        private readonly TeamService _teamService;
        private readonly SoccerGameService _soccerGameService;
        private List<Player> _allGoalSoccer;
        private List<Player> _allAssitant;
        private bool isInitializing = true;
        private readonly Guid _soccerId;
        private SoccerGame _soccerGame;

        public EditResultForm(PlayerService playerService, TeamService teamService, SoccerGameService soccerGameService, Guid id)
        {
            isInitializing = true; // Bắt đầu khởi tạo
            InitializeComponent();
            _playerService = playerService;
            _teamService = teamService;
            _soccerGameService = soccerGameService;
            _allGoalSoccer = new List<Player>();
            _allAssitant = new List<Player>();
            _soccerId = id;

        }

        private void ckbAssitant_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbAssitant.Checked)
            {
                cbAssitant.Enabled = true;
                cbAssitant.DataSource = null;
                cbAssitant.DataSource = _allAssitant;
                cbAssitant.DisplayMember = "Name";
                cbAssitant.ValueMember = "Id";
            }
            else
                cbAssitant.Enabled = false;
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn cập nhật kết quả này?", "Xác nhận", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;
            if (string.IsNullOrEmpty(txbTime.Text))
            {
                MessageBox.Show("Thời gian không được để trống.");
                return;
            }
            var soccerGame = new SoccerGame
            {
                Minute = int.Parse(txbTime.Text),
                SoccerType = cbSoccerType.SelectedItem as string,
                GoalScorerId = (Guid)cbGoalScorer.SelectedValue,
                AssitantId = ckbAssitant.Checked ? (Guid?)cbAssitant.SelectedValue : null,
                GameId = _soccerGame.GameId,
            };

            try
            {
                var created = await _soccerGameService.UpdateSoccerGameAsync(_soccerGame.Id, soccerGame);

                AppService.ShowSuccess("Cập nhật kết quả thành công!");
                this.Hide();
            }
            catch (Exception ex)
            {
                AppService.ShowError("Lỗi khi cập nhật kết quả: " + ex.Message);
            }
        }

        private async Task LoadData()
        {
            try
            {
                var game = await _teamService.GetGameWithTeamsAsync(_soccerGame.GameId);
                if (game == null)
                {
                    MessageBox.Show("Không tìm thấy trận đấu.");
                    this.Close();
                    return;
                }

                var teams = new List<Team> { game.HomeTeam, game.AwayTeam };
                cbTeam.DataSource = teams;
                cbTeam.DisplayMember = "Name";
                cbTeam.ValueMember = "Id";

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu trận đấu: {ex.Message}");
                this.Close();
            }
        }

        private async Task cbTeam_SelectedIndexChangedAsync()
        {
            if (cbTeam.SelectedItem is Team selectedTeam)
            {
                var players = await _playerService.GetPlayersByTeamIdAsync(selectedTeam.Id);
                var playe = await _playerService.GetPlayersByTeamIdAsync(selectedTeam.Id);

                _allGoalSoccer = players;
                _allAssitant = playe;

                cbGoalScorer.DataSource = null;
                cbGoalScorer.DataSource = _allGoalSoccer;
                cbGoalScorer.DisplayMember = "Name";
                cbGoalScorer.ValueMember = "Id";

                if (ckbAssitant.Checked)
                {
                    cbAssitant.DataSource = null;
                    cbAssitant.DataSource = _allAssitant;
                    cbAssitant.DisplayMember = "Name";
                    cbAssitant.ValueMember = "Id";
                }
            }
        }


        private async void UpdateResultForm_Load(object sender, EventArgs e)
        {
            try
            {
                _soccerGame = await _soccerGameService.GetSoccerGameByIdAsync(_soccerId);
                if (_soccerGame == null)
                {
                    MessageBox.Show("Không tìm thấy sự kiện trận đấu.");
                    this.Close();
                    return;
                }

                await LoadData();
                await PopulateEditData();
                isInitializing = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}");
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async Task PopulateEditData()
        {
            try
            {
                txbTime.Text = _soccerGame.Minute.ToString();
                cbSoccerType.SelectedItem = _soccerGame.SoccerType ?? "Normal";

                // Load danh sách cầu thủ theo đội
                if (_soccerGame.GoalScorer?.Team != null)
                {
                    cbTeam.SelectedValue = _soccerGame.GoalScorer.Team.Id;
                    await cbTeam_SelectedIndexChangedAsync(); // dùng version async
                    cbGoalScorer.SelectedValue = _soccerGame.GoalScorerId;
                }

                if (_soccerGame.AssitantId.HasValue)
                {
                    ckbAssitant.Checked = true;
                    cbAssitant.Enabled = true;
                    cbAssitant.SelectedValue = _soccerGame.AssitantId;
                }
                else
                {
                    ckbAssitant.Checked = false;
                    cbAssitant.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi điền dữ liệu: {ex.Message}");
            }
        }

        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa kết quả này?", "Xác nhận", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            try
            {
                var delete = await _soccerGameService.DeleteSoccerGameAsync(_soccerGame.Id);
                if (delete)
                {
                    AppService.ShowSuccess("Xóa kết quả thành công!");
                    this.Hide();
                }
                else
                {
                    AppService.ShowError("Lỗi khi xóa kết quả.");
                }
            }
            catch (Exception ex)
            {
                AppService.ShowError("Lỗi khi xóa kết quả: " + ex.Message);
            }
        }

    }
}
