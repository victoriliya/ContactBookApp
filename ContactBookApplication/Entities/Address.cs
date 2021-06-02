using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContactBookApplication.Entities
{
    public class Address
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [StringLength(150)]
        public string StreetName { get; set; }

        [StringLength(150)]
        public string StreetNumber { get; set; }

         [StringLength(100)]
        public string City { get; set; }

        [StringLength(100)]
        public string State { get; set; }

        [StringLength(100)]
        public string PostCode { get; set; }

        [StringLength(100)]
        public string Country { get; set; }
        public Guid ContactId { get; set; }
        public Contact Contact { get; set; }

    }
}
