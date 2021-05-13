using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFAdapter
{
    public class EFAdapterDbContext : DbContext
    {
        public EFAdapterDbContext() : base("Server=192.168.70.237;Database=Test;User ID = ztkm;Password = admin_2019;Trusted_Connection=false;MultipleActiveResultSets=true")
        {

        }
        public DbSet<Models.Product> Products { get; set; }
    }
}
