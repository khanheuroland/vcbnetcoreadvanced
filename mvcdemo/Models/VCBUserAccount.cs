using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvcdemo.Models
{
    public class VCBUserAccount
    {
        public int Id { get; set; }
        public String UserName { get; set; } 
        public String Password {get;set;}
        public Boolean IsActive {get;set;}
    }
}