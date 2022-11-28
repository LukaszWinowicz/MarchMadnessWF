using MarchMadnessWF.Model;
using Newtonsoft.Json;

namespace MarchMadnessWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public async Task loadApi()
        {
            using (var httpClient = new HttpClient())
            {
                var result = await httpClient.GetAsync("https://www.balldontlie.io/api/v1/teams");
                var json = await result.Content.ReadAsStringAsync();

                var db = JsonConvert.DeserializeObject<RootTeam>(json);

                var selectedData = db.data;
                dgv_teams.DataSource = db.data;
                dgv_teams.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

                if (cbox_teams.Items.Count == 0)
                {
                    foreach (var team in selectedData)
                    {
                        cbox_teams.Items.Add(team.full_name);
                    }

                   // MessageBox.Show("All teams are added");
                }
                else
                {
                    MessageBox.Show("Sorry but you have loaded teams in combobox");
                }
                
            };
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            loadApi();
        }

        private void cbox_teams_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dgv_teams.Rows.Count; i++)
            {
                if (cbox_teams.Text == dgv_teams.Rows[i].Cells[5].Value.ToString())
                {
                    lbl_id_value.Text = dgv_teams.Rows[i].Cells[0].Value.ToString();
                    lbl_city_value.Text = dgv_teams.Rows[i].Cells[2].Value.ToString();
                    lbl_division_value.Text = dgv_teams.Rows[i].Cells[4].Value.ToString();
                    lbl_full_name_value.Text = dgv_teams.Rows[i].Cells[5].Value.ToString();

                    string teamName = dgv_teams.Rows[i].Cells[6].Value.ToString();

                    pBox_logo.Image = Image.FromFile(@"..\..\..\Logos\"+ teamName + ".png");
                    pBox_logo.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }



        }


        public async Task loadPlayers()
        {
            using (var httpClient = new HttpClient())
            {
                var result = await httpClient.GetAsync("https://www.balldontlie.io/api/v1/players?per_page=100&page=2");
                
                var json = await result.Content.ReadAsStringAsync();

                var db = JsonConvert.DeserializeObject<RootPlayer>(json);

                var selectedData = db.data;
                dgv_players.DataSource = db.data;
                dgv_players.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                

            };
        }


        private void btn_load_all_players_Click(object sender, EventArgs e)
        {
            loadPlayers();
        }
    }
}