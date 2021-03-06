using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Asobu.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        
        public short SignUpFee { get; set; }
        
        public byte DurationInMonths { get; set; }
        
        public decimal DiscountRate { get; set; }
    }
}