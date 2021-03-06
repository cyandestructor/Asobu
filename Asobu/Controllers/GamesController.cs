using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;

using Asobu.Models;
using Asobu.ViewModels.Games;

namespace Asobu.Controllers
{
    public class GamesController : Controller
    {
        private ApplicationDbContext _context;

        public GamesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            _context.Dispose();
        }

        [Route("Games/Details/{id:int}")]
        public ActionResult Details(int id)
        {
            var game = _context.Games.Include(g => g.Genre).SingleOrDefault(g => g.Id == id);

            if (game == null)
            {
                return HttpNotFound();
            }

            return View(game);
        }

        public ActionResult New()
        {
            var model = new GameFormViewModel()
            {
                Genres = _context.Genres.ToList()
            };

            return View("GameForm", model);
        }

        public ActionResult Edit(int id)
        {
            var game = _context.Games.SingleOrDefault(g => g.Id == id);
            
            if (game == null)
            {
                return HttpNotFound();
            }

            var model = new GameFormViewModel()
            {
                Game = game,
                Genres = _context.Genres.ToList()
            };

            return View("GameForm", model);
        }

        public ActionResult Save(Game game)
        {
            if (game.Id == 0)
            {
                _context.Games.Add(game);
            }
            else
            {
                var original = _context.Games.Single(g => g.Id == game.Id);
                original.Title = game.Title;
                original.ReleaseDate = game.ReleaseDate;
                original.DateAdded = game.DateAdded;
                original.GenreId = game.GenreId;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Games");
        }

        // GET: Games
        public ActionResult Index()
        {
            var games = _context.Games.Include(g => g.Genre).ToList();
            var model = new ViewModels.Games.IndexViewModel() { Games = games };
            return View(model);
        }
    }
}