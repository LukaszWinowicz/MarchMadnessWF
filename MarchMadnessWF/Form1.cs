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

                var db = JsonConvert.DeserializeObject<Root>(json);

                var selectedData = db.data;

                if (cbox_teams.Items.Count == 0)
                {
                    foreach (var team in selectedData)
                    {
                        cbox_teams.Items.Add(team.city);
dgv_teams.
                    }

                    MessageBox.Show("All teams are added");
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
            lbl_id_value.Text = cbox_teams.SelectedIndex.ToString();
            lbl_city_value.Text = cbox_teams.SelectedIndex.ToString();
            lbl_division_value.Text = cbox_teams.SelectedIndex.ToString();
            lbl_full_name_value.Text = cbox_teams.SelectedIndex.ToString();
        }
    }
}