
using Diyet_Deneme_DaLL.Entities;
using DiyetDenemeDATA.TemelOgeler.Base;
using DiyetDenemeDATA.TemelOgeler.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetDenemeDATA.TemelOgeler.Base
{
    public class Yemek 
    {
        public int ID { get; set; }
        public Ogunler YemekAdı { get; set; }       
    }
}
