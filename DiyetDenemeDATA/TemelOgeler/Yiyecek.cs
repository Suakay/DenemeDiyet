using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiyetDenemeDATA.TemelOgeler;
using DiyetDenemeDATA.TemelOgeler.Base;

namespace Diyet_Deneme_DaLL.Entities
{
    public  class Yiyecek
    {
        public int  ID { get; set; }
        public string Adı {  get; set; }    
        public double Olcu {  get; set; } 
        public  double Kalori {  get; set; }    
        public double Karbonhidrat {  get; set; }
        public double Yağ { get; set; }
        public double Protein {  get; set; }    
        //public  string Resim {  get; set; }
        public virtual ICollection<YiyecekYemekKategori> YiyecekYemekKategoris { get; set; } = new List<YiyecekYemekKategori>();

    }
}
