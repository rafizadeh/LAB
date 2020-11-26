using LabPagination.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LabPagination.DAL
{
    public class PageDbContext:DbContext
    {
        public PageDbContext() : base("PageDbContext") { }

        public DbSet<Product> Products { get; set; }
    }
}