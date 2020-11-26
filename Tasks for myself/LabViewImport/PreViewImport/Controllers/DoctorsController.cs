using PreViewImport.DAL;
using PreViewImport.Models;
using PreViewImport.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PreViewImport.Controllers
{
    
    public class DoctorsController : Controller
    {
        private readonly PromedyContext _db = new PromedyContext();

        public ActionResult Index()
        {
            if (!ModelState.IsValid)
            {
                return HttpNotFound();
            }

            List<Doctor> doctors = _db.Doctors.Include("Department").ToList();

            return View(doctors);
        }

        public ActionResult Details(string slug)
        {
            if (string.IsNullOrEmpty(slug))
            {
                return HttpNotFound();
            }


            var doctor = _db.Doctors.Include("Department").FirstOrDefault(d => d.Slug == slug);
            if(doctor == null)
            {
                return HttpNotFound();
            }

            return View(doctor);
        }
    }
}