using DataAccess.Abstract;
using DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class IGenericRepository<T> : IBaseDal<T> where T : class
    {
        
        public void Add(T t)
        {
            using var c = new AppDBContext();
            c.Add(t);
            c.SaveChanges();
        }
        public IEnumerable<T> GetAll()
        {
            using var c = new AppDBContext();
            return c.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            using var c = new AppDBContext();
            return c.Set<T>().Find(id);
        }

        public IEnumerable<T> GetListFilter(Expression<Func<T, bool>> filter)
        {
            using var c = new AppDBContext();
            return c.Set<T>().Where(filter).ToList();
        }

        public void Remove(T t)
        {
            using var c = new AppDBContext();
            c.Remove(t);
            c.SaveChanges();
        }

        public void Update(T t)
        {
            using var c = new AppDBContext();
            c.Update(t);
            c.SaveChanges();
        }
    }
}
