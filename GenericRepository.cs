using mvc_poduct.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace mvc_poduct.Generic_Repos
{
    public interface IGeneric_repository<T>
    {

        List<T> GetAll();
        void AddEntity(T Entity);
        T GetEntityById(int id);
        void UpdateEntity(T Entity);
        void DeleteEntity(int id);

    }
    public class GenericRepository<T> : IGeneric_repository<T> where T : class
    {
        private readonly CatgoryDbContext dbContext;
        private readonly DbSet<T> dbset;
        public GenericRepository()
        {
            dbContext = new CatgoryDbContext();
            dbset = dbContext.Set<T>();

        }
        public void AddEntity(T Entity)
        {
            dbset.Add(Entity);
            dbContext.SaveChanges();
        }

        public void DeleteEntity(int id)
        {
            var searched_entity = dbset.Find(id);
            dbset.Remove(searched_entity);
            dbContext.SaveChanges();
        }

        public List<T> GetAll()
        {
            return dbset.ToList();
        }

        public T GetEntityById(int id)
        {
            return dbset.Find(id);
        }

        public void UpdateEntity(T Entity)
        {
            dbset.Attach(Entity);
          dbContext.Entry<T>(Entity).State=  EntityState.Modified;
            dbContext.SaveChanges();
        }
    }
}
