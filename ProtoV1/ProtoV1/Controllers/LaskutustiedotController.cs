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
    }
}
    
            
        
         
        
    
