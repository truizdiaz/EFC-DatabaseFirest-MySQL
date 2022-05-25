using System;
using System.Collections.Generic;

#nullable disable

namespace NorthwindDatabseFirst.Models
{
    public partial class Vwinvoice
    {
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipRegion { get; set; }
        public string ShipPostalCode { get; set; }
        public string ShipCountry { get; set; }
        public string CustomerId { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Salesperson { get; set; }
        public uint OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime? RequiredDate { get; set; }
        public DateTime? ShippedDate { get; set; }
        public string ShipperName { get; set; }
        public uint ProductId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public ushort Quantity { get; set; }
        public float Discount { get; set; }
        public double ExtendedPrice { get; set; }
        public double Freight { get; set; }
    }
}
