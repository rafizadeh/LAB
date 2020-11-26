using lab05082020.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab05082020.DAL
{
    public class LastLabContext:DbContext
    {
        public LastLabContext(DbContextOptions<LastLabContext> options):base(options) { }

        public DbSet<Blog> Blogs { get; set; }
    }
}
