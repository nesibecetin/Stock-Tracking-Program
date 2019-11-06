namespace StokUygulamasi
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btnBolumYetkili = new DevExpress.XtraEditors.SimpleButton();
            this.btnSatinAlmaYetkili = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdmin = new DevExpress.XtraEditors.SimpleButton();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btnBolumYetkili
            // 
            this.btnBolumYetkili.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBolumYetkili.Appearance.Options.UseFont = true;
            this.btnBolumYetkili.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnBolumYetkili.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBolumYetkili.ImageOptions.Image")));
            this.btnBolumYetkili.Location = new System.Drawing.Point(164, 255);
            this.btnBolumYetkili.Name = "btnBolumYetkili";
            this.btnBolumYetkili.Size = new System.Drawing.Size(236, 61);
            this.btnBolumYetkili.TabIndex = 8;
            this.btnBolumYetkili.Text = "Bölüm Yetkilisi";
            this.btnBolumYetkili.Click += new System.EventHandler(this.btnBolumYetkili_Click);
            // 
            // btnSatinAlmaYetkili
            // 
            this.btnSatinAlmaYetkili.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatinAlmaYetkili.Appearance.Options.UseFont = true;
            this.btnSatinAlmaYetkili.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnSatinAlmaYetkili.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSatinAlmaYetkili.ImageOptions.Image")));
            this.btnSatinAlmaYetkili.Location = new System.Drawing.Point(164, 175);
            this.btnSatinAlmaYetkili.Name = "btnSatinAlmaYetkili";
            this.btnSatinAlmaYetkili.Size = new System.Drawing.Size(236, 61);
            this.btnSatinAlmaYetkili.TabIndex = 7;
            this.btnSatinAlmaYetkili.Text = "Satın Alma Yetkilisi";
            this.btnSatinAlmaYetkili.Click += new System.EventHandler(this.btnSatinAlmaYetkili_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdmin.Appearance.Options.UseFont = true;
            this.btnAdmin.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnAdmin.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdmin.ImageOptions.Image")));
            this.btnAdmin.Location = new System.Drawing.Point(164, 92);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(236, 61);
            this.btnAdmin.TabIndex = 6;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnKapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnKapat.Location = new System.Drawing.Point(509, 12);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(39, 35);
            this.btnKapat.TabIndex = 9;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // Login
            // 
            this.Appearance.BackColor = System.Drawing.Color.Teal;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 471);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnBolumYetkili);
            this.Controls.Add(this.btnSatinAlmaYetkili);
            this.Controls.Add(this.btnAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnBolumYetkili;
        private DevExpress.XtraEditors.SimpleButton btnSatinAlmaYetkili;
        private DevExpress.XtraEditors.SimpleButton btnAdmin;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
    }
}