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
    public partial class SatinAlmaYetkiliLogin : DevExpress.XtraEditors.XtraForm
    {
        public SatinAlmaYetkiliLogin()
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

        private void SatinAlmaYetkiliLogin_Load(object sender, EventArgs e)
        {

        }

        public void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string Yetki = ("Satın Alma Yetkilisi").ToString();
                SqlCommand komut = new SqlCommand("select * from Kullanicilar where Yetki='" + Yetki + "'and  KullaniciAdi ='" + txtSatinYetkiliAdi.Text + "' and Sifre='" + txtSatinYetkiliSifre.Text + "'", baglanti);
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    SatinAlmaYetkilisiIslem SatinAlmaYetkilisiIslem = new SatinAlmaYetkilisiIslem();
                    SatinAlmaYetkilisiIslem.Show();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı/Şifre Yanlış veya Satın Alma Yetkilisi Değilsiniz");
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