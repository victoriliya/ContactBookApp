using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactBookApplication.Entities
{
    public class Admin : IdentityUser
    {
        public string Firstname { get; set; }
        public string SecondName { get; set; }
    }
}
