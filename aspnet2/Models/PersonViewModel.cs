using aspnet2.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspnet2.Models
{
    public class PersonViewModel
    {
        public Person Person { get; set; }
        public IFormFile File { get; set; }
        public bool HasSaved { get; set; }
    }
}
