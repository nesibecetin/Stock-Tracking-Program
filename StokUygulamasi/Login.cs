using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace StokUygulamasi
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {

            AdminLogin AdminLogin = new AdminLogin();
            AdminLogin.Show();
            this.Hide();
        }

        private void btnSatinAlmaYetkili_Click(object sender, EventArgs e)
        {

            SatinAlmaYetkiliLogin SatinAlmaYetkiliLogin = new SatinAlmaYetkiliLogin();
            SatinAlmaYetkiliLogin.Show();
            this.Hide();
        }

        private void btnBolumYetkili_Click(object sender, EventArgs e)
        {
            
            BolumYetkilisiLogin BolumYetkilisiLogin = new BolumYetkilisiLogin();
            BolumYetkilisiLogin.Show();
            this.Hide();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}