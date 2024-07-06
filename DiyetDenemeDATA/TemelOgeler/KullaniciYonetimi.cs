using DiyetDenemeDATA.TemelOgeler;
using DiyetDenemeDATA.TemelOgeler.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diyet_Deneme_DaLL.Entities
{
    public  class KullaniciYonetimi
    {
   
        private static Kullanici _currentUser;
        public static Kullanici CurrentUser
        {
            get { return _currentUser; }
            set { _currentUser=value; } 

        }
    }
}
