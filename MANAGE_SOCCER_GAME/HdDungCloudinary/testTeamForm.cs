using MANAGE_SOCCER_GAME.Data;
using MANAGE_SOCCER_GAME.Models;
using MANAGE_SOCCER_GAME.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MANAGE_SOCCER_GAME.HdDungCloudinary
{
    public partial class testTeamForm : Form
    {
        private readonly ManageSoccerGame _context;
        private readonly TournamentService _tournamentService;
        private readonly TeamService _teamService;
        public testTeamForm(ManageSoccerGame context)
        {
            InitializeComponent();
            _context = context;
            _tournamentService = new TournamentService(_context);
            _teamService = new TeamService(_context);
        }

        private async Task LoadTournamentsToComboBox()
        {
            var tournaments = await _tournamentService.GetAllTournamentsAsync();

            cbTounament.DataSource = tournaments;
            cbTounament.DisplayMember = "Name";
            cbTounament.ValueMember = "Id";
        }

        private async void testTeamForm_Load(object sender, EventArgs e)
        {
            await LoadTournamentsToComboBox();
        }

        private async void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtProvince.Text))
                {
                    MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var selectedTournamentId = (Guid)cbTounament.SelectedValue;

                var team = new Team
                {
                    Name = txtName.Text,
                    Province = txtProvince.Text,
                    IdTournament = selectedTournamentId,
                    IdCoach = Guid.Empty,
                    IdImage = null
                };

                await _teamService.CreateAsync(team);
                MessageBox.Show("Created!");


            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
