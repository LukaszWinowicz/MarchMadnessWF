namespace MarchMadnessWF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_loadApi = new System.Windows.Forms.Button();
            this.btn_load = new System.Windows.Forms.Button();
            this.cbox_teams = new System.Windows.Forms.ComboBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_id_value = new System.Windows.Forms.Label();
            this.lbl_city_value = new System.Windows.Forms.Label();
            this.lbl_city = new System.Windows.Forms.Label();
            this.lbl_division_value = new System.Windows.Forms.Label();
            this.lbl_division = new System.Windows.Forms.Label();
            this.lbl_full_name_value = new System.Windows.Forms.Label();
            this.lbl_full_name = new System.Windows.Forms.Label();
            this.dgv_teams = new System.Windows.Forms.DataGridView();
            this.pBox_logo = new System.Windows.Forms.PictureBox();
            this.dgv_players = new System.Windows.Forms.DataGridView();
            this.btn_load_all_players = new System.Windows.Forms.Button();
            this.cbox_players = new System.Windows.Forms.ComboBox();
            this.lbl_last_name_value = new System.Windows.Forms.Label();
            this.lbl_last_name = new System.Windows.Forms.Label();
            this.lbl_first_name_value = new System.Windows.Forms.Label();
            this.lbl_first_name = new System.Windows.Forms.Label();
            this.lbl_id_player_value = new System.Windows.Forms.Label();
            this.lbl_id_player = new System.Windows.Forms.Label();
            this.lbl_team_player_value = new System.Windows.Forms.Label();
            this.lbl_team_player = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_teams)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_players)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_loadApi
            // 
            this.btn_loadApi.Location = new System.Drawing.Point(12, 12);
            this.btn_loadApi.Name = "btn_loadApi";
            this.btn_loadApi.Size = new System.Drawing.Size(88, 41);
            this.btn_loadApi.TabIndex = 0;
            this.btn_loadApi.Text = "Load";
            this.btn_loadApi.UseVisualStyleBackColor = true;
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(12, 12);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(121, 23);
            this.btn_load.TabIndex = 0;
            this.btn_load.Text = "Load teams";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // cbox_teams
            // 
            this.cbox_teams.FormattingEnabled = true;
            this.cbox_teams.Location = new System.Drawing.Point(12, 41);
            this.cbox_teams.Name = "cbox_teams";
            this.cbox_teams.Size = new System.Drawing.Size(121, 23);
            this.cbox_teams.TabIndex = 1;
            this.cbox_teams.SelectedIndexChanged += new System.EventHandler(this.cbox_teams_SelectedIndexChanged);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(213, 16);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(17, 15);
            this.lbl_id.TabIndex = 2;
            this.lbl_id.Text = "Id";
            // 
            // lbl_id_value
            // 
            this.lbl_id_value.AutoSize = true;
            this.lbl_id_value.Location = new System.Drawing.Point(284, 16);
            this.lbl_id_value.Name = "lbl_id_value";
            this.lbl_id_value.Size = new System.Drawing.Size(12, 15);
            this.lbl_id_value.TabIndex = 3;
            this.lbl_id_value.Text = "-";
            // 
            // lbl_city_value
            // 
            this.lbl_city_value.AutoSize = true;
            this.lbl_city_value.Location = new System.Drawing.Point(284, 41);
            this.lbl_city_value.Name = "lbl_city_value";
            this.lbl_city_value.Size = new System.Drawing.Size(12, 15);
            this.lbl_city_value.TabIndex = 5;
            this.lbl_city_value.Text = "-";
            // 
            // lbl_city
            // 
            this.lbl_city.AutoSize = true;
            this.lbl_city.Location = new System.Drawing.Point(213, 41);
            this.lbl_city.Name = "lbl_city";
            this.lbl_city.Size = new System.Drawing.Size(28, 15);
            this.lbl_city.TabIndex = 4;
            this.lbl_city.Text = "City";
            // 
            // lbl_division_value
            // 
            this.lbl_division_value.AutoSize = true;
            this.lbl_division_value.Location = new System.Drawing.Point(284, 65);
            this.lbl_division_value.Name = "lbl_division_value";
            this.lbl_division_value.Size = new System.Drawing.Size(12, 15);
            this.lbl_division_value.TabIndex = 7;
            this.lbl_division_value.Text = "-";
            // 
            // lbl_division
            // 
            this.lbl_division.AutoSize = true;
            this.lbl_division.Location = new System.Drawing.Point(213, 65);
            this.lbl_division.Name = "lbl_division";
            this.lbl_division.Size = new System.Drawing.Size(49, 15);
            this.lbl_division.TabIndex = 6;
            this.lbl_division.Text = "Division";
            // 
            // lbl_full_name_value
            // 
            this.lbl_full_name_value.AutoSize = true;
            this.lbl_full_name_value.Location = new System.Drawing.Point(284, 92);
            this.lbl_full_name_value.Name = "lbl_full_name_value";
            this.lbl_full_name_value.Size = new System.Drawing.Size(12, 15);
            this.lbl_full_name_value.TabIndex = 9;
            this.lbl_full_name_value.Text = "-";
            // 
            // lbl_full_name
            // 
            this.lbl_full_name.AutoSize = true;
            this.lbl_full_name.Location = new System.Drawing.Point(213, 92);
            this.lbl_full_name.Name = "lbl_full_name";
            this.lbl_full_name.Size = new System.Drawing.Size(59, 15);
            this.lbl_full_name.TabIndex = 8;
            this.lbl_full_name.Text = "Full name";
            // 
            // dgv_teams
            // 
            this.dgv_teams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_teams.Location = new System.Drawing.Point(12, 147);
            this.dgv_teams.Name = "dgv_teams";
            this.dgv_teams.RowTemplate.Height = 25;
            this.dgv_teams.Size = new System.Drawing.Size(779, 215);
            this.dgv_teams.TabIndex = 10;
            // 
            // pBox_logo
            // 
            this.pBox_logo.Location = new System.Drawing.Point(669, 12);
            this.pBox_logo.Name = "pBox_logo";
            this.pBox_logo.Size = new System.Drawing.Size(122, 117);
            this.pBox_logo.TabIndex = 11;
            this.pBox_logo.TabStop = false;
            // 
            // dgv_players
            // 
            this.dgv_players.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_players.Location = new System.Drawing.Point(12, 390);
            this.dgv_players.Name = "dgv_players";
            this.dgv_players.RowTemplate.Height = 25;
            this.dgv_players.Size = new System.Drawing.Size(779, 252);
            this.dgv_players.TabIndex = 12;
            // 
            // btn_load_all_players
            // 
            this.btn_load_all_players.Location = new System.Drawing.Point(12, 70);
            this.btn_load_all_players.Name = "btn_load_all_players";
            this.btn_load_all_players.Size = new System.Drawing.Size(121, 23);
            this.btn_load_all_players.TabIndex = 13;
            this.btn_load_all_players.Text = "Load players";
            this.btn_load_all_players.UseVisualStyleBackColor = true;
            this.btn_load_all_players.Click += new System.EventHandler(this.btn_load_all_players_Click);
            // 
            // cbox_players
            // 
            this.cbox_players.FormattingEnabled = true;
            this.cbox_players.Location = new System.Drawing.Point(812, 147);
            this.cbox_players.Name = "cbox_players";
            this.cbox_players.Size = new System.Drawing.Size(121, 23);
            this.cbox_players.TabIndex = 14;
            this.cbox_players.SelectedIndexChanged += new System.EventHandler(this.cbox_players_SelectedIndexChanged);
            // 
            // lbl_last_name_value
            // 
            this.lbl_last_name_value.AutoSize = true;
            this.lbl_last_name_value.Location = new System.Drawing.Point(883, 237);
            this.lbl_last_name_value.Name = "lbl_last_name_value";
            this.lbl_last_name_value.Size = new System.Drawing.Size(12, 15);
            this.lbl_last_name_value.TabIndex = 20;
            this.lbl_last_name_value.Text = "-";
            // 
            // lbl_last_name
            // 
            this.lbl_last_name.AutoSize = true;
            this.lbl_last_name.Location = new System.Drawing.Point(812, 237);
            this.lbl_last_name.Name = "lbl_last_name";
            this.lbl_last_name.Size = new System.Drawing.Size(61, 15);
            this.lbl_last_name.TabIndex = 19;
            this.lbl_last_name.Text = "Last name";
            // 
            // lbl_first_name_value
            // 
            this.lbl_first_name_value.AutoSize = true;
            this.lbl_first_name_value.Location = new System.Drawing.Point(883, 213);
            this.lbl_first_name_value.Name = "lbl_first_name_value";
            this.lbl_first_name_value.Size = new System.Drawing.Size(12, 15);
            this.lbl_first_name_value.TabIndex = 18;
            this.lbl_first_name_value.Text = "-";
            // 
            // lbl_first_name
            // 
            this.lbl_first_name.AutoSize = true;
            this.lbl_first_name.Location = new System.Drawing.Point(812, 213);
            this.lbl_first_name.Name = "lbl_first_name";
            this.lbl_first_name.Size = new System.Drawing.Size(62, 15);
            this.lbl_first_name.TabIndex = 17;
            this.lbl_first_name.Text = "First name";
            // 
            // lbl_id_player_value
            // 
            this.lbl_id_player_value.AutoSize = true;
            this.lbl_id_player_value.Location = new System.Drawing.Point(883, 188);
            this.lbl_id_player_value.Name = "lbl_id_player_value";
            this.lbl_id_player_value.Size = new System.Drawing.Size(12, 15);
            this.lbl_id_player_value.TabIndex = 16;
            this.lbl_id_player_value.Text = "-";
            // 
            // lbl_id_player
            // 
            this.lbl_id_player.AutoSize = true;
            this.lbl_id_player.Location = new System.Drawing.Point(812, 188);
            this.lbl_id_player.Name = "lbl_id_player";
            this.lbl_id_player.Size = new System.Drawing.Size(17, 15);
            this.lbl_id_player.TabIndex = 15;
            this.lbl_id_player.Text = "Id";
            // 
            // lbl_team_player_value
            // 
            this.lbl_team_player_value.AutoSize = true;
            this.lbl_team_player_value.Location = new System.Drawing.Point(884, 265);
            this.lbl_team_player_value.Name = "lbl_team_player_value";
            this.lbl_team_player_value.Size = new System.Drawing.Size(12, 15);
            this.lbl_team_player_value.TabIndex = 22;
            this.lbl_team_player_value.Text = "-";
            // 
            // lbl_team_player
            // 
            this.lbl_team_player.AutoSize = true;
            this.lbl_team_player.Location = new System.Drawing.Point(813, 265);
            this.lbl_team_player.Name = "lbl_team_player";
            this.lbl_team_player.Size = new System.Drawing.Size(35, 15);
            this.lbl_team_player.TabIndex = 21;
            this.lbl_team_player.Text = "Team";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1113, 690);
            this.Controls.Add(this.lbl_team_player_value);
            this.Controls.Add(this.lbl_team_player);
            this.Controls.Add(this.lbl_last_name_value);
            this.Controls.Add(this.lbl_last_name);
            this.Controls.Add(this.lbl_first_name_value);
            this.Controls.Add(this.lbl_first_name);
            this.Controls.Add(this.lbl_id_player_value);
            this.Controls.Add(this.lbl_id_player);
            this.Controls.Add(this.cbox_players);
            this.Controls.Add(this.btn_load_all_players);
            this.Controls.Add(this.dgv_players);
            this.Controls.Add(this.pBox_logo);
            this.Controls.Add(this.dgv_teams);
            this.Controls.Add(this.lbl_full_name_value);
            this.Controls.Add(this.lbl_full_name);
            this.Controls.Add(this.lbl_division_value);
            this.Controls.Add(this.lbl_division);
            this.Controls.Add(this.lbl_city_value);
            this.Controls.Add(this.lbl_city);
            this.Controls.Add(this.lbl_id_value);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.cbox_teams);
            this.Controls.Add(this.btn_load);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_teams)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_players)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_loadApi;
        private Button btn_load;
        private ComboBox cbox_teams;
        private Label lbl_id;
        private Label lbl_id_value;
        private Label lbl_city_value;
        private Label lbl_city;
        private Label lbl_division_value;
        private Label lbl_division;
        private Label lbl_full_name_value;
        private Label lbl_full_name;
        private DataGridView dgv_teams;
        private PictureBox pBox_logo;
        private DataGridView dgv_players;
        private Button btn_load_all_players;
        private ComboBox cbox_players;
        private Label lbl_last_name_value;
        private Label lbl_last_name;
        private Label lbl_first_name_value;
        private Label lbl_first_name;
        private Label lbl_id_player_value;
        private Label lbl_id_player;
        private Label lbl_team_player_value;
        private Label lbl_team_player;
    }
}