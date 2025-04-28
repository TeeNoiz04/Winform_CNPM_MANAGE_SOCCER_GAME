using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MANAGE_SOCCER_GAME.Data;
using MANAGE_SOCCER_GAME.Models;
using MANAGE_SOCCER_GAME.Services;
using Microsoft.EntityFrameworkCore;

namespace MANAGE_SOCCER_GAME.HdDungCloudinary
{
    public partial class testPlayerForm : Form
    {
        private readonly ManageSoccerGame _context;
        private readonly TeamService _teamService;
        private readonly PlayerService _playerService;
        private Guid guid;
        public testPlayerForm(ManageSoccerGame context)
        {
            InitializeComponent();
            _context = context;
            _playerService = new PlayerService(_context);
            _teamService = new TeamService(_context);
        }

        private async Task LoadTeamToComboBox()
        {
            //var teams = await _teamService.GetAllTeamAsync();

            //cbTeam.DataSource = teams;
            //cbTeam.DisplayMember = "Name";
            //cbTeam.ValueMember = "Id";
        }

        private async Task LoadPlayers()
        {
            var players = await _context.Players.ToListAsync();
            if (players == null || !players.Any())
            {
                MessageBox.Show("No players found.");
                return;
            }
            lvPlayer.Items.Clear();

            foreach (var player in players)
            {
                ListViewItem item = new ListViewItem(player.Id.ToString());
                item.SubItems.Add(player.Name);
                item.SubItems.Add(player.BirthDate.ToString());
                item.SubItems.Add(player.Number.ToString());
                item.SubItems.Add(player.Position);
                item.SubItems.Add(player.National);
                item.SubItems.Add(player.Status);
                item.SubItems.Add(player.Height.ToString());
                item.SubItems.Add(player.Weight.ToString());
                item.SubItems.Add(player.IdTeam.ToString());
                lvPlayer.Items.Add(item);
            }
        }

        private async void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvPlayer.SelectedItems.Count > 0)
            {
                string playerId = lvPlayer.SelectedItems[0].SubItems[0].Text;

                var player = await _playerService.GetPlayerByIdAsync(Guid.Parse(playerId));
                if (player == null)
                {
                    MessageBox.Show("Player not found.");
                    return;
                }

                //txtName.Text = player.Name;
                //Ibirthdate.Value = player.BirthDate;
                //txtNumber.Text = player.Number.ToString();
                //txtPosition.Text = player.Position;
                //txtNational.Text = player.National;
                //txtStatus.Text = player.Status;
                //txtHeight.Text = player.Height.ToString();
                //txtWeight.Text = player.Weight.ToString();
                //cbTeam.SelectedValue = player.IdTeam;

                guid = player.Id;
                btnUpdate.Enabled = true;
                MessageBox.Show("Selected player: " + guid);

            }
            else
            {
                MessageBox.Show("Chưa chọn dòng nào.");
                btnUpdate.Enabled = false;

            }
        }

        private async void testPlayerForm_Load(object sender, EventArgs e)
        {
            await LoadPlayers();
            await LoadTeamToComboBox();
        }

        private async void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedTeamId = (Guid)cbTeam.SelectedValue;

                var player = new Player
                {
                    Name = txtName.Text,
                    BirthDate = Ibirthdate.Value,
                    Number = int.Parse(txtNumber.Text),
                    Position = txtPosition.Text,
                    National = txtNational.Text,
                    Status = txtStatus.Text,
                    Height = float.Parse(txtHeight.Text),
                    Weight = float.Parse(txtWeight.Text),
                    IdTeam = selectedTeamId
                };

                await _playerService.CreatePlayerAsync(player);
                MessageBox.Show("Created!");

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                await LoadPlayers();
                await LoadTeamToComboBox();
            }
        }


        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedTeamId = (Guid)cbTeam.SelectedValue;

                var player = new Player
                {
                    Name = txtName.Text,
                    BirthDate = Ibirthdate.Value,
                    Number = int.Parse(txtNumber.Text),
                    Position = txtPosition.Text,
                    National = txtNational.Text,
                    Status = txtStatus.Text,
                    Height = float.Parse(txtHeight.Text),
                    Weight = float.Parse(txtWeight.Text),
                    IdTeam = selectedTeamId
                };

               var t = await _playerService.UpdatePlayerAsync(guid, player);
                if (t == null)
                {
                    MessageBox.Show("Update failed.");
                    return;
                }

                MessageBox.Show("Updated!");

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                await LoadPlayers();
                await LoadTeamToComboBox();
            }
        }
    }
}
