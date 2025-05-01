using CloudinaryDotNet;
using MANAGE_SOCCER_GAME.Data;
using MANAGE_SOCCER_GAME.Dtos;
using MANAGE_SOCCER_GAME.Models;
using MANAGE_SOCCER_GAME.Services;
using MANAGE_SOCCER_GAME.Utils.Routing;
using System.Data;

namespace MANAGE_SOCCER_GAME.Views.Management_Team_Players
{
    public partial class TeamDetailForm : Form
    {
        private readonly TeamService _teamService;
        private readonly PlayerService _playerService;
        private readonly Guid _id;
        private Router _router;
        private int curentPage = 1;
        private int countLine = 10;
        private float totalPage = 0;
        private List<PlayerViewDTO> _allPlayers = new List<PlayerViewDTO>();


        public TeamDetailForm(TeamService teamService, PlayerService playerService, Guid id)
        {
            InitializeComponent();
            _router = new Router();
            _playerService = playerService;
            _teamService = teamService;
            _id = id;

            cbbSoDong.SelectedIndex = 0;
            cbbSapXep.SelectedIndex = 0;
            cbbCot.DataSource = typeof(PlayerViewDTO).GetProperties().Select(prop => prop.Name).ToList();
            cbbCot.SelectedIndex = 0;

            if (curentPage == 1)
            {
                btnTrangTruoc.Enabled = false;
                btnTrangKe.Enabled = true;
            }
        }

        private async Task Getall()
        {
            _allPlayers = await _playerService.GetAllPlayersByTeamIdAsync(_id);
        }

        private void LoadData()
        {
            if (!string.IsNullOrWhiteSpace(txbTimKiem.Text) && txbTimKiem.Text != "Search")
            {
                string keyword = txbTimKiem.Text.Trim().ToLower();
                var fillterSearch = _allPlayers.Where(n => n.Name.ToLower().Contains(keyword)).ToList();
                if (fillterSearch == null)
                {
                    MessageBox.Show("Không tìm thấy kết quả");
                    return;
                }
                _allPlayers = fillterSearch;
                curentPage = 1;
            }

            var count = _allPlayers.Count;
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
                _allPlayers = _allPlayers.OrderBy(c => c.GetType().GetProperty(columnName)?.GetValue(c, null)).ToList();
            }
            else if (sortOrder == "Giảm dần")
            {
                _allPlayers = _allPlayers.OrderByDescending(c => c.GetType().GetProperty(columnName)?.GetValue(c, null)).ToList();
            }

            dataGridView.AutoGenerateColumns = false;

            //dataGridView.Columns["ID"].DataPropertyName = "MaHD";
            //dataGridView.Columns["TimeStamp"].DataPropertyName = "NgayGD";
            //dataGridView.Columns["PhuongThucGD"].DataPropertyName = "PhuongThucGD";
            //dataGridView.Columns["Price"].DataPropertyName = "TongTien";
            //dataGridView.Columns["Username"].DataPropertyName = "TenKH";
            //dataGridView.Columns["IsCheck"].DataPropertyName = "IsCheck";
            //dataGridView.Columns["Action"].AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            //dataGridView.Columns["Action2"].AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            //dataGridView.Columns["Action"].Width = 100;
            //dataGridView.Columns["Action2"].Width = 100;
            dataGridView.DataSource = _allPlayers.Skip(countLine * (curentPage - 1)).Take(countLine).ToList();

            if (countLine > count)
            {
                btnTrangTruoc.Enabled = false;
                btnTrangKe.Enabled = false;
    // Dòng lỗi
                //pnContent.Size = new Size(pnContent.Size.Width, (dataGridView.Rows[0].Height * count) + 30 + pnFooter.Size.Height);
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

        private async void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];
                Guid id = Guid.Parse(row.Cells["ID"].Value.ToString());
                var formDetailFactory = AppService.Get<Func<PlayerService, Guid, PlayerDetailForm>>();

                // Duyệt
                if (e.ColumnIndex == dataGridView.Columns["Action"].Index)
                {
                    var form = formDetailFactory(AppService.Get<PlayerService>(), id);
                    _router.LoadForm3(form);
                       
                }
                // Chi tiết
                else if (e.ColumnIndex == dataGridView.Columns["Action2"].Index && e.RowIndex >= 0)
                {
                    var result = MessageBox.Show("Bạn có chắc chắn muốn xóa cầu thủ này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No) {
                        return;
                    }
                    await _playerService.DeletePlayerAsync(id);
                    await Getall();
                    LoadData();
                }

            }    
        }

        private void btnTimKiem_ClickAsync(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txbTimKiem_KeyPress(object sender, KeyPressEventArgs e)
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
            await Getall();
            LoadData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _router.LoadForm3<TeamListForm>();
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            var formEditFactory = AppService.Get<Func<TournamentService, TeamService, CoachService, 
                CloudService, ImageTeamService, Guid, EditTeamForm>>();
            var form = formEditFactory(AppService.Get<TournamentService>(), _teamService, AppService.Get<CoachService>(),
                AppService.Get<CloudService>(), AppService.Get<ImageTeamService>(), _id);

            form.Location = new Point(250, 140);
            form.ShowDialog();
            await LoadTeam();
        }

        private async void btnAddPlayer_Click(object sender, EventArgs e)
        {
            var formAddFactory = AppService.Get<Func<PlayerService, CloudService, ImagePlayerService,Guid, AddPlayerForm>>();
            var form = formAddFactory(_playerService, AppService.Get<CloudService>(), AppService.Get<ImagePlayerService>(), _id);
            form.Location = new Point(250, 140);
            form.ShowDialog();
            await Getall();
            LoadData();
        }

        private async void TeamDetailForm_Load(object sender, EventArgs e)
        {
            await Getall();
            await LoadTeam();
            LoadData();
        }

        private async Task LoadTeam()
        {
            var team = await _teamService.GetTeamByIdAsync(_id);
            if (team != null)
            {
                lblName.Text = team.Name;
                lblCode.Text = team.Id.ToString();
                lblStadium.Text = team.Province;
                lblCoach.Text = team.Coach.Name;
                if (!string.IsNullOrEmpty(team.Image?.Url))
                    AppService.LoadImageFromUrl(team.Image.Url, picLogo);

            }
        }
    }
}

