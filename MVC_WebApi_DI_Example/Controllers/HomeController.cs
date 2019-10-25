using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMyInterface instance;

        public HomeController(IMyInterface instance)
        {
            this.instance = instance ?? throw new ArgumentNullException(nameof(instance));
        }
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            ViewBag.GotInstance = this.instance != null;

            return View();
        }
    }
}
