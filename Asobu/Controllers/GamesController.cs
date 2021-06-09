using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Asobu.Models;
using Asobu.ViewModels.Games;

namespace Asobu.Controllers
{
    public class GamesController : Controller
    {
        static private List<Game> _games = new List<Game>()
        {
            new Game() {Id = 1, Title = "Animal Crossing: New Horizons" },
            new Game() {Id = 2, Title = "Bloodborne" },
            new Game() {Id = 3, Title = "Dark Souls III" },
            new Game() {Id = 4, Title = "Terraria" }
        };

        [Route("Games/Details/{id:int}")]
        public ActionResult Details(int id)
        {
            foreach (var game in _games)
            {
                if(game.Id == id)
                {
                    return View(game);
                }
            }

            return HttpNotFound();
        }

        // GET: Games
        public ActionResult Index()
        {
            var model = new IndexViewModel() { Games = _games };
            return View(model);
        }
    }
}