using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bai3.Models;
namespace Bai3.Controllers
{
    public class MenuController : Controller
    {
        Bai3Entities db = new Bai3Entities();
        // GET: Menu
        public ActionResult Index()
        {
            var menus = db.Menu;
            return PartialView(menus);
        }
    }
}