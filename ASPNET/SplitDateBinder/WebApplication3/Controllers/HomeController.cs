using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SplitDateDemo.Models;

namespace SplitDateDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                //return Content("Fail");
            }
            else
            {
                //return Content("Success");
            }

            return View(model);
        }
    }
}