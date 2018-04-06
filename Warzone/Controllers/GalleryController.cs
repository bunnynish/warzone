using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Warzone.Controllers
{
    public class GalleryController : Controller
    {
        // GET: Gallery
        public ActionResult Index()
        {
            return View();
        }

		public ActionResult Rodjendani()
		{
			return View();
		}

		public ActionResult TeamBuilding()
		{
			return View();
		}
	}
}