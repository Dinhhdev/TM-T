using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TMDT_Lab4.Models;

namespace TMDT_Lab4.Controllers
{
    public class LaptopController : Controller
    {
        Model1 db = new Model1();
        // GET: Laptop
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult getCompany()
        {
            var ListCompany = db.laptops.GroupBy(l => l.Company).Select(l => l.Key);
            return PartialView(ListCompany);
        }
        public ActionResult getCPU()
        {
            var ListCPU = db.laptops.GroupBy(l => l.Cpu).Select(l => l.Key);
            return PartialView(ListCPU);
        }


        /// Sv tự thêm các thông tin khác 


    }
}