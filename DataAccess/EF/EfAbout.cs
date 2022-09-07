using DataAccess.Abstract;
using DataAccess.Entity;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EF
{
    public class EfAbout : IGenericRepository<About>, IAboutDal
    {
    }
}
