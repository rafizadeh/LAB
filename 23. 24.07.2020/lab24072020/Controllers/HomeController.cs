using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using lab24072020.DAL;
using lab24072020.Models;
using lab24072020.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace lab24072020.Controllers
{
    public class HomeController : Controller
    {
        private readonly SeedDbContext _db;
        public HomeController(SeedDbContext db)
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

            return View("Index" ,vm);
        }

    }
}
