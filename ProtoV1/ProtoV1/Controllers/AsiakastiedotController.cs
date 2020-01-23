using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using ProtoV1.Models;

namespace ProtoV1.Controllers
{
    public class AsiakastiedotController : Controller
    {
        // GET: Asiakastiedot
        private SenioritEntities db = new SenioritEntities();
        public ActionResult Index()
        {
            SenioritEntities db = new SenioritEntities();
            List<AsiakkaanPerustiedot> model = db.AsiakkaanPerustiedot.ToList();
            db.Dispose();
            return View(model);
            //db.Dispose(); << Huom! lisää tämä!
        }
    }
}