using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace timetospeak.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "О нас";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Контакты";

            return View();
        }
        public ActionResult Feedback ()
        {
            ViewBag.Message = "Отзывы";

            return View();
        }
        public ActionResult Price ()
        {
            ViewBag.Message = "Цены";

            return View();
        }
        public ActionResult Test ()
        {
            ViewBag.Message = "Тесты";

            return View();
        }

        public ActionResult Location()
        {
            ViewBag.Message = "Тесты";

            return PartialView();
        }
    }
}