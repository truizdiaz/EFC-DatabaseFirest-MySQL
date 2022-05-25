using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace NorthwindDatabseFirst.Models
{
    public partial class northwindContext : DbContext
    {
        public northwindContext(DbContextOptions<northwindContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Shipper> Shippers { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<Vw10mostExpensiveProduct> Vw10mostExpensiveProducts { get; set; }
        public virtual DbSet<VwcustomerSupplierByCity> VwcustomerSupplierByCities { get; set; }
        public virtual DbSet<Vwinvoice> Vwinvoices { get; set; }
        public virtual DbSet<VwproductsAboveAveragePrice> VwproductsAboveAveragePrices { get; set; }
        public virtual DbSet<VwquarterlyOrdersByProduct> VwquarterlyOrdersByProducts { get; set; }
        public virtual DbSet<VwsalesByCategory> VwsalesByCategories { get; set; }
        public virtual DbSet<VwunitsInStock> VwunitsInStocks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasCharSet("utf8")
                .UseCollation("utf8_unicode_ci");

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("categories");

                entity.UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.CategoryName, "Uidx_categories_category_name")
                    .IsUnique();

                entity.Property(e => e.CategoryId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("CategoryID");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasDefaultValueSql("''")
                    .UseCollation("utf8_unicode_ci");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .UseCollation("utf8_unicode_ci");

                entity.Property(e => e.Picture)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''")
                    .UseCollation("utf8_unicode_ci");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("customers");

                entity.UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.City, "idx_customers_city");

                entity.HasIndex(e => e.CompanyName, "idx_customers_company_name");

                entity.HasIndex(e => e.PostalCode, "idx_customers_postalcode");

                entity.HasIndex(e => e.Region, "idx_customers_region");

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(5)
                    .HasColumnName("CustomerID")
                    .HasDefaultValueSql("''")
                    .UseCollation("utf8_unicode_ci");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(60)
                    .HasDefaultValueSql("''")
                    .UseCollation("utf8_unicode_ci");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasDefaultValueSql("''")
                    .UseCollation("utf8_unicode_ci");

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasDefaultValueSql("''")
                    .UseCollation("utf8_unicode_ci");

                entity.Property(e => e.ContactName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("'Unknown'")
                    .UseCollation("utf8_unicode_ci");

                entity.Property(e => e.ContactTitle)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''")
                    .UseCollation("utf8_unicode_ci");

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasDefaultValueSql("''")
                    .UseCollation("utf8_unicode_ci");

                entity.Property(e => e.Fax)
                    .IsRequired()
                    .HasMaxLength(24)
                    .HasDefaultValueSql("''")
                    .UseCollation("utf8_unicode_ci");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(24)
                    .HasDefaultValueSql("''")
                    .UseCollation("utf8_unicode_ci");

                entity.Property(e => e.PostalCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''")
                    .UseCollation("utf8_unicode_ci");

                entity.Property(e => e.Region)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasDefaultValueSql("''")
                    .UseCollation("utf8_unicode_ci");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("employees");

                entity.UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.ReportsTo, "idx_ReportsTo");

                entity.HasIndex(e => e.LastName, "idx_employees_lastname");

                entity.HasIndex(e => e.PostalCode, "idx_employees_postalcode");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(60)
                    .HasDefaultValueSql("''")
                    .UseCollation("utf8_unicode_ci");

                entity.Property(e => e.BirthDate).HasColumnType("datetime");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasDefaultValueSql("''")
                    .UseCollation("utf8_unicode_ci");

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasDefaultValueSql("''")
                    .UseCollation("utf8_unicode_ci");

                entity.Property(e => e.Extension)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasDefaultValueSql("''")
                    .UseCollation("utf8_unicode_ci");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''")
                    .UseCollation("utf8_unicode_ci");

                entity.Property(e => e.HireDate).HasColumnType("datetime");

                entity.Property(e => e.HomePhone)
                    .IsRequired()
                    .HasMaxLength(24)
                    .HasDefaultValueSql("''")
                    .UseCollation("utf8_unicode_ci");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''")
                    .UseCollation("utf8_unicode_ci");

                entity.Property(e => e.Notes)
                    .HasColumnType("mediumtext")
                    .UseCollation("utf8_unicode_ci");

                entity.Property(e => e.Photo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''")
                    .UseCollation("utf8_unicode_ci");

                entity.Property(e => e.PostalCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''")
                    .UseCollation("utf8_unicode_ci");

                entity.Property(e => e.Region)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasDefaultValueSql("''")
                    .UseCollation("utf8_unicode_ci");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''")
                    .UseCollation("utf8_unicode_ci");

                entity.Property(e => e.TitleOfCourtesy)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasDefaultValueSql("''")
                    .UseCollation("utf8_unicode_ci");

                entity.HasOne(d => d.ReportsToNavigation)
                    .WithMany(p => p.InverseReportsToNavigation)
                    .HasForeignKey(d => d.ReportsTo)
                    .HasConstraintName("FK_employees_reports_to");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("orders");

                entity.UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.CustomerId, "idx_FK_orders_customer_id");

                entity.HasIndex(e => e.EmployeeId, "idx_FK_orders_employeeid");

                entity.HasIndex(e => e.ShipVia, "idx_FK_orders_shipvia");

                entity.HasIndex(e => e.ShipPostalCode, "idx_orders_ship_postalcode");

                entity.HasIndex(e => e.ShippedDate, "idx_orders_shipped_date");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.CustomerId)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("CustomerID")
                    .HasDefaultValueSql("''")
                    .UseCollation("utf8_unicode_ci");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.RequiredDate).HasColumnType("datetime");

                entity.Property(e => e.ShipAddress)
                    .IsRequired()
                    .HasMaxLength(60)
                    .HasDefaultValueSql("''")
                    .UseCollation("utf8_unicode_ci");

                entity.Property(e => e.ShipCity)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasDefaultValueSql("''")
                    .UseCollation("utf8_unicode_ci");

                entity.Property(e => e.ShipCountry)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasDefaultValueSql("''")
                    .UseCollation("utf8_unicode_ci");

                entity.Property(e => e.ShipName)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasDefaultValueSql("''")
                    .UseCollation("utf8_unicode_ci");

                entity.Property(e => e.ShipPostalCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''")
                    .UseCollation("utf8_unicode_ci");

                entity.Property(e => e.ShipRegion)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasDefaultValueSql("''")
                    .UseCollation("utf8_unicode_ci");

                entity.Property(e => e.ShippedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_orders_customer_id");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_orders_employeeid");

                entity.HasOne(d => d.ShipViaNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.ShipVia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_orders_shipvia");
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.ToTable("order_details");

                entity.UseCollation("utf8_general_ci");

                entity.HasIndex(e => new { e.OrderId, e.ProductId }, "Uidx_OrderID_ProductID")
                    .IsUnique();

                entity.HasIndex(e => e.ProductId, "idx_FK_order_details_productid");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Discount).HasColumnType("float unsigned");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Quantity).HasDefaultValueSql("'1'");

                entity.Property(e => e.UnitPrice).HasColumnType("double unsigned");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_order_details_orderid");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_order_details_productid");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("products");

                entity.UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.CategoryId, "idx_FK_products_categoryid");

                entity.HasIndex(e => e.SupplierId, "idx_FK_products_supplierid");

                entity.HasIndex(e => e.ProductName, "idx_products_product_name");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Discontinued)
                    .IsRequired()
                    .HasColumnType("enum('y','n')")
                    .HasDefaultValueSql("'n'")
                    .UseCollation("utf8_unicode_ci");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasDefaultValueSql("''")
                    .UseCollation("utf8_unicode_ci");

                entity.Property(e => e.QuantityPerUnit)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''")
                    .UseCollation("utf8_unicode_ci");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_products_categoryid");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_products_supplierid");
            });

            modelBuilder.Entity<Shipper>(entity =>
            {
                entity.ToTable("shippers");

                entity.UseCollation("utf8_general_ci");

                entity.Property(e => e.ShipperId).HasColumnName("ShipperID");

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasDefaultValueSql("''")
                    .UseCollation("utf8_unicode_ci");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(24)
                    .HasDefaultValueSql("''")
                    .UseCollation("utf8_unicode_ci");
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.ToTable("suppliers");

                entity.UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.PostalCode, "idx_suppliers_postalcode");

                entity.HasIndex(e => e.CompanyName, "idx_suppliers_product_name");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(60)
                    .HasDefaultValueSql("''")
                    .UseCollation("utf8_unicode_ci");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasDefaultValueSql("''")
                    .UseCollation("utf8_unicode_ci");

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasDefaultValueSql("''")
                    .UseCollation("utf8_unicode_ci");

                entity.Property(e => e.ContactName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''")
                    .UseCollation("utf8_unicode_ci");

                entity.Property(e => e.ContactTitle)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''")
                    .UseCollation("utf8_unicode_ci");

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasDefaultValueSql("''")
                    .UseCollation("utf8_unicode_ci");

                entity.Property(e => e.Fax)
                    .IsRequired()
                    .HasMaxLength(24)
                    .HasDefaultValueSql("''")
                    .UseCollation("utf8_unicode_ci");

                entity.Property(e => e.HomePage)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(24)
                    .HasDefaultValueSql("''")
                    .UseCollation("utf8_unicode_ci");

                entity.Property(e => e.PostalCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''")
                    .UseCollation("utf8_unicode_ci");

                entity.Property(e => e.Region)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasDefaultValueSql("''")
                    .UseCollation("utf8_unicode_ci");
            });

            modelBuilder.Entity<Vw10mostExpensiveProduct>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw10most_expensive_products");

                entity.Property(e => e.TenMostExpensiveProducts)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("Ten_Most_Expensive_Products")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<VwcustomerSupplierByCity>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwcustomer_supplier_by_city");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ContactName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Relationship)
                    .IsRequired()
                    .HasMaxLength(9)
                    .HasDefaultValueSql("''")
                    .UseCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Vwinvoice>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwinvoice");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(60)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CustomerId)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("CustomerID")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Discount).HasColumnType("float unsigned");

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.PostalCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Quantity).HasDefaultValueSql("'1'");

                entity.Property(e => e.Region)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RequiredDate).HasColumnType("datetime");

                entity.Property(e => e.Salesperson)
                    .IsRequired()
                    .HasMaxLength(31)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ShipAddress)
                    .IsRequired()
                    .HasMaxLength(60)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ShipCity)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ShipCountry)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ShipName)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ShipPostalCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ShipRegion)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ShippedDate).HasColumnType("datetime");

                entity.Property(e => e.ShipperName)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.UnitPrice).HasColumnType("double unsigned");
            });

            modelBuilder.Entity<VwproductsAboveAveragePrice>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwproducts_above_average_price");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<VwquarterlyOrdersByProduct>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwquarterly_orders_by_product");

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Qtr1)
                    .HasMaxLength(61)
                    .HasColumnName("Qtr 1")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.Qtr2)
                    .HasMaxLength(61)
                    .HasColumnName("Qtr 2")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.Qtr3)
                    .HasMaxLength(61)
                    .HasColumnName("Qtr 3")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.Qtr4)
                    .HasMaxLength(61)
                    .HasColumnName("Qtr 4")
                    .UseCollation("utf8_general_ci");
            });

            modelBuilder.Entity<VwsalesByCategory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwsales_by_category");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<VwunitsInStock>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwunits_in_stock");

                entity.Property(e => e.ProductCategory)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("Product Category")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SupplierContinent)
                    .IsRequired()
                    .HasMaxLength(12)
                    .HasColumnName("Supplier Continent")
                    .HasDefaultValueSql("''")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.UnitsInStock).HasPrecision(27);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
