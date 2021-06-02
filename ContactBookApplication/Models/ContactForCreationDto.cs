using ContactBookApplication.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContactBookApplication.Models
{
    public class ContactForCreationDto
    {

        public string Salutation { get; set; }
        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string OtherName { get; set; }
        public string NickName { get; set; }
        public string PhotoUrl { get; set; }
        public string Website { get; set; }
        public string Company { get; set; }
        public string CompanyEmail { get; set; }
        public DateTime DateOfCreation { get; set; } = DateTime.UtcNow;
        public ICollection<Address> Addresses { get; set; } = new List<Address>();
        public ICollection<PhoneNumber> PhoneNumbers { get; set; } = new List<PhoneNumber>();
        public ICollection<EmailAddress> Emails { get; set; } = new List<EmailAddress>();
    }
}
