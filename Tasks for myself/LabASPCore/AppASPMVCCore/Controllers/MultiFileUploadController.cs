using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AppASPMVCCore.DAL;
using AppASPMVCCore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AppASPMVCCore.Controllers
{
    public class MultiFileUploadController : Controller
    {
        private readonly AppDbContext _db;
        public MultiFileUploadController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index(List<IFormFile> files)
        {
            //var filePath = Path.Combine(Guid.NewGuid().ToString(),Path.GetExtension(fi));

            //foreach (var formFile in files)
            //{
            //    if (formFile.Length > 0)
            //    {
            //        using (var stream = new FileStream(filePath, FileMode.Create))
            //        {
            //            formFile.CopyToAsync(stream);
            //        }
            //    }
            //}
            var servicesph = _db.ServicePhotos.FirstOrDefault();

            return View(servicesph);
        }
    }
}