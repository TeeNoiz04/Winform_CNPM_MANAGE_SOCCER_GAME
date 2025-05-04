using MANAGE_SOCCER_GAME.Dtos;
using MANAGE_SOCCER_GAME.Models;
using MANAGE_SOCCER_GAME.Services;

namespace MANAGE_SOCCER_GAME.Views.Schedule_Management
{
    public partial class UcTimeLine : UserControl
    {
        private readonly ResultDTO _resultDTO;
        private static int HomeScore { get; set; }
        private static int AwayScore { get; set; }

        public UcTimeLine(ResultDTO resultDTO)
        {
            InitializeComponent();
            _resultDTO = resultDTO;
            DisplayData();
        }
        public static void ResetScores()
        {
            HomeScore = 0;
            AwayScore = 0;
        }

        public void DisplayData()
        {
            lbMinute.Text = $"{_resultDTO.Minute}'";

            // Update scores based on goal event
            if (!string.IsNullOrEmpty(_resultDTO.GoalScorerHome))
            {
                HomeScore++;
                lbTeam1.Text = $"⚽︎ {_resultDTO.GoalScorerHome}";
                lbTeam1.Visible = true;
            }
            else
            {
                lbTeam1.Visible = false;
            }

            if (!string.IsNullOrEmpty(_resultDTO.GoalScorerAway))
            {
                AwayScore++;
                lbTeam2.Text = $"⚽︎ {_resultDTO.GoalScorerAway}"; ;
                lbTeam2.Visible = true;
            }
            else
            {
                lbTeam2.Visible = false;
            }
            lblResult.Text = $"{HomeScore} - {AwayScore}";
        }

        private void UcTimeLine_Click(object sender, EventArgs e)
        {
            var formEditFactory = AppService.Get<Func<PlayerService, TeamService, SoccerGameService, Guid,EditResultForm>>();
            var formEdit = formEditFactory(
                AppService.Get<PlayerService>(),
                AppService.Get<TeamService>(),
                AppService.Get<SoccerGameService>(),
                _resultDTO.Id
            );
            formEdit.Location = new Point(250, 140);
            formEdit.ShowDialog();
        }
    }
}
