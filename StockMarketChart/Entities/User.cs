using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarketChart.Entities
{
    public class User
    {
        [Key]
        public int id { get; set;}

        [Required]
        [StringLength(30)]
        public string username { get; set; }

        [Required]
        public long mobile { get; set; }

        [Required]
        [StringLength(50, MinimumLength =6)]
        public string password { get; set; }

        public bool confirmed { get; set; }

        [EmailAddress]
        [Required]
        public string email { get; set; }

        [Required]
        public string userType { get; set; }

    }
}
