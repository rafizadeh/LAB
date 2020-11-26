using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lab30062020.DAL;
using lab30062020.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace lab30062020.Controllers
{
    public class FileUploadController : Controller
    {
        private readonly LabFileUploadContext _context;
        private readonly IHostingEnvironment _env;

        public FileUploadController(LabFileUploadContext context, IHostingEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(Photo photo)
        {
            if (photo.files == null || photo.files.Length == 0)
            {
                ModelState.AddModelError("Files", "Please select at least 1 file!");
                return View();
            }

            foreach (IFormFile img in photo.files)
            {
                if (!img.ContentType.Contains("image/"))
                {
                    ModelState.AddModelError("Files", "You do not have an access for adding different type of file!");
                    return View();
                }

                var imgSave = Path.Combine(_env.WebRootPath,"img");
                var fileName = Guid.NewGuid().ToString()+img.FileName;
                var path = Path.Combine(imgSave, fileName);
                FileStream stream = new FileStream(path, FileMode.Create);

                await img.CopyToAsync(stream);

                // yeni photo obyekti yaradib onun icerisinde fileName'i beraber edirik ImagePath property'sine
                Photo newPhoto = new Photo { ImagePath = fileName };
                //photo.ImagePath = fileName;

                await _context.AddAsync(newPhoto);
                await _context.SaveChangesAsync();
            }

            return View(nameof(Index));
        }
    }
}