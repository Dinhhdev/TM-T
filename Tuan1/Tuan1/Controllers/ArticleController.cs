using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tuan1.Models;
namespace Tuan1.Controllers
{
    public class ArticleController : Controller
    {
        // GET: Article
        public ActionResult Index(string categoryAlias, string articleAlias)
        {
            var db = new TMDTEntities2();
            var article = db.Articles.SingleOrDefault(c => c.Alias == articleAlias);
            if (article == null)
            {
                return HttpNotFound();
            }

            return View(article);
            
        }
    }
}