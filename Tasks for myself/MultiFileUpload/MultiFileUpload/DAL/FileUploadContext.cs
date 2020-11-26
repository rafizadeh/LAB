using Microsoft.EntityFrameworkCore;
using MultiFileUpload.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiFileUpload.DAL
{
    public class FileUploadContext:DbContext
    {
        public FileUploadContext(DbContextOptions<FileUploadContext> options):base(options) { }

        public DbSet<Photo> Photos { get; set; }
    }
}
