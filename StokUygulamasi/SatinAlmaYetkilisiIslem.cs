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
    public partial class SatinAlmaYetkilisiIslem : DevExpress.XtraEditors.XtraForm
    {
        public SatinAlmaYetkilisiIslem()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-IPOPUUC;Initial Catalog=StokUygulamasi;Integrated Security=True");
        private void btnGoster_Click(object sender, EventArgs e)
        {
            
            if (cmbStok.Text == "Anakart")
            {

                lblBoyut.Visible = true;
                lblChipset.Visible = true;
                lblSoketTipi.Visible = true;
                lblRamTipi.Visible = true;
                txtBoyut.Visible = true;
                txtChipset.Visible = true;
                txtSoketTipi.Visible = true;
                txtRamTipi.Visible = true;
                lblCekirdekHizi.Visible = false;
                lblRamKapasitesi.Visible = false;
                lblChipseti.Visible = false;
                lblChipsetiMarkasi.Visible = false;
                lblDonusHizi.Visible = false;
                lblBoyutu.Visible = false;
                lblOnBellegi.Visible = false;
                lblTip.Visible = false;
                lblSoketTip.Visible = false;
                lblCekirdekSayisi.Visible = false;
                lblHizi.Visible = false;
                lblOnBellek.Visible = false;
                txtCekirdekhizi.Visible = false;
                txtRamKapasitesi.Visible = false;
                txtChipsetiMarkasi.Visible = false;
                txtChipseti.Visible = false;
                txtDonusHizi.Visible = false;
                txtBoyutu.Visible = false;
                txtOnBellegi.Visible = false;
                txtTip.Visible = false;
                txtSoketTip.Visible = false;
                txtCekirdekSayisi.Visible = false;
                txtHizi.Visible = false;
                txtOnBellek.Visible = false;


            }
            else if (cmbStok.Text == "Ekran Kartı")
            {
                lblCekirdekHizi.Visible = true;
                lblRamKapasitesi.Visible = true;
                lblChipseti.Visible = true;
                lblChipsetiMarkasi.Visible = true;
                txtCekirdekhizi.Visible = true;
                txtRamKapasitesi.Visible = true;
                txtChipsetiMarkasi.Visible = true;
                txtChipseti.Visible = true;
                lblBoyut.Visible = false;
                lblChipset.Visible = false;
                lblSoketTipi.Visible = false;
                lblRamTipi.Visible = false;
                lblDonusHizi.Visible = false;
                lblBoyutu.Visible = false;
                lblOnBellegi.Visible = false;
                lblTip.Visible = false;
                lblSoketTip.Visible = false;
                lblCekirdekSayisi.Visible = false;
                lblHizi.Visible = false;
                lblOnBellek.Visible = false;
                txtBoyut.Visible = false;
                txtChipset.Visible = false;
                txtSoketTipi.Visible = false;
                txtRamTipi.Visible = false;
                txtDonusHizi.Visible = false;
                txtBoyutu.Visible = false;
                txtOnBellegi.Visible = false;
                txtTip.Visible = false;
                txtSoketTip.Visible = false;
                txtCekirdekSayisi.Visible = false;
                txtHizi.Visible = false;
                txtOnBellek.Visible = false;



            }
            else if (cmbStok.Text == "Hard Disk")
            {
                lblDonusHizi.Visible = true;
                lblBoyutu.Visible = true;
                lblOnBellegi.Visible = true;
                lblTip.Visible = true;
                txtDonusHizi.Visible = true;
                txtBoyutu.Visible = true;
                txtOnBellegi.Visible = true;
                txtTip.Visible = true;
                lblBoyut.Visible = false;
                lblChipset.Visible = false;
                lblSoketTipi.Visible = false;
                lblRamTipi.Visible = false;
                lblCekirdekHizi.Visible = false;
                lblRamKapasitesi.Visible = false;
                lblChipseti.Visible = false;
                lblChipsetiMarkasi.Visible = false;
                lblSoketTip.Visible = false;
                lblCekirdekSayisi.Visible = false;
                lblHizi.Visible = false;
                lblOnBellek.Visible = false;
                txtBoyut.Visible = false;
                txtChipset.Visible = false;
                txtSoketTipi.Visible = false;
                txtRamTipi.Visible = false;
                txtCekirdekhizi.Visible = false;
                txtRamKapasitesi.Visible = false;
                txtChipsetiMarkasi.Visible = false;
                txtChipseti.Visible = false;
                txtSoketTip.Visible = false;
                txtCekirdekSayisi.Visible = false;
                txtHizi.Visible = false;
                txtOnBellek.Visible = false;



            }
            else if (cmbStok.Text == "İşlemci")
            {
                lblSoketTip.Visible = true;
                lblCekirdekSayisi.Visible = true;
                lblHizi.Visible = true;
                lblOnBellek.Visible = true;
                txtSoketTip.Visible = true;
                txtCekirdekSayisi.Visible = true;
                txtHizi.Visible = true;
                txtOnBellek.Visible = true;
                lblBoyut.Visible = false;
                lblChipset.Visible = false;
                lblSoketTipi.Visible = false;
                lblRamTipi.Visible = false;
                lblCekirdekHizi.Visible = false;
                lblRamKapasitesi.Visible = false;
                lblChipseti.Visible = false;
                lblChipsetiMarkasi.Visible = false;
                lblDonusHizi.Visible = false;
                lblBoyutu.Visible = false;
                lblOnBellegi.Visible = false;
                lblTip.Visible = false;
                txtBoyut.Visible = false;
                txtChipset.Visible = false;
                txtSoketTipi.Visible = false;
                txtRamTipi.Visible = false;
                txtCekirdekhizi.Visible = false;
                txtRamKapasitesi.Visible = false;
                txtChipsetiMarkasi.Visible = false;
                txtChipseti.Visible = false;
                txtDonusHizi.Visible = false;
                txtBoyutu.Visible = false;
                txtOnBellegi.Visible = false;
                txtTip.Visible = false;
            }
        }
        void TextBoxTemizle()
        {
            cmbStok.Text = "";
            txtFirma.Text = "";
            dteAlmaTarihi.Text = "";
            txtParcaAdi.Text = "";
            txtFiyat.Text = "";
            txtAdet.Text = "";
            txtMarka.Text = "";
            txtBoyut.Text = "";
            txtChipset.Text = "";
            txtSoketTipi.Text = "";
            txtRamTipi.Text = "";
            txtCekirdekhizi.Text = "";
            txtRamKapasitesi.Text = "";
            txtChipseti.Text = "";
            txtChipsetiMarkasi.Text = "";
            txtDonusHizi.Text = "";
            txtBoyutu.Text = "";
            txtOnBellegi.Text = "";
            txtTip.Text = "";
            txtSoketTip.Text = "";
            txtCekirdekSayisi.Text = "";
            txtHizi.Text = "";
            txtOnBellek.Text = "";
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if(cmbStok.Text != "" && txtFirma.Text != "" && dteAlmaTarihi.Text != "" && txtParcaAdi.Text != "" && txtFiyat.Text != "" && txtAdet.Text != "")
            {
                try
                {
                    baglanti.Open();
                    if (cmbStok.Text == "Anakart")
                    {
                        if(txtBoyut.Text != "" && txtChipset.Text != "" && txtSoketTipi.Text != "" && txtRamTipi.Text != "")
                        {
                            string kayit1 = "insert into AnaKart(Boyut,Chipset,SoketTipi,RamTipi) values(@Boyut,@Chipset,@SoketTipi,@RamTipi)";
                            SqlCommand Komut2 = new SqlCommand(kayit1, baglanti);
                            Komut2.Parameters.AddWithValue("@Boyut", txtBoyut.Text);
                            Komut2.Parameters.AddWithValue("@Chipset", txtChipset.Text);
                            Komut2.Parameters.AddWithValue("@SoketTipi", txtSoketTipi.Text);
                            Komut2.Parameters.AddWithValue("@RamTipi", txtRamTipi.Text);
                            Komut2.ExecuteNonQuery();
                            baglanti.Close();
                            baglanti.Open();
                            string cekme = "select top 1 AnaKartId from Anakart order by AnakartId desc ";

                            SqlCommand cekmeKomut = new SqlCommand(cekme, baglanti);

                            cekmeKomut.ExecuteNonQuery();
                            SqlDataReader dr = cekmeKomut.ExecuteReader();
                            if (dr.Read())
                            {
                                int id = Convert.ToInt32(dr["AnakartId"]);
                                baglanti.Close();
                                baglanti.Open();
                                string kayit = "insert into Urun(Firma,SatinAlmaTarihi,ParcaAdi,Fiyat,Adet,Marka,AnaKartId) values(@Firma,@SatinAlmaTarihi,@ParcaAdi,@Fiyat,@Adet,@Marka,@AnakartId)";
                                SqlCommand Komut = new SqlCommand(kayit, baglanti);
                                Komut.Parameters.AddWithValue("@Firma", txtFirma.Text);
                                Komut.Parameters.AddWithValue("@SatinAlmaTarihi", Convert.ToDateTime(dteAlmaTarihi.Text));
                                Komut.Parameters.AddWithValue("@ParcaAdi", txtParcaAdi.Text);
                                Komut.Parameters.AddWithValue("@Fiyat", txtFiyat.Text);
                                Komut.Parameters.AddWithValue("@Adet", txtAdet.Text);
                                Komut.Parameters.AddWithValue("@Marka", txtMarka.Text);
                                Komut.Parameters.AddWithValue("@AnakartId", id);
                                Komut.ExecuteNonQuery();

                                MessageBox.Show("Anakart Başarıyla Kaydedildi.");
                            }

                        }
                        else
                            MessageBox.Show("Alanlar Boş Geçilemez");

                    }
                        
                    baglanti.Close();

                }
                catch (Exception hata)
                {

                    MessageBox.Show("İŞLEM SIRASINDA HATA OLUŞTU" + hata.Message);
                }
                try
                {
                    baglanti.Open();
                    if (cmbStok.Text == "Ekran Kartı")
                    {
                        if(txtCekirdekhizi.Text != "" && txtRamKapasitesi.Text != "" && txtChipseti.Text != "" && txtChipsetiMarkasi.Text != "")
                        {
                            string kayit1 = "insert into EkranKarti(CekirdekHizi,RamKapasitesi,ChipsetiMarkasi,Chipseti) values(@CekirdekHizi,@RamKapasitesi,@ChipsetiMarkasi,@Chipseti)";
                            SqlCommand Komut2 = new SqlCommand(kayit1, baglanti);
                            Komut2.Parameters.AddWithValue("@CekirdekHizi", txtCekirdekhizi.Text);
                            Komut2.Parameters.AddWithValue("@RamKapasitesi", txtRamKapasitesi.Text);
                            Komut2.Parameters.AddWithValue("@ChipsetiMarkasi", txtChipsetiMarkasi.Text);
                            Komut2.Parameters.AddWithValue("@Chipseti", txtChipseti.Text);
                            Komut2.ExecuteNonQuery();
                            baglanti.Close();
                            baglanti.Open();
                            string cekme = "select top 1 EkranKartiId from EkranKarti order by EkranKartiId desc ";

                            SqlCommand cekmeKomut = new SqlCommand(cekme, baglanti);

                            cekmeKomut.ExecuteNonQuery();
                            SqlDataReader dr = cekmeKomut.ExecuteReader();
                            if (dr.Read())
                            {
                                int id = Convert.ToInt32(dr["EkranKartiId"]);
                                baglanti.Close();
                                baglanti.Open();
                                string kayit = "insert into Urun(Firma,SatinAlmaTarihi,ParcaAdi,Fiyat,Adet,Marka,EkranKartiId) values(@Firma,@SatinAlmaTarihi,@ParcaAdi,@Fiyat,@Adet,@Marka,@EkranKartiId)";
                                SqlCommand Komut = new SqlCommand(kayit, baglanti);
                                Komut.Parameters.AddWithValue("@Firma", txtFirma.Text);
                                Komut.Parameters.AddWithValue("@SatinAlmaTarihi", Convert.ToDateTime(dteAlmaTarihi.Text));
                                Komut.Parameters.AddWithValue("@ParcaAdi", txtParcaAdi.Text);
                                Komut.Parameters.AddWithValue("@Fiyat", txtFiyat.Text);
                                Komut.Parameters.AddWithValue("@Adet", txtAdet.Text);
                                Komut.Parameters.AddWithValue("@Marka", txtMarka.Text);
                                Komut.Parameters.AddWithValue("@EkranKartiId", id);
                                Komut.ExecuteNonQuery();

                                MessageBox.Show("Ekran Kartı Başarıyla Kaydedildi.");
                            }

                        }
                        else
                            MessageBox.Show("Alanlar Boş Geçilemez");
                    }
                       
                    baglanti.Close();
                }


                catch (Exception hata)
                {

                    MessageBox.Show("İŞLEM SIRASINDA HATA OLUŞTU" + hata.Message);
                }
                try
                {
                    baglanti.Open();
                    if (cmbStok.Text == "Hard Disk")
                    {
                        if(txtMarka.Text != "" && txtDonusHizi.Text != "" && txtBoyutu.Text != "" && txtOnBellegi.Text != "" && txtTip.Text != "")
                        {

                            string kayit1 = "insert into HardDisk(DonusHizi,Boyutu,OnBellegi,Tipi) values(@DonusHizi,@Boyutu,@OnBellegi,@Tipi)";
                            SqlCommand Komut2 = new SqlCommand(kayit1, baglanti);
                            Komut2.Parameters.AddWithValue("@DonusHizi", txtDonusHizi.Text);
                            Komut2.Parameters.AddWithValue("@Boyutu", txtBoyutu.Text);
                            Komut2.Parameters.AddWithValue("@OnBellegi", txtOnBellegi.Text);
                            Komut2.Parameters.AddWithValue("@Tipi", txtTip.Text);
                            Komut2.ExecuteNonQuery();
                            baglanti.Close();
                            baglanti.Open();
                            string cekme = "select top 1 HardDiskId from HardDisk order by HardDiskId desc ";

                            SqlCommand cekmeKomut = new SqlCommand(cekme, baglanti);

                            cekmeKomut.ExecuteNonQuery();
                            SqlDataReader dr = cekmeKomut.ExecuteReader();
                            if (dr.Read())
                            {
                                int id = Convert.ToInt32(dr["HardDiskId"]);
                                baglanti.Close();
                                baglanti.Open();
                                string kayit = "insert into Urun(Firma,SatinAlmaTarihi,ParcaAdi,Fiyat,Adet,Marka,HardDiskId) values(@Firma,@SatinAlmaTarihi,@ParcaAdi,@Fiyat,@Adet,@Marka,@HardDiskId)";
                                SqlCommand Komut = new SqlCommand(kayit, baglanti);
                                Komut.Parameters.AddWithValue("@Firma", txtFirma.Text);
                                Komut.Parameters.AddWithValue("@SatinAlmaTarihi", Convert.ToDateTime(dteAlmaTarihi.Text));
                                Komut.Parameters.AddWithValue("@ParcaAdi", txtParcaAdi.Text);
                                Komut.Parameters.AddWithValue("@Fiyat", txtFiyat.Text);
                                Komut.Parameters.AddWithValue("@Adet", txtAdet.Text);
                                Komut.Parameters.AddWithValue("@Marka", txtMarka.Text);
                                Komut.Parameters.AddWithValue("@HardDiskId", id);
                                Komut.ExecuteNonQuery();

                                MessageBox.Show("HardDisk Başarıyla Kaydedildi.");
                            }

                        }
                        else
                            MessageBox.Show("Alanlar Boş Geçilemez");
                    }
                       
                    baglanti.Close();
                    
                }


                catch (Exception hata)
                {

                    MessageBox.Show("İŞLEM SIRASINDA HATA OLUŞTU" + hata.Message);
                }

                try
                {
                    baglanti.Open();
                    if (cmbStok.Text == "İşlemci")
                    {
                        if(txtSoketTip.Text != "" && txtCekirdekSayisi.Text != "" && txtHizi.Text != "" && txtOnBellek.Text != "")
                        {
                            string kayit1 = "insert into Islemci(SoketTip,CekirdekSayisi,Hiz,OnBellek) values(@SoketTip,@CekirdekSayisi,@Hiz,@OnBellek)";
                            SqlCommand Komut2 = new SqlCommand(kayit1, baglanti);
                            Komut2.Parameters.AddWithValue("@SoketTip", txtSoketTip.Text);
                            Komut2.Parameters.AddWithValue("@CekirdekSayisi", txtCekirdekSayisi.Text);
                            Komut2.Parameters.AddWithValue("@Hiz", txtHizi.Text);
                            Komut2.Parameters.AddWithValue("@OnBellek", txtOnBellek.Text);
                            Komut2.ExecuteNonQuery();
                            baglanti.Close();
                            baglanti.Open();
                            string cekme = "select top 1 IslemciId from Islemci order by IslemciId desc ";

                            SqlCommand cekmeKomut = new SqlCommand(cekme, baglanti);

                            cekmeKomut.ExecuteNonQuery();
                            SqlDataReader dr = cekmeKomut.ExecuteReader();
                            if (dr.Read())
                            {
                                int id = Convert.ToInt32(dr["IslemciId"]);
                                baglanti.Close();
                                baglanti.Open();
                                string kayit = "insert into Urun(Firma,SatinAlmaTarihi,ParcaAdi,Fiyat,Adet,Marka,IslemciId) values(@Firma,@SatinAlmaTarihi,@ParcaAdi,@Fiyat,@Adet,@Marka,@IslemciId)";
                                SqlCommand Komut = new SqlCommand(kayit, baglanti);
                                Komut.Parameters.AddWithValue("@Firma", txtFirma.Text);
                                Komut.Parameters.AddWithValue("@SatinAlmaTarihi", Convert.ToDateTime(dteAlmaTarihi.Text));
                                Komut.Parameters.AddWithValue("@ParcaAdi", txtParcaAdi.Text);
                                Komut.Parameters.AddWithValue("@Fiyat", txtFiyat.Text);
                                Komut.Parameters.AddWithValue("@Adet", txtAdet.Text);
                                Komut.Parameters.AddWithValue("@Marka", txtMarka.Text);
                                Komut.Parameters.AddWithValue("@IslemciId", id);
                                Komut.ExecuteNonQuery();

                                MessageBox.Show("İşlemci Başarıyla Kaydedildi.");
                            }

                        }
                        else
                            MessageBox.Show("Alanlar Boş Geçilemez");
                    }
                        
                    baglanti.Close();

                }
                catch (Exception hata)
                {

                    MessageBox.Show("İŞLEM SIRASINDA HATA OLUŞTU" + hata.Message);
                }

            }
            else
                MessageBox.Show("Alanlar Boş Geçilemez");
            TextBoxTemizle();
            DataGridGetir();
        }
        void DataGridGetir()
        {
            baglanti.Open();
            string getir = "SELECT * from Urun";
            SqlCommand komut = new SqlCommand(getir, baglanti);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();

        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if(cmbSilKategori.Text != "" && txtKategoriId.Text != "")
            {
                if (cmbSilKategori.Text == "Ekran Kartı")
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("DELETE FROM EkranKarti where EkranKartiId=@EkranKartiId", baglanti);
                    komut.Parameters.AddWithValue("@EkranKartiId", int.Parse(txtKategoriId.Text));
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    baglanti.Open();
                    SqlCommand komut1 = new SqlCommand("DELETE FROM Urun where EkranKartiId=@EkranKartiId", baglanti);
                    komut1.Parameters.AddWithValue("@EkranKartiId", int.Parse(txtKategoriId.Text));
                    komut1.ExecuteNonQuery();
                    baglanti.Close();
                    DataGridGetir();
                }

                else if (cmbSilKategori.Text == "Anakart")
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("DELETE FROM Anakart where AnakartId=@AnakartId", baglanti);
                    komut.Parameters.AddWithValue("@AnakartId", int.Parse(txtKategoriId.Text));
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    baglanti.Open();
                    SqlCommand komut1 = new SqlCommand("DELETE FROM Urun where AnakartId=@AnakartId", baglanti);
                    komut1.Parameters.AddWithValue("@AnakartId", int.Parse(txtKategoriId.Text));
                    komut1.ExecuteNonQuery();
                    baglanti.Close();
                    DataGridGetir();
                }
                else if (cmbSilKategori.Text == "Hard Disk")
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("DELETE FROM  HardDisk where HardDiskId=@HardDiskId", baglanti);
                    komut.Parameters.AddWithValue("@HardDiskId", int.Parse(txtKategoriId.Text));
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    baglanti.Open();
                    SqlCommand komut1 = new SqlCommand("DELETE FROM Urun where HardDiskId=@HardDiskId", baglanti);
                    komut1.Parameters.AddWithValue("@HardDiskId", int.Parse(txtKategoriId.Text));
                    komut1.ExecuteNonQuery();
                    baglanti.Close();
                    DataGridGetir();
                }
                else
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("DELETE FROM  Islemci where IslemciId=@IslemciId", baglanti);
                    komut.Parameters.AddWithValue("@IslemciId", int.Parse(txtKategoriId.Text));
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    baglanti.Open();
                    SqlCommand komut1 = new SqlCommand("DELETE FROM Urun where IslemciId=@IslemciId", baglanti);
                    komut1.Parameters.AddWithValue("@IslemciId", int.Parse(txtKategoriId.Text));
                    komut1.ExecuteNonQuery();
                    baglanti.Close();
                    DataGridGetir();
                }
            }
            else
                MessageBox.Show("Alanalar Boş Geçilmez!!!!!");
            cmbSilKategori.Text = "";
            txtKategoriId.Text = "";

        }
        private void SatinAlmaYetkilisiIslem_Load(object sender, EventArgs e)
        {
            DataGridGetir();
        }
        private void btnGetir_Click(object sender, EventArgs e)
        {
            if(cmbGuncelle.Text != "" && txtGuncelleId.Text != "")
            {
                if (cmbGuncelle.Text == "Anakart")
                {
                    lblBoyut.Visible = true;
                    lblChipset.Visible = true;
                    lblSoketTipi.Visible = true;
                    lblRamTipi.Visible = true;
                    txtBoyut.Visible = true;
                    txtChipset.Visible = true;
                    txtSoketTipi.Visible = true;
                    txtRamTipi.Visible = true;
                    lblCekirdekHizi.Visible = false;
                    lblRamKapasitesi.Visible = false;
                    lblChipseti.Visible = false;
                    lblChipsetiMarkasi.Visible = false;
                    lblDonusHizi.Visible = false;
                    lblBoyutu.Visible = false;
                    lblOnBellegi.Visible = false;
                    lblTip.Visible = false;
                    lblSoketTip.Visible = false;
                    lblCekirdekSayisi.Visible = false;
                    lblHizi.Visible = false;
                    lblOnBellek.Visible = false;
                    txtCekirdekhizi.Visible = false;
                    txtRamKapasitesi.Visible = false;
                    txtChipsetiMarkasi.Visible = false;
                    txtChipseti.Visible = false;
                    txtDonusHizi.Visible = false;
                    txtBoyutu.Visible = false;
                    txtOnBellegi.Visible = false;
                    txtTip.Visible = false;
                    txtSoketTip.Visible = false;
                    txtCekirdekSayisi.Visible = false;
                    txtHizi.Visible = false;
                    txtOnBellek.Visible = false;

                    baglanti.Open();

                    string kayit = "SELECT * from Anakart where AnakartId=@AnakartId";
                    SqlCommand komut = new SqlCommand(kayit, baglanti);
                    komut.Parameters.AddWithValue("@AnakartId", txtGuncelleId.Text);
                    SqlDataAdapter da = new SqlDataAdapter(komut);
                    SqlDataReader dr = komut.ExecuteReader();
                    if (dr.Read())
                    {
                        txtBoyut.Text = dr["Boyut"].ToString();
                        txtChipset.Text = dr["Chipset"].ToString();
                        txtSoketTipi.Text = dr["SoketTipi"].ToString();
                        txtRamTipi.Text = dr["RamTipi"].ToString();

                    }
                    baglanti.Close();
                    baglanti.Open();
                    string kayit1 = "SELECT * from Urun where AnakartId=@AnakartId";
                    SqlCommand komut1 = new SqlCommand(kayit1, baglanti);
                    komut1.Parameters.AddWithValue("@AnakartId", txtGuncelleId.Text);
                    SqlDataAdapter da1 = new SqlDataAdapter(komut1);
                    SqlDataReader dr1 = komut1.ExecuteReader();
                    if (dr1.Read())
                    {
                        txtFirma.Text = dr1["Firma"].ToString();
                        dteAlmaTarihi.Text = dr1["SatinAlmaTarihi"].ToString();
                        txtParcaAdi.Text = dr1["ParcaAdi"].ToString();
                        txtFiyat.Text = dr1["Fiyat"].ToString();
                        txtAdet.Text = dr1["Adet"].ToString();
                        txtMarka.Text = dr1["Marka"].ToString();

                    }
                    baglanti.Close();

                }
                else if (cmbGuncelle.Text == "Ekran Kartı")
                {
                    lblCekirdekHizi.Visible = true;
                    lblRamKapasitesi.Visible = true;
                    lblChipseti.Visible = true;
                    lblChipsetiMarkasi.Visible = true;
                    txtCekirdekhizi.Visible = true;
                    txtRamKapasitesi.Visible = true;
                    txtChipsetiMarkasi.Visible = true;
                    txtChipseti.Visible = true;
                    lblBoyut.Visible = false;
                    lblChipset.Visible = false;
                    lblSoketTipi.Visible = false;
                    lblRamTipi.Visible = false;
                    lblDonusHizi.Visible = false;
                    lblBoyutu.Visible = false;
                    lblOnBellegi.Visible = false;
                    lblTip.Visible = false;
                    lblSoketTip.Visible = false;
                    lblCekirdekSayisi.Visible = false;
                    lblHizi.Visible = false;
                    lblOnBellek.Visible = false;
                    txtBoyut.Visible = false;
                    txtChipset.Visible = false;
                    txtSoketTipi.Visible = false;
                    txtRamTipi.Visible = false;
                    txtDonusHizi.Visible = false;
                    txtBoyutu.Visible = false;
                    txtOnBellegi.Visible = false;
                    txtTip.Visible = false;
                    txtSoketTip.Visible = false;
                    txtCekirdekSayisi.Visible = false;
                    txtHizi.Visible = false;
                    txtOnBellek.Visible = false;

                    baglanti.Open();
                    string kayit = "SELECT * from EkranKarti where EkranKartiId=@EkranKartiId";
                    SqlCommand komut = new SqlCommand(kayit, baglanti);
                    komut.Parameters.AddWithValue("@EkranKartiId", txtGuncelleId.Text);
                    SqlDataAdapter da = new SqlDataAdapter(komut);
                    SqlDataReader dr = komut.ExecuteReader();
                    if (dr.Read())
                    {

                        txtCekirdekhizi.Text = dr["CekirdekHizi"].ToString();
                        txtRamKapasitesi.Text = dr["RamKapasitesi"].ToString();
                        txtChipsetiMarkasi.Text = dr["ChipsetiMarkasi"].ToString();
                        txtChipseti.Text = dr["Chipseti"].ToString();

                    }
                    baglanti.Close();
                    baglanti.Open();
                    string kayit1 = "SELECT * from Urun where EkranKartiId=@EkranKartiId";
                    SqlCommand komut1 = new SqlCommand(kayit1, baglanti);
                    komut1.Parameters.AddWithValue("@EkranKartiId", txtGuncelleId.Text);
                    SqlDataAdapter da1 = new SqlDataAdapter(komut1);
                    SqlDataReader dr1 = komut1.ExecuteReader();
                    if (dr1.Read())
                    {
                        txtFirma.Text = dr1["Firma"].ToString();
                        dteAlmaTarihi.Text = dr1["SatinAlmaTarihi"].ToString();
                        txtParcaAdi.Text = dr1["ParcaAdi"].ToString();
                        txtFiyat.Text = dr1["Fiyat"].ToString();
                        txtAdet.Text = dr1["Adet"].ToString();
                        txtMarka.Text = dr1["Marka"].ToString();

                    }
                    baglanti.Close();
                }
                else if (cmbGuncelle.Text == "Hard Disk")
                {
                    lblDonusHizi.Visible = true;
                    lblBoyutu.Visible = true;
                    lblOnBellegi.Visible = true;
                    lblTip.Visible = true;
                    txtDonusHizi.Visible = true;
                    txtBoyutu.Visible = true;
                    txtOnBellegi.Visible = true;
                    txtTip.Visible = true;
                    lblBoyut.Visible = false;
                    lblChipset.Visible = false;
                    lblSoketTipi.Visible = false;
                    lblRamTipi.Visible = false;
                    lblCekirdekHizi.Visible = false;
                    lblRamKapasitesi.Visible = false;
                    lblChipseti.Visible = false;
                    lblChipsetiMarkasi.Visible = false;
                    lblSoketTip.Visible = false;
                    lblCekirdekSayisi.Visible = false;
                    lblHizi.Visible = false;
                    lblOnBellek.Visible = false;
                    txtBoyut.Visible = false;
                    txtChipset.Visible = false;
                    txtSoketTipi.Visible = false;
                    txtRamTipi.Visible = false;
                    txtCekirdekhizi.Visible = false;
                    txtRamKapasitesi.Visible = false;
                    txtChipsetiMarkasi.Visible = false;
                    txtChipseti.Visible = false;
                    txtSoketTip.Visible = false;
                    txtCekirdekSayisi.Visible = false;
                    txtHizi.Visible = false;
                    txtOnBellek.Visible = false;

                    baglanti.Open();
                    string kayit = "SELECT * from HardDisk where HardDiskId=@HardDiskId";
                    SqlCommand komut = new SqlCommand(kayit, baglanti);
                    komut.Parameters.AddWithValue("@HardDiskId", txtGuncelleId.Text);
                    SqlDataAdapter da = new SqlDataAdapter(komut);
                    SqlDataReader dr = komut.ExecuteReader();
                    if (dr.Read())
                    {

                        txtDonusHizi.Text = dr["DonusHizi"].ToString();
                        txtBoyutu.Text = dr["Boyutu"].ToString();
                        txtOnBellegi.Text = dr["OnBellegi"].ToString();
                        txtTip.Text = dr["Tipi"].ToString();

                    }
                    baglanti.Close();
                    baglanti.Open();
                    string kayit1 = "SELECT * from Urun where HardDiskId=@HardDiskId";
                    SqlCommand komut1 = new SqlCommand(kayit1, baglanti);
                    komut1.Parameters.AddWithValue("@HardDiskId", txtGuncelleId.Text);
                    SqlDataAdapter da1 = new SqlDataAdapter(komut1);
                    SqlDataReader dr1 = komut1.ExecuteReader();
                    if (dr1.Read())
                    {
                        txtFirma.Text = dr1["Firma"].ToString();
                        dteAlmaTarihi.Text = dr1["SatinAlmaTarihi"].ToString();
                        txtParcaAdi.Text = dr1["ParcaAdi"].ToString();
                        txtFiyat.Text = dr1["Fiyat"].ToString();
                        txtAdet.Text = dr1["Adet"].ToString();
                        txtMarka.Text = dr1["Marka"].ToString();

                    }
                    baglanti.Close();



                }
                else if (cmbGuncelle.Text == "İşlemci")
                {
                    lblSoketTip.Visible = true;
                    lblCekirdekSayisi.Visible = true;
                    lblHizi.Visible = true;
                    lblOnBellek.Visible = true;
                    txtSoketTip.Visible = true;
                    txtCekirdekSayisi.Visible = true;
                    txtHizi.Visible = true;
                    txtOnBellek.Visible = true;
                    lblBoyut.Visible = false;
                    lblChipset.Visible = false;
                    lblSoketTipi.Visible = false;
                    lblRamTipi.Visible = false;
                    lblCekirdekHizi.Visible = false;
                    lblRamKapasitesi.Visible = false;
                    lblChipseti.Visible = false;
                    lblChipsetiMarkasi.Visible = false;
                    lblDonusHizi.Visible = false;
                    lblBoyutu.Visible = false;
                    lblOnBellegi.Visible = false;
                    lblTip.Visible = false;
                    txtBoyut.Visible = false;
                    txtChipset.Visible = false;
                    txtSoketTipi.Visible = false;
                    txtRamTipi.Visible = false;
                    txtCekirdekhizi.Visible = false;
                    txtRamKapasitesi.Visible = false;
                    txtChipsetiMarkasi.Visible = false;
                    txtChipseti.Visible = false;
                    txtDonusHizi.Visible = false;
                    txtBoyutu.Visible = false;
                    txtOnBellegi.Visible = false;
                    txtTip.Visible = false;


                    baglanti.Open();
                    string kayit = "SELECT * from Islemci where IslemciId=@IslemciId";
                    SqlCommand komut = new SqlCommand(kayit, baglanti);
                    komut.Parameters.AddWithValue("@IslemciId", txtGuncelleId.Text);
                    SqlDataAdapter da = new SqlDataAdapter(komut);
                    SqlDataReader dr = komut.ExecuteReader();
                    if (dr.Read())
                    {
                        txtSoketTip.Text = dr["SoketTip"].ToString();
                        txtCekirdekSayisi.Text = dr["CekirdekSayisi"].ToString();
                        txtHizi.Text = dr["Hiz"].ToString();
                        txtOnBellek.Text = dr["OnBellek"].ToString();

                    }
                    baglanti.Close();
                    baglanti.Open();
                    string kayit1 = "SELECT * from Urun where IslemciId=@IslemciId";
                    SqlCommand komut1 = new SqlCommand(kayit1, baglanti);
                    komut1.Parameters.AddWithValue("@IslemciId", txtGuncelleId.Text);
                    SqlDataAdapter da1 = new SqlDataAdapter(komut1);
                    SqlDataReader dr1 = komut1.ExecuteReader();
                    if (dr1.Read())
                    {
                        txtFirma.Text = dr1["Firma"].ToString();
                        dteAlmaTarihi.Text = dr1["SatinAlmaTarihi"].ToString();
                        txtParcaAdi.Text = dr1["ParcaAdi"].ToString();
                        txtFiyat.Text = dr1["Fiyat"].ToString();
                        txtAdet.Text = dr1["Adet"].ToString();
                        txtMarka.Text = dr1["Marka"].ToString();

                    }
                    baglanti.Close();
                }
            }
            else
                MessageBox.Show("Alanlar Boş Geçilemez!!!!!!");
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (cmbGuncelle.Text == "Anakart")
            {
                baglanti.Open();
                int id;
                id = Convert.ToInt32(txtGuncelleId.Text);
                string kayit = "update Anakart set Boyut=@Boyut,Chipset=@Chipset,SoketTipi=@SoketTipi,RamTipi=@RamTipi where AnakartId=@params";
                SqlCommand Komut = new SqlCommand(kayit, baglanti);
                Komut.Parameters.Add("@params", id);
                Komut.Parameters.AddWithValue("@Boyut", txtBoyut.Text);
                Komut.Parameters.AddWithValue("@Chipset", txtChipset.Text);
                Komut.Parameters.AddWithValue("@SoketTipi", txtSoketTipi.Text);
                Komut.Parameters.AddWithValue("@RamTipi", txtRamTipi.Text);
                Komut.ExecuteNonQuery();
                baglanti.Close();
                baglanti.Open();
                //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
                string kayit1 = "update Urun set Firma=@Firma,SatinAlmaTarihi=@SatinAlmaTarihi,ParcaAdi=@ParcaAdi,Fiyat=@Fiyat,Adet=@Adet,Marka=@Marka where AnakartId=@params";
                SqlCommand Komut1 = new SqlCommand(kayit1, baglanti);
                Komut1.Parameters.Add("@params", id);
                Komut1.Parameters.AddWithValue("@Firma", txtFirma.Text);
                Komut1.Parameters.AddWithValue("@SatinAlmaTarihi", Convert.ToDateTime(dteAlmaTarihi.Text));
                Komut1.Parameters.AddWithValue("@ParcaAdi", txtParcaAdi.Text);
                Komut1.Parameters.AddWithValue("@Fiyat", txtFiyat.Text);
                Komut1.Parameters.AddWithValue("@Adet", txtAdet.Text);
                Komut1.Parameters.AddWithValue("@Marka", txtMarka.Text);
                Komut1.ExecuteNonQuery();
                MessageBox.Show("Müşteri Bilgileri Güncellendi.");
                baglanti.Close();
                DataGridGetir();

            }
            else if (cmbGuncelle.Text == "Ekran Kartı")
            {
                baglanti.Open();
                int id;
                id = Convert.ToInt32(txtGuncelleId.Text);
                string kayit = "update EkranKarti set CekirdekHizi=@CekirdekHizi,RamKapasitesi=@RamKapasitesi,ChipsetiMarkasi=@ChipsetiMarkasi,Chipseti=@Chipseti where EkranKartiId=@params";
                SqlCommand Komut = new SqlCommand(kayit, baglanti);
                Komut.Parameters.Add("@params", id);
                Komut.Parameters.AddWithValue("@CekirdekHizi", txtCekirdekhizi.Text);
                Komut.Parameters.AddWithValue("@RamKapasitesi", txtRamKapasitesi.Text);
                Komut.Parameters.AddWithValue("@ChipsetiMarkasi", txtChipsetiMarkasi.Text);
                Komut.Parameters.AddWithValue("@Chipseti", txtChipseti.Text);

                Komut.ExecuteNonQuery();
                baglanti.Close();
                baglanti.Open();
                //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
                string kayit1 = "update Urun set Firma=@Firma,SatinAlmaTarihi=@SatinAlmaTarihi,ParcaAdi=@ParcaAdi,Fiyat=@Fiyat,Adet=@Adet,Marka=@Marka where EkranKartiId=@params";
                SqlCommand Komut1 = new SqlCommand(kayit1, baglanti);
                Komut1.Parameters.Add("@params", id);
                Komut1.Parameters.AddWithValue("@Firma", txtFirma.Text);
                Komut1.Parameters.AddWithValue("@SatinAlmaTarihi", Convert.ToDateTime(dteAlmaTarihi.Text));
                Komut1.Parameters.AddWithValue("@ParcaAdi", txtParcaAdi.Text);
                Komut1.Parameters.AddWithValue("@Fiyat", txtFiyat.Text);
                Komut1.Parameters.AddWithValue("@Adet", txtAdet.Text);
                Komut1.Parameters.AddWithValue("@Marka", txtMarka.Text);
                Komut1.ExecuteNonQuery();
                MessageBox.Show("Müşteri Bilgileri Güncellendi.");
                baglanti.Close();
                DataGridGetir();

            }
            else if (cmbGuncelle.Text == "Hard Disk")
            {
                baglanti.Open();
                int id;
                id = Convert.ToInt32(txtGuncelleId.Text);
                string kayit = "update HardDisk set DonusHizi=@DonusHizi,Boyutu=@Boyutu,OnBellegi=@OnBellegi,Tipi=@Tipi where HardDiskId=@params";
                SqlCommand Komut = new SqlCommand(kayit, baglanti);
                Komut.Parameters.Add("@params", id);
                Komut.Parameters.AddWithValue("@DonusHizi", txtDonusHizi.Text);
                Komut.Parameters.AddWithValue("@Boyutu", txtBoyutu.Text);
                Komut.Parameters.AddWithValue("@OnBellegi", txtOnBellegi.Text);
                Komut.Parameters.AddWithValue("@Tipi", txtTip.Text);


                Komut.ExecuteNonQuery();
                baglanti.Close();
                baglanti.Open();
                //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
                string kayit1 = "update Urun set Firma=@Firma,SatinAlmaTarihi=@SatinAlmaTarihi,ParcaAdi=@ParcaAdi,Fiyat=@Fiyat,Adet=@Adet,Marka=@Marka where HardDiskId=@params";
                SqlCommand Komut1 = new SqlCommand(kayit1, baglanti);
                Komut1.Parameters.Add("@params", id);
                Komut1.Parameters.AddWithValue("@Firma", txtFirma.Text);
                Komut1.Parameters.AddWithValue("@SatinAlmaTarihi", Convert.ToDateTime(dteAlmaTarihi.Text));
                Komut1.Parameters.AddWithValue("@ParcaAdi", txtParcaAdi.Text);
                Komut1.Parameters.AddWithValue("@Fiyat", txtFiyat.Text);
                Komut1.Parameters.AddWithValue("@Adet", txtAdet.Text);
                Komut1.Parameters.AddWithValue("@Marka", txtMarka.Text);
                Komut1.ExecuteNonQuery();
                MessageBox.Show("Müşteri Bilgileri Güncellendi.");
                baglanti.Close();
                DataGridGetir();

            }
            else if (cmbGuncelle.Text == "İşlemci")
            {
                baglanti.Open();
                int id;
                id = Convert.ToInt32(txtGuncelleId.Text);
                string kayit = "update Islemci set SoketTip=@SoketTip,CekirdekSayisi=@CekirdekSayisi,Hiz=@Hiz,OnBellek=@OnBellek where IslemciId=@params";
                SqlCommand Komut = new SqlCommand(kayit, baglanti);
                Komut.Parameters.Add("@params", id);
                Komut.Parameters.AddWithValue("@SoketTip", txtSoketTip.Text);
                Komut.Parameters.AddWithValue("@CekirdekSayisi", txtCekirdekSayisi.Text);
                Komut.Parameters.AddWithValue("@Hiz", txtHizi.Text);
                Komut.Parameters.AddWithValue("@OnBellek", txtOnBellek.Text);
                Komut.ExecuteNonQuery();
                baglanti.Close();
                baglanti.Open();
                //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
                string kayit1 = "update Urun set Firma=@Firma,SatinAlmaTarihi=@SatinAlmaTarihi,ParcaAdi=@ParcaAdi,Fiyat=@Fiyat,Adet=@Adet,Marka=@Marka where IslemciId=@params";
                SqlCommand Komut1 = new SqlCommand(kayit1, baglanti);
                Komut1.Parameters.Add("@params", id);
                Komut1.Parameters.AddWithValue("@Firma", txtFirma.Text);
                Komut1.Parameters.AddWithValue("@SatinAlmaTarihi", Convert.ToDateTime(dteAlmaTarihi.Text));
                Komut1.Parameters.AddWithValue("@ParcaAdi", txtParcaAdi.Text);
                Komut1.Parameters.AddWithValue("@Fiyat", txtFiyat.Text);
                Komut1.Parameters.AddWithValue("@Adet", txtAdet.Text);
                Komut1.Parameters.AddWithValue("@Marka", txtMarka.Text);
                Komut1.ExecuteNonQuery();
                MessageBox.Show("Müşteri Bilgileri Güncellendi.");
                baglanti.Close();
            }
            DataGridGetir();
            TextBoxTemizle();
            cmbGuncelle.Text = "";
            txtGuncelleId.Text="";
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Login Login = new Login();
            Login.Show();
            this.Close();
        }
    }
}
