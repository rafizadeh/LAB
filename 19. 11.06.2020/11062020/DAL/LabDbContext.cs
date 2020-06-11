using _11062020.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _11062020.DAL
{
    public class LabDbContext:DbContext
    {
        public LabDbContext(DbContextOptions<LabDbContext> options) : base(options) { }

        public DbSet<Service> Services { get; set; }

        public DbSet<ServicePhoto> ServicePhotos { get; set; }
    }
}
