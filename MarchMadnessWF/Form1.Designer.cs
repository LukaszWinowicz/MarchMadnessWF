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
            this.btn_loadApi.Click += new System.EventHandler(this.btn_loadApi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 548);
            this.Controls.Add(this.btn_loadApi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_loadApi;
    }
}