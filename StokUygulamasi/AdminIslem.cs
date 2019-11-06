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
    public partial class AdminIslem : DevExpress.XtraEditors.XtraForm
    {
        public AdminIslem()
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
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if(cmbStok.Text!=""&&txtFirma.Text!=""&&dteAlmaTarihi.Text!=""&&txtParcaAdi.Text!=""&&txtFiyat.Text!=""&&txtAdet.Text!="")
            {
                try
                {
                    baglanti.Open();
                    if (cmbStok.Text == "Anakart")
                    {
                        if (txtBoyut.Text != "" && txtChipset.Text != "" && txtSoketTipi.Text != "" && txtRamTipi.Text != "")
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
                            MessageBox.Show("Alanlar Boş Geçilemez!!!!!!");
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
                            MessageBox.Show("Alanlar Boş Geçilemez!!!!!!");
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
                            MessageBox.Show("Alanlar Boş Geçilemez!!!!!!");
                    }baglanti.Close();
                    
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
                            MessageBox.Show("Alanlar Boş Geçilemez!!!!!!");
                    } baglanti.Close();
                }    
                catch (Exception hata)
                {
                    MessageBox.Show("İŞLEM SIRASINDA HATA OLUŞTU" + hata.Message);
                }
                 DataGridGetir();
                 TextBoxTemizle();
            }
            else
                MessageBox.Show("Alanlar Boş Geçilemez!!!!!!");
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
        void KullaniciTexBoxTemizle()
        {
            txtAd.Text="";
            txtSoyad.Text = "";
            txtTelefon.Text = "";
            txtEMail.Text = "";
            txtAdres.Text = "";
            cmbYetki.Text = "";
            txtKullaniciAdi.Text = "";
            txtSifre.Text = "";

        }
        public void btnSil_Click(object sender, EventArgs e)
        {
            if(cmbSilKategori.Text!="" && txtKategoriId.Text!="")
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
                cmbSilKategori.Text = "";
                txtKategoriId.Text = "";

            }
            else
                MessageBox.Show("Alanlar Boş Bırakılamaz!!!!!!");
        }
        private void btnGetir_Click(object sender, EventArgs e)
        {
            if(cmbGuncelle.Text!=""&&txtGuncelleId.Text!="")
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
                MessageBox.Show("Alanlar boş geçilemez!!!!");
            DataGridGetir();
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if(cmbGuncelle.Text=="Anakart")
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
            else if(cmbGuncelle.Text=="Ekran Kartı")
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
            else if(cmbGuncelle.Text=="Hard Disk")
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
            else if(cmbGuncelle.Text=="İşlemci")
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
                DataGridGetir();
            }
                TextBoxTemizle();
                cmbGuncelle.Text = "";
                txtGuncelleId.Text = "";
        }
        public void btnKullaniciEkle_Click(object sender, EventArgs e)
        {
            if(txtSoyad.Text!=""&&txtTelefon.Text!=""&&txtEMail.Text!=""&&txtAdres.Text!=""&&cmbYetki.Text!=""&&txtKullaniciAdi.Text!=""&&txtSifre.Text!="")
            {
                baglanti.Open();

                try
                {
                    string kayit1 = "insert into CalisanDetay(Adi,Soyadi,TelNo,Email,Adres) values(@Adi,@Soyadi,@TelNo,@Email,@Adres)";
                    SqlCommand Komut2 = new SqlCommand(kayit1, baglanti);
                    Komut2.Parameters.AddWithValue("@Adi", txtAd.Text);
                    Komut2.Parameters.AddWithValue("@Soyadi", txtSoyad.Text);
                    Komut2.Parameters.AddWithValue("@TelNo", txtTelefon.Text);
                    Komut2.Parameters.AddWithValue("@Email", txtEMail.Text);
                    Komut2.Parameters.AddWithValue("@Adres", txtAdres.Text);
                    Komut2.ExecuteNonQuery();
                    baglanti.Close();
                    baglanti.Open();
                    string cekme = "select top 1 DetayId from CalisanDetay order by DetayId desc ";

                    SqlCommand cekmeKomut = new SqlCommand(cekme, baglanti);

                    cekmeKomut.ExecuteNonQuery();
                    SqlDataReader dr = cekmeKomut.ExecuteReader();
                    if (dr.Read())
                    {
                        int id = Convert.ToInt32(dr["DetayId"]);
                        baglanti.Close();
                        baglanti.Open();
                        string kayit = "insert into Kullanicilar(Yetki,KullaniciAdi,Sifre,DetayId) values(@Yetki,@KullaniciAdi,@Sifre,@DetayId)";
                        SqlCommand Komut = new SqlCommand(kayit, baglanti);
                        Komut.Parameters.AddWithValue("@Yetki", cmbYetki.Text);
                        Komut.Parameters.AddWithValue("@KullaniciAdi", txtKullaniciAdi.Text);
                        Komut.Parameters.AddWithValue("@Sifre", txtSifre.Text);
                        Komut.Parameters.AddWithValue("@DetayId", id);
                        Komut.ExecuteNonQuery();

                        MessageBox.Show("Kullanıcı Başarıyla Kaydedildi.");
                    }
                    baglanti.Close();

                    baglanti.Open();
                    string getir = "SELECT K.KullaniciId,C.DetayId,K.Yetki,C.Adi,C.Soyadi,C.TelNo,C.EMail,C.Adres,K.KullaniciAdi,K.Sifre from CalisanDetay C Inner Join Kullanicilar K On K.DetayId=C.DetayId";
                    SqlCommand komut = new SqlCommand(getir, baglanti);
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(komut);
                    da.Fill(dt);
                    dataGridView3.DataSource = dt;

                    baglanti.Close();
                }
                catch (Exception hata)
                {

                    MessageBox.Show("İŞLEM SIRASINDA HATA OLUŞTU" + hata.Message);
                }
            }
            else
                MessageBox.Show("Alanlar Boş Geçilemez!!!!!!");

            KullaniciTexBoxTemizle();
        }
        private void btnZimmetle_Click(object sender, EventArgs e)
        {
            void ZimmetEkle1(int UrunId,int DetayId)
            {
                baglanti.Open();
                string kayit = "Insert into  Zimmet(UrunId,DetayId) values(@UrunId,@DetayId )";
               
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                komut.Parameters.AddWithValue("@UrunId", UrunId);
                komut.Parameters.AddWithValue("@DetayId", DetayId);
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
             foreach (DataGridViewRow drow in dataGridView4.SelectedRows)  //Seçili Satırları Silme
             {
                    int UrunId = Convert.ToInt32(drow.Cells[0].Value);
                    foreach (DataGridViewRow drow1 in dataGridView5.SelectedRows)  //Seçili Satırları Silme
                    {
                        int DetayId = Convert.ToInt32(drow1.Cells[0].Value);
                        ZimmetEkle1(UrunId, DetayId);
                    }
             }
            baglanti.Open();
            string getir2 = "SELECT * from Zimmet";
            SqlCommand komut3 = new SqlCommand(getir2, baglanti);
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(komut3);
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;
            baglanti.Close();
            MessageBox.Show("Zimmetleme Başarıyla gerçekleştirildi..");
        }
        private void btnAtik_Click(object sender, EventArgs e)
        {
            if(txtAtikKategoriId.Text!="")
            {
                DataGridGetir();
                void AtikEkle(int UrunId)
                {
                    baglanti.Open();
                    string kayit = "Insert into  Atik(UrunId) values(@UrunId)";
                    SqlCommand komut = new SqlCommand(kayit, baglanti);
                    komut.Parameters.AddWithValue("@UrunId", UrunId);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    baglanti.Open();
                    string getir3 = "Select *From Atik";
                    SqlCommand komut4 = new SqlCommand(getir3, baglanti);
                    DataTable dt3 = new DataTable();
                    SqlDataAdapter da3 = new SqlDataAdapter(komut4);
                    da3.Fill(dt3);
                    dataGridView7.DataSource = dt3;
                    baglanti.Close();
                }
                foreach (DataGridViewRow drow in dataGridView6.SelectedRows)  //Seçili Satırları Silme
                {
                    int UrunId = Convert.ToInt32(drow.Cells[0].Value);
                    AtikEkle(UrunId);

                    baglanti.Open();
                    SqlCommand komut1 = new SqlCommand("DELETE FROM Urun where UrunId=@UrunId", baglanti); ;
                    komut1.Parameters.AddWithValue("@UrunId", UrunId);
                    komut1.ExecuteNonQuery();
                    baglanti.Close();

                    baglanti.Open();
                    SqlCommand komut2 = new SqlCommand("DELETE FROM EkranKarti where EkranKartiId=@EkranKartiId", baglanti);
                    komut2.Parameters.AddWithValue("@EkranKartiId", int.Parse(txtAtikKategoriId.Text));
                    komut2.ExecuteNonQuery();
                    baglanti.Close();

                    baglanti.Open();
                    SqlCommand komut5 = new SqlCommand("DELETE FROM Anakart where AnakartId=@AnakartId", baglanti);
                    komut5.Parameters.AddWithValue("@AnakartId", int.Parse(txtAtikKategoriId.Text));
                    komut5.ExecuteNonQuery();
                    baglanti.Close();

                    baglanti.Open();
                    SqlCommand komut6 = new SqlCommand("DELETE FROM HardDisk where HardDiskId=@HardDiskId", baglanti);
                    komut6.Parameters.AddWithValue("@HardDiskId", int.Parse(txtAtikKategoriId.Text));
                    komut6.ExecuteNonQuery();
                    baglanti.Close();

                    baglanti.Open();
                    SqlCommand komut7 = new SqlCommand("DELETE FROM Islemci where IslemciId=@IslemciId", baglanti);
                    komut7.Parameters.AddWithValue("@IslemciId", int.Parse(txtAtikKategoriId.Text));
                    komut7.ExecuteNonQuery();
                    baglanti.Close();
                }
            }
            else
                MessageBox.Show("Kategori Id Boş Geçilemez!!!");
        }
        private void btnAtikDataGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string getir2 = "SELECT * from Urun";
            SqlCommand komut3 = new SqlCommand(getir2, baglanti);
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(komut3);
            da2.Fill(dt2);
            dataGridView6.DataSource = dt2;
            baglanti.Close();
        }
        private void btnZimmetDataGetir_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string getir = "SELECT * from Urun";
            SqlCommand komut1 = new SqlCommand(getir, baglanti);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut1);
            da.Fill(dt);
            dataGridView4.DataSource = dt;
            baglanti.Close();

            baglanti.Open();
            string getir2 = "SELECT * from CalisanDetay";
            SqlCommand komut2 = new SqlCommand(getir2, baglanti);
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(komut2);
            da2.Fill(dt2);
            dataGridView5.DataSource = dt2;
            baglanti.Close();
        }
        DataTable tablo = new DataTable();
        private void AdminIslem_Load(object sender, EventArgs e)
        {
            tablo.Columns.Add("ZimmetId", typeof(string));
            tablo.Columns.Add("UrunId", typeof(string));
            tablo.Columns.Add("DetayId", typeof(string));
            dataGridView8.DataSource = tablo;
            DataGridGetir();

            baglanti.Open();
            string getir6 = "SELECT * from Zimmet";
            SqlCommand komut7 = new SqlCommand(getir6, baglanti);
            DataTable dt5 = new DataTable();
            SqlDataAdapter da5 = new SqlDataAdapter(komut7);
            da5.Fill(dt5);
            dataGridView2.DataSource = dt5;
            baglanti.Close();

            baglanti.Open();
            string getir1 = "SELECT * from Urun";
            SqlCommand komut5 = new SqlCommand(getir1, baglanti);
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(komut5);
            da1.Fill(dt1);
            dataGridView4.DataSource = dt1;
            baglanti.Close();

            string getir = "SELECT K.KullaniciId,C.DetayId,K.Yetki,C.Adi,C.Soyadi,C.TelNo,C.EMail,C.Adres,K.KullaniciAdi,K.Sifre from CalisanDetay C Inner Join Kullanicilar K On K.DetayId=C.DetayId";
            SqlCommand komut2 = new SqlCommand(getir, baglanti);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut2);
            da.Fill(dt);
            dataGridView3.DataSource = dt;

            string getir3 = "Select *From Atik";
            SqlCommand komut4 = new SqlCommand(getir3, baglanti);
            DataTable dt3 = new DataTable();
            SqlDataAdapter da3 = new SqlDataAdapter(komut4);
            da3.Fill(dt3);
            dataGridView7.DataSource = dt3;
            baglanti.Close();

            baglanti.Open();
            string getir2 = "SELECT * from Urun";
            SqlCommand komut3 = new SqlCommand(getir2, baglanti);
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(komut3);
            da2.Fill(dt2);
            dataGridView6.DataSource = dt2;
            baglanti.Close();

            baglanti.Open();
            string getir5 = "SELECT * from CalisanDetay";
            SqlCommand komut6 = new SqlCommand(getir5, baglanti);
            DataTable dt4 = new DataTable();
            SqlDataAdapter da4 = new SqlDataAdapter(komut6);
            da4.Fill(dt4);
            dataGridView5.DataSource = dt4;
            baglanti.Close();


            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT *FROM CalisanDetay";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;
            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbKisiRapor.Items.Add(dr["Adi"]);
            }
            baglanti.Close();
        }
        private void btnKisiRaporGoruntule_Click(object sender, EventArgs e)
        {
            tablo.Rows.Clear();
            baglanti.Open();
            string ad;
            ad=cmbKisiRapor.SelectedItem.ToString();
            string kayit = "SELECT * from CalisanDetay where Adi='"+ad+"'";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Open();
            SqlDataReader dr = komut.ExecuteReader();
            int DetayId=0;
            if (dr.Read())
            {
                DetayId=Convert.ToInt32(dr["DetayId"]);
            }
            baglanti.Close();
            baglanti.Open();
            string kayit1 = "SELECT * from Zimmet where DetayId='"+ DetayId.ToString()+"'" ;
            SqlCommand komut1 = new SqlCommand(kayit1, baglanti);
            komut1.ExecuteNonQuery();
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                tablo.Rows.Add(dr1["ZimmetId"].ToString(),dr1["UrunId"].ToString(),dr1["DetayId"].ToString());
               
            }
            dataGridView8.DataSource = tablo;
            baglanti.Close();
        }
        private void btnBolumRaorGoruntule_Click(object sender, EventArgs e)
        {
            if (cmbBolumRapor.Text == "Anakart")
            {
                baglanti.Open();
                string Kayit = " Select  U.UrunId ,U.Firma, U.SatinAlmaTarihi, U.ParcaAdi, U.Fiyat ,U.Adet, U.Marka, U.AnakartId ,Z.ZimmetId , Z.DetayId, C.Adi From Zimmet Z  Inner Join Urun U on U.UrunId = Z.UrunId  Inner Join CalisanDetay C on Z.DetayId = C.DetayId ";
                SqlCommand komut = new SqlCommand(Kayit, baglanti);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);
                dataGridView9.DataSource = dt;
                baglanti.Close();
            }
            else if (cmbBolumRapor.Text == "Ekran Kartı")
            {
                baglanti.Open();
                string Kayit = " Select  U.UrunId ,U.Firma, U.SatinAlmaTarihi, U.ParcaAdi, U.Fiyat ,U.Adet, U.Marka, U.EkranKartiId ,Z.ZimmetId , Z.DetayId,C.Adi From Zimmet Z  Inner Join Urun U on U.UrunId = Z.UrunId  Inner Join CalisanDetay C on Z.DetayId = C.DetayId ";
                SqlCommand komut = new SqlCommand(Kayit, baglanti);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);
                dataGridView9.DataSource = dt;
                
                baglanti.Close();
            }
            else if (cmbBolumRapor.Text == "Hard Disk")
            {
                baglanti.Open();
                string Kayit = " Select  U.UrunId ,U.Firma, U.SatinAlmaTarihi, U.ParcaAdi, U.Fiyat ,U.Adet, U.Marka, U.HardDiskId ,Z.ZimmetId , Z.DetayId,C.Adi From Zimmet Z  Inner Join Urun U on U.UrunId = Z.UrunId  Inner Join CalisanDetay C on Z.DetayId = C.DetayId ";
                SqlCommand komut = new SqlCommand(Kayit, baglanti);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);
                dataGridView9.DataSource = dt;
                baglanti.Close();
            }
            else if (cmbBolumRapor.Text == "İşlemci")
            {
                baglanti.Open();
                string Kayit = " Select  U.UrunId ,U.Firma, U.SatinAlmaTarihi, U.ParcaAdi, U.Fiyat ,U.Adet, U.Marka, U.IslemciId ,Z.ZimmetId , Z.DetayId,C.Adi From Zimmet Z  Inner Join Urun U on U.UrunId = Z.UrunId  Inner Join CalisanDetay C on Z.DetayId = C.DetayId ";
                SqlCommand komut = new SqlCommand(Kayit, baglanti);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);
                dataGridView9.DataSource = dt;
                baglanti.Close();
            }
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            Login Login = new Login();
            Login.Show();
            this.Close();
        }
    }
}
