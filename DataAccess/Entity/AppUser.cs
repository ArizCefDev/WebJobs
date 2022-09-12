using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class AppUser : IdentityUser<int>
    {
        public string ImageURL { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Work { get; set; }
        public string Phone { get; set; }
    }
}
