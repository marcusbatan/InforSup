using Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InforSup.Controllers
{
    public class StatController : Controller
    {
        // GET: Stat
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Stat line)
        {
            using (var context = new SimonOMarcusEntities())
            {
                var repos = new StatRepository();
                repos.addLine(line.Goals, line.Assists);
                ViewBag.Mess = "You have registered a game!";
            }
            return View(line);
        }
    }
}
