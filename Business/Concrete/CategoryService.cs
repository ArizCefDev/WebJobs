using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryService : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryService(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Delete(Category t)
        {
            _categoryDal.Remove(t);
        }

        public Category GetID(int id)
        {
            return _categoryDal.GetById(id);
        }

        public IEnumerable<Category> GetList()
        {
            return _categoryDal.GetAll();
        }

        public void Insert(Category t)
        {
            _categoryDal.Add(t);
        }

        public void Update(Category t)
        {
            _categoryDal.Update(t);
        }
    }
}
