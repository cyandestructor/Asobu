using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Asobu.Models;

namespace Asobu.ViewModels.Games
{
    public class GameFormViewModel
    {
        public Game Game { get; set; }

        public IEnumerable<Genre> Genres { get; set; }
    }
}