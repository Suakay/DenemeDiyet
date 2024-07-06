using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiyetDenemeDATA.TemelOgeler.Base;

namespace Diyet_Deneme_DaLL.Entities
{
    public class YemekTarihi 
    {
        public int ID { get; set; }
        public int UserID {  get; set; }    
        public string Tarih {  get; set; }  
        public string Yemek {  get; set; }  
        public  string ToplamKalori {  get; set; } 
        public string YemekKategorileri {  get; set; }  
        public string Yiyecek {  get; set; }

        public string  Olcu {  get; set; }
        public string ToplamYag {  get; set; }    
        public string ToplamProtein {  get; set; }    
        public string ToplamKarbonhidrat {  get; set; }   

        


    }
}
