using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarketChart.Entities
{
    public class IPODetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [ForeignKey("StockExchange")]
        public string stock_ex_code { get; set; }

        [Required]
        public long price_p_share { get; set; }
        public int total_shares { get; set; }

        [ForeignKey("Company")]
        public string company_id { get; set; }
        public Company company { get; set; }


        public DateTime open_datetime { get; set; }

        [Required]
        [StringLength(500)]
        public string Remarks { get; set; }

    }
}
