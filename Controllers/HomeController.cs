using Millenium.Mvc.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Millenium.Mvc.App.Controllers
{
    public class HomeController : BaseController
    {

        [AllowAnonymous]
        public ActionResult SelectLanguage(string SelectedLanguage)
        {
            switch (SelectedLanguage)
            {
                case "EN":
                    ChangeCulture("en-GB");
                    break;
                case "PL":
                default:
                    ChangeCulture("pl-PL");
                    break;
            }

            return RedirectToAction("Index");

        }
        public ActionResult Index(UserCredentials credentials)
        {
            if(credentials?.Email != null)
            {
                return RedirectToRoute(nameof(Submit),credentials);
            }
            return View();
        }

        public ActionResult Submit(UserCredentials credentials)
        {
            return View(credentials);
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}