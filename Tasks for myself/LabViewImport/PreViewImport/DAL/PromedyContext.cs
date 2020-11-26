using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using PreViewImport.Models;

namespace PreViewImport.DAL
{
    public class PromedyContext : DbContext
    {
        public PromedyContext() : base("PromedyContext")
        {
            
        }

        public DbSet<Doctor> Doctors { get; set; }

        public DbSet<Department> Departments { get; set; }

        public DbSet<Setting> Settings { get; set; }
    }
}