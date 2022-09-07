using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IBaseDal<T>
    {
        void Add(T t);
        void Update(T t);
        void Remove(T t);
        IEnumerable<T> GetAll();
        T GetById(int id);
        IEnumerable<T> GetListFilter(Expression<Func<T, bool>> filter);
    }
}
