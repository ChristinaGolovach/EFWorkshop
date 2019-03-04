using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using DAL.Entities;

namespace DAL.EntityConfigs
{
    public class OrderItemConfig : EntityTypeConfiguration<OrderItem>
    {
        public OrderItemConfig()
        {
            this.ToTable("dbo.tbl_order_items").HasKey(oi => new { oi.OrderId, oi.ItemId });
            this.Property(oi => oi.OrderId).HasColumnName("cln_order_id");
            this.Property(oi => oi.ItemId).HasColumnName("cln_item_id");
            this.Property(oi => oi.Quantity).HasColumnName("cln_order_item_quantity");

            //this.HasRequired(oi => oi.Order)
            //    .WithMany(o => o.OrderItems)
            //    .HasForeignKey(oi => oi.OrderId);

            //this.HasRequired(oi => oi.Item)
            //    .WithMany(i => i.OrderItems)
            //    .HasForeignKey(oi => oi.ItemId);
                
        }
    }
}
