using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProtoV1.Models;
using System.ComponentModel.DataAnnotations;


namespace ProtoV1.Controllers
{
    public class EtusivuController : Controller
    {
        private SenioritEntities db = new SenioritEntities();
        // GET: Etusivu
        public ActionResult Index()

        {
            SenioritEntities db = new SenioritEntities();
            return View(db.AsiakkaanPerustiedot.ToList());
            //db.Dispose(); << Huom! lisää tämä!
        }
    }
}