using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTOEntity
{
    public class CategoryDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public IEnumerable<Job> Jobs { get; set; }
        public bool Status { get; set; }
    }
}
