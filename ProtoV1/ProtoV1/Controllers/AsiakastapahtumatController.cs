using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProtoV1.Models;

namespace ProtoV1.Controllers
{
    public class AsiakastapahtumatController : Controller
    {
        // GET: Asiakastapahtumat
        private SenioritEntities db = new SenioritEntities();
        public ActionResult Index()
        {
            SenioritEntities db = new SenioritEntities();
            return View(db.Asiakastapahtumat.ToList());
            //db.Dispose(); << Huom! lisää tämä!
        }
        public ActionResult Create()
        {
            return View();
            //db.Dispose(); << Huom! lisää tämä!
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create ([Bind(Include ="Asiakasnumero, Päivämäärä, Yhteydenotto, Kuvaus, Ratkaisu")] Asiakastapahtumat asiakastapahtumat)
        {
            if (ModelState.IsValid)
            {
                db.Asiakastapahtumat.Add(asiakastapahtumat);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(asiakastapahtumat);
        }
    }
}