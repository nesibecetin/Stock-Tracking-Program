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
using System.Data.SqlClient;

namespace StokUygulamasi
{
    public partial class AdminLogin : DevExpress.XtraEditors.XtraForm
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-IPOPUUC;Initial Catalog=StokUygulamasi;Integrated Security=True");
        private void btnAnaMenu_Click(object sender, EventArgs e)
        {
            Login Login = new Login();
            Login.Show();
            this.Close();
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }
        
        public void muhittin()
        {
            btnAdminGiris.PerformClick();
        }
        public void btnAdminGiris_Click(object sender, EventArgs e)
        {

            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select * from Admin where  AdminKullaniciAdi ='" + txtAdminAdi.Text + "' and AdminSifre='" + txtAdminSifre.Text + "'", baglanti);
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {

                    AdminIslem adminIslem = new AdminIslem();
                    adminIslem.Show();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı/Şifre Yanlış veya Admin Değilsiniz");
                }
                baglanti.Close();

            }
            catch (Exception hata)
            {
                MessageBox.Show("Bağlantı Sırasında Hata Oluştu" + hata.Message);
            }

        }
    }
}