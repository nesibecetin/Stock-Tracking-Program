namespace StokUygulamasi
{
    partial class AdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            this.lblKullaniciAdi = new DevExpress.XtraEditors.LabelControl();
            this.lblSifre = new DevExpress.XtraEditors.LabelControl();
            this.txtAdminAdi = new DevExpress.XtraEditors.TextEdit();
            this.txtAdminSifre = new DevExpress.XtraEditors.TextEdit();
            this.btnAdminGiris = new DevExpress.XtraEditors.SimpleButton();
            this.btnAnaMenu = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdminAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdminSifre.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullaniciAdi.Appearance.Options.UseFont = true;
            this.lblKullaniciAdi.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblKullaniciAdi.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lblKullaniciAdi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("lblKullaniciAdi.ImageOptions.Image")));
            this.lblKullaniciAdi.Location = new System.Drawing.Point(107, 86);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(140, 59);
            this.lblKullaniciAdi.TabIndex = 0;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // lblSifre
            // 
            this.lblSifre.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.Appearance.Options.UseFont = true;
            this.lblSifre.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblSifre.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lblSifre.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("lblSifre.ImageOptions.SvgImage")));
            this.lblSifre.Location = new System.Drawing.Point(107, 164);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(104, 44);
            this.lblSifre.TabIndex = 1;
            this.lblSifre.Text = "Şifre";
            // 
            // txtAdminAdi
            // 
            this.txtAdminAdi.EditValue = "";
            this.txtAdminAdi.Location = new System.Drawing.Point(270, 105);
            this.txtAdminAdi.Name = "txtAdminAdi";
            this.txtAdminAdi.Size = new System.Drawing.Size(152, 22);
            this.txtAdminAdi.TabIndex = 4;
            // 
            // txtAdminSifre
            // 
            this.txtAdminSifre.EditValue = "";
            this.txtAdminSifre.Location = new System.Drawing.Point(270, 175);
            this.txtAdminSifre.Name = "txtAdminSifre";
            this.txtAdminSifre.Properties.PasswordChar = '*';
            this.txtAdminSifre.Size = new System.Drawing.Size(152, 22);
            this.txtAdminSifre.TabIndex = 5;
            // 
            // btnAdminGiris
            // 
            this.btnAdminGiris.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdminGiris.Appearance.Options.UseFont = true;
            this.btnAdminGiris.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnAdminGiris.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdminGiris.ImageOptions.Image")));
            this.btnAdminGiris.Location = new System.Drawing.Point(293, 263);
            this.btnAdminGiris.Name = "btnAdminGiris";
            this.btnAdminGiris.Size = new System.Drawing.Size(129, 49);
            this.btnAdminGiris.TabIndex = 6;
            this.btnAdminGiris.Text = "Giriş";
            this.btnAdminGiris.Click += new System.EventHandler(this.btnAdminGiris_Click);
            // 
            // btnAnaMenu
            // 
            this.btnAnaMenu.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnaMenu.Appearance.Options.UseFont = true;
            this.btnAnaMenu.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnAnaMenu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAnaMenu.ImageOptions.Image")));
            this.btnAnaMenu.Location = new System.Drawing.Point(140, 263);
            this.btnAnaMenu.Name = "btnAnaMenu";
            this.btnAnaMenu.Size = new System.Drawing.Size(129, 49);
            this.btnAnaMenu.TabIndex = 7;
            this.btnAnaMenu.Text = "Ana Menü";
            this.btnAnaMenu.Click += new System.EventHandler(this.btnAnaMenu_Click);
            // 
            // AdminLogin
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 471);
            this.Controls.Add(this.btnAnaMenu);
            this.Controls.Add(this.btnAdminGiris);
            this.Controls.Add(this.txtAdminSifre);
            this.Controls.Add(this.txtAdminAdi);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblKullaniciAdi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminLogin";
            this.Load += new System.EventHandler(this.AdminLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtAdminAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdminSifre.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblKullaniciAdi;
        private DevExpress.XtraEditors.LabelControl lblSifre;
        private DevExpress.XtraEditors.TextEdit txtAdminAdi;
        private DevExpress.XtraEditors.TextEdit txtAdminSifre;
        private DevExpress.XtraEditors.SimpleButton btnAdminGiris;
        private DevExpress.XtraEditors.SimpleButton btnAnaMenu;
    }
}