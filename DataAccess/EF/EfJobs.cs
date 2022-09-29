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
        public void ChangeToFalseByJobs(int id)
        {
            using (var c = new AppDBContext())
            {
                var values = c.Jobs.Find(id);
                values.Status = false;
                c.Update(values);
                c.SaveChanges();
            }
        }

        public void ChangeToTrueByJobs(int id)
        {
            using (var c = new AppDBContext())
            {
                var values = c.Jobs.Find(id);
                values.Status = true;
                c.Update(values);
                c.SaveChanges();
            }
        }

        public IEnumerable<Job> GetListWithCategory()
        {
            using(var c=new AppDBContext())
            {
                return c.Jobs.Include(x => x.Category).ToList();
            }
        }
    }
}
