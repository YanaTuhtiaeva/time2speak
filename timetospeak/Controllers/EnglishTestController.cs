using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace timetospeak.Controllers
{
    public class EnglishTestController : Controller
    {
        public ActionResult TestsMain()
        {
            return View();
        }

        //IELTS tests
        public ActionResult TestsIelts()
        {
            return View();
        }
    }
}