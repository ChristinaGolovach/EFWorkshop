using System.Data.Entity.ModelConfiguration;
using DAL.Entities;

namespace DAL.EntityConfigs
{
    public class OrderConfig : EntityTypeConfiguration<Order>
    {
        public OrderConfig()
        {
            this.ToTable("tbl_orders").HasKey(order => order.Id);
            this.Property(order => order.Id).HasColumnName("cln_order_id");
            this.Property(order => order.Date).HasColumnName("cln_order_date");
            this.Property(order => order.CustomerId).HasColumnName("cln_order_customer_id");

            this.HasMany(order => order.OrderItems)
                .WithRequired(oi => oi.Order)
                .HasForeignKey(oi => oi.OrderId);

            // For step 2
            //this.HasMany(order => order.Items).WithMany(item => item.Orders)
            //    .Map(io =>
            //    {
            //        io.MapLeftKey("cln_order_id");
            //        io.MapRightKey("cln_item_id");
            //        io.ToTable("tbl_order_items");
            //    });
        }
    }
}
