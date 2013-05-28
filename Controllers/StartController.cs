using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BuildAProject.Models.FormModels;
using BuildAProject.Models.ViewModels;

namespace BuildAProject.Controllers
{
    public class StartController : Controller
    {
        //
        // GET: /Start/

        private InputViewModel inputDisplay;

        public StartController()
        {
            inputDisplay.FirstName = "";
            inputDisplay.LastName = "";
        }

        public ActionResult Index()
        {
            ViewBag.Message = "Starting simple.";

            ViewBag.CurrentDate = DateTime.Now;


            return View();
        } 
        
        public ActionResult Next()
        {
            ViewBag.Message = "Starting simple.";

            ViewBag.CurrentDate = DateTime.Now;

            return View();
        }

        public ActionResult Post(InputFormModel formModel)
        {
            return RedirectToAction("Next");
        }
    }

    
}
