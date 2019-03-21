using Dal.Entities;
using Dal.Interfaces;
using System.Web.Mvc;


namespace timetospeak.Controllers
{
    public class HomeController : Controller
    {
        private IAboutRepository<AboutSchool> repo;

        public HomeController(IAboutRepository<AboutSchool> repos)
        {
            repo = repos;
        }


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

        public ActionResult Header()
        {
            
            return PartialView();
        }
    }
}