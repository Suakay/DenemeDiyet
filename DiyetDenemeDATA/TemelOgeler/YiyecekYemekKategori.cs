using Diyet_Deneme_DaLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetDenemeDATA.TemelOgeler
{
    public class YiyecekYemekKategori
    {
        public int YiyecekID{ get; set; }
        public virtual  Yiyecek Yiyecek { get; set; }

        public int YemekKategorileriID {  get; set; }   
        public virtual YemekKategorileri YemekKategorileri {  get; set; }    
    }
}
