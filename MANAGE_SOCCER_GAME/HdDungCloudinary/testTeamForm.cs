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
        private readonly CoachService _coachService;
        private readonly TeamService _teamService;
        private Guid guid;

        public testTeamForm(ManageSoccerGame context)
        {
            InitializeComponent();
            _context = context;
            _tournamentService = new TournamentService(_context);
            _teamService = new TeamService(_context);
            _coachService = new CoachService(_context);
        }

        private async Task LoadTournamentsToComboBox()
        {
            var tournaments = await _tournamentService.GetAllTournamentsAsync();

            cbTounament.DataSource = tournaments;
            cbTounament.DisplayMember = "Name";
            cbTounament.ValueMember = "Id";
        }

        private async Task LoadCoachesToComboBox()
        {
            var coaches = await _coachService.GetAllCoachesAsync();
            cbCoach.DataSource = coaches;
            cbCoach.DisplayMember = "Name";
            cbCoach.ValueMember = "Id";
        }

        private async Task LoadTeams()
        {
            var teams = await _teamService.GetAllTeamAsync();
            if (teams == null || !teams.Any())
            {
                MessageBox.Show("No teams found.");
                return;
            }
            lvTeam.Items.Clear();

            foreach (var team in teams)
            {
                var listItem = new ListViewItem(team.Id.ToString());
                listItem.SubItems.Add(team.Name);
                listItem.SubItems.Add(team.Province);
                listItem.SubItems.Add(team.IdTournament.ToString());
                listItem.SubItems.Add(team.IdCoach.ToString());

                lvTeam.Items.Add(listItem);
            }
        }

        private async void testTeamForm_Load(object sender, EventArgs e)
        {
            await LoadTournamentsToComboBox();
            await LoadCoachesToComboBox();
            await LoadTeams();
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
                var selectedCoachId = (Guid)cbCoach.SelectedValue;

                var team = new Team
                {
                    Name = txtName.Text,
                    Province = txtProvince.Text,
                    IdTournament = selectedTournamentId,
                    IdCoach = selectedCoachId,
                    IdImage = null
                };

                await _teamService.CreateTeamAsync(team);
                MessageBox.Show("Created!");


            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                await LoadTournamentsToComboBox();
                await LoadCoachesToComboBox();
                await LoadTeams();
            }
        }

        private async void btnUpdate_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                Team team = new Team
                {
                    Name = txtName.Text,
                    Province = txtProvince.Text,
                    IdTournament = (Guid)cbTounament.SelectedValue,
                    IdCoach = (Guid)cbCoach.SelectedValue
                };
              

                var t = await _teamService.UpdateTeamAsync(guid, team);
                if (t == null)
                {
                    MessageBox.Show("Update failed.");
                    return;
                }
             
                MessageBox.Show("Updated!");
         

                btnUpdate.Enabled = false;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                await LoadTournamentsToComboBox();
                await LoadCoachesToComboBox();
                await LoadTeams();
            }

        }

        private async void LoadTeam(object sender, EventArgs e)
        {
            if (lvTeam.SelectedItems.Count > 0)
            {
                string teamId = lvTeam.SelectedItems[0].SubItems[0].Text;

                var team = await _teamService.GetTeamByIdAsync(Guid.Parse(teamId));
                if (team == null)
                {
                    MessageBox.Show("Team not found.");
                    return;
                }

                txtName.Text = team.Name;
                txtProvince.Text = team.Province;
                guid = team.Id;
                btnUpdate.Enabled = true;
                MessageBox.Show("Selected team: " + guid);

            }
            else
            {
                MessageBox.Show("Chưa chọn dòng nào.");
                btnUpdate.Enabled = false;

            }
        }
    }
}
