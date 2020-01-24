using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using ProtoV1.Models;

namespace ProtoV1.Controllers
{
    public class AsiakastiedotController : Controller
    {
        // GET: Asiakastiedot
        SenioritEntities db = new SenioritEntities();
        public ActionResult Index()
        {
            SenioritEntities db = new SenioritEntities();
            return View(db.AsiakkaanPerustiedot.ToList());
        }
        public ActionResult Create()
        {
            return View();
            //db.Dispose(); << Huom! lisää tämä!
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Etunimi, Sukunimi, Osoite, Postinumero, Postitoimipaikka, Puhelin, Sähköposti")] AsiakkaanPerustiedot asiakkaanPerustiedot)
        {
            if (ModelState.IsValid)
            {
                db.AsiakkaanPerustiedot.Add(asiakkaanPerustiedot);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(asiakkaanPerustiedot);
        }
    }
}