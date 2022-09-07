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
    public class AboutService : IAboutService
    {
        IAboutDal _aboutDal;

        public AboutService(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void Delete(About t)
        {
            _aboutDal.Remove(t);
        }

        public About GetID(int id)
        {
            return _aboutDal.GetById(id);
        }

        public IEnumerable<About> GetList()
        {
            return _aboutDal.GetAll();
        }

        public void Insert(About t)
        {
            _aboutDal.Add(t);
        }

        public void Update(About t)
        {
            _aboutDal.Update(t);
        }
    }
}
