using GeziRehberi.Helper;
using GeziRehberi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GeziRehberi.Controllers
{
    public class HomeController : Controller
    {
        private GeziRehberiEntities db = new GeziRehberiEntities();
        [CustomAuthorize(Roles ="Admin,User")]
        public ActionResult Index()
        {
            var countries = db.Countries.ToList();
            ViewBag.Countries = countries;
            return View();
        }

        public ActionResult GetCities(int countryId)
        {
            var cities = db.Cities
                           .Where(x => x.CountryId == countryId)
                           .Select(x => new
                           {
                               x.Id,
                               x.Name
                           })
                           .ToList();

            return Json(cities, JsonRequestBehavior.AllowGet);
        }



    }
}