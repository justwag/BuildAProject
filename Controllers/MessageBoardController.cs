using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BuildAProject.Models;

namespace BuildAProject.Controllers
{
    public class MessageBoardController : Controller
    {
        //
        // GET: /MessageBoard/
        private MessageBoardContext _db = new MessageBoardContext();

        public ActionResult Index()
        {
            var mostRecentEntries =
                (from entry in _db.Entries
                 orderby entry.DateAdded descending
                 select entry).Take(20);
            ViewBag.Entries = mostRecentEntries.ToList();
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }   
        [HttpPost]
        public ActionResult Create(MessageBoardEntry entry)
        {
            {
                entry.DateAdded = DateTime.Now;

                _db.Entries.Add(entry);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
         }

    }
}
