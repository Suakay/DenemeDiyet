using DenemeDiyetDAL.Repository;
using Diyet_Deneme_DaLL.Entities;
using DiyetDenemeDATA.TemelOgeler.Base;

namespace DiyetDenemeUI
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void btnKayitOlLogin_Click(object sender, EventArgs e)
        {
            KayitOl kayitOl = new KayitOl();
            kayitOl.Show();
            this.Hide();
        }

        private void btnParolaUnuttum_Click(object sender, EventArgs e)
        {
            ParolayıGuncelle parolayıGuncelle = new ParolayıGuncelle();
            parolayıGuncelle.Show();
            this.Hide();
        }

        private void btnGirisLogin_Click(object sender, EventArgs e)
        {
            string email = txtKullaniciAdiLogin.Text;
            string sifre = txtSifreLogin.Text;
            KullanıcıRepository kullanıcıRepository = new KullanıcıRepository();
            Kullanici girisKullanici = kullanıcıRepository.GetUserByEmail(email);
            if(girisKullanici != null && girisKullanici.Password == sifre ) 
            {
                KullaniciYonetimi.CurrentUser = girisKullanici;
                AnaSayfa anaSayfa = new AnaSayfa();
                anaSayfa.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş");

            }
        }
    }
}
