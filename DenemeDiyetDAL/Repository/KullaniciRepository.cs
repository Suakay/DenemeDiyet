using DiyetDenemeDATA.TemelOgeler;
using DiyetDenemeDATA.TemelOgeler.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenemeDiyetDAL.Repository
{
    public class KullanıcıRepository : IRepository<Kullanici>
    {
        AppDbContext context= new AppDbContext();
        public void Add(Kullanici item)
        {
            context.Kullanicis.Add(item);
            context.SaveChanges();
        }

        public void Delete(Kullanici item)
        {
            context.Kullanicis.Remove(item);
            context.SaveChanges();
        }

        public List<Kullanici> GetAll()
        {
            return context.Kullanicis.ToList();
        }

        public Kullanici GetID(int id)
        {
            return context.Kullanicis.Find(id);
        }

        public void Update(Kullanici item)
        {
            context.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }
        //kayıt olurken email sadece 1 kişi özelinde kayıt olmalı
        public bool MailKayitKontrol(string email)
        {
            return context.Kullanicis.Any(u => u.EMail.Equals(email));
        }

        //login için
        public Kullanici Giriş(string email, string password)
        {
            var kullaniciGirisi = context.Kullanicis.FirstOrDefault(u => u.EMail.Equals(email) && u.Password.Equals(password));

            return kullaniciGirisi;
        }
        // Veritabanından e-posta adresine göre kullanıcıyı getir
        public Kullanici GetUserByEmail(string email)
        {
            return context.Kullanicis.FirstOrDefault(u => u.EMail.Equals(email));
        }





    }
}
