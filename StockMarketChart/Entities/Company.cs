using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarketChart.Entities
{
    public class Company
    {
        [Key]
        [StringLength(5)]
        [Column(TypeName = "Char")]
        public string id { get; set; }

        [Required]
        [StringLength(100)]
        public string company_name { get; set; }

        [Required]
        public float turnover { get; set; }
        [Required]
        [StringLength(100)]
        public string ceo { get; set; }

        [Required]
        [StringLength(500)]
        public string brief{ get; set; }

        [ForeignKey("StockExchange")]
        public string stock_id { get; set; }

        [ForeignKey("Sector")]
        public string sector { get; set; }


    }
}
