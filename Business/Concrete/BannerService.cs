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
    public class BannerService : IBannerService
    {
        IBannerDal _bannerDal;

        public BannerService(IBannerDal bannerDal)
        {
            _bannerDal = bannerDal;
        }

        public void Delete(Banner t)
        {
            _bannerDal.Remove(t);
        }

        public Banner GetID(int id)
        {
            return _bannerDal.GetById(id);
        }

        public IEnumerable<Banner> GetList()
        {
            return _bannerDal.GetAll();
        }

        public void Insert(Banner t)
        {
            _bannerDal.Add(t);
        }

        public void Update(Banner t)
        {
            _bannerDal.Update(t);
        }
    }
}
