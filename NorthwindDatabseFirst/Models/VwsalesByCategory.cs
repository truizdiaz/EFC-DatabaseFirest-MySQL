using System;
using System.Collections.Generic;

#nullable disable

namespace NorthwindDatabseFirst.Models
{
    public partial class VwsalesByCategory
    {
        public byte CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public double? ProductSales { get; set; }
    }
}
