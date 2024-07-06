using DenemeDiyetDAL;
using Diyet_Deneme_DaLL.Entities;
using DiyetDenemeDATA.TemelOgeler.Base;
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
    public partial class KarşılaştırmaRaporu : Form
    {


        AppDbContext db = new AppDbContext();
        public KarşılaştırmaRaporu()
        {
            InitializeComponent();

        }



        private List<YemekTarihi> YemekTarihiGetAll()
        {
            return db.YemekTarihis.ToList();
        }

        private List<Kullanici> KullaniciGetAll()
        {
            return db.Kullanicis.ToList();
        }
        private void FoodCategoryReport(string period)
        {
            DateTime baslangıc;
            DateTime bitis;

            if (period == "Haftalık")
            {
                baslangıc = DateTime.Now.Date;
                bitis = baslangıc.AddDays(-7);
            }
            else
            {
                baslangıc = DateTime.Now.Date;
                bitis = baslangıc.AddMonths(-1);
            }

            List<YemekTarihi> yemekTarihis = YemekTarihiGetAll().Where(x => DateTime.Parse(x.Tarih) <= baslangıc && DateTime.Parse(x.Tarih) >= bitis).ToList();

            DataTable dt = new DataTable();
            dt.Columns.Add("KullaniciId");
            dt.Columns.Add("YemekKategori");
            dt.Columns.Add("ToplamKalori");
            dt.Columns.Add("ToplamYağ");
            dt.Columns.Add("ToplamProtein");
            dt.Columns.Add("ToplamKarbonhidrat");

            var groupData = yemekTarihis
                .GroupBy(x => new { x.ID, x.YemekKategorileri })
                .Select(g => new
                {
                    KullaniciId = g.Key.ID,
                    YemekKategori = g.Key.YemekKategorileri,
                    ToplamKalori = g.Sum(x => Convert.ToDouble(x.ToplamKalori)),
                    ToplamYağ = g.Sum(x => Convert.ToDouble(x.ToplamYag)),
                    ToplamProtein = g.Sum(x => Convert.ToDouble(x.ToplamProtein)),
                    ToplamKarbonhidrat = g.Sum(x => Convert.ToDouble(x.ToplamKarbonhidrat))
                })
                .ToList();

            foreach (var reportRow in groupData)
            {
                DataRow row = dt.NewRow();

                Kullanici user = KullaniciGetAll().FirstOrDefault(u => u.ID == reportRow.KullaniciId);
                if (user != null)
                {
                    row["KullaniciId"] = $"{user.Ad} {user.Soyad}"; 
                }

                row["YemekKategori"] = reportRow.YemekKategori.ToString();
                row["ToplamKalori"] = reportRow.ToplamKalori.ToString("0.#");
                row["ToplamYağ"] = reportRow.ToplamYağ.ToString("0");
                row["ToplamProtein"] = reportRow.ToplamProtein.ToString("0");
                row["ToplamKarbonhidrat"] = reportRow.ToplamKarbonhidrat.ToString("0");

                dt.Rows.Add(row);
            }

            dataGridView1.DataSource = dt;
        }
        private void MealReport(string period)
        {

            DateTime baslangıcTarihi;
            DateTime bitisTarihi;

            if (period == "Haftalık")
            {
                baslangıcTarihi = DateTime.Now.Date;
                bitisTarihi = baslangıcTarihi.AddDays(-7);
            }
            else
            {
                baslangıcTarihi = DateTime.Now.Date;
                bitisTarihi = baslangıcTarihi.AddMonths(-1);
            }

            List<YemekTarihi> foodCatDate = YemekTarihiGetAll().Where(x => DateTime.Parse(x.Tarih) <= baslangıcTarihi && DateTime.Parse(x.Tarih) >= bitisTarihi).ToList();

            DataTable dt = new DataTable();
            dt.Columns.Add("KullaniciId");
            dt.Columns.Add("Yemek");
            dt.Columns.Add("ToplamKalori");
            dt.Columns.Add("ToplamYağ");
            dt.Columns.Add("ToplamProtein");
            dt.Columns.Add("ToplamKarbonhidrat");

            var groupData = foodCatDate
                .GroupBy(x => new { x.ID, x.Yemek })
                .Select(g => new
                {
                    KullaniciId = g.Key.ID,
                    Yemek = g.Key.Yemek,
                    ToplamKalori = g.Sum(x => Convert.ToDouble(x.ToplamKalori)),
                    ToplamYağ = g.Sum(x => Convert.ToDouble(x.ToplamYag)),
                    ToplamProtein = g.Sum(x => Convert.ToDouble(x.ToplamProtein)),
                    ToplamKarbonhidrat = g.Sum(x => Convert.ToDouble(x.ToplamKarbonhidrat))
                })
                .ToList();

            foreach (var reportRow in groupData)
            {
                DataRow row = dt.NewRow();

                Kullanici user = KullaniciGetAll().FirstOrDefault(u => u.ID == reportRow.KullaniciId);
                if (user != null)
                {
                    row["KullaniciId"] = $"{user.Ad} {user.Soyad}";
                }

                row["Yemek"] = reportRow.Yemek;
                row["ToplamKalori"] = reportRow.ToplamKalori.ToString("0,#");
                row["ToplamYağ"] = reportRow.ToplamYağ.ToString("0");
                row["ToplamProtein"] = reportRow.ToplamProtein.ToString("0");
                row["ToplamKarbonhidrat"] = reportRow.ToplamKarbonhidrat.ToString("0");

                dt.Rows.Add(row);
            }

            dataGridView1.DataSource = dt;
        }



        private void btnGeri_Click(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa = new AnaSayfa();
            anaSayfa.Show();
            this.Hide();

        }

        private void yemekKategorisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FoodCategoryReport("Haftalık");
        }

        private void yemekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MealReport("Haftalık");
        }

        private void yemekKategorisiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FoodCategoryReport("Aylık");
        }

        private void yemekToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MealReport("Aylık");
        }
    }


}
