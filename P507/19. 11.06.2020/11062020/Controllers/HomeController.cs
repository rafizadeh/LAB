using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using _11062020.DAL;
using _11062020.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _11062020.Controllers
{
    public class HomeController : Controller
    {
        private readonly LabDbContext _db;
        public HomeController(LabDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<Service> services = _db.Services.Include(s=>s.ServicePhotos).ToList();

            return View(services);
        }
    }
}
