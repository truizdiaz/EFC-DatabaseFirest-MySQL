using System;
using System.Collections.Generic;

#nullable disable

namespace NorthwindDatabseFirst.Models
{
    public partial class VwunitsInStock
    {
        public string ProductCategory { get; set; }
        public string SupplierContinent { get; set; }
        public decimal? UnitsInStock { get; set; }
    }
}
