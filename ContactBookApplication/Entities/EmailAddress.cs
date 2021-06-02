﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContactBookApplication.Entities
{
    public class EmailAddress
    {
        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
        public Guid ContactId { get; set; }
    }
}
