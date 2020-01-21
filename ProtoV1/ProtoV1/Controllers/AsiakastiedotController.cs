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
            return View(db.AsiakkaanPerustiedot.ToList());
            //db.Dispose(); << Huom! lisää tämä!
        }
    }
}