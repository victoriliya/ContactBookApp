using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContactBookApplication.Entities
{
    public class User : IdentityUser
    {
        [StringLength(35)]
        public string FirstName { get; set; }

        [StringLength(35)]
        public string SecondName { get; set; }

    }
}
