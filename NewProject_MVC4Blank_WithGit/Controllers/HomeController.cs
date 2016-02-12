using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewProject_MVC4Blank_WithGit.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return Content("HomeController");
        }

        public ActionResult About()
        {
            return Content("AboutController");

        }

        public ActionResult Search()
        {
            return Content("SearchController");
        }
    }
}
