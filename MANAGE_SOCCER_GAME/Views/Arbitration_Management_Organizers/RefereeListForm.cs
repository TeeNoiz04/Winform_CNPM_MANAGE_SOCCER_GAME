using MANAGE_SOCCER_GAME.Models;
using MANAGE_SOCCER_GAME.Services;
using MANAGE_SOCCER_GAME.Utils.Routing;
using MANAGE_SOCCER_GAME.Views.Management_Team_Players;

namespace MANAGE_SOCCER_GAME.Views.Arbitration_Management_Organizers
{
    public partial class RefereeListForm : Form
    {
        private readonly RefereeService _refereeService;
        private Router _router;
        private int curentPage = 1;
        private int countLine = 0;
        private float totalPage = 0;
        private List<Referee> _allReferees = new List<Referee>();
        public RefereeListForm(RefereeService refereeService)
        {
            InitializeComponent();
            _router = new Router();

            cbbSoDong.SelectedIndex = 0;
            cbbSapXep.SelectedIndex = 0;
            cbbCot.DataSource = typeof(Referee).GetProperties().Select(prop => prop.Name).ToList();
            cbbCot.SelectedIndex = 0;

            if (curentPage == 1)
            {
                btnTrangTruoc.Enabled = false;
                btnTrangKe.Enabled = true;
            }

            LoadData();
            _refereeService = refereeService;
        }

        private async Task GetAll()
        {
            _allReferees = await _refereeService.GetAllRefereesAsync();
        }

        private async void LoadData()
        {
            if (!string.IsNullOrWhiteSpace(txbTimKiem.Text) && txbTimKiem.Text != "Search")
            {
                string keyword = txbTimKiem.Text.Trim().ToLower();
                var fillterSearch = _allReferees.Where(n => n.Name.ToLower().Contains(keyword)).ToList();
                if (fillterSearch == null)
                {
                    MessageBox.Show("Không tìm thấy kết quả");
                    return;
                }
                _allReferees = fillterSearch;
                curentPage = 1;
            }

            var count = _allReferees.Count;
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
                _allReferees = _allReferees.OrderBy(c => c.GetType().GetProperty(columnName)?.GetValue(c, null)).ToList();
            }
            else if (sortOrder == "Giảm dần")
            {
                _allReferees = _allReferees.OrderByDescending(c => c.GetType().GetProperty(columnName)?.GetValue(c, null)).ToList();
            }

            dataGridView.AutoGenerateColumns = false;
            dataGridView.DataSource = _allReferees.Skip(countLine * (curentPage - 1)).Take(countLine).ToList();

            if (countLine > count)
            {
                btnTrangTruoc.Enabled = false;
                btnTrangKe.Enabled = false;
                //pnContent.Size = new Size(pnContent.Size.Width, (dataGridView.Rows[0].Height * count) + 30 + pnFooter.Size.Height);
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
                Guid id = Guid.Parse(row.Cells["ID"].Value.ToString());

                // Edit
                if (e.ColumnIndex == dataGridView.Columns["Action"].Index)
                {
                    var formDetailFactory = AppService.Get<Func<RefereeService, Guid, EditRefereeForm>>();
                    var form = formDetailFactory(AppService.Get<RefereeService>(), id);
                    form.ShowDialog();
                }
                // Chi tiết
                else if (e.ColumnIndex == dataGridView.Columns["Action2"].Index && e.RowIndex >= 0)
                {
                    var result = MessageBox.Show("Bạn có chắc chắn muốn xóa cầu thủ này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No)
                    {
                        return;
                    }
                    await _refereeService.DeleteRefereeAsync(id);
                }
                await GetAll();
                LoadData();

            }
        }

        private async void btnTimKiem_ClickAsync(object sender, EventArgs e)
        {
            await GetAll();
            LoadData();
            txbTimKiem.Clear();
        }

        private async void txbTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                await GetAll();
                LoadData();
                txbTimKiem.Clear();
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

        private async void btnAddReferee_Click(object sender, EventArgs e)
        {
            var form = AppService.Get<AddRefereeForm>();
            form.Location = new Point(250, 140);
            form.ShowDialog();
            await GetAll();
            LoadData();
        }

        private async void RefereeListForm_Load(object sender, EventArgs e)
        {
            await GetAll();
            LoadData();
        }

        private async void btnRefresh_Click_1(object sender, EventArgs e)
        {
            await GetAll();
            LoadData();
        }
    }
}
