using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tuan1.Models;
namespace Tuan1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            var db = new TMDTEntities1();
            var categories = db.Categories.ToList();

            return View(categories);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}