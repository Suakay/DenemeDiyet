using DenemeDiyetDAL;
using DenemeDiyetDAL.Repository;
using Diyet_Deneme_DaLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietBuddyApp.BLL.Concrete
{
    public class YemekTarihiRepository : IRepository<YemekTarihi> // Bura düzenlenecek
    {
        AppDbContext context = new AppDbContext();
        public void Add(YemekTarihi item)
        {
            context.YemekTarihis.Add(item);
            context.SaveChanges();
        }

        public void Delete(YemekTarihi item)
        {
            context.YemekTarihis.Remove(item);
            context.SaveChanges();
        }

        public List<YemekTarihi> GetAll()
        {
            return context.YemekTarihis.ToList();
        }

        public YemekTarihi GetBuId(int id)
        {
            return context.YemekTarihis.Find(id);
        }

        public YemekTarihi GetID(int id)
        {
            return context.YemekTarihis.Find(id);
        }

        public void Update(YemekTarihi item)
        {
            context.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }

    }
}
