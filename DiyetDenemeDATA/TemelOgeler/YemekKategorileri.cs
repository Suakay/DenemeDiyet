using DiyetDenemeDATA.TemelOgeler;
using DiyetDenemeDATA.TemelOgeler.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diyet_Deneme_DaLL.Entities
{
    public class YemekKategorileri
    {
        public int ID { get; set; }



        public string YemekAdı { get; set; }

        public virtual ICollection<YiyecekYemekKategori> YiyecekYemekKategoris { get; set; } = new List<YiyecekYemekKategori>();

    }
}
