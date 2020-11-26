using AjaxCrud.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AjaxCrud.DAL
{
    public class AjaxDbContext : DbContext
    {
        public AjaxDbContext() : base("AjaxDbContext") { }

        public DbSet<Student> Students { get; set; }

        public DbSet<Group> Groups { get; set; }
    }
}