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
    public class ContactService : IContactService
    {
        IContactDal _contactDal;

        public ContactService(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void Delete(Contact t)
        {
            _contactDal.Remove(t);
        }

        public Contact GetID(int id)
        {
           return _contactDal.GetById(id);
        }

        public IEnumerable<Contact> GetList()
        {
            return _contactDal.GetAll();
        }

        public void Insert(Contact t)
        {
            _contactDal.Add(t);
        }

        public void Update(Contact t)
        {
            _contactDal.Update(t);
        }
    }
}
