using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LabSlugBundle.DAL;
using Microsoft.AspNetCore.Mvc;

namespace LabSlugBundle.Controllers
{
    public class BlogController : Controller
    {
        private ApplicationDb _db;
        public BlogController(ApplicationDb db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var blogs = _db.Blogs.ToList();

            return View(blogs);
        }

        [Route("/blog/{slug}")]
        public IActionResult Detail(string slug)
        {
            if (string.IsNullOrEmpty(slug))
            {
                return NotFound();
            }
           

            var blog = _db.Blogs.FirstOrDefault(b => b.Slug == slug);

            if (blog == null)
            {
                return NotFound();
            }

            return View(blog);
        }
    }
}