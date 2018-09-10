using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProjectMinera.Models;

namespace ProjectMinera.Controllers
{
    public class SolicitudProveedoresController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: SolicitudProveedores
        public ActionResult Index()
        {
            var solicitudProveedores = db.SolicitudProveedores.Include(s => s.User);
            return View(solicitudProveedores.ToList());
        }

        // GET: SolicitudProveedores/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SolicitudProveedores solicitudProveedores = db.SolicitudProveedores.Find(id);
            if (solicitudProveedores == null)
            {
                return HttpNotFound();
            }
            return View(solicitudProveedores);
        }

        // GET: SolicitudProveedores/Create
        public ActionResult Create()
        {
            ViewBag.UserId = new SelectList(db.ApplicationUsers, "Id", "Nombre");
            return View();
        }

        // POST: SolicitudProveedores/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdSolicitud,NombreProveedor,Direccion,Ciudad,Estado,Telefono,NombreCon,EmailCon,TelefonoCon,Extension,Clasificacion,Aprobada,FechaSolicitud,TipoSolicitud,MotivoSolicitud,UserId")] SolicitudProveedores solicitudProveedores)
        {
            if (ModelState.IsValid)
            {
                db.SolicitudProveedores.Add(solicitudProveedores);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.UserId = new SelectList(db.ApplicationUsers, "Id", "Nombre", solicitudProveedores.UserId);
            return View(solicitudProveedores);
        }

        // GET: SolicitudProveedores/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SolicitudProveedores solicitudProveedores = db.SolicitudProveedores.Find(id);
            if (solicitudProveedores == null)
            {
                return HttpNotFound();
            }
            ViewBag.UserId = new SelectList(db.ApplicationUsers, "Id", "Nombre", solicitudProveedores.UserId);
            return View(solicitudProveedores);
        }

        // POST: SolicitudProveedores/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdSolicitud,NombreProveedor,Direccion,Ciudad,Estado,Telefono,NombreCon,EmailCon,TelefonoCon,Extension,Clasificacion,Aprobada,FechaSolicitud,TipoSolicitud,MotivoSolicitud,UserId")] SolicitudProveedores solicitudProveedores)
        {
            if (ModelState.IsValid)
            {
                db.Entry(solicitudProveedores).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.UserId = new SelectList(db.ApplicationUsers, "Id", "Nombre", solicitudProveedores.UserId);
            return View(solicitudProveedores);
        }

        // GET: SolicitudProveedores/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SolicitudProveedores solicitudProveedores = db.SolicitudProveedores.Find(id);
            if (solicitudProveedores == null)
            {
                return HttpNotFound();
            }
            return View(solicitudProveedores);
        }

        // POST: SolicitudProveedores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SolicitudProveedores solicitudProveedores = db.SolicitudProveedores.Find(id);
            db.SolicitudProveedores.Remove(solicitudProveedores);
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
