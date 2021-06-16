﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;

using Asobu.Models;

namespace Asobu.Controllers
{
    public class PlayersController : Controller
    {
        private ApplicationDbContext _context;

        public PlayersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            _context.Dispose();
        }

        [Route("Players/Details/{id:int}")]
        public ActionResult Details(int id)
        {
            var player = _context.Players.Include(p => p.MembershipType).SingleOrDefault(g => g.Id == id);

            if(player == null)
            {
                return HttpNotFound();
            }

            return View(player);
        }

        // GET: Players
        public ActionResult Index()
        {
            var players = _context.Players.Include(p => p.MembershipType).ToList();
            var model = new ViewModels.Players.IndexViewModel() { Players = players };
            return View(model);
        }
    }
}