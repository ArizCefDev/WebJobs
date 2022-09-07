using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTOEntity
{
    public class JobDTO
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Company { get; set; }
        public string Address { get; set; }
        public DateTime Date { get; set; }
        public DateTime LastDate { get; set; }
        public string Salary { get; set; }
        public string Mail { get; set; }
        public string Responsibility { get; set; }
        public string VacancyRequirement { get; set; }
        public string AddInformation { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public bool Status { get; set; }
    }
}
