using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProjectMinera.Models;
using static ProjectMinera.Models.ApplicationUser;

namespace ProjectMinera.Controllers
{
    [Authorize(Roles = RoleNames.ADMIN)]
    public class TiposProveedoresController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: TiposProveedores
        public ActionResult Index()
        {
            return View(db.TiposProveedores.ToList());
        }

        // GET: TiposProveedores/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TiposProveedores tiposProveedores = db.TiposProveedores.Find(id);
            if (tiposProveedores == null)
            {
                return HttpNotFound();
            }
            return View(tiposProveedores);
        }

        // GET: TiposProveedores/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TiposProveedores/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdTipo,NombreTipo")] TiposProveedores tiposProveedores)
        {
            if (ModelState.IsValid)
            {
                db.TiposProveedores.Add(tiposProveedores);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tiposProveedores);
        }

        // GET: TiposProveedores/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TiposProveedores tiposProveedores = db.TiposProveedores.Find(id);
            if (tiposProveedores == null)
            {
                return HttpNotFound();
            }
            return View(tiposProveedores);
        }

        // POST: TiposProveedores/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdTipo,NombreTipo")] TiposProveedores tiposProveedores)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tiposProveedores).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tiposProveedores);
        }

        // GET: TiposProveedores/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TiposProveedores tiposProveedores = db.TiposProveedores.Find(id);
            if (tiposProveedores == null)
            {
                return HttpNotFound();
            }
            return View(tiposProveedores);
        }

        // POST: TiposProveedores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TiposProveedores tiposProveedores = db.TiposProveedores.Find(id);
            db.TiposProveedores.Remove(tiposProveedores);
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
