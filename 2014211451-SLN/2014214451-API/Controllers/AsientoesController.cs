using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using _2014214451_ENT;
using _2014214451_PER;

namespace _2014214451_API.Controllers
{
    public class AsientoesController : Controller
    {
        private EnsambladoraDbContext db = new EnsambladoraDbContext();

        // GET: Asientoes
        public ActionResult Index()
        {
            var asientos = db.Asientos.Include(a => a.Cinturon);
            return View(asientos.ToList());
        }

        // GET: Asientoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Asiento asiento = db.Asientos.Find(id);
            if (asiento == null)
            {
                return HttpNotFound();
            }
            return View(asiento);
        }

        // GET: Asientoes/Create
        public ActionResult Create()
        {
            ViewBag.CinturonId = new SelectList(db.Cinturones, "CinturonId", "NumSerieCinturon");
            return View();
        }

        // POST: Asientoes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AsientoId,NumSerieAsiento,CinturonId")] Asiento asiento)
        {
            if (ModelState.IsValid)
            {
                db.Asientos.Add(asiento);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CinturonId = new SelectList(db.Cinturones, "CinturonId", "NumSerieCinturon", asiento.CinturonId);
            return View(asiento);
        }

        // GET: Asientoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Asiento asiento = db.Asientos.Find(id);
            if (asiento == null)
            {
                return HttpNotFound();
            }
            ViewBag.CinturonId = new SelectList(db.Cinturones, "CinturonId", "NumSerieCinturon", asiento.CinturonId);
            return View(asiento);
        }

        // POST: Asientoes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AsientoId,NumSerieAsiento,CinturonId")] Asiento asiento)
        {
            if (ModelState.IsValid)
            {
                db.Entry(asiento).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CinturonId = new SelectList(db.Cinturones, "CinturonId", "NumSerieCinturon", asiento.CinturonId);
            return View(asiento);
        }

        // GET: Asientoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Asiento asiento = db.Asientos.Find(id);
            if (asiento == null)
            {
                return HttpNotFound();
            }
            return View(asiento);
        }

        // POST: Asientoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Asiento asiento = db.Asientos.Find(id);
            db.Asientos.Remove(asiento);
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
