using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Narail.Controllers
{
    public class ContantController : Controller
    {
        // GET: Contant
        public ActionResult Index()
        {
            ViewBag.Title = "Narail | Contant";
            return View();
        }
    }
}