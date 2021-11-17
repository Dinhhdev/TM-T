using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tuan6.Models;
using Tuan6.ModelView;
using Tuan6.Repository;

namespace Tuan6.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        public ActionResult Favorites(int page, int size)
        {

            var records = new FavoritesList();

            var model = new ProductViewModel
            {
                Products = records.GetResults(new ListParams
                {
                    PageIndex = page,
                    PageSize = size
                })
            };

            Common.Page = page;
            Common.Size = size;
            Common.Count = records.GetCount(size);

            return View(model.Products);
        }
        public ActionResult WishList(int page, int size)
        {
            
            var records = new WishList();
            var model = new ProductViewModel
            {
                Products = records.GetResults(new ListParams
                {
                    PageIndex = page,
                    PageSize = size
                })
            };

            Common.Page = page;
            Common.Size = size;
            Common.Count = records.GetCount(size);

            return View(model.Products);
        }

        public ActionResult SearchResults(int page, int size)
        {
            
            var records = new SearchResultList();
            var model = new ProductViewModel
            {
                Products = records.GetResults(new ListParams
                {
                    PageIndex = page,
                    PageSize = size
                })
            };

            Common.Page = page;
            Common.Size = size;
            Common.Count = records.GetCount(size);

            return View(model.Products);
        }

    }
}