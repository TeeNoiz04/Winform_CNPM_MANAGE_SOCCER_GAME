using Guna.UI2.WinForms;
using MANAGE_SOCCER_GAME.Models;
using MANAGE_SOCCER_GAME.Services;
using MANAGE_SOCCER_GAME.Utils.Routing;
using MANAGE_SOCCER_GAME.Views.Management_Team_Players;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MANAGE_SOCCER_GAME.Views.Schedule_Management
{
    public partial class MatchScheduleForm : Form
    {
        private readonly HttpClient _httpClient;
        private RoundService _roundService;
        private Router _router;
        private List<Round> _allRound = new List<Round>();
        public MatchScheduleForm(RoundService roundService)
        {
            InitializeComponent();
            _router = new Router();
            _roundService = roundService;
            _httpClient = new HttpClient();
        }

        private async Task GetAll()
        {
            _allRound = await _roundService.GetAllRoundsAsync();
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            pnLayoutMain.Controls.Clear();
            await GetAll();
            createRound();
        }

        // Xem chi tiết trận đấu 
        private void view_Match_Click(object sender, EventArgs e)
        {
            if (sender is Control control && control.Tag is Guid gameId)
            {
                var formFactory = AppService.Get<Func<GameService, Guid, MatchDetailForm>>();
                var form = formFactory(AppService.Get<GameService>(), gameId);
                _router.LoadForm3(form);
            }
        }

        private async void MatchScheduleForm_Load(object sender, EventArgs e)
        {
            await GetAll();
            createRound();
        }

        // Tạo từng vòng đấu
        void createRound()
        {
            int i = 0;
            foreach (var round in _allRound)
            {
                Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
                Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
                FlowLayoutPanel layoutPanel = new FlowLayoutPanel();
                Guna2Panel titlePanel = new Guna2Panel();
                Label roundLabel = new Label();
                // 
                // pnLayout
                // 
                layoutPanel.Controls.Add(titlePanel);
                layoutPanel.Location = new Point(3, 3);
                layoutPanel.Name = "pnLayout" + i.ToString();
                layoutPanel.AutoSize = true; // Increased height to accommodate larger match panels
                layoutPanel.TabIndex = 27;
                layoutPanel.FlowDirection = FlowDirection.TopDown;
                // 
                // pnTitle
                // 
                titlePanel.Controls.Add(roundLabel);
                titlePanel.CustomizableEdges = customizableEdges17;
                titlePanel.Dock = DockStyle.Top;
                titlePanel.Location = new Point(3, 3);
                titlePanel.Name = "pnTitle" + i.ToString();
                titlePanel.ShadowDecoration.CustomizableEdges = customizableEdges18;
                titlePanel.Size = new Size(900, 60); // Slightly taller title panel
                titlePanel.TabIndex = 7;
                // 
                // lblRound
                // 
                roundLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
                roundLabel.ForeColor = Color.White;
                roundLabel.Location = new Point(10, 0);
                roundLabel.Name = "lblRound" + i.ToString();
                roundLabel.Size = new Size(300, 60);
                roundLabel.TabIndex = 0;
                roundLabel.Text = round.Name;
                roundLabel.TextAlign = ContentAlignment.MiddleLeft;
                createMatch(layoutPanel, round.Games);
                pnLayoutMain.Controls.Add(layoutPanel);
                i++;
            }
        }

        // Tạo từng trận đấu
        private async void createMatch(FlowLayoutPanel layout, ICollection<Game> games)
        {
            var sortedGames = games
                    .OrderBy(g => g.DateStart)
                    .ThenBy(g => g.TimeStart)
                    .ToList();
            int i = 0;
            foreach (var game in sortedGames)
            {
                Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
                Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
                Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
                Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
                Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
                Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
                Guna2Panel contentPanel = new Guna2Panel();
                Label resultLabel = new Label();
                Label team1Label = new Label();
                Label team2Label = new Label();
                Label dateTimeLabel = new Label();
                Guna2PictureBox team1Pic = new Guna2PictureBox();
                Guna2PictureBox team2Pic = new Guna2PictureBox();
                // 
                // pnContent
                // 
                contentPanel.Controls.Add(resultLabel);
                contentPanel.Controls.Add(team1Label);
                contentPanel.Controls.Add(team2Label);
                contentPanel.Controls.Add(dateTimeLabel);
                contentPanel.Controls.Add(team1Pic);
                contentPanel.Controls.Add(team2Pic);
                contentPanel.CustomizableEdges = customizableEdges23;
                contentPanel.Location = new Point(10, 70); // Adjusted for better spacing
                contentPanel.Name = "pnContent" + i.ToString();
                contentPanel.Tag = game.Id; // Gắn Id trận đấu vào panel
                contentPanel.ShadowDecoration.CustomizableEdges = customizableEdges24;
                contentPanel.Size = new Size(860, 80); // Wider and taller for better layout
                contentPanel.TabIndex = 6;
                contentPanel.BackColor = Color.FromArgb(30, 30, 30); // Dark background for contrast
                contentPanel.Click += view_Match_Click;
                // 
                // lblResult
                // 
                resultLabel.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
                resultLabel.ForeColor = Color.White;
                resultLabel.Location = new Point(380, 20); // Centered
                resultLabel.Name = "lblResult" + i.ToString();
                resultLabel.Size = new Size(100, 32);
                resultLabel.TabIndex = 4;
                resultLabel.Text = $"{game.HomeScore} - {game.AwayScore}"; // Placeholder; update with actual score if available
                resultLabel.TextAlign = ContentAlignment.MiddleCenter;
                resultLabel.AutoSize = true; // Adjusted for better layout
                // 
                // lblTeam1
                // 
                team1Label.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular);
                team1Label.ForeColor = Color.White;
                team1Label.Location = new Point(110, 24);
                team1Label.Name = "lblTeam1" + i.ToString();
                team1Label.Size = new Size(250, 32);
                team1Label.TabIndex = 2;
                team1Label.Text = game.HomeTeam.Name;
                team1Label.TextAlign = ContentAlignment.MiddleLeft;
                team1Label.Tag = game.Id;
                team1Label.Click += view_Match_Click;
                // 
                // lblTeam2
                // 
                team2Label.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular);
                team2Label.ForeColor = Color.White;
                team2Label.Location = new Point(500, 24);
                team2Label.Name = "lblTeam2" + i.ToString();
                team2Label.Size = new Size(250, 32);
                team2Label.TabIndex = 3;
                team2Label.Text = game.AwayTeam.Name;
                team2Label.TextAlign = ContentAlignment.MiddleRight;
                team2Label.Click += view_Match_Click;
                team2Label.Tag = game.Id;

                // 
                // lblDateTime
                // 
                dateTimeLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular);
                dateTimeLabel.ForeColor = Color.LightGray;
                dateTimeLabel.Location = new Point(310, 50);
                dateTimeLabel.Name = "lblDateTime" + i.ToString();
                dateTimeLabel.Size = new Size(200, 20);
                dateTimeLabel.TabIndex = 5;
                dateTimeLabel.Text = $"{game.DateStart.ToString("dd/MM/yyyy")} - {game.TimeStart.ToString(@"hh\:mm")}";
                dateTimeLabel.TextAlign = ContentAlignment.MiddleCenter;
                // 
                // picTeam1
                // 
                team1Pic.CustomizableEdges = customizableEdges21;
                team1Pic.ImageRotate = 0F;
                team1Pic.Location = new Point(20, 15);
                team1Pic.Name = "picTeam1" + i.ToString();
                team1Pic.ShadowDecoration.CustomizableEdges = customizableEdges22;
                team1Pic.Size = new Size(60, 60); // Slightly larger logos
                team1Pic.SizeMode = PictureBoxSizeMode.StretchImage;
                team1Pic.TabIndex = 0;
                team1Pic.TabStop = false;
                if (!string.IsNullOrEmpty(game.HomeTeam.Image?.Url))
                {
                    var image = await LoadImageFromUrlAsync(game.HomeTeam.Image.Url);
                    if (image != null)
                    {
                        team1Pic.Image = image;
                        team1Pic.Refresh();
                    }
                }
                // 
                // picTeam2
                // 
                team2Pic.CustomizableEdges = customizableEdges19;
                team2Pic.ImageRotate = 0F;
                team2Pic.Location = new Point(780, 15);
                team2Pic.Name = "picTeam2" + i.ToString();
                team2Pic.ShadowDecoration.CustomizableEdges = customizableEdges20;
                team2Pic.Size = new Size(60, 60); // Slightly larger logos
                team2Pic.SizeMode = PictureBoxSizeMode.StretchImage;
                team2Pic.TabIndex = 1;
                team2Pic.TabStop = false;
                if (!string.IsNullOrEmpty(game.AwayTeam.Image?.Url))
                {
                    var image = await LoadImageFromUrlAsync(game.AwayTeam.Image.Url);
                    if (image != null)
                    {
                        team2Pic.Image = image;
                        team2Pic.Refresh();
                    }
                }

                layout.Controls.Add(contentPanel);
                i++;
            }
        }

        private void Team1Label_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnAddSchedule_Click(object sender, EventArgs e)
        {
            var formAdd = AppService.Get<AddScheduleForm>();
            formAdd.Location = new Point(250, 140);
            formAdd.ShowDialog();
        }

        private void btnAddRound_Click(object sender, EventArgs e)
        {
            var formAdd = AppService.Get<AddRoundForm>();
            formAdd.Location = new Point(250, 140);
            formAdd.ShowDialog();
        }

        private async Task<Image> LoadImageFromUrlAsync(string url)
        {
            try
            {
                byte[] imageBytes = await _httpClient.GetByteArrayAsync(url);
                using (var ms = new System.IO.MemoryStream(imageBytes))
                {
                    return Image.FromStream(ms);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading image from {url}: {ex.Message}");
                return null;
            }
        }
    }
}