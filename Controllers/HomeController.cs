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
            viewBag.CurrentTime = DateTime.Now.ToString("Fahadasdasdasdsadsafaf");
            viewBag.CurrentTime = DateTime.Now.ToString("Fahadasdasdasdsadsafaf");
			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}