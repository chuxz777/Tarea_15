using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class survey_resultsController : Controller
    {
        private localeze_tareaEntities db = new localeze_tareaEntities();

        // GET: survey_results
        public ActionResult Index()
        {
            return View(db.survey_results.ToList());
        }

        // GET: survey_results/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            survey_results survey_results = db.survey_results.Find(id);
            if (survey_results == null)
            {
                return HttpNotFound();
            }
            return View(survey_results);
        }

        // GET: survey_results/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: survey_results/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_row,total_surveys,total_users,stat_date")] survey_results survey_results)
        {
            if (ModelState.IsValid)
            {
                db.survey_results.Add(survey_results);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(survey_results);
        }

        // GET: survey_results/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            survey_results survey_results = db.survey_results.Find(id);
            if (survey_results == null)
            {
                return HttpNotFound();
            }
            return View(survey_results);
        }

        // POST: survey_results/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_row,total_surveys,total_users,stat_date")] survey_results survey_results)
        {
            if (ModelState.IsValid)
            {
                db.Entry(survey_results).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(survey_results);
        }

        // GET: survey_results/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            survey_results survey_results = db.survey_results.Find(id);
            if (survey_results == null)
            {
                return HttpNotFound();
            }
            return View(survey_results);
        }

        // POST: survey_results/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            survey_results survey_results = db.survey_results.Find(id);
            db.survey_results.Remove(survey_results);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
