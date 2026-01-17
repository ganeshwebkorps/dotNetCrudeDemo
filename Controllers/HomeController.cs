using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace demoApplication.Controllers
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
	}
}



using System.Web.Mvc;

namespace dotNetCrudeDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // ================================
        // FEATURE-DEV DEMO METHOD
        // ================================
        public ActionResult FeatureDevDemo()
        {
            ViewBag.Message = "This is demo code from feature-dev branch";
            return View();
        }
    }
}
