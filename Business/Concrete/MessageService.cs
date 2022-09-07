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
    public class MessageService : IMessageService
    {
        IMessageDal _messageDal;

        public MessageService(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public void Delete(Message t)
        {
            _messageDal.Remove(t);
        }

        public Message GetID(int id)
        {
            return _messageDal.GetById(id);
        }

        public IEnumerable<Message> GetList()
        {
            return _messageDal.GetAll();
        }

        public void Insert(Message t)
        {
            _messageDal.Add(t);
        }

        public void Update(Message t)
        {
            _messageDal.Update(t);
        }
    }
}
