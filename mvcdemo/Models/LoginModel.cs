using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace mvcdemo.Models
{
    public class LoginModel
    {
        [Required]
        public String Username{get;set;}
        public String Password { get; set; }
    }
}