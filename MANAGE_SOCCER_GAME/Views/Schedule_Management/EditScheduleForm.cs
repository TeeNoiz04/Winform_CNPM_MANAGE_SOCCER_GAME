using MANAGE_SOCCER_GAME.Dtos;
using MANAGE_SOCCER_GAME.Models;
using MANAGE_SOCCER_GAME.Services;

namespace MANAGE_SOCCER_GAME.Views.Schedule_Management
{
    public partial class EditScheduleForm : Form
    {
        private RoundService _roundService;
        private TeamService _teamService;
        private GameService _gameService;
        private List<Round> _rounds;
        private List<TeamDTO> _teamHomes;
        private List<TeamDTO> _teamAways;
        private readonly Guid _id;

        public EditScheduleForm(RoundService roundService, TeamService teamService, GameService gameService, Guid id)
        {
            InitializeComponent();
            _roundService = roundService;
            _teamService = teamService;
            _gameService = gameService;
            _rounds = new List<Round>();
            _teamHomes = new List<TeamDTO>();
            _teamAways = new List<TeamDTO>();
            _id = id;
            dtStartDate.Format = DateTimePickerFormat.Custom;
            dtStartDate.CustomFormat = "dd/MM/yyyy";

            dtStartTime.Format = DateTimePickerFormat.Custom;
            dtStartTime.CustomFormat = "HH:mm";
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn cập nhật lịch đấu này?", "Xác nhận", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            var game = new Game
            {
                RoundId = (Guid)cbRound.SelectedValue,
                DateStart = dtStartDate.Value.Date,
                TimeStart = dtStartTime.Value.TimeOfDay,
                HomeTeamId = (Guid)cbHomeTeam.SelectedValue,
                AwayTeamId = (Guid)cbAwayTeam.SelectedValue
            };

            try
            {
                var createdGames = await _gameService.UpdateGameAsync(_id, game);

                AppService.ShowSuccess("Cập nhật lịch đấu thành công!");
                this.Hide();
            }
            catch (Exception ex)
            {
                AppService.ShowError("Lỗi khi cập nhật lịch vòng đấu: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private async Task LoadData()
        {
            _rounds = await _roundService.GetAllRoundsAsync();
            _teamHomes = await _teamService.GetAllTeamByTournamentIdAsync(AppService.TournamentId);
            _teamAways = await _teamService.GetAllTeamByTournamentIdAsync(AppService.TournamentId);

            cbRound.DataSource = _rounds;
            cbRound.DisplayMember = "Name";
            cbRound.ValueMember = "Id";

            cbHomeTeam.DataSource = _teamHomes;
            cbHomeTeam.DisplayMember = "Name";
            cbHomeTeam.ValueMember = "Id";

            cbAwayTeam.DataSource = _teamAways;
            cbAwayTeam.DisplayMember = "Name";
            cbAwayTeam.ValueMember = "Id";

            var game = await _gameService.GetGameByIdAsync(_id);
            if (game != null)
            {
                cbRound.SelectedValue = game.RoundId;
                dtStartDate.Value = game.DateStart;
                dtStartTime.Value = DateTime.Today.Add(game.TimeStart);
                cbHomeTeam.SelectedValue = game.HomeTeamId;
                cbAwayTeam.SelectedValue = game.AwayTeamId;
            }
            else
            {
                MessageBox.Show("Lịch đấu không tồn tại.");
            }
        }

        private async void EditScheduleForm_Load(object sender, EventArgs e)
        {
           
            await LoadData();
        }

        private async void cbRound_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRound.SelectedValue == null) return;

            try
            {
                Guid roundId = Guid.Parse(cbRound.SelectedValue.ToString());
                var selectedRound = await _roundService.GetRoundByIdAsync(roundId);
                if (selectedRound != null)
                {
                    lblStartDateR.Text = selectedRound.StartDate.ToString("dd/MM/yyyy");
                    lblEndDateR.Text = selectedRound.EndDate.ToString("dd/MM/yyyy");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy thông tin vòng đấu: " + ex.Message);
            }
        }
    }
}
