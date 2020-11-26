using LabPagination.DAL;
using LabPagination.Models;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LabPagination.Controllers
{
    public class HomeController : Controller
    {
        private readonly PageDbContext _db = new PageDbContext();

        // Custom Pagination Controller
        //public ActionResult Index(int? page)
        //{
        //    ViewBag.PageSize = Math.Ceiling((decimal)_db.Products.Count() / 3);
        //    if(page == null)
        //    {
        //        ViewBag.Page = 0;
        //        return View(_db.Products.Take(3).ToList());
        //    }

        //    ViewBag.Page = page;
        //    List<Product> products = _db.Products.OrderBy(p=>p.Name).Skip((int)page * 3).Take(3).ToList();

        //    return View(products);
        //}

        //X.PagedList Pagination Controller
        public ActionResult Index(int? page)
        {
            var pageNumber = page ?? 1;
            var pageSize = 3;
            var onePageOfProducts = _db.Products.OrderBy(p=>p.Name).ToPagedList(pageNumber, pageSize);

            return View(onePageOfProducts);
        }


    }
}