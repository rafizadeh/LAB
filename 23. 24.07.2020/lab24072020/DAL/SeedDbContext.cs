using lab24072020.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab24072020.DAL
{
    public class SeedDbContext:DbContext
    {
        public SeedDbContext(DbContextOptions<SeedDbContext> options) : base(options) { }

        public DbSet<AppDetail> AppDetails{ get; set; }

        public DbSet<Contact> Contacts { get; set; }
    }
}
