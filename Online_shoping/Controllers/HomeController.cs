using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Online_shoping.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(string name)
        {
           
            return View();
        }
        
        public ActionResult Male()
        {
            return View();
        }
        public ActionResult Women()
        {
            return View();
        }
        public ActionResult Kid()
        {
            return View();
        }
    }
}