namespace StokUygulamasi
{
    partial class SatinAlmaYetkiliLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SatinAlmaYetkiliLogin));
            this.btnAnaMenu = new DevExpress.XtraEditors.SimpleButton();
            this.btnGiris = new DevExpress.XtraEditors.SimpleButton();
            this.txtSatinYetkiliSifre = new DevExpress.XtraEditors.TextEdit();
            this.txtSatinYetkiliAdi = new DevExpress.XtraEditors.TextEdit();
            this.lblSifre = new DevExpress.XtraEditors.LabelControl();
            this.lblKullaniciAdi = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtSatinYetkiliSifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSatinYetkiliAdi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAnaMenu
            // 
            this.btnAnaMenu.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnaMenu.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnAnaMenu.Appearance.Options.UseFont = true;
            this.btnAnaMenu.Appearance.Options.UseForeColor = true;
            this.btnAnaMenu.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnAnaMenu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAnaMenu.ImageOptions.Image")));
            this.btnAnaMenu.Location = new System.Drawing.Point(143, 287);
            this.btnAnaMenu.Name = "btnAnaMenu";
            this.btnAnaMenu.Size = new System.Drawing.Size(129, 49);
            this.btnAnaMenu.TabIndex = 19;
            this.btnAnaMenu.Text = "Ana Menü";
            this.btnAnaMenu.Click += new System.EventHandler(this.btnAnaMenu_Click);
            // 
            // btnGiris
            // 
            this.btnGiris.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.Appearance.Options.UseFont = true;
            this.btnGiris.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnGiris.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGiris.ImageOptions.Image")));
            this.btnGiris.Location = new System.Drawing.Point(307, 287);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(129, 49);
            this.btnGiris.TabIndex = 18;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // txtSatinYetkiliSifre
            // 
            this.txtSatinYetkiliSifre.EditValue = "";
            this.txtSatinYetkiliSifre.Location = new System.Drawing.Point(284, 199);
            this.txtSatinYetkiliSifre.Name = "txtSatinYetkiliSifre";
            this.txtSatinYetkiliSifre.Properties.PasswordChar = '*';
            this.txtSatinYetkiliSifre.Size = new System.Drawing.Size(152, 22);
            this.txtSatinYetkiliSifre.TabIndex = 17;
            // 
            // txtSatinYetkiliAdi
            // 
            this.txtSatinYetkiliAdi.EditValue = "";
            this.txtSatinYetkiliAdi.Location = new System.Drawing.Point(284, 129);
            this.txtSatinYetkiliAdi.Name = "txtSatinYetkiliAdi";
            this.txtSatinYetkiliAdi.Size = new System.Drawing.Size(152, 22);
            this.txtSatinYetkiliAdi.TabIndex = 16;
            // 
            // lblSifre
            // 
            this.lblSifre.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.Appearance.Options.UseFont = true;
            this.lblSifre.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblSifre.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lblSifre.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("lblSifre.ImageOptions.SvgImage")));
            this.lblSifre.Location = new System.Drawing.Point(121, 188);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(104, 44);
            this.lblSifre.TabIndex = 15;
            this.lblSifre.Text = "Şifre";
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullaniciAdi.Appearance.Options.UseFont = true;
            this.lblKullaniciAdi.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblKullaniciAdi.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lblKullaniciAdi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("lblKullaniciAdi.ImageOptions.Image")));
            this.lblKullaniciAdi.Location = new System.Drawing.Point(121, 110);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(140, 59);
            this.lblKullaniciAdi.TabIndex = 14;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // SatinAlmaYetkiliLogin
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 471);
            this.Controls.Add(this.btnAnaMenu);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtSatinYetkiliSifre);
            this.Controls.Add(this.txtSatinYetkiliAdi);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblKullaniciAdi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SatinAlmaYetkiliLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SatinAlmaYetkiliLogin";
            this.Load += new System.EventHandler(this.SatinAlmaYetkiliLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtSatinYetkiliSifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSatinYetkiliAdi.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnAnaMenu;
        private DevExpress.XtraEditors.SimpleButton btnGiris;
        private DevExpress.XtraEditors.TextEdit txtSatinYetkiliSifre;
        private DevExpress.XtraEditors.TextEdit txtSatinYetkiliAdi;
        private DevExpress.XtraEditors.LabelControl lblSifre;
        private DevExpress.XtraEditors.LabelControl lblKullaniciAdi;
    }
}