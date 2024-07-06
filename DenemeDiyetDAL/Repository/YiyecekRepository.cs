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
    public class YiyecekRepository : IRepository<Yiyecek> // bura düzenlenecek
    {
        AppDbContext context = new AppDbContext();
        public void Add(Yiyecek item)
        {
            context.Yiyeceks.Add(item);
            context.SaveChanges();
        }

        public void Delete(Yiyecek item)
        {
            context.Yiyeceks.Remove(item);
            context.SaveChanges();
        }

        public List<Yiyecek> GetAll()
        {
            return context.Yiyeceks.ToList();
        }

        public Yiyecek GetBuId(int id)
        {
            return context.Yiyeceks.Find(id);
        }

        public void Update(Yiyecek item)
        {
            context.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }

        // Resim için yapıldı
        //public string GetFoodImage(int YiyecekID)
        //{
        //    // Yemek Id'sine göre veritabanından resim dosya yolunu al
        //    var food = context.Yiyeceks.Find(YiyecekID);
        //    return food?.Resim;
        //}

        public Yiyecek GetID(int id)
        {
            return context.Yiyeceks.Find(id);
        }
    }
}
