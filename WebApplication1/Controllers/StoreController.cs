using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {

            return View();
        }
        public ActionResult Catalog()
        {

            return View();
        }
        public ActionResult Cart()
        {

            return View();
        }

    }
}