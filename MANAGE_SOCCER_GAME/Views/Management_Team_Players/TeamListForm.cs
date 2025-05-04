using Guna.UI2.WinForms;
using MANAGE_SOCCER_GAME.Dtos;
using MANAGE_SOCCER_GAME.Services;
using MANAGE_SOCCER_GAME.Utils.Routing;
using Microsoft.VisualBasic.Devices;
using System.ComponentModel.DataAnnotations;
using System.Data;
using static System.Collections.Specialized.BitVector32;

namespace MANAGE_SOCCER_GAME.Views.Management_Team_Players
{
    public partial class TeamListForm : Form
    {
        private readonly TeamService _teamService;
        private Router _router;
        private int curentPage = 1;
        private int countLine = 10;
        private float totalPage = 0;
        private List<TeamDTO> _allTeams = new List<TeamDTO>();
        private List<TeamDTO> _filteredTeams = new List<TeamDTO>();

        private bool isInitializing = true;

        public TeamListForm(TeamService teamService)
        {
            InitializeComponent();
            _teamService = teamService;
            _router = new Router();

            isInitializing = true; // Bắt đầu khởi tạo


            cbbSoDong.SelectedIndex = 0;
            cbbSapXep.SelectedIndex = 0;
            var props = typeof(TeamDTO).GetProperties()
            .Select(prop =>
            {
                var displayAttr = prop.GetCustomAttributes(typeof(DisplayAttribute), false)
                                      .Cast<DisplayAttribute>()
                                      .FirstOrDefault();
                return new
                {
                    Value = prop.Name,
                    Display = displayAttr?.Name ?? prop.Name
                };
            })
            .ToList();

            cbbCot.DataSource = props;
            cbbCot.ValueMember = "Value";
            cbbCot.DisplayMember = "Display";

            cbbCot.SelectedIndex = 0;

            if (curentPage == 1)
            {
                btnTrangTruoc.Enabled = false;
                btnTrangKe.Enabled = true;
            }
            isInitializing = false;

        }

        private async Task LoadData(bool isReload = false)
        {
            try
            {
                if (isReload || _allTeams.Count == 0)
                {
                    _allTeams = await _teamService.GetAllTeamByTournamentIdAsync(AppService.TournamentId);
                    _filteredTeams = new List<TeamDTO>(_allTeams);
                }


                string selectedColumn = cbbCot.SelectedValue?.ToString();
                string sortDirection = cbbSapXep.SelectedItem?.ToString();

                if (!string.IsNullOrEmpty(selectedColumn))
                {
                    var propInfo = typeof(TeamDTO).GetProperty(selectedColumn);
                    if (propInfo != null)
                    {
                        if (sortDirection == "Tăng dần")
                            _filteredTeams = _filteredTeams.OrderBy(x => propInfo.GetValue(x, null)).ToList();
                        else if (sortDirection == "Giảm dần")
                            _filteredTeams = _filteredTeams.OrderByDescending(x => propInfo.GetValue(x, null)).ToList();
                    }
                }

                var count = _filteredTeams.Count;
                countLine = int.Parse(cbbSoDong.SelectedItem.ToString());
                totalPage = (float)count / countLine;
                totalPage = totalPage > (int)totalPage ? (int)totalPage + 1 : (int)totalPage;

                dataGridView.DataSource = _filteredTeams.Skip(countLine * (curentPage - 1)).Take(countLine).ToList();

                if (countLine > count)
                {
                    btnTrangTruoc.Enabled = false;
                    btnTrangKe.Enabled = false;
                    pnContent.Size = new Size(pnContent.Size.Width, (dataGridView.Rows[0].Height * count) + 30 + pnFooter.Size.Height);
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
            catch (Exception ex)
            {
                AppService.ShowError("Lỗi khi tải danh sách team: " + ex.Message);
            }
        }

        private async void btnTrangTruoc_Click(object sender, EventArgs e)
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

            await LoadData();
        }

        private async void btnTrangKe_Click(object sender, EventArgs e)
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

            await LoadData();
        }

        private async void cbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isInitializing) return;
            countLine = int.Parse(cbbSoDong.SelectedItem.ToString());
            curentPage = 1;
            await LoadData();
        }

        private async void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Guid teamId = Guid.Parse(dataGridView.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                var clickedColumn = dataGridView.Columns[e.ColumnIndex].Name;
                var formDetailFactory = AppService.Get<Func<TeamService, PlayerService, Guid, TeamDetailForm>>();

                if (clickedColumn == "Detail")
                {
                    var form = formDetailFactory(_teamService, AppService.Get<PlayerService>(), teamId);
                    _router.LoadForm3(form);
                }
                else if (clickedColumn == "Delete")
                {
                    var result = MessageBox.Show("Bạn có chắc chắn muốn xóa đội bóng này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.No)
                        return;

                    await _teamService.DeleteTeamAsync(teamId);
                    await LoadData(true);
                }
            }
            //}
            //// Delete
            //else if (e.ColumnIndex == dataGridView.Columns["Action2"].Index && e.RowIndex >= 0)
            //{
            //    //_action.LoadDetailOrders(id);
            //}
        }

        private async void btnTimKiem_ClickAsync(object sender, EventArgs e)
        {

            string keyword = txbTimKiem.Text.Trim().ToLower();
            bool success = FilterTeams(keyword);
            if (success)
                await LoadData(); // chỉ load nếu có kết quả
        }

        private async void txbTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                await LoadData();
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
            _allTeams = null;
            txbTimKiem.Clear();
            await LoadData(true);
        }

        private async void btnAddTeam_Click(object sender, EventArgs e)
        {
            var form = AppService.Get<AddTeamForm>();
            form.Location = new Point(250, 140);
            form.ShowDialog();
            _allTeams = null;
            await LoadData();
        }

        private async void TeamListForm_Shown(object sender, EventArgs e)
        {
            await LoadData();
        }
        private bool FilterTeams(string keyword)
        {
            if (!string.IsNullOrWhiteSpace(keyword))
            {
                var searchResult = _allTeams
                    .Where(x => x.Name != null && x.Name.ToLower().Contains(keyword))
                    .ToList();

                if (!searchResult.Any())
                {
                    MessageBox.Show("Không tìm thấy kết quả");
                    txbTimKiem.Clear();
                    return false;
                }

                _filteredTeams = searchResult;
                curentPage = 1;
            }

            return true;
        }

    }
}


