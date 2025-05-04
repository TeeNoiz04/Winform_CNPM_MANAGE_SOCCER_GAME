using MANAGE_SOCCER_GAME.Models;
using MANAGE_SOCCER_GAME.Services;
namespace MANAGE_SOCCER_GAME.Views.Arbitration_Management_Organizers
{
    public partial class AddAssignReferee : Form
    {
        private readonly MatchOfficialService _matchOfficialService;
        private readonly RoundService _roundService;
        private readonly RefereeService _refereeService;
        private readonly GameService _gameService;
        private List<Round> _rounds;
        private List<Referee> _referees;
        bool isLoaded = true;

        public AddAssignReferee(MatchOfficialService matchOfficialService, RoundService roundService,
            RefereeService refereeService, GameService gameService)
        {
            isLoaded = true;
            InitializeComponent();
            _matchOfficialService = matchOfficialService;
            _roundService = roundService;
            _refereeService = refereeService;
            _gameService = gameService;
            _rounds = new List<Round>();
            _referees = new List<Referee>();
        }
        private async void AddAssignReferee_Load(object sender, EventArgs e)
        {
            await LoadData();

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async Task LoadData()
        {
            _rounds = await _roundService.GetAllRoundsForComboBoxAsync();
            _referees = await _refereeService.GetAllRefereesAsync();

            if (_rounds == null || _referees == null)
            {
                MessageBox.Show("No data found.");
                return;
            }
            cbbRound.DataSource = _rounds;
            cbbRound.DisplayMember = "Name";
            cbbRound.ValueMember = "Id";

            cbbReferee.DataSource = _referees;
            cbbReferee.DisplayMember = "Name";
            cbbReferee.ValueMember = "Id";
            isLoaded = false;
        }
        
        private async void cbbGame_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoaded) return;
           Guid roundId = (Guid)cbbRound.SelectedValue;
            var games = await _gameService.GetGamesByRoundIdAsync(roundId);

            if (games == null)
            {
                MessageBox.Show("No games found for the selected round.");
                return;
            }

            cbbGame.DataSource = games;
            cbbGame.DisplayMember = "Name";  // Hoặc trường khác mô tả trận đấu
            cbbGame.ValueMember = "Id";
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn phân công trọng tài cho trận này?", "Xác nhận", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            var match = new MatchOfficials
            {
                IdGame = (Guid)cbbGame.SelectedValue,
                IdReferee = (Guid)cbbReferee.SelectedValue,
            };

            try
            {
                var createCoach = await _matchOfficialService.CreateMatchOfficialAsync(match);

                AppService.ShowSuccess("Phân công trọng tài thành công!");
                this.Close();
            }
            catch (Exception ex)
            {
                AppService.ShowError("Lỗi khi Phân công trọng tài: " + ex.Message);
            }
        }
    }
}
