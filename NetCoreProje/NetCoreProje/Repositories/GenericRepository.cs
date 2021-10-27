using Dapper;
using NetCoreProje.Contexts;
using NetCoreProje.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreProje.Repositories
{
    public class GenericRepository<Tablo>where Tablo : class , new() 
    {
        public void Ekle(Tablo tablo)
        {
            using var context = new NetCoreProjeContexts();
            context.Set<Tablo>().Add(tablo);
            context.SaveChanges();
        }
        public void Guncelle(Tablo tablo)
        {
            using var context = new NetCoreProjeContexts();
            context.Set<Tablo>().Update(tablo);
            context.SaveChanges();
        }
        public void Sil(Tablo tablo)
        {
            using var context = new NetCoreProjeContexts();
            context.Set<Tablo>().Remove(tablo);
            context.SaveChanges();
        }

        public List<Tablo> GetirHepsi()
        {
            using var context = new NetCoreProjeContexts();
            return context.Set<Tablo>().ToList();

            //.OrderByDescending(I => I.Id)
            //Son eklenen en başta şeklinde sıraladı.
        }

        public Tablo GetirIdile(int id)
        {
            using var context = new NetCoreProjeContexts();
            return context.Set<Tablo>().Find(id);
        }
    }
}
