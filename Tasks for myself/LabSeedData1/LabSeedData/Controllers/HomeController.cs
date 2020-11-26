using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LabSeedData.Models;
using LabSeedData.DAL;
using LabSeedData.ViewModels;

namespace LabSeedData.Controllers
{
    public class HomeController : Controller
    {
        private readonly SeedDataContext _db;
        public HomeController(SeedDataContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {

            var vm = new ContactViewModel(_db.AppDetails.FirstOrDefault());
            
            return View(vm);
        }

        public IActionResult Create(Contact contact)
        {
            var appdetail = _db.AppDetails.FirstOrDefault();
            if (ModelState.IsValid)
            {
                _db.Contacts.Add(contact);
                _db.SaveChanges();
                return Redirect("");
            }
            var vm = new ContactViewModel(appdetail, contact);

            return View("Index", vm);
        }
    }
}
