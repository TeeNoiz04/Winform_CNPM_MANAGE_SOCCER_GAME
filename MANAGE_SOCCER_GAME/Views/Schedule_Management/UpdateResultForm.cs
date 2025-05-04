using MANAGE_SOCCER_GAME.Models;
using MANAGE_SOCCER_GAME.Services;

namespace MANAGE_SOCCER_GAME.Views.Schedule_Management
{
    public partial class UpdateResultForm : Form
    {
        private readonly PlayerService _playerService;
        private readonly TeamService _teamService;
        private readonly SoccerGameService _soccerGameService;
        private readonly Guid _gameId;
        private List<Player> _allGoalSoccer;
        private List<Player> _allAssitant;
        private bool isInitializing = true;

        public UpdateResultForm(PlayerService playerService, TeamService teamService, SoccerGameService soccerGameService,Guid gameId)
        {
            isInitializing = true; // Bắt đầu khởi tạo
            InitializeComponent();
            _playerService = playerService;
            _teamService = teamService;
            _soccerGameService = soccerGameService;
            _gameId = gameId;
            _allGoalSoccer = new List<Player>();
            _allAssitant = new List<Player>();
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
                GameId = _gameId,
            };

            try
            {
                var created = await _soccerGameService.CreateSoccerGameAsync(soccerGame);

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
            var game = await _teamService.GetGameWithTeamsAsync(_gameId);
            if (game == null)
            {
                MessageBox.Show("Không tìm thấy trận đấu.");
                return;
            }

            // Lấy danh sách đội bóng
            var teams = new List<Team> { game.HomeTeam, game.AwayTeam };

            cbTeam.DataSource = teams;
            cbTeam.DisplayMember = "Name";
            cbTeam.ValueMember = "Id";
        }

        private async void cbTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isInitializing) return;
            if (cbTeam.SelectedItem is Team selectedTeam)
            {
                var players = await _playerService.GetPlayersByTeamIdAsync(selectedTeam.Id);
                var assitants = await _playerService.GetPlayersByTeamIdAsync(selectedTeam.Id);

                _allGoalSoccer = players;
                _allAssitant = assitants;

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
            await LoadData();
            isInitializing = false;
            // Kết thúc khởi tạo
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
