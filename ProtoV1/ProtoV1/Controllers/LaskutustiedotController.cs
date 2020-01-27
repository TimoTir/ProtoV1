using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProtoV1.Models;
using System.ComponentModel.DataAnnotations;

namespace ProtoV1.Controllers
{
    public class LaskutustiedotController : Controller
    {
        // GET: Laskutustiedot
        private SenioritEntities db = new SenioritEntities();
        public ActionResult Index()
        {

            SenioritEntities db = new SenioritEntities();
            return View(db.Laskutustiedot.ToList());

        }
        public ActionResult Create()
        {
            return View();
            //db.Dispose(); << Huom! lisää tämä!
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Asiakasnumero, Etunimi, Sukunimi, Puhelin, Osoite, Postinumero, Postitoimipaikka, Sähköposti")] Laskutustiedot laskutustiedot)
        {
            if (ModelState.IsValid)
            {
                db.Laskutustiedot.Add(laskutustiedot);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(laskutustiedot);
        }
    }
}