using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace lab_2.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: HomeController1
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(string category)
        {
            ViewBag.category = category;
            return View();
        }
    }
}
