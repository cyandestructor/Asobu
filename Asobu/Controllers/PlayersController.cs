using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Asobu.Models;
using Asobu.ViewModels.Players;

namespace Asobu.Controllers
{
    public class PlayersController : Controller
    {
        static private List<Player> _players = new List<Player>()
        {
            new Player(){Id=1, Username="Heroplayer321" },
            new Player(){Id=2, Username="Masterlock50" }
        };

        [Route("games/details/{id:int}")]
        public ActionResult Details(int id)
        {
            foreach (var player in _players)
            {
                if (player.Id == id)
                {
                    return View(player);
                }
            }

            return HttpNotFound();
        }

        // GET: Players
        public ActionResult Index()
        {
            var model = new ViewModels.Players.IndexViewModel() { Players = _players };
            return View(model);
        }
    }
}