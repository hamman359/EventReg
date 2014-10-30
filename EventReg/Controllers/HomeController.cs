using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EventReg.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return RedirectToAction("EventDetails");
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

		public ActionResult EventDetails()
		{
			return View();
		}

		public ActionResult NewEvent()
		{
			return View();
		}

		public ActionResult EditProfile() {
			return View();
		}

		public ActionResult CacheSample()
		{
			return View();
		}

		public ActionResult CompileSample()
		{
			return View();
		}

		public ActionResult LocaleSample()
		{
			return View();
		}

		public ActionResult TimeoutSample()
		{
			return View();
		}

	}
}