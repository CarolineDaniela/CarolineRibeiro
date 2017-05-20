using CarolineRibeiro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarolineRibeiro.Controllers
{
    public class SubjectsController : Controller
    {
        private static IList<Subject> subjects = new List<Subject>()
        {
            new Subject(){SubjId = 1, Name = "Databases"},
            new Subject(){SubjId = 2, Name = "Visual Programming"},
            new Subject(){SubjId = 3, Name = "Algorithm"}
        };

        // GET: Subjects
        public ActionResult Index()
        {
            return View(subjects);
        }

        // GET: Create
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Subject subject)
        {
            subjects.Add(subject);
            subject.SubjId = subjects.Select(m => m.SubjId).Max() + 1;
            return RedirectToAction("Index");
        }

        // GET: Edit
        public ActionResult Edit(long id)
        {
            return View(subjects.Where(m => m.SubjId == id).First());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Subject subject)
        {
            subjects.Remove(subjects.Where(c => c.SubjId == subject.SubjId).First());
            subjects.Add(subject);
            return RedirectToAction("Index");
        }

        public ActionResult Details(long id)
        {
            return View(subjects.Where(m => m.SubjId == id).First());
        }

        // GET: Delete
        public ActionResult Delete(long id)
        {
            return View(subjects.Where(m => m.SubjId == id).First());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Subject subject)
        {
            subjects.Remove(subjects.Where(c => c.SubjId == subject.SubjId).First());
            return RedirectToAction("Index");
        }
    }
}