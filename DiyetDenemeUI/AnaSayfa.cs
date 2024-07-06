using Diyet_Deneme_DaLL.Entities;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiyetDenemeUI
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
            if (KullaniciYonetimi.CurrentUser != null)
            {
                // Kullanıcı bilgilerini kullanarak sayfayı güncelle
                lblUser.Text = $"{KullaniciYonetimi.CurrentUser.Ad} {KullaniciYonetimi.CurrentUser.Soyad}";
                lblBoy.Text = $"{KullaniciYonetimi.CurrentUser.Boy} cm";
                lblAgirlik.Text = $"{KullaniciYonetimi.CurrentUser.Kilo} kg";

                double bMi = 10000 * KullaniciYonetimi.CurrentUser.Kilo / (KullaniciYonetimi.CurrentUser.Boy * KullaniciYonetimi.CurrentUser.Boy);
                lblVucutIndeksi.Text = $"{bMi.ToString("0.0")}";

            }
            else
            {
                // Kullanıcı bilgisi bulunamazsa, giriş ekranına yönlendir
                MessageBox.Show("User info is not found. Please enter again.");
                Giris giris = new Giris();
                giris.Show();
                this.Hide();

            }




        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Alınan_Kaloriler kacKalori = new Alınan_Kaloriler();
            kacKalori.Show();
            this.Close();
        }


        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Yediklerim yediklerim = new Yediklerim();
            yediklerim.Show();
            this.Close();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {


        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Ayarlar ayarlar = new Ayarlar();
            ayarlar.Show();
            this.Close();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            giris.Show();
            this.Close();
        }

        private void gunSonuRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GünSonuRaporu gunSonu = new GünSonuRaporu();
            gunSonu.Show();
            this.Close();
        }

        private void karsılastirmaRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KarşılaştırmaRaporu karşılaştırmaRaporu = new KarşılaştırmaRaporu();
            karşılaştırmaRaporu.Show();
            this.Close();
        }

        private void yemekSeçimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YemekSecimi yemekSecimi = new YemekSecimi();
            yemekSecimi.Show();
            this.Hide();
        }
    }
}
