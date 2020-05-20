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
        public ActionResult Index()
        {
            var vm = new HomeIndexViewModel()
            {
                Products = db.Products.OrderByDescending(x=>x.CreationTime).ToList()
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
            ViewBag.Message = "Your menu page.";

            return View();
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