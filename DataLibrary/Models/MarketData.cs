using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLibrary.Models
{
    public class MarketData
    {
       
        public int Id { get; set; }
        [Required]
        public decimal AllShareIndex { get; set; }
        [Required]
        public decimal BondCap { get; set; }
        [Required]
        public decimal ETFCap { get; set; }

        [Required]
        public DateTime Date { get; set; }
    }
}
