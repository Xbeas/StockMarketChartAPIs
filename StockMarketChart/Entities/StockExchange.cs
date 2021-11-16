using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarketChart.Entities
{
    public class StockExchange
    {
        [Key]
        [StringLength(3)]
        public string id { get; set;}

        [Required]
        [StringLength(30)]
        public string stock_exchange_name { get; set; }


        [Required]
        [StringLength(500)]
        public string brief { get; set; }

        [Required]
        [StringLength(100)]
        public string contact_address { get; set; }

        [Required]
        [StringLength(500)]
        public string Remarks { get; set; }

        public DateTime timestamp { get; set; }


    }
}
