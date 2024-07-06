using DietBuddyApp.BLL.Concrete;
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
    public partial class GünSonuRaporu : Form
    {
        private object entriesForDate;
        private object lblLProtein;

        public GünSonuRaporu()
        {
            InitializeComponent();

            //DateTime olarak açıldığın  zaman günlük olarak verisini seçilmiş olarak getir.
            DateTime today = DateTime.Today;
            dateTimePicker1.Value = today;
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime secilenZaman = dateTimePicker1.Value.Date;
            YemekTarihiRepository yemekTarihiRepository = new YemekTarihiRepository();
            List<YemekTarihi> yemekTarihi = yemekTarihiRepository.GetAll()
                .Where(a => DateTime.Parse(a.Tarih) == secilenZaman && a.UserID == KullaniciYonetimi.CurrentUser.ID)
                .ToList();


            //Tarih seçince toplam kalORİ hesaplasın.
            double ToplamKalori = yemekTarihi.Sum(a => Convert.ToDouble(a.ToplamKalori));
            lblToplamKalori.Text = ToplamKalori.ToString();
            //Toplam Karbonhidrat
            double ToplamKarbonhidrat = yemekTarihi.Sum(a => Convert.ToDouble(a.ToplamKarbonhidrat));
            lblTKarbonhidrat.Text = ToplamKarbonhidrat.ToString();

            //Toplam Protein
            double ToplamProtein = yemekTarihi.Sum(a => Convert.ToDouble(a.ToplamProtein));
            lblTProtein.Text = ToplamProtein.ToString();

            //Toplam Yağ
            double ToplamYağ = yemekTarihi.Sum(a => Convert.ToDouble(a.ToplamYag));
            lblTYağ.Text = ToplamYağ.ToString();




            //Kahvaltı Karbonhidrat
            double kKarbonhidrat = yemekTarihi.Where(a => a.Yemek == "Kahvaltı").Sum(a => Convert.ToDouble(a.ToplamKarbonhidrat));
            lblKKarbonhidrat.Text = kKarbonhidrat.ToString();
            //Kahvaltının protein
            double kProtein = yemekTarihi.Where(a => a.Yemek == "Kahvaltı").Sum(a => Convert.ToDouble(a.ToplamProtein));
            lblKProtein.Text = kProtein.ToString();

            //Kahvaltın yağ
            double kYağ = yemekTarihi.Where(a => a.Yemek == "Kahvaltı").Sum(a => Convert.ToDouble(a.ToplamYag));
            lblKProtein.Text = kYağ.ToString();
            //Kahvaltı kalori
            double kKalori = yemekTarihi.Where(a => a.Yemek == "Kahvaltı").Sum(a => Convert.ToDouble(a.ToplamKalori));
            lblAKalori.Text = kKalori.ToString();



            //Öğlen Karbonhidrat
            double oKarbonhidrat = yemekTarihi.Where(a => a.Yemek == "OglenYemegi").Sum(a => Convert.ToDouble(a.ToplamKarbonhidrat));
            lblOKarbonhidrat.Text = oKarbonhidrat.ToString();
            //Öğlen protein
            double oProtein = yemekTarihi.Where(a => a.Yemek == "OglenYemegi").Sum(a => Convert.ToDouble(a.ToplamProtein));
            lblOProtein.Text = kProtein.ToString();

            //Öğlen yağ
            double oYag = yemekTarihi.Where(a => a.Yemek == "OglenYemegi").Sum(a => Convert.ToDouble(a.ToplamYag));
            lblOYağ.Text = kYağ.ToString();
            //Öğlen kalori
            double oKalori = yemekTarihi.Where(a => a.Yemek == "OglenYemegi").Sum(a => Convert.ToDouble(a.ToplamKalori));
            lblToplamKalori.Text = oKalori.ToString();



            //Akşam Karbonhidrat
            double aKarbonhidrat = yemekTarihi.Where(a => a.Yemek == "AksamYemegi").Sum(a => Convert.ToDouble(a.ToplamKarbonhidrat));
            lblAKarbonhidrat.Text = aKarbonhidrat.ToString();
            //Akşam protein
            double aProtein = yemekTarihi.Where(a => a.Yemek == "AksamYemegi").Sum(a => Convert.ToDouble(a.ToplamProtein));
            lblAProtein.Text = aProtein.ToString();

            //Akşam yağ
            double aYag = yemekTarihi.Where(a => a.Yemek == "AksamYemegi").Sum(a => Convert.ToDouble(a.ToplamYag));
            lblAYağ.Text = aYag.ToString();
            //Akşam  kalori
            double aKalori = yemekTarihi.Where(a => a.Yemek == "AksamYemegi").Sum(a => Convert.ToDouble(a.ToplamKalori));
            lblAKalori.Text = aKalori.ToString();
        }



        private void btnGeri_Click(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa = new AnaSayfa();
            anaSayfa.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
    

