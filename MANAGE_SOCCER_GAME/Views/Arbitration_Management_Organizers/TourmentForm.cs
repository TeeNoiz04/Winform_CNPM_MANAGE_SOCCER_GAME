using MANAGE_SOCCER_GAME.Dtos;
using MANAGE_SOCCER_GAME.Models;
using MANAGE_SOCCER_GAME.Services;
using MANAGE_SOCCER_GAME.Utils.Routing;
using MANAGE_SOCCER_GAME.Views.Management_Team_Players;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MANAGE_SOCCER_GAME.Views.Arbitration_Management_Organizers
{
    public partial class TourmentForm : Form
    {
        private TournamentService _tournamentService;
        private Router _router;
        private int curentPage = 1;
        private int countLine = 0;
        private float totalPage = 0;
        private IEnumerable<TournamentDTO> _allTournament = new List<TournamentDTO>();

        public TourmentForm(TournamentService tournamentService)
        {
            InitializeComponent();
            _tournamentService = tournamentService;
            _router = new Router();

            cbbSoDong.SelectedIndex = 0;
            cbbSapXep.SelectedIndex = 0;
            cbbCot.DataSource = typeof(TournamentDTO).GetProperties().Select(prop => prop.Name).ToList();
            cbbCot.SelectedIndex = 0;

            if (curentPage == 1)
            {
                btnTrangTruoc.Enabled = false;
                btnTrangKe.Enabled = true;
            }

            LoadData();
        }

        private async Task Getall()
        {
            _allTournament = await _tournamentService.GetAllTournamentsDTOAsync();
        }


        private async void LoadData()
        {
            if (!string.IsNullOrWhiteSpace(txbTimKiem.Text) && txbTimKiem.Text != "Search")
            {
                string keyword = txbTimKiem.Text.Trim().ToLower();
                var fillterSearch = _allTournament.Where(n => n.Name.ToLower().Contains(keyword)).ToList();
                if (fillterSearch == null)
                {
                    MessageBox.Show("Không tìm thấy kết quả");
                    return;
                }
                _allTournament = fillterSearch;
                curentPage = 1;
            }

            var count = _allTournament.Count();
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
                _allTournament = _allTournament.OrderBy(c => c.GetType().GetProperty(columnName)?.GetValue(c, null)).ToList();
            }
            else if (sortOrder == "Giảm dần")
            {
                _allTournament = _allTournament.OrderByDescending(c => c.GetType().GetProperty(columnName)?.GetValue(c, null)).ToList();
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
            dataGridView.DataSource = _allTournament.Skip(countLine * (curentPage - 1)).Take(countLine).ToList(); ;

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
            DataGridViewRow row = dataGridView.Rows[e.RowIndex];
            var id = row.Cells["ID"].Value.ToString();
            // Duyệt
            if (e.ColumnIndex == dataGridView.Columns["Action"].Index && e.RowIndex >= 0)
            {
                //var hoadonDuyet = _entities.HOADONs.FirstOrDefault(n => n.MaHD == id);
                //if (hoadonDuyet != null)
                //{
                //    hoadonDuyet.IsCheck = true;
                //    hoadonDuyet.MaQTV = Session.CurentUser.MaQTV;
                //    _entities.HOADONs.AddOrUpdate(hoadonDuyet);
                //    _entities.SaveChanges();
                //    LoadData();
                //}
            }
            // Chi tiết
            if (e.ColumnIndex == dataGridView.Columns["Action2"].Index && e.RowIndex >= 0)
            {
                //_action.LoadDetailOrders(id);
            }
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
            await Getall();
            LoadData();
        }

        private void btnAddTourment_Click(object sender, EventArgs e)
        {
            var formAdd = new AddTourmentForm();
            formAdd.Location = new Point(250, 140);
            formAdd.ShowDialog();
        }

        private async void TourmentForm_Load(object sender, EventArgs e)
        {
            await Getall();
            LoadData();
        }
    }
}
