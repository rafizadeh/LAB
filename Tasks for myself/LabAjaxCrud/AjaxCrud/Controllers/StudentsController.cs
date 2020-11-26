using AjaxCrud.DAL;
using AjaxCrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxCrud.Controllers
{
    public class StudentsController : Controller
    {
        private readonly AjaxDbContext _db = new AjaxDbContext();

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetStudents()
        {
            var data = _db.Students.Include("Group").OrderBy(s => s.Name).Select(s => new
            {
                s.Id,
                s.Name,
                s.Surname,
                Group = s.Group.Name
            });

            return Json(data, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetGroups()
        {
            var data = _db.Groups.Select(g => new
            {
                g.Id,
                g.Name
            }).ToList();

            return Json(data, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public JsonResult Create(Student student)
        {
            if (!ModelState.IsValid)
            {
                Response.StatusCode = 400;
                var errorList = ModelState.Values.SelectMany(m => m.Errors)
                                 .Select(e => e.ErrorMessage)
                                 .ToList();

                return Json(errorList,JsonRequestBehavior.AllowGet);
            }

            _db.Students.Add(student);
            _db.SaveChanges();

            student.Group = _db.Groups.Find(student.GroupId);
            return Json(new {
                    student.Id,
                    student.Name,
                    student.Surname,
                    Group = student.Group.Name
            }, JsonRequestBehavior.AllowGet);

        }

        public JsonResult Delete(int id)
        {
            Student student = _db.Students.Find(id);

            if(student == null)
            {
                Response.StatusCode = 404;
                return Json(new
                {
                    message = "Student could not be found"
                }, JsonRequestBehavior.AllowGet);
            }

            _db.Students.Remove(student);
            _db.SaveChanges();

            return Json("", JsonRequestBehavior.AllowGet);

        }

    }
}