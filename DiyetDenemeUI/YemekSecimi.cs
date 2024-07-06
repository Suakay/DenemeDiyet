using DenemeDiyetDAL;
using Diyet_Deneme_DaLL.Entities;
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
    public partial class YemekSecimi : Form
    {
        public YemekSecimi()
        {
            InitializeComponent();
        }

        private AppDbContext dbContext = new AppDbContext();
        private List<YemekTarihi> YemekTarihiGetAll()
        {
            return dbContext.YemekTarihis.ToList();
        }

        private void btnKahvalti_Click(object sender, EventArgs e)
        {
            var mostConsumedFoods = dbContext.YemekTarihis
                .Where(x => x.UserID == KullaniciYonetimi.CurrentUser.ID && x.Yemek == "Kahvaltı")
                .GroupBy(x => x.Yiyecek)
                .Select(group => new
                {
                    FoodName = group.Key,
                    TotalConsumed = group.Sum(x => Convert.ToDouble(x.Olcu))
                })
                .OrderByDescending(x => x.TotalConsumed)
                .ToList();

            dataGridView1.DataSource = mostConsumedFoods;

        }

        private void btnAraOgun_Click(object sender, EventArgs e)
        {
            var mostConsumedFoods = dbContext.YemekTarihis
                .Where(x => x.UserID == KullaniciYonetimi.CurrentUser.ID && x.Yemek == "AraOgun")
                .GroupBy(x => x.Yiyecek)
                .Select(group => new
                {
                    FoodName = group.Key,
                    TotalConsumed = group.Sum(x => Convert.ToDouble(x.Olcu))
                })
                .OrderByDescending(x => x.TotalConsumed)
                .ToList();

            dataGridView1.DataSource = mostConsumedFoods;
        }

        private void btnAksamYemegi_Click(object sender, EventArgs e)
        {
            var mostConsumedFoods = dbContext.YemekTarihis
                .Where(x => x.UserID == KullaniciYonetimi.CurrentUser.ID && x.Yemek == "AksamYemegi")
                .GroupBy(x => x.Yiyecek)
                .Select(group => new
                {
                    FoodName = group.Key,
                    TotalConsumed = group.Sum(x => Convert.ToDouble(x.Olcu))
                })
                .OrderByDescending(x => x.TotalConsumed)
                .ToList();

            dataGridView1.DataSource = mostConsumedFoods;

        }

        private void btnOgleYemegi_Click(object sender, EventArgs e)
        {
            var mostConsumedFoods = dbContext.YemekTarihis
                .Where(x => x.UserID == KullaniciYonetimi.CurrentUser.ID && x.Yemek == "OgleYemegi")
                .GroupBy(x => x.Yiyecek)
                .Select(group => new
                {
                    FoodName = group.Key,
                    TotalConsumed = group.Sum(x => Convert.ToDouble(x.Olcu))
                })
                .OrderByDescending(x => x.TotalConsumed)
                .ToList();

            dataGridView1.DataSource = mostConsumedFoods;
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            AnaSayfa homePages = new AnaSayfa();
            homePages.Show();
            this.Close();
        }
    }
}
