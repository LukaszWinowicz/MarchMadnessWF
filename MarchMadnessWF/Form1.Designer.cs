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
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_teams)).BeginInit();
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
            this.dgv_teams.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgv_teams.Location = new System.Drawing.Point(12, 251);
            this.dgv_teams.Name = "dgv_teams";
            this.dgv_teams.RowTemplate.Height = 25;
            this.dgv_teams.Size = new System.Drawing.Size(779, 286);
            this.dgv_teams.TabIndex = 10;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "id";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "abbreviation";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "city";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "conference";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "division";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "full_name";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "name";
            this.Column7.Name = "Column7";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(814, 562);
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
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
    }
}