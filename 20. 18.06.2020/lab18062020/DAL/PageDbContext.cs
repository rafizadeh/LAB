using lab18062020.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab18062020.DAL
{
    public class PageDbContext : DbContext
    {
        public PageDbContext(DbContextOptions<PageDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }

    }
}
