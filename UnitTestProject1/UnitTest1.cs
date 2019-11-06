using System;
using StokUygulamasi;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Linq;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {   
        
        [TestMethod]
        public void AdminLoginTest()
        {
            AdminLogin a = new AdminLogin();
            TextEdit txtAdminAdi = a.Controls.Find("txtAdminAdi", true).FirstOrDefault() as TextEdit;
            TextEdit txtAdminSifre = a.Controls.Find("txtAdminSifre", true).FirstOrDefault() as TextEdit;
            SimpleButton login=a.Controls.Find("btnAdminGiris",true).FirstOrDefault() as SimpleButton;
            txtAdminAdi.Text="admin";
            txtAdminSifre.Text = "admin";
            login.Click += a.btnAdminGiris_Click;
        }
        [TestMethod]
        public void BolumYetkiliGirisTest()
        {
            BolumYetkilisiLogin b = new BolumYetkilisiLogin();
            TextEdit txtBolumYetkiliAdi = b.Controls.Find("txtBolumYetkiliAdi", true).FirstOrDefault() as TextEdit;
            TextEdit txtBolumYetkiliSifre = b.Controls.Find("txtBolumYetkiliSifre", true).FirstOrDefault() as TextEdit;
            SimpleButton login = b.Controls.Find("btnBolumYetkiliGiris", true).FirstOrDefault() as SimpleButton;
            txtBolumYetkiliAdi.Text = "nesibe1905";
            txtBolumYetkiliSifre.Text = "1905nesibe";
            login.Click += b.btnBolumYetkiliGiris_Click;
        }
        [TestMethod]
        public void SatinAlmaYetkiliGirisTest()
        {
            SatinAlmaYetkiliLogin s = new SatinAlmaYetkiliLogin();
            TextEdit txtBolumYetkiliAdi = s.Controls.Find("txtSatinYetkiliAdi", true).FirstOrDefault() as TextEdit;
            TextEdit txtBolumYetkiliSifre = s.Controls.Find("txtSatinYetkiliSifre", true).FirstOrDefault() as TextEdit;
            SimpleButton login = s.Controls.Find("btnGiris", true).FirstOrDefault() as SimpleButton;
            txtBolumYetkiliAdi.Text = "irem123";
            txtBolumYetkiliSifre.Text = "123irem";
            login.Click += s.btnGiris_Click;
        }

        [TestMethod]
        public void StokSilTest()
        {
            AdminIslem I = new AdminIslem();
            System.Windows.Forms.ComboBox cmbSilKategori = I.Controls.Find("cmbSilKategori", true).FirstOrDefault() as System.Windows.Forms.ComboBox;
            TextBox txtKategoriId = I.Controls.Find("txtKategoriId", true).FirstOrDefault() as TextBox;
            SimpleButton login = I.Controls.Find("btnSil", true).FirstOrDefault() as SimpleButton;
            cmbSilKategori.Text = "Anakart";
            txtKategoriId.Text = "38";
            login.Click += I.btnSil_Click;
        }
        [TestMethod]
        public void KullaniciEkleTest()
        {
            AdminIslem i = new AdminIslem();
            TextEdit txtAd = i.Controls.Find("txtAd", true).FirstOrDefault() as TextEdit;
            TextEdit txtSoyad = i.Controls.Find("txtSoyad", true).FirstOrDefault() as TextEdit;
            TextEdit txtTelefon = i.Controls.Find("txtTelefon", true).FirstOrDefault() as TextEdit;
            TextEdit txtEMail = i.Controls.Find("txtEMail", true).FirstOrDefault() as TextEdit;
            TextEdit txtAdres = i.Controls.Find("txtAdres", true).FirstOrDefault() as TextEdit;
            System.Windows.Forms.ComboBox cmbYetki = i.Controls.Find("cmbYetki", true).FirstOrDefault() as System.Windows.Forms.ComboBox;
            TextEdit txtKullaniciAdi = i.Controls.Find("txtKullanicicAdi", true).FirstOrDefault() as TextEdit;
            TextEdit txtSifre = i.Controls.Find("txtSifre", true).FirstOrDefault() as TextEdit;
            SimpleButton login = i.Controls.Find("btnKullaniciEkle", true).FirstOrDefault() as SimpleButton;
            login.Click += i.btnKullaniciEkle_Click;

        }
    }
}
