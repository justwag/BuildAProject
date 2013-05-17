using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BuildAProject.Controllers
{
    public class StartController : Controller
    {
        //
        // GET: /Start/

        public ActionResult Index()
        {
            ViewBag.Message = "Starting simple.";

            ViewBag.CurrentDate = DateTime.Now;

            return View();
        } 
        
        public ActionResult Next()
        {
            ViewBag.Message = "Starting simple.";

            return View();
        }

    }
}
