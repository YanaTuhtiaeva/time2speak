using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace timetospeak.Controllers
{
    public class TeacherController : Controller
    {
        // GET: Teacher
        public ActionResult Teachers()
        {
            return View();
        }
    }
}