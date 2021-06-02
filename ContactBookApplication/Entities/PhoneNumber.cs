using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContactBookApplication.Entities
{
    public class PhoneNumber
    {
        [Key]
        public int PhoneNumberId { get; set; }
        public string CountryCode { get; set; }
        public string Number { get; set; }
        public Guid ContactId { get; set; }
    }
}
