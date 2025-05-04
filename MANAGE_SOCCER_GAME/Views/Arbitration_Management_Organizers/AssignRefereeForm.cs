using MANAGE_SOCCER_GAME.Dtos;
using MANAGE_SOCCER_GAME.Services;
using MANAGE_SOCCER_GAME.Utils.Routing;
namespace MANAGE_SOCCER_GAME.Views.Arbitration_Management_Organizers
{
    public partial class AssignRefereeForm : Form
    {
        private readonly MatchOfficialService _matchOfficialService;
        private readonly GameService _gameService;
        private readonly RefereeService _refereeService;
        private List<MatchOfficialDTO> _allMatch = new List<MatchOfficialDTO>();
        private Router _router;
        private int curentPage = 1;
        private int countLine = 0;
        private float totalPage = 0;
        public AssignRefereeForm(GameService gameService, RefereeService refereeService, MatchOfficialService matchOfficialService)
        {
            InitializeComponent();
            _router = new Router();
            _gameService = gameService;
            _refereeService = refereeService;
            _matchOfficialService = matchOfficialService;

            cbbSoDong.SelectedIndex = 0;
            cbbSapXep.SelectedIndex = 0;
            cbbCot.DataSource = typeof(MatchOfficialDTO).GetProperties().Select(prop => prop.Name).ToList();
            cbbCot.SelectedIndex = 0;

            if (curentPage == 1)
            {
                btnTrangTruoc.Enabled = false;
                btnTrangKe.Enabled = true;
            }

        }

        private async Task Getall()
        {
            _allMatch = await _matchOfficialService.GetAllMatchOfficialsAsync();
        }

        private async void LoadData()
        {
            if (!string.IsNullOrWhiteSpace(txbTimKiem.Text) && txbTimKiem.Text != "Search")
            {
                string keyword = txbTimKiem.Text.Trim().ToLower();
                var fillterSearch = _allMatch.Where(n => n.RefereeName.ToLower().Contains(keyword)).ToList();
                if (fillterSearch == null)
                {
                    MessageBox.Show("Không tìm thấy kết quả");
                    return;
                }
                _allMatch = fillterSearch;
                curentPage = 1;
            }

            var count = _allMatch.Count;
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
                _allMatch = _allMatch.OrderBy(c => c.GetType().GetProperty(columnName)?.GetValue(c, null)).ToList();
            }
            else if (sortOrder == "Giảm dần")
            {
                _allMatch = _allMatch.OrderByDescending(c => c.GetType().GetProperty(columnName)?.GetValue(c, null)).ToList();
            }

            dataGridView.AutoGenerateColumns = false;
            dataGridView.DataSource = _allMatch.Skip(countLine * (curentPage - 1)).Take(countLine).ToList();

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

        private async void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];
                Guid refereeId = Guid.Parse(row.Cells["RefereeId"].Value.ToString());
                Guid gameId = Guid.Parse(row.Cells["GameId"].Value.ToString());

                // Delete
                if (e.ColumnIndex == dataGridView.Columns["Action"].Index)
                {
                    var result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        bool isDeleted = await _matchOfficialService.DeleteMatchOfficialAsync(refereeId, gameId);
                        if (isDeleted)
                        {
                            MessageBox.Show("Xóa thành công");
                        }
                        else
                        {
                            MessageBox.Show("Xóa không thành công");
                        }
                    }
                }
                await Getall();
                LoadData();
            }
        }

        private async void btnTimKiem_ClickAsync(object sender, EventArgs e)
        {
            await Getall();
            LoadData();
        }

        private async void txbTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                await Getall();
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

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            var form = AppService.Get<AddAssignReferee>();
            form.Location = new Point(250, 140);
            form.ShowDialog();
            await Getall();
            LoadData();
        }

        private async void AssignRefereeForm_Load(object sender, EventArgs e)
        {
            await Getall();
            LoadData();
        }
    }
}
