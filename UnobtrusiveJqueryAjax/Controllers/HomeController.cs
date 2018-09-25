using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UnobtrusiveJqueryAjax.Models;

namespace UnobtrusiveJqueryAjax.Controllers
{
    public class HomeController : Controller
    {
        UnobtrusiveJqueryAjaxContext db = new UnobtrusiveJqueryAjaxContext();

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

        public ActionResult AllTeachers()
        {
            return PartialView(db.Teachers.OrderBy(x => x.Name).ToList());
        }

        public ActionResult AllSchools()
        {
            return PartialView(db.Schools.OrderBy(x => x.Name).ToList());
        }
    }
}