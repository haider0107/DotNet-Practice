using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.DTOs.Stock
{
    public class CreateStockRequestDTO
    {
        public String Symbol { get; set; } = string.Empty;
        public String CompanyName { get; set; } = string.Empty;
        public decimal Purchase { get; set; }
        public decimal LastDiv { get; set; }
        public String Industry { get; set; } = string.Empty;
        public long MarketCap { get; set; }
    }
}