using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Asobu.Models;

namespace Asobu.Controllers
{
    public class PlayersController : Controller
    {
        [Route("games/details/{id:int}")]
        public ActionResult Details(int id)
        {
            var players = new List<Player>()
            {
                new Player(){Id=1, Username="Heroplayer321" },
                new Player(){Id=2, Username="Masterlock50" }
            };

            foreach (var player in players)
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
            return View();
        }
    }
}