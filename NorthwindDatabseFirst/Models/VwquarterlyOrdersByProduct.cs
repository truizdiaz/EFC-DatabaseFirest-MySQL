using System;
using System.Collections.Generic;

#nullable disable

namespace NorthwindDatabseFirst.Models
{
    public partial class VwquarterlyOrdersByProduct
    {
        public string ProductName { get; set; }
        public string CompanyName { get; set; }
        public int? OrderYear { get; set; }
        public string Qtr1 { get; set; }
        public string Qtr2 { get; set; }
        public string Qtr3 { get; set; }
        public string Qtr4 { get; set; }
    }
}
