using TMDT_Lab4.Helper;
using TMDT_Lab4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TMDT_Lab4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetSearchFilter()
        {
            Model1 db = new Model1();
            SearchParameters search = new SearchParameters();

            var listLaptop = db.laptops.ToList();


            search.Company = listLaptop.GroupBy(l => l.Company).Select(l => l.Key).ToList();

            search.ScreenResolution = listLaptop.GroupBy(l => l.ScreenResolution).Select(l => l.Key).ToList();

            search.TypeName = listLaptop.GroupBy(l => l.TypeName).Select(l => l.Key).ToList();

            search.Inches = listLaptop.GroupBy(l => l.Inches).Select(l => l.Key).ToList();

            search.CPU = listLaptop.GroupBy(l => l.Cpu).Select(l => l.Key).ToList();

            search.Speed = listLaptop.GroupBy(l => l.Speed).Select(l => l.Key).ToList();

            search.Memory = listLaptop.GroupBy(l => l.Memory).Select(l => l.Key).ToList();

            search.Ram = listLaptop.GroupBy(l => l.Ram).Select(l => l.Key).ToList();

            search.Gpu = listLaptop.GroupBy(l => l.Gpu).Select(l => l.Key).ToList();

            search.Gen = listLaptop.GroupBy(l => l.Gen).Select(l => l.Key).ToList();

            search.OpSys = listLaptop.GroupBy(l => l.OpSys).Select(l => l.Key).ToList();

            search.Weight = listLaptop.GroupBy(l => l.Weight).Select(l => l.Key).ToList();

            return PartialView(search);
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