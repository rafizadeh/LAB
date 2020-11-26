using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppASPMVCCore.DAL;
using AppASPMVCCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AppASPMVCCore.Controllers
{
    public class ServiceController : Controller
    {
        private readonly AppDbContext _db;

        public ServiceController(AppDbContext db)
        {
            this._db = db;
        }
        public IActionResult Index()
        {
            List<Service> services = _db.Services.Include(s => s.ServicePhotos).ToList();

            return View(services);
        }

        public IActionResult Details(int id)
        {
            Service service = _db.Services.Include(s=>s.ServicePhotos).FirstOrDefault(s => s.Id == id);
            return View(service);
        }
    }
}