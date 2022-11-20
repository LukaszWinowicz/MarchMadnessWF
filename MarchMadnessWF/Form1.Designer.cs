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
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1112, 562);
            this.Controls.Add(this.cbox_teams);
            this.Controls.Add(this.btn_load);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_loadApi;
        private Button btn_load;
        private ComboBox cbox_teams;
    }
}