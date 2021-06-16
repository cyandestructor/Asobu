using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Asobu.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        public MembershipType MembershipType { get; set; }
        public byte MembershipTypeId { get; set; }
    }
}