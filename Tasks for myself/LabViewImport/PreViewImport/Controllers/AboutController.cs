using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PreViewImport.DAL;
using PreViewImport.Models;
using PreViewImport.ViewModels;

namespace PreViewImport.Controllers
{
    public class AboutController : Controller
    {
        private readonly PromedyContext _db = new PromedyContext();
        // GET: About
        public ActionResult Index()
        {
            if (!ModelState.IsValid)
            {
                return HttpNotFound();
            }

            var doctors = _db.Doctors.Include("Department").ToList();

            return View(doctors);
        }
    }
}