using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactBookApplication.Models
{
    public class PhotoToAddDto
    {
        public IFormFile PhotoFile { get; set; }
        public string PhotoUrl { get; set; }
        public Guid ContactId { get; set; }
    }
}
