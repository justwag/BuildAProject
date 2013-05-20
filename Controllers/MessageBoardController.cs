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
        private IMessageBoardRepository _repository;

        public MessageBoardController()
        {
            _repository = new MessageBoardRepository();
        }

        public MessageBoardController(IMessageBoardRepository repository)
        {
            _repository = repository;
        }

        public ActionResult Index()
        {
            var mostRecentEntries = _repository.GetMostRecentEntries();
            return View(mostRecentEntries);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(MessageBoardEntry entry)
        {
            if (ModelState.IsValid)
            {
                _repository.AddEntry(entry);
                return RedirectToAction("Index");
            }

            return View(entry);
        }

        public ViewResult Show(int id)
        {
            var entry = _repository.FindById(id);

            bool hasPermission = User.Identity.Name == entry.Name;

            ViewBag.HasPermission = hasPermission;

            return View(entry);
        }

        public ActionResult PostSummary()
        {
            var entries = _repository.GetPostSummary();
            return View(entries);

        }
    }
}
