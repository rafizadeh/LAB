using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiFileUpload.DAL;
using MultiFileUpload.Models;

namespace MultiFileUpload.Controllers
{
    public class FileUploadController : Controller
    {
        private readonly FileUploadContext _context;
        private readonly IHostingEnvironment _env;

        public FileUploadController(FileUploadContext context, IHostingEnvironment env)
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
            if (photo.Files == null || photo.Files.Length == 0)
            {
                ModelState.AddModelError("Files","Please select at least 1 image file");
                return View();
            }

            foreach (IFormFile img in photo.Files)
            {
                if (!img.ContentType.Contains("image/"))
                {
                    ModelState.AddModelError("Files", "You don't have an access for adding different type of file!");
                    return View();
                }
                else
                {
                    var imgSave = Path.Combine(_env.WebRootPath, "img");
                    string fileName = Guid.NewGuid().ToString() + img.FileName;
                    string path = Path.Combine(imgSave, fileName);
                    FileStream stream = new FileStream(path, FileMode.Create);

                    await img.CopyToAsync(stream);

                    Photo newPhoto = new Photo { ImagePath = fileName };
                    //photo.ImagePath = fileName;

                    await _context.Photos.AddAsync(newPhoto);
                    await _context.SaveChangesAsync();
                }

            }

            return RedirectToAction(nameof(Index));
        }
    }
}