using lab30062020.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab30062020.DAL
{
    public class LabFileUploadContext:DbContext
    {
        public LabFileUploadContext(DbContextOptions<LabFileUploadContext> options):base(options) { }

        public DbSet<Photo> Photos { get; set; }
    }
}
