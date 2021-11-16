using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarketChart.Entities
{
    public class StockPrice
    {
        [Key]
        public int id { get; set; }

        [ForeignKey("StockExchange")]
        public string stock_ex_code { get; set; }
        public StockExchange stockExchange { get; set; }

        [Required]
        public long current_price { get; set; }

        [ForeignKey("Company")]
        public string company_id { get; set; }
        public Company company { get; set; }


        public DateTime timestamp { get; set; }
    }
}
