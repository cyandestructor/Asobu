using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;

using Asobu.Models;

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

        // GET: Games
        public ActionResult Index()
        {
            var games = _context.Games.Include(g => g.Genre).ToList();
            var model = new ViewModels.Games.IndexViewModel() { Games = games };
            return View(model);
        }
    }
}