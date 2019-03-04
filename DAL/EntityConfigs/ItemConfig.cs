using System.Data.Entity.ModelConfiguration;
using DAL.Entities;

namespace DAL.EntityConfigs
{
    public class ItemConfig : EntityTypeConfiguration<Item>
    {
        public ItemConfig()
        {
            this.ToTable("tbl_items").HasKey(item => item.Id);
            this.Property(item => item.Id).HasColumnName("cln_item_id");
            this.Property(item => item.Description).HasColumnName("cln_item_description");
            this.Property(item => item.Price).HasColumnName("cln_item_price");

            this.HasMany(item => item.OrderItems)
                .WithRequired(oi => oi.Item)
                .HasForeignKey(oi => oi.ItemId);
        }
    }
}
