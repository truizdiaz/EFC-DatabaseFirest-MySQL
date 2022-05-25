using System;
using System.Collections.Generic;

#nullable disable

namespace NorthwindDatabseFirst.Models
{
    public partial class Product
    {
        public Product()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public uint ProductId { get; set; }
        public string ProductName { get; set; }
        public uint SupplierId { get; set; }
        public byte CategoryId { get; set; }
        public string QuantityPerUnit { get; set; }
        public double UnitPrice { get; set; }
        public ushort UnitsInStock { get; set; }
        public ushort UnitsOnOrder { get; set; }
        public ushort ReorderLevel { get; set; }
        public string Discontinued { get; set; }

        public virtual Category Category { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
