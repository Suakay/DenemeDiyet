
using Diyet_Deneme_DaLL.Entities;
using DiyetDenemeDATA.TemelOgeler.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DiyetDenemeDATA.TemelOgeler.Base
{
    public class Kullanici 
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }
        public double Boy { get; set; }
        public double Kilo { get; set; }
        public string EMail { get; set; }
        public string Password { get; set; }
        public Cinsiyet Cinsiyet { get; set; }
      

    }
}
