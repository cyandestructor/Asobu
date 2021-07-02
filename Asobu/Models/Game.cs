using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Asobu.Models
{
    public class Game
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        [Display(Name = "Release date")]
        public DateTime? ReleaseDate { get; set; }

        [Display(Name = "Date added")]
        public DateTime? DateAdded { get; set; }

        public Genre Genre { get; set; }

        [Display(Name = "Genre")]
        public int? GenreId { get; set; }
    }
}