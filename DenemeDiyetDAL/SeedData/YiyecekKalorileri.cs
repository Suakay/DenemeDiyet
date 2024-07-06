using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


using Microsoft.EntityFrameworkCore;
using Diyet_Deneme_DaLL.Entities;
using DiyetDenemeDATA.TemelOgeler.Base;

namespace Diyet_Deneme_DaLL.Seed
{
    public class YiyecekKalorileri
    {
        public void YiyecekEkle(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Yiyecek>().HasData(
                new Yiyecek { ID = 1, Adı = " Peynirli Omlet",  Olcu= 1, Kalori = 254, Karbonhidrat = 2.05, Yağ = 14.9, Protein = 15.37},
                new Yiyecek { ID = 2, Adı = "Mantarlı Omlet", Olcu = 1, Kalori = 205, Karbonhidrat = 3.69, Yağ = 9.9, Protein = 12.46},
                new Yiyecek { ID = 3, Adı = "Menemen ", Olcu = 1, Kalori = 205, Karbonhidrat = 3.69, Yağ = 9.9, Protein = 12.46},
                new Yiyecek { ID = 4, Adı = " Kaşarlı Omlet", Olcu = 1, Kalori = 260.3, Karbonhidrat = 2.2, Yağ = 13.29, Protein = 20.27},
                new Yiyecek { ID = 5, Adı = "Sebzeli Omlet", Olcu = 1, Kalori = 205, Karbonhidrat = 3.69, Yağ = 9.9, Protein = 12.46},
                new Yiyecek { ID = 6, Adı = "Yulaflı Omlet", Olcu = 1, Kalori = 258, Karbonhidrat = 14.4, Yağ = 10.8, Protein = 14.52},
                new Yiyecek { ID = 7, Adı = "Sandviç ekmeği(beyaz)", Olcu = 1, Kalori = 264, Karbonhidrat = 48.6, Yağ = 3.2, Protein = 8.9},
                new Yiyecek { ID = 8, Adı = "Sandviç ekmeği(cok tahıllı)", Olcu = 1, Kalori = 312, Karbonhidrat = 57.6, Yağ = 2.4, Protein = 9.6},
                new Yiyecek { ID = 9, Adı = "Musli", Olcu = 1, Kalori = 340, Karbonhidrat = 62, Yağ = 6, Protein = 10},
                new Yiyecek { ID = 10, Adı = "Mısır gevregi", Olcu = 1, Kalori = 356, Karbonhidrat = 84, Yağ = 0.4, Protein = 7.4},
                new Yiyecek { ID = 11, Adı = "Beyaz peynir", Olcu = 1, Kalori = 162, Karbonhidrat = 0, Yağ = 14, Protein = 14.1},
                new Yiyecek { ID = 12, Adı = "Labne peyniri", Olcu = 1, Kalori = 213.5, Karbonhidrat = 3.5, Yağ = 19.3, Protein = 6.7},
                new Yiyecek { ID = 13, Adı = "Hellim peyniri", Olcu = 1, Kalori = 320, Karbonhidrat = 2.8, Yağ = 25, Protein = 21},
                new Yiyecek { ID = 14, Adı = "Kefir", Olcu = 1, Kalori = 63, Karbonhidrat = 5.2, Yağ = 3.2, Protein = 3.3},
                new Yiyecek { ID = 15, Adı = "Meyveli kefir", Olcu = 1, Kalori = 78, Karbonhidrat = 10, Yağ = 3, Protein = 2.7},
                new Yiyecek { ID = 16, Adı = "Suzme Yogurt", Olcu = 1, Kalori = 106, Karbonhidrat = 5, Yağ = 6, Protein = 8},
                new Yiyecek { ID = 17, Adı = "Yogurt", Olcu = 1, Kalori = 61, Karbonhidrat = 4.6, Yağ = 3.25, Protein = 3.42},
                new Yiyecek { ID = 18, Adı = "Meyveli Yogurt", Olcu = 1, Kalori = 93, Karbonhidrat = 15, Yağ = 2.1, Protein = 3.1},
                new Yiyecek { ID = 19, Adı = "Ayran", Olcu = 1, Kalori = 32, Karbonhidrat = 2, Yağ = 1.8, Protein = 2},
                new Yiyecek { ID = 20, Adı = "Cacik", Olcu = 1, Kalori = 41, Karbonhidrat = 3.9, Yağ = 0, Protein = 3},
                new Yiyecek { ID = 21, Adı = "Grissini", Olcu = 1, Kalori = 396, Karbonhidrat = 74.94, Yağ = 4.79, Protein = 10.21},
                new Yiyecek { ID = 22, Adı = "Elma", Olcu = 1, Kalori = 57, Karbonhidrat = 15, Yağ = 0.2, Protein = 0.3 },
                new Yiyecek { ID = 23, Adı = "Armut", Olcu = 1, Kalori = 60, Karbonhidrat = 16.2, Yağ = 0.2, Protein = 0.4},
                new Yiyecek { ID = 24, Adı = "Portakal", Olcu = 1, Kalori = 48.3, Karbonhidrat = 12.6, Yağ = 0.1, Protein = 1.23},
                new Yiyecek { ID = 25, Adı = "Greyfurt", Olcu = 1, Kalori = 41.6, Karbonhidrat = 10.4, Yağ = 0.1, Protein = 0.8},
                new Yiyecek { ID = 26, Adı = "Mandalina", Olcu = 1, Kalori = 49, Karbonhidrat = 12.5, Yağ = 0.2, Protein = 0.9},
                new Yiyecek { ID = 27, Adı = "Kivi", Olcu = 1, Kalori = 63, Karbonhidrat = 15, Yağ = 0.5, Protein = 1.2},
                new Yiyecek { ID = 28, Adı = "Muz", Olcu = 1, Kalori = 105, Karbonhidrat = 26.95, Yağ = 0.39, Protein = 1.29},
                new Yiyecek { ID = 29, Adı = "Avokado", Olcu = 1, Kalori = 160, Karbonhidrat = 8.53, Yağ = 14.66, Protein = 2},
                new Yiyecek { ID = 30, Adı = "Yesil Salata", Olcu = 1, Kalori = 24, Karbonhidrat = 5, Yağ = 0.2, Protein = 1.4},
                new Yiyecek { ID = 31, Adı = "Tavuk Salatası", Olcu = 1, Kalori = 65, Karbonhidrat = 3.23, Yağ = 1.65, Protein = 9.73},
                new Yiyecek { ID = 32, Adı = "Mercimek Corbasi", Olcu = 1, Kalori = 69, Karbonhidrat = 10, Yağ = 1.4, Protein = 4.7},
                new Yiyecek { ID = 33, Adı = "Tavuk Corbasi", Olcu = 1, Kalori = 31, Karbonhidrat = 3.88, Yağ = 1.02, Protein = 1.68},
                new Yiyecek { ID = 34, Adı = "Tarhana Corbasi", Olcu = 1, Kalori = 82, Karbonhidrat = 14.77, Yağ = 1.4, Protein = 2.45},
                new Yiyecek { ID = 35, Adı = "Sebze Corbasi", Olcu = 1, Kalori = 43, Karbonhidrat = 6.26, Yağ = 1.9, Protein = 0.5},
                new Yiyecek { ID = 36, Adı = "Zeytinyaglı Taze Fasulye", Olcu = 1, Kalori = 81, Karbonhidrat = 14.46, Yağ = 0.4, Protein = 5.42},
                new Yiyecek { ID = 37, Adı = "Zeytinyagli Pirasa Yemegi", Olcu = 1, Kalori = 102, Karbonhidrat = 9.81, Yağ = 6.4, Protein = 2.12},
                new Yiyecek { ID = 38, Adı = "Havuclu Bezelye", Olcu = 1, Kalori = 147, Karbonhidrat = 11.07, Yağ = 10.38, Protein = 3.48},
                new Yiyecek { ID = 39, Adı = "Zeytinyagli Brokoli", Olcu = 1, Kalori = 52, Karbonhidrat = 6.67, Yağ = 2.48, Protein = 2.22},
                new Yiyecek { ID = 40, Adı = "Zeytinyagli Sebzeli Turlu", Olcu = 1, Kalori = 112, Karbonhidrat = 8.68, Yağ = 8.87, Protein = 1.33},
                new Yiyecek { ID = 41, Adı = "Patlican Musakka", Olcu = 1, Kalori = 117, Karbonhidrat = 7.12, Yağ = 7.62, Protein = 4.82},
                new Yiyecek { ID = 42, Adı = "Nohut Yemegi", Olcu = 1, Kalori = 169, Karbonhidrat = 15.63, Yağ = 10.79, Protein = 3.22},
                new Yiyecek { ID = 43, Adı = "Bulgur pilavi", Olcu = 1, Kalori = 130, Karbonhidrat = 22.39, Yağ = 2.62, Protein = 3.67},
                new Yiyecek { ID = 44, Adı = "Pirinc pilavi", Olcu = 1, Kalori = 125, Karbonhidrat = 21.57, Yağ = 3.24, Protein = 2.07},
                new Yiyecek { ID = 45, Adı = "Makarna", Olcu = 1, Kalori = 124, Karbonhidrat = 25.12, Yağ = 0.98, Protein = 4.37},
                new Yiyecek { ID = 46, Adı = "Ekler", Olcu = 1, Kalori = 174, Karbonhidrat = 10.94, Yağ = 12.43, Protein = 4.3},
                new Yiyecek { ID = 47, Adı = "Baklava", Olcu = 1, Kalori = 428, Karbonhidrat = 37.62, Yağ = 29.03, Protein = 6.07},
                new Yiyecek { ID = 48, Adı = "MilkShake", Olcu = 1, Kalori = 135, Karbonhidrat = 20.11, Yağ = 4.89 },
                new Yiyecek { ID = 49, Adı = "Cay", Olcu = 1, Kalori = 1, Karbonhidrat = 0.3, Yağ = 0, Protein = 0 },
                new Yiyecek { ID = 50, Adı = "Kola", Olcu = 1, Kalori = 42, Karbonhidrat = 10.6, Yağ = 0, Protein = 0 }


                );

        }
    }
}



