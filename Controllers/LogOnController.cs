using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BuildAProject.Models;

namespace BuildAProject.Controllers
{
    public class LogOnController : Controller
    {
        //
        // GET: /LogOn/

        public ActionResult LogOn(LogOnModel model, string returnUrl)
        {
            return View();
        }

    }
}
