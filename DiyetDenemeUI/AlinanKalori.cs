using DenemeDiyetDAL;

using Diyet_Deneme_DaLL.Entities;
using DiyetDenemeDATA.TemelOgeler;
using Microsoft.VisualBasic.ApplicationServices;
using System.Data;
using System.Diagnostics.Metrics;
using YemekKategorileri = Diyet_Deneme_DaLL.Entities.YemekKategorileri;

namespace DiyetDenemeUI
{
    public partial class Alınan_Kaloriler : Form
    {
        AppDbContext db = new AppDbContext();

        public Alınan_Kaloriler()
        {
            InitializeComponent();
            cmbkategori.DisplayMember = "YemekAdı";
            cmbkategori.DataSource = YemekKategorileriGettAll();
            cmbYiyecek.DisplayMember = "Adı";
            cmbYiyecek.DataSource = YiyeceksGettAll();
        }





        private List<Yiyecek> YiyeceksGettAll()
        {
            return db.Yiyeceks.ToList();
        }
        private List<YemekKategorileri> YemekKategorileriGettAll()
        {
            return db.YemekKategorileris.ToList();
        }
        private List<YiyecekYemekKategori> YiyecekYemekKategorisGettAll()
        {
            return db.YiyecekYemekKategoris.ToList();
        }

        private void cmbkategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbkategori.SelectedItem != null)
            {
                YemekKategorileri secilenYemekKategorisi = (YemekKategorileri)cmbkategori.SelectedItem;
                List<YiyecekYemekKategori> yiyecekYemekKategoris = YiyecekYemekKategorisGettAll();
                var kategoriiçindekiYiyecekler = yiyecekYemekKategoris
                    .Where(k => k.YemekKategorileriID == secilenYemekKategorisi.ID)
                    .Select(k => k.Yiyecek)
                    .ToList();
                cmbYiyecek.DisplayMember = "YemekAdı";
                cmbYiyecek.DataSource = yiyecekYemekKategoris;


            }
        }

       



        private void btnGeri_Click_1(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa = new AnaSayfa();
            anaSayfa.Show();
            this.Hide();

        }

        private void btnHesapla2_Click_1(object sender, EventArgs e)
        {
            YemekKategorileri secilenKategori = (YemekKategorileri)cmbkategori.SelectedItem;
            Yiyecek secilenYiyecek = (Yiyecek)cmbYiyecek.SelectedItem;
            double toplamOlcu = Convert.ToDouble(nmrOlcu.Value);

            double toplamKalori = secilenYiyecek.Kalori * toplamOlcu;
            double toplamYag = secilenYiyecek.Yağ * toplamOlcu;
            double toplamProtein = secilenYiyecek.Protein * toplamOlcu;
            double toplamKarbonhidrat = secilenYiyecek.Karbonhidrat * toplamOlcu;

            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("ToplamKalori", "ToplamKalori");
            dataGridView1.Columns.Add("ToplamYağ", "ToplamYağ");
            dataGridView1.Columns.Add("ToplamProtein", "ToplamProtein");
            dataGridView1.Columns.Add("ToplamKarbonhidrat", "ToplamKarbonhidrat");

            dataGridView1.Rows.Add(
                toplamKalori.ToString(),
                toplamYag.ToString(),
                toplamProtein.ToString(),
                toplamKarbonhidrat.ToString()
                );

        }


        //private void cmbYiyecek_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if(cmbYiyecek.SelectedItem!=null)
        //    {
        //        string deger = ((Yiyecek)cmbYiyecek.SelectedItem).Resim;
        //        //pictureBox2.Image=Image.FromFile();
        //    }
        //}
    }
}

