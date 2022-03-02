using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CushkaMVS1.Data
{
    public class CushkaContext : DbContext
    {
        public CushkaContext()
        {

        }
        public CushkaContext(DbContextOptions<CushkaContext> op) : base(op)
        {

        }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
    }
}
