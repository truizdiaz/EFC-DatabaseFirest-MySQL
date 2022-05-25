using System;
using System.Collections.Generic;

#nullable disable

namespace NorthwindDatabseFirst.Models
{
    public partial class OrderDetail
    {
        public uint Id { get; set; }
        public uint OrderId { get; set; }
        public uint ProductId { get; set; }
        public double UnitPrice { get; set; }
        public ushort Quantity { get; set; }
        public float Discount { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
