using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using lab18062020.DAL;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace lab18062020.Controllers
{
    public class HomeController : Controller
    {
        private readonly PageDbContext _db;
        public HomeController(PageDbContext db)
        {
            _db = db;
        }
        public IActionResult Index(int? page)
        {
            var pageNumber = page ?? 1;
            var pageSize = 3;

            var onePageOfProducts = _db.Products.ToPagedList(pageNumber, pageSize);

            return View(onePageOfProducts);
        }
       
    }
}
