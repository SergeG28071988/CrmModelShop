using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmBL.Models
{
    public class CrmContext : DbContext
    {
        public CrmContext() : base("DBConnection") { }
        public DbSet<Check> Checks { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Seller> Sellers { get; set; }       
        
    }
}
