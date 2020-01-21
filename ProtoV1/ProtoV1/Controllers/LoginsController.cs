using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using ProtoV1.Models;

namespace ProtoV1.Controllers
{
    public class LoginsController : Controller
    {
        // GET: Logins
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Käyttäjätunnukset()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Authorize(Logins LoginsModel)
        {
            SenioritEntities db = new SenioritEntities();

            var LoggedUser = db.Logins.SingleOrDefault(x => x.Käyttäjätunnus == LoginsModel.Käyttäjätunnus && x.Salasana == LoginsModel.Salasana);
            if (LoggedUser != null)
            {
                ViewBag.LoginMessage = "Successfull login";
                ViewBag.LoginId = LoggedUser.LoginID;
                Session["UserName"] = LoggedUser.Käyttäjätunnus;
                Session["LoginId"] = LoggedUser.LoginID;
                return RedirectToAction("Index", "Etusivu");
            }
            else
            {
                ViewBag.LoginMessage = "Login unsuccessfull";
                ViewBag.LoggedStatus = "Out";
                LoginsModel.LoginIdErrorMessage = "Tuntematon käyttäjätunnus tai salasana.";
                return View("Logins", LoginsModel);
            }

        }
        public ActionResult LogOut()
        {
            Session.Abandon();
            ViewBag.LoggedStatus = "Out";
            return RedirectToAction("Index", "Logins"); //Uloskirjautumisen jälkeen pääsivulle
        }
    }

}
