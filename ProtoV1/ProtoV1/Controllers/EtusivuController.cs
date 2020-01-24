using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProtoV1.Models;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace ProtoV1.Controllers
{
    public class EtusivuController : Controller
    {
        private SenioritEntities db = new SenioritEntities();
        // GET: Etusivu
        public ActionResult Index()
        {
            SenioritEntities db = new SenioritEntities();
            List<AsiakkaanPerustiedot> model = db.AsiakkaanPerustiedot.ToList();
            return View(model);
            //db.Dispose(); << Huom! lisää tämä!
        }
        public ActionResult Details(int? id)
        {
            //if (id == null)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}
            //AsiakkaanPerustiedot asiakkaanPerustiedot = db.AsiakkaanPerustiedot.Find(id);
            //if (asiakkaanPerustiedot == null)
            //{
            //    return HttpNotFound();
            //}
            return View();
        }
    }
}