using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class SmallBusinessController : Controller
    {
        // GET: SmallBusiness
        public ActionResult Index()
        {
            return View();
        }

        // GET: SmallBusiness/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SmallBusiness/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SmallBusiness/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: SmallBusiness/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SmallBusiness/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: SmallBusiness/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SmallBusiness/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
