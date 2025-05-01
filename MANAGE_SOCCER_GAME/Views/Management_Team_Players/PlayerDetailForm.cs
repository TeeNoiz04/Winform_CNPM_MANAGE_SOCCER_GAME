using MANAGE_SOCCER_GAME.Models;
using MANAGE_SOCCER_GAME.Services;
using MANAGE_SOCCER_GAME.Utils.Routing;
namespace MANAGE_SOCCER_GAME.Views.Management_Team_Players
{
    public partial class PlayerDetailForm : Form
    {
        private readonly PlayerService _playerService;
        private Router _router;
        private readonly Guid _id;
        private Guid _teamId;
        public PlayerDetailForm(PlayerService playerService, Guid id)
        {
            InitializeComponent();
            _router = new Router();
            _playerService = playerService;
            _id = id;
        }


        private async void btnTimKiem_ClickAsync(object sender, EventArgs e)
        {
            //LoadData();
        }

        private async void txbTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                //LoadData();
            }
        }

        private void txbTimKiem_Click(object sender, EventArgs e)
        {
            if (txbTimKiem.Text == "Search")
            {
                txbTimKiem.Text = string.Empty;
                txbTimKiem.ForeColor = Color.Black;
            }
        }

        private void txbTimKiem_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbTimKiem.Text) || txbTimKiem.Text == "Search")
            {
                txbTimKiem.Text = "Search";
                txbTimKiem.ForeColor = Color.DarkGray;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var formDetailFactory = AppService.Get<Func<TeamService, PlayerService, Guid, TeamDetailForm>>();
            var form = formDetailFactory(AppService.Get<TeamService>(), AppService.Get<PlayerService>(), _teamId);
            _router.LoadForm3(form);
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            var formEditFactory = AppService.Get<Func<PlayerService, Guid, EditPlayerForm>>();
            var formEdit = formEditFactory(AppService.Get<PlayerService>(), _id);
            formEdit.Location = new Point(250, 140);
            formEdit.ShowDialog();
            await LoadData();
        }

        private async Task LoadData()
        {
            var players = await _playerService.GetPlayerDetailByIdAsync(_id);
            if (players != null)
            {
                _teamId = players.TeamId.Value;
                lblName.Text = players.Name;
                lblPosition.Text = players.Position;
                lblAge.Text = players.Age.ToString();
                lblHeight.Text = players.Height.ToString();
                lblGoalsScored.Text = players.TotalGoals.ToString();
                lblAssists.Text = players.TotalAssists.ToString();
                lblMatchPlayed.Text = players.TotalMatches.ToString();
                lblYellowCards.Text = players.TotalYellowCards.ToString();
                lblRedCards.Text = players.TotalRedCards.ToString();
                lblNameClub.Text = players.TeamName;
            }
            else
            {
                MessageBox.Show("Player not found.");
            }
        }

        private async void PlayerDetailForm_Load(object sender, EventArgs e)
        {
            await LoadData();
        }
    }
}
