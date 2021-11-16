using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarketChart.Entities
{
    public class Sector
    {
        [Key]
        [StringLength(5)]
        [Column(TypeName="Char")]
        public string id { get; set; }

        [Required]
        [StringLength(50)]
        public string sector_name { get; set; }

        [StringLength(100)]
        public string brief { get; set; }


    }
}
