using DenemeDiyetDAL;
using DenemeDiyetDAL.Repository;
using DiyetDenemeDATA.TemelOgeler;
using DiyetDenemeDATA.TemelOgeler.Base;
using DiyetDenemeDATA.TemelOgeler.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiyetDenemeUI
{
    public partial class KayitOl : Form
    {

        public KayitOl()
        {
            InitializeComponent();
        }
        KullanıcıRepository userRepository = new KullanıcıRepository();


        private void s_Click(object sender, EventArgs e)
        {
            Kullanici kullanici = new Kullanici();
            if (rdbErkek.Checked)
            {
                kullanici.Cinsiyet = Cinsiyet.Erkek;
            }
            else if (rdbKadin.Checked)
            {
                kullanici.Cinsiyet = Cinsiyet.Kadın;
            }
            else
            {
                MessageBox.Show("Cinsiyet Seçin");
                return;
            }
            kullanici.EMail = txtEmail.Text;
            kullanici.Ad = txtAd.Text;
            kullanici.Soyad = txtSoyad.Text;
            kullanici.Boy = Convert.ToDouble(txtBoy.Text);
            kullanici.Kilo = Convert.ToDouble(txtKilo.Text);
            kullanici.DogumTarihi = dtmDogumTarihi.Value;

            string sifre = txtSifre.Text;
            string tekrarSifre = txtsifreTekrarı.Text;

            if (userRepository.MailKayitKontrol(kullanici.EMail))
            {
                MessageBox.Show("Bu mail kayıtlı tekrar deneyin");
                return;
            }
            if (!SifreDogruMu(sifre))
            {
                MessageBox.Show("şifreniz yeterince güçlü değil");
                return;
            }
            if (sifre != tekrarSifre)
            {
                MessageBox.Show("Şifre eşleşmiyor");
                return;
            }
            kullanici.Password = sifre;
            try
            {
                userRepository.Add(kullanici);
            }
            catch (Exception)
            {

                MessageBox.Show("Exception");
            }
            finally
            {
                Giris giris = new Giris();
                giris.Show();

                this.Hide();
            }


        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            if (!email.Contains("@"))
            {
                MessageBox.Show("Email adresini yanlış yazdınız.");
                txtEmail.Focus();
                return;
            }

        }
        static bool SifreDogruMu(string sifre)
        {
            string passwordPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$";
            return Regex.IsMatch(sifre, passwordPattern);
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            giris.Show();
            this.Hide();
        }
    }
}
