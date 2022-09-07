using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class JobsService : IJobsService
    {
        IJobsDal _jobsDal;

        public JobsService(IJobsDal jobsDal)
        {
            _jobsDal = jobsDal;
        }

        public void Delete(Job t)
        {
            _jobsDal.Remove(t);
        }

        public Job GetID(int id)
        {
            return _jobsDal.GetById(id);
        }

        public IEnumerable<Job> GetJobFilter(int id)
        {
            return _jobsDal.GetListFilter(x=>x.CategoryID==id);
        }

        public IEnumerable<Job> GetJobID(int id)
        {
            return _jobsDal.GetListFilter(x => x.ID == id);
        }

        public IEnumerable<Job> GetJobSearch(string s)
        {
            return _jobsDal.GetListFilter(x=>x.Title.Contains(s));
        }

        public IEnumerable<Job> GetList()
        {
            return _jobsDal.GetAll();
        }

        public void Insert(Job t)
        {
            _jobsDal.Add(t);
        }

        public void Update(Job t)
        {
            _jobsDal.Update(t);
        }
    }
}
