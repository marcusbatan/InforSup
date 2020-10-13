using Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InforSup.Controllers
{
    public class GamesController : Controller
    {
        // GET: Games
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Games game)
        {
            using (var db = new SimonOMarcusEntities())
            {
                var repos = new GamesRepository();
                repos.AddGame(game.GameId, game.HomeScore, game.AwayScore, game.HomeTeam, game.AwayTeam);
                ViewBag.Mess = "You have registered a game!";
            }
            return View(game);
        }
    }
}
