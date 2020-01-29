using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProtoV1.Models;

namespace ProtoV1.Controllers
{
    public class AsiakasluokitteluController : Controller
    {
        // GET: Asiakasluokittelu
        private SenioritEntities db = new SenioritEntities();

        public ActionResult Index()
        {
            SenioritEntities db = new SenioritEntities();
            return View(/*db.Asiakasluokittelu.ToList()*/);
            //db.Dispose(); << Huom! lisää tämä!
        }

        public ActionResult Create()
        {
            return View();
            //db.Dispose(); << Huom! lisää tämä!
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Asiakasnumero")] Asiakasluokittelu asiakasluokittelu)
        {
            if (ModelState.IsValid)
            {
                db.Asiakasluokittelu.Add(asiakasluokittelu);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(asiakasluokittelu);
        }
    }
}