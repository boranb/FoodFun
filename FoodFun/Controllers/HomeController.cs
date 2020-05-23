using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FoodFun.ViewModels;

namespace FoodFun.Controllers
{
    public class HomeController : BaseController
    {

        public List<T> Shuffle<T>(List<T> ts)
        {
            var count = ts.Count;
            var last = count - 1;
            for (var i = 0; i < last; ++i)
            {
                var r = new Random().Next(i, count);
                var tmp = ts[i];
                ts[i] = ts[r];
                ts[r] = tmp;
            }

            return ts;
        }

        [OutputCache(Duration = 42300)] // cash 12 saat
        public ActionResult Index()
        {
            var Products = Shuffle(db.Products.ToList());

            var vm = new HomeIndexViewModel()
            {
                Products = Products.Take(3).ToList()

            };
            return View(vm);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Menu()
        {
            var vm = new HomeIndexViewModel()
            {
                Products = db.Products.OrderByDescending(x => x.CreationTime).ToList()
            };
            return View(vm);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult CategoriesPartial()
        {
            var cats = db.Categories.OrderBy(x => x.CategoryName).ToList();
            return PartialView("_CategoriesPartial", cats);
        }

    }
}