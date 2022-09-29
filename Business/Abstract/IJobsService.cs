using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IJobsService : IBaseService<Job>
    {
        IEnumerable<Job> GetJobID(int id);
        IEnumerable<Job> GetJobFilter(int id);
        IEnumerable<Job> GetJobSearch(string s);
        IEnumerable<Job> GetJobWithCategory();
        void ChangeStatusTrue(int id);
        void ChangeStatusFalse(int id);
    }
}
