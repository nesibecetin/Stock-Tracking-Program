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
    public partial class BolumYetkilisiIslem : DevExpress.XtraEditors.XtraForm
    {
        public BolumYetkilisiIslem()
        {
            InitializeComponent();
        }
       
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-IPOPUUC;Initial Catalog=StokUygulamasi;Integrated Security=True");
        private void BolumYetkilisiIslem_Load(object sender, EventArgs e)
        {
         
            baglanti.Open();
            string ad= BolumYetkilisiLogin.kullaniciadi;
           
            string kayit = "SELECT * from Kullanicilar where KullaniciAdi='" + ad + "'";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Open();
            SqlDataReader dr = komut.ExecuteReader();
            int DetayId = 0;
            if (dr.Read())
            {
                DetayId = Convert.ToInt32(dr["DetayId"]);
                
            }
            baglanti.Close();
            baglanti.Open();
            string kayit1 = "SELECT * from Zimmet where DetayId='" + DetayId.ToString() + "'";
            SqlCommand komut1 = new SqlCommand(kayit1, baglanti);
            komut1.ExecuteNonQuery();
            SqlDataReader dr1 = komut1.ExecuteReader();
            baglanti.Close();
            
            baglanti.Open();
            string getir2 = " Select  U.UrunId ,U.Firma, U.SatinAlmaTarihi, U.ParcaAdi, U.Fiyat ,U.Adet, U.Marka, U.AnakartId ,U.EkranKartiId ,U.HardDiskId ,U.IslemciId ,Z.ZimmetId , Z.DetayId From Urun U Inner Join Zimmet Z on U.UrunId = Z.UrunId";
            SqlCommand komut2 = new SqlCommand(getir2, baglanti);
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(komut2);
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;
            baglanti.Close();

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {

            Login Login = new Login();
            Login.Show();
            this.Close();
        }
    }
}