using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WishList.Data
{
    public class ApplicationDbContext
    {
        public class ApplicationDbContext : DbContext
        {
            public ApplicationDbContext(DbContextOptions options) : base(options)
            {
            }

            public DbSet<Models.Item> Items { get; set; }
        }
    }
}

