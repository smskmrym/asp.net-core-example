using Proje.DataAccess.Concrete.EntityFrameworkCore.Contexts;
using Proje.DataAccess.Interfaces;
using Proje.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proje.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfGenericRepository<Tablo> : IGenericDal<Tablo> where Tablo : class, ITablo, new()
    {
        public void Delete(Tablo tablo)
        {
            using var context = new ProjeContext();
            context.Set<Tablo>().Remove(tablo);
            context.SaveChanges();

        }


        public List<Tablo> GetAll()
        {
            using var context = new ProjeContext();
            return context.Set<Tablo>().ToList();
        }


        public Tablo GetWithId(int id)
        {
            using var context = new ProjeContext();
            return context.Set<Tablo>().Find(id);

        }



        public void Save(Tablo tablo)
        {
            using var context = new ProjeContext();
            context.Set<Tablo>().Add(tablo);
            context.SaveChanges();

        }


        public void Update(Tablo tablo)
        {
            using var context = new ProjeContext();
            context.Set<Tablo>().Update(tablo);
            context.SaveChanges();

        }

    }
}
