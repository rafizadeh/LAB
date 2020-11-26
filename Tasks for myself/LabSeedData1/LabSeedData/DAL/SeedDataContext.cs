using LabSeedData.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabSeedData.DAL
{
    public class SeedDataContext:DbContext
    {
        public SeedDataContext(DbContextOptions<SeedDataContext> options) : base(options) { }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<AppDetail> AppDetails { get; set; }
    }
}
