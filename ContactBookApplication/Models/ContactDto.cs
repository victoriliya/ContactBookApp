using ContactBookApplication.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContactBookApplication.Models
{
    public class ContactDto
    {
        public Guid ContactId { get; set; }
        public string Name { get; set; }
        public string NickName { get; set; }
        public string PhotoUrl { get; set; }
        public string Website { get; set; }      
        public string Company { get; set; }
        public string CompanyEmail { get; set; }
        public DateTime DateOfCreation { get; set; } 
        public ICollection<string> Addresses { get; set; } 
        public ICollection<string> PhoneNumbers { get; set; } 
        public ICollection<string> Emails { get; set; } 
    }
}
