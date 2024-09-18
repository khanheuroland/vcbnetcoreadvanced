using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using mvcdemo.Models;

namespace mvcdemo.Data
{
    public class VCBDataContext: DbContext
    {
        public VCBDataContext(DbContextOptions<VCBDataContext> options):base(options)
        {
            
        }
        public DbSet<VCBUser> vCBUsers{ get; set; } = default!;
    }
}