using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MANAGE_SOCCER_GAME.Data;
using MANAGE_SOCCER_GAME.Models;
using MANAGE_SOCCER_GAME.Services;

namespace MANAGE_SOCCER_GAME.HdDungCloudinary
{
    public partial class TestTournamentForm : Form
    {
        private readonly ManageSoccerGame _context;
        private TournamentService _service;
        public TestTournamentForm(ManageSoccerGame context)
        {
            InitializeComponent();
            _context = context;
            _service = new TournamentService(_context);
            LoadTournaments();
        }
        private async void LoadTournaments()
        {
            var tournaments = await _service.GetAllTournamentsAsync();
            if (tournaments == null || !tournaments.Any())
            {
                MessageBox.Show("No tournaments found.");
                return;
            }
            lstTournaments.Items.Clear();
            foreach (var t in tournaments)
            {
                lstTournaments.Items.Add($"{t.Id} - {t.Name}");
            }
        }

        private async void btnCreate_Click(object sender, EventArgs e)
        {
            var t = new Tournament
            {
                Name = txtName.Text,
                Description = txtDescription.Text,
                StartDate = dtpStartDate.Value,
                EndDate = dtpEndDate.Value
            };

            await _service.CreateTournamentAsync(t);
            MessageBox.Show("Created!");
            LoadTournaments();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadTournaments();
        }

        private async void lstTournaments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTournaments.SelectedItems.Count == 0) return;

            var selectedItem = lstTournaments.SelectedItems[0];
            var parts = selectedItem.Text.Split(" - ");
            if (parts.Length < 2) return;

            if (!Guid.TryParse(parts[0], out Guid id)) return;

            var t = await _service.GetTournamentByIdAsync(id);
            if (t == null) return;

            lblSelectedId.Text = t.Id.ToString();
            txtName.Text = t.Name;
            txtDescription.Text = t.Description;
            dtpStartDate.Value = t.StartDate;
            dtpEndDate.Value = t.EndDate;
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!Guid.TryParse(lblSelectedId.Text, out Guid id)) return;

            var t = new Tournament
            {
                Id = id,
                Name = txtName.Text,
                Description = txtDescription.Text,
                StartDate = dtpStartDate.Value,
                EndDate = dtpEndDate.Value
            };

            await _service.UpdateTournamentAsync(t);
            MessageBox.Show("Updated!");
            LoadTournaments();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (!Guid.TryParse(lblSelectedId.Text, out Guid id)) return;

            await _service.DeleteTournamentAsync(id);
            MessageBox.Show("Deleted!");
            LoadTournaments();
        }
    }
}
