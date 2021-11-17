using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bai3.Models;

namespace Bai3.Controllers
{
    public class BannerController : Controller
    {
        Bai3Entities db = new Bai3Entities();
        // GET: Banner
       
            public ActionResult Index()
            {
                return View();
            }
            public ActionResult HeaderBanner()
            {
                var headerBanner = db.Banner.Where(c => c.Name == "Header").FirstOrDefault();
                return PartialView(headerBanner);
            }
            public ActionResult LeftBanner()
            {
                var leftBanner = db.Banner.Where(c => c.Name == "Left").FirstOrDefault();
                return PartialView(leftBanner);
            }
            public ActionResult RightBanner()
            {
                var rightBanner = db.Banner.Where(c => c.Name == "Right").FirstOrDefault();
                return PartialView(rightBanner);
            }
        }
   }
