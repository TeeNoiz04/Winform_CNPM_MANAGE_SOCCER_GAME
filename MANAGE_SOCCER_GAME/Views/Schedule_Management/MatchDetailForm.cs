using MANAGE_SOCCER_GAME.Dtos;
using MANAGE_SOCCER_GAME.Models;
using MANAGE_SOCCER_GAME.Services;
using MANAGE_SOCCER_GAME.Utils.Routing;

namespace MANAGE_SOCCER_GAME.Views.Schedule_Management
{
    public partial class MatchDetailForm : Form
    {
        private readonly GameService _gameService;
        private readonly Guid _id;
        private Router _router;
        public MatchDetailForm(GameService gameService, Guid Id)
        {
            InitializeComponent();
            _router = new Router();
            _gameService = gameService;
            _id = Id;
            this.Size = new System.Drawing.Size(1920, 930);
        }

        private async Task LoadData()
        {
            var game = await _gameService.GetGameByIdAsync(_id);
            if (game == null)
            {
                MessageBox.Show("Game not found.");
                return;
            }
            txbTeam1.Text = game.HomeTeam.Name;
            txbTeam2.Text = game.AwayTeam.Name + "";
            lblTime.Text = $"{game.DateStart.ToString("dd/MM/yyyy")} - {game.TimeStart.ToString(@"hh\:mm")}";

            if (!string.IsNullOrEmpty(game.HomeTeam.Image?.Url))
                AppService.LoadImageFromUrl(game.HomeTeam.Image.Url, picTeam1);

            if (!string.IsNullOrEmpty(game.AwayTeam.Image?.Url))
                AppService.LoadImageFromUrl(game.AwayTeam.Image.Url, picTeam2);

            lblResult.Text = $"{game.HomeScore} - {game.AwayScore}";

            if (game.Status)
            {
                lblStatus.Text = "FINISHED";
            }
            else
            {
                lblStatus.Text = "UPCOMING";
            }
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await LoadData();
            await DisplayResultAsync();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _router.LoadForm3<MatchScheduleForm>();
        }

        private async void MatchDetailForm_Load(object sender, EventArgs e)
        {
            await LoadData();
            await DisplayResultAsync();
        }

        private async void btnEditMatch_Click(object sender, EventArgs e)
        {
            var formEditFactory = AppService.Get<Func<RoundService, TeamService, GameService, Guid, EditScheduleForm>>();
            var formEdit = formEditFactory(AppService.Get<RoundService>(), AppService.Get<TeamService>(), AppService.Get<GameService>(), _id);
            formEdit.Location = new Point(250, 140);
            formEdit.ShowDialog();
            await LoadData();
        }

        private async void btnUpdateResults_Click(object sender, EventArgs e)
        {
            var formEditFactory = AppService.Get<Func<PlayerService, TeamService,SoccerGameService ,Guid, UpdateResultForm>>();
            var formEdit = formEditFactory(AppService.Get<PlayerService>(), AppService.Get<TeamService>(), AppService.Get<SoccerGameService>(), _id);
            formEdit.Location = new Point(250, 140);
            formEdit.ShowDialog();
            await LoadData();
            await DisplayResultAsync();
        }

        private async Task DisplayResultAsync()
        {
            try
            {
                var game = await _gameService.GetGameByIdAsync(_id); if (game == null) { MessageBox.Show("Trận đấu không tồn tại."); return; }

                fpanel.Controls.Clear();
                UcTimeLine.ResetScores(); // Reset scores before rendering

                var soccerGames = game.SoccerGames?.OrderBy(x => x.Minute).ToList() ?? new List<SoccerGame>();
                foreach (var soccerGame in soccerGames)
                {
                    var resultDTO = new ResultDTO
                    {
                        Id = soccerGame.Id,
                        Minute = soccerGame.Minute,
                        GoalScorerHome = soccerGame.GoalScorer?.IdTeam == game.HomeTeamId ? soccerGame.GoalScorer.Name : null,
                        GoalScorerAway = soccerGame.GoalScorer?.IdTeam == game.AwayTeamId ? soccerGame.GoalScorer.Name : null
                    };

                    var uc = new UcTimeLine(resultDTO);
                    int leftMargin = (fpanel.ClientSize.Width - uc.Width) / 2;
                    uc.Margin = new Padding(leftMargin, 10, 0, 10);
                    fpanel.Controls.Add(uc);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error displaying timeline: {ex.Message}");
            }
        }

    }
}
