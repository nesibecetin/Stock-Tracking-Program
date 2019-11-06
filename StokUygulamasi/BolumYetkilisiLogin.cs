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
    public partial class BolumYetkilisiLogin : DevExpress.XtraEditors.XtraForm
    {
        
        public BolumYetkilisiLogin()
        {
            InitializeComponent();
        }
        public static string kullaniciadi;
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-IPOPUUC;Initial Catalog=StokUygulamasi;Integrated Security=True");
        private void btnAnaMenu_Click(object sender, EventArgs e)
        {
            Login Login = new Login();
            Login.Show();
            this.Close();
        }
        public void btnBolumYetkiliGiris_Click(object sender, EventArgs e)
        {
            kullaniciadi = txtBolumYetkiliAdi.Text;
            try
            {
                baglanti.Open();
                string Yetki=("Bölüm Yetkilisi").ToString();
                SqlCommand komut = new SqlCommand("select * from Kullanicilar where Yetki='" +Yetki + "'and  KullaniciAdi ='" + txtBolumYetkiliAdi.Text + "' and Sifre='" + txtBolumYetkiliSifre.Text + "'", baglanti);
                SqlDataReader dr = komut.ExecuteReader();
                if(dr.Read())
                {
                    BolumYetkilisiIslem BolumYetkilisiIslem = new BolumYetkilisiIslem();
                    BolumYetkilisiIslem.Show();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı/Şifre Yanlış veya Bölüm Yetkilisi Değilsiniz" );
                }
                baglanti.Close();

            }
            catch(Exception hata)
            {
                MessageBox.Show("Bağlantı Sırasında Hata Oluştu" + hata.Message);
            }
           
            
        }

        private void BolumYetkilisiLogin_Load(object sender, EventArgs e)
        {
           

        }
    }
}