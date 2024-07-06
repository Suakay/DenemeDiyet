using DenemeDiyetDAL;
using DietBuddyApp.BLL.Concrete;
using Diyet_Deneme_DaLL.Entities;
using DiyetDenemeDATA.TemelOgeler;
using DiyetDenemeDATA.TemelOgeler.Enum;
using Microsoft.AspNetCore.Identity;
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
    public partial class Yediklerim : Form
    {
        private AppDbContext db = new AppDbContext();
        private void DataGridView(DataGridView dataGridView)
        {
            var yiyecekTarihi = db.YemekTarihis
                .Where(x => x.UserID == KullaniciYonetimi.CurrentUser.ID && x.Tarih == dtpTarih.Value.ToShortDateString())
                .ToList();
            dataGridView.AutoGenerateColumns = false;


            dataGridView.Columns.Clear();
            dataGridView.Columns.Add("Tarih", "Tarih");
            dataGridView.Columns.Add("Yemek", "Yemek");
            dataGridView.Columns.Add("YiyecekKategori", "Yiyecek Kategorisi");
            dataGridView.Columns.Add("Yiyecek", "Yiyecek");
            dataGridView.Columns.Add("ToplamKalori", "Kaloriler");
            dataGridView.Columns.Add("ToplamKarbonhidrat", "Karbonhidrat");
            dataGridView.Columns.Add("ToplamProtein", "Protein");
            dataGridView.Columns.Add("ToplamYag", "Yağ");

            dataGridView.DataSource = yiyecekTarihi;

            dataGridView.Columns["Tarih"].DataPropertyName = "Tarih";
            dataGridView.Columns["Yemek"].DataPropertyName = "Yemek";
            dataGridView.Columns["YiyecekKategori"].DataPropertyName = "YemekKategorileri";
            dataGridView.Columns["Yiyecek"].DataPropertyName = "Yiyecek";
            dataGridView.Columns["ToplamKalori"].DataPropertyName = "ToplamKalori";
            dataGridView.Columns["ToplamKarbonhidrat"].DataPropertyName = "ToplamKarbonhidrat";
            dataGridView.Columns["ToplamProtein"].DataPropertyName = "ToplamProtein";
            dataGridView.Columns["ToplamYag"].DataPropertyName = "ToplamYag";


        }

        public List<YiyecekYemekKategori> YiyecekYemekKategoriGetAll()
        {
            return db.YiyecekYemekKategoris.ToList();
        }
        public List<Yiyecek> YiyecekGetAll()
        {
            return db.Yiyeceks.ToList();
        }
        public List<YemekKategorileri> YemekKategorileriGetAll()
        {
            return db.YemekKategorileris.ToList();
        }
        public Yediklerim()
        {
            InitializeComponent();

            DataGridView(dgwGoster);
            if (KullaniciYonetimi.CurrentUser != null)
            {
                //Kullanıcı bilgierine göre güncelle
                lblKullanici.Text = $"{KullaniciYonetimi.CurrentUser.Ad} {KullaniciYonetimi.CurrentUser.Soyad}";
            }
            YiyecekRepository yiyecekRepository = new YiyecekRepository();

            cmbYiyecekKategori.DisplayMember = "YemekAdı";
            cmbYiyecekKategori.DataSource = YemekKategorileriGetAll();

            cmbYiyecek.DisplayMember = "Adı";
            cmbYiyecek.DataSource = YiyecekGetAll();

            cmbYemek.DataSource = Enum.GetNames(typeof(Ogunler));
        }

        //private void cmbYiyecek_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (cmbYiyecek.SelectedItem != null)
        //    {
        //        string dosyaAdi = ((Yiyecek)cmbYiyecek.SelectedItem).Resim;
        //        pictureBox1.Image = Image.FromFile($"C:\\Users\\REMZI\\Desktop\\DenemeDiyet-master-son 01.06.2024\\DenemeDiyet-master-son 01.06.2024\\DiyetDenemeUI\\Resim\\");
        //    }
        //}

        private void btnGeri_Click(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa = new AnaSayfa();
            anaSayfa.Show();
            this.Close();
        }

        private void cmbYiyecekKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbYiyecekKategori.SelectedItem != null)
            {
                YemekKategorileri secilenKategori = (YemekKategorileri)cmbYiyecekKategori.SelectedItem;

                List<YiyecekYemekKategori> yiyecekYemekKategoris = YiyecekYemekKategoriGetAll();

                var yiyecekKategori = yiyecekYemekKategoris
                    .Where(ff => ff.YemekKategorileriID == secilenKategori.ID)
                    .Select(ff => ff.Yiyecek)
                    .ToList();

                cmbYiyecek.DisplayMember = "Adı";
                cmbYiyecek.DataSource = yiyecekKategori;
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            YemekKategorileri secilenYemekKategori = (YemekKategorileri)cmbYiyecekKategori.SelectedItem;
            Yiyecek secilenYiyecek = (Yiyecek)cmbYiyecek.SelectedItem;

            double toplamOlcu = Convert.ToDouble(nudOlcu.Value);

            double totalCalories = secilenYiyecek.Kalori * toplamOlcu;
            double totalFat = secilenYiyecek.Yağ * toplamOlcu;
            double totalProtein = secilenYiyecek.Protein * toplamOlcu;
            double totalCarbs = secilenYiyecek.Karbonhidrat * toplamOlcu;

            YemekTarihi foodCatDate = new YemekTarihi();
            foodCatDate.Tarih = dtpTarih.Value.ToShortDateString();
            foodCatDate.Yemek = cmbYemek.SelectedItem?.ToString();
            foodCatDate.YemekKategorileri = secilenYemekKategori.YemekAdı;
            foodCatDate.Yiyecek = secilenYiyecek.Adı;
            foodCatDate.Olcu = nudOlcu.Value.ToString();
            foodCatDate.ToplamKalori = totalCalories.ToString();
            foodCatDate.ToplamYag = totalFat.ToString();
            foodCatDate.ToplamProtein = totalProtein.ToString();
            foodCatDate.ToplamKarbonhidrat = totalCarbs.ToString();
            foodCatDate.UserID = KullaniciYonetimi.CurrentUser.ID;

            YemekTarihiRepository foodCatDateRepository = new YemekTarihiRepository();
            foodCatDateRepository.Add(foodCatDate);

            DataGridView(dgwGoster);
        }

        private List<YemekTarihi> YemekTarihiGetAll()
        {
            return db.YemekTarihis.ToList();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            YemekTarihi selectedFoodCatDate = (YemekTarihi)dgwGoster.CurrentRow.DataBoundItem;

            YemekKategorileri selectedFoodCategory = (YemekKategorileri)cmbYiyecekKategori.SelectedItem;
            Yiyecek selectedFood = (Yiyecek)cmbYiyecek.SelectedItem;

            double toplamOlcu = Convert.ToDouble(nudOlcu.Value);

            selectedFoodCatDate.Yemek = cmbYemek.SelectedItem?.ToString();
            selectedFoodCatDate.YemekKategorileri = selectedFoodCategory.YemekAdı;
            selectedFoodCatDate.Yiyecek = selectedFood.Adı;
            selectedFoodCatDate.Olcu = nudOlcu.Value.ToString();
            selectedFoodCatDate.ToplamKalori = (selectedFood.Kalori * toplamOlcu).ToString();
            selectedFoodCatDate.ToplamYag = (selectedFood.Yağ * toplamOlcu).ToString();
            selectedFoodCatDate.ToplamProtein = (selectedFood.Protein * toplamOlcu).ToString();
            selectedFoodCatDate.ToplamKarbonhidrat = (selectedFood.Karbonhidrat * toplamOlcu).ToString();
            selectedFoodCatDate.UserID = KullaniciYonetimi.CurrentUser.ID;

            YemekTarihiRepository foodCatDateRepository = new YemekTarihiRepository();
            foodCatDateRepository.Update(selectedFoodCatDate);

            DataGridView(dgwGoster);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            YemekTarihi selectedFoodCatDate = (YemekTarihi)dgwGoster.CurrentRow.DataBoundItem;

            YemekTarihiRepository foodCatDateRepository = new YemekTarihiRepository();
            foodCatDateRepository.Delete(selectedFoodCatDate);

            DataGridView(dgwGoster);
        }
    }
}
