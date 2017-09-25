using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DnD5_Chargen.Models.Chargen;

namespace DnD5_Chargen.Controllers
{
    public class ChargenController : Controller
    {
        // GET: Chargen
        public ActionResult Index()
        {
            return View();
        }

        // GET: Chargen/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Chargen/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Chargen/Create
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

        // GET: Chargen/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Chargen/Edit/5
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

        // GET: Chargen/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Chargen/Delete/5
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

    [Route("Chargen/Races/{type}")]
    public ActionResult RaceView(string type) {
      return View(Race.GetRace(type));
    }
  }
}
