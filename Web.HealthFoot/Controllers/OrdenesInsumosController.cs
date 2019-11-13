using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.HealthFoot.Controllers
{
    public class OrdenesInsumosController : Controller
    {
        // GET: OrdenesInsumos
        public ActionResult Index()
        {
            return View();
        }

        // GET: OrdenesInsumos/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: OrdenesInsumos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OrdenesInsumos/Create
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

        // GET: OrdenesInsumos/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OrdenesInsumos/Edit/5
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

        // GET: OrdenesInsumos/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OrdenesInsumos/Delete/5
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
