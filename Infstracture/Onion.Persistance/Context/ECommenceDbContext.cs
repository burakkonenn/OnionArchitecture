using Microsoft.EntityFrameworkCore;
using Onion.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Persistance.Context
{
    public class ECommenceDbContext : DbContext
    {
        public ECommenceDbContext(DbContextOptions options) : base(options)
        {
        
        }



        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
