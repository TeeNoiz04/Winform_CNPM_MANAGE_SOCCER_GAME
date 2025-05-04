using MANAGE_SOCCER_GAME.Dtos;
using MANAGE_SOCCER_GAME.Models;
using MANAGE_SOCCER_GAME.Services;
using MANAGE_SOCCER_GAME.Utils.Routing;

namespace MANAGE_SOCCER_GAME.Views.Manage_Results_Rankings
{
    public partial class RankingForm : Form
    {
        private readonly TeamService _teamService;
        private List<Team> _allTeams = new List<Team>();
        private readonly GameService _gameService;
        private List<Game> _allGames = new List<Game>();

        private LeagueTableService _leagueTableService;
        private List<LeagueTableEntry> leagueTable;
        private List<LeagueTableEntry> filteredTable;


        private Router _router;
        private int curentPage = 1;
        private int countLine = 0;
        private float totalPage = 0;
        public RankingForm(GameService gameService, TeamService teamService)
        {
            InitializeComponent();
            _router = new Router();
            _leagueTableService = new LeagueTableService();
            _gameService = gameService;
            _teamService = teamService;

            cbbSoDong.SelectedIndex = 0;
            cbbSapXep.SelectedIndex = 0;

            cbbCot.DataSource = new List<string> { "Points", "GoalDifference", "TeamName" };
            cbbCot.SelectedIndex = 0;

            if (curentPage == 1)
            {
                btnTrangTruoc.Enabled = false;
                btnTrangKe.Enabled = true;
            }

        }

        private async void LoadData()
        {
            leagueTable = _leagueTableService.CalculateLeagueTable(AppService.TournamentId, _allTeams, _allGames);

            string searchTerm = txbTimKiem.Text.ToLower();
            if (!string.IsNullOrWhiteSpace(searchTerm) && searchTerm != "search")
            {
                filteredTable = leagueTable.Where(n => n.TeamName.ToLower().Contains(searchTerm)).ToList();
                curentPage = 1;
            }
            else
            {
                filteredTable = leagueTable;
            }

            var count = filteredTable.Count;
            countLine = int.Parse(cbbSoDong.SelectedItem.ToString());
            totalPage = (float)count / countLine;
            totalPage = totalPage > (int)totalPage ? (int)totalPage + 1 : (int)totalPage;

            if (cbbCot.SelectedItem == null)
            {
                return;
            }

            var columnName = cbbCot.SelectedItem.ToString();
            var sortOrder = cbbSapXep.SelectedItem.ToString();
            if (sortOrder == "Tăng dần")
            {
                filteredTable = filteredTable.OrderBy(c => c.GetType().GetProperty(columnName)?.GetValue(c, null)).ToList();
            }
            else if (sortOrder == "Giảm dần")
            {
                filteredTable = filteredTable.OrderByDescending(c => c.GetType().GetProperty(columnName)?.GetValue(c, null)).ToList();
            }
           
            dataGridView.AutoGenerateColumns = false;
            dataGridView.DataSource = filteredTable.Skip(countLine * (curentPage - 1)).Take(countLine).ToList();

            if (countLine > count)
            {
                btnTrangTruoc.Enabled = false;
                btnTrangKe.Enabled = false;
                int rowHeight = (dataGridView.Rows.Count > 0) ? dataGridView.Rows[0].Height : 22; // hoặc giá trị mặc định
                pnContent.Size = new Size(
                    pnContent.Size.Width,
                    (rowHeight * count) + 30 + pnFooter.Size.Height
                );
            }
            else
            {
                if (curentPage == 1)
                {
                    btnTrangKe.Enabled = true;
                }
                pnContent.Size = new Size(pnContent.Size.Width, (dataGridView.Rows[0].Height * countLine) + 30 + pnFooter.Size.Height);
            }
            if (pnContent.Size.Height > this.Size.Height - pnHeader.Size.Height)
            {
                pnContent.Size = new Size(pnContent.Size.Width, this.Size.Height - pnHeader.Size.Height);
            }
            lblSoTrang.Text = $"{curentPage}/{totalPage}";
        }

        private void btnTrangTruoc_Click(object sender, EventArgs e)
        {
            if (curentPage > 1)
            {
                curentPage--;
                if (!btnTrangKe.Enabled)
                {
                    btnTrangKe.Enabled = true;
                }
            }
            if (curentPage == 1)
            {
                btnTrangTruoc.Enabled = false;
            }

            LoadData();
        }

        private void btnTrangKe_Click(object sender, EventArgs e)
        {
            if (curentPage < totalPage)
            {
                curentPage++;
                if (!btnTrangTruoc.Enabled)
                {
                    btnTrangTruoc.Enabled = true;
                }
            }
            if (curentPage == totalPage)
            {
                btnTrangKe.Enabled = false;
            }

            LoadData();
        }

        private void cbbSoDong_SelectedIndexChanged(object sender, EventArgs e)
        {
            curentPage = 1;
            LoadData();
        }

        private void cbbSapXep_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void cbbCot_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private async void btnTimKiem_ClickAsync(object sender, EventArgs e)
        {
            LoadData();
        }

        private async void txbTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                LoadData();
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

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await GetAll();
            LoadData();
        }

        private async Task GetAll()
        {
            _allGames = await _gameService.GetAllGamesAsync();
            _allTeams = await _teamService.GetAllTeamByTournamentAsync(AppService.TournamentId);
        }

        private async void RankingForm_Load(object sender, EventArgs e)
        {
            await GetAll();
            LoadData();
        }
    }
}
