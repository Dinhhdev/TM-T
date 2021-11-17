using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tuan1.Models;
namespace Tuan1.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index(string alias)
        {
            var db = new TMDTEntities1();
            var articles = db.Articles.Where(c => c.Category.Alias == alias);
            if(articles.Count() == 0)
            {
                return HttpNotFound();
            }

            return View(articles);
        }
    }
}