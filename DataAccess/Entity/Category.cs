using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public IEnumerable<Job> Jobs { get; set; }
        public bool Status { get; set; }
    }
}
