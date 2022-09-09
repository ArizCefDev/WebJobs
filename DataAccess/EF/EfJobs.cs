using DataAccess.Abstract;
using DataAccess.Context;
using DataAccess.Entity;
using DataAccess.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EF
{
    public class EfJobs : IGenericRepository<Job>, IJobsDal
    {
        public IEnumerable<Job> GetListWithCategory()
        {
            using(var c=new AppDBContext())
            {
                return c.Jobs.Include(x => x.Category).ToList();
            }
        }
    }
}
