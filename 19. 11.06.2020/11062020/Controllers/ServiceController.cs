using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _11062020.DAL;
using _11062020.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _11062020.Controllers
{
    public class ServiceController : Controller
    {
        private readonly LabDbContext _db;

        public ServiceController(LabDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<Service> services = _db.Services.Include(s => s.ServicePhotos).ToList();

            return View(services);
        }

        public IActionResult Details(int id)
        {
            Service service = _db.Services.Include(s => s.ServicePhotos).FirstOrDefault(s => s.Id == id);

            return View(service);
        }
    }
}