using DenemeDiyetDAL;
using DenemeDiyetDAL.Repository;
using DiyetDenemeDATA.TemelOgeler;
using DiyetDenemeDATA.TemelOgeler.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietBuddyApp.BLL.Concrete
{
    public class YemekRepository : IRepository<Yemek> // Bura düzenlenecek
    {
        AppDbContext context = new AppDbContext();
        public void Add(Yemek item)
        {
            context.Yemeks.Add(item);
            context.SaveChanges();
        }

        public void Delete(Yemek item)
        {
            context.Yemeks.Remove(item);
            context.SaveChanges();
        }

        public List<Yemek> GetAll()
        {
            return context.Yemeks.ToList();
        }

        public Yemek GetBuId(int id)
        {
            return context.Yemeks.Find(id);
        }

        public Yemek GetID(int id)
        {
            return context.Yemeks.Find(id);
        }

        public void Update(Yemek item)
        {
            context.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }
    }
}
