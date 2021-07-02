using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Asobu.Models;

namespace Asobu.ViewModels.Players
{
    public class NewViewModel
    {
        public Player Player { get; set; }

        public IEnumerable<MembershipType> MembershipTypes { get; set; }
    }
}