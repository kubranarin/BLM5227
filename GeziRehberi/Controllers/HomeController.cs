using GeziRehberi.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GeziRehberi.Controllers
{
    public class HomeController : Controller
    {

        [CustomAuthorize(Roles ="Admin,User")]
        public ActionResult Index()
        {
            return View();
        }

    }
}