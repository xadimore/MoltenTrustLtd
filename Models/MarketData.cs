using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class MarketData
    {
        public int Id { get; set; }
        public decimal AllShareIndex { get; set; }
        public decimal BondCap { get; set; }
        public decimal ETFCap { get; set; }

        public DateTime Date { get; set; }
    }
}
