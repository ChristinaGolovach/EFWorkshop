namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OrderItemMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tbl_order_items", "cln_order_item_quantity", c => c.Int(nullable: false));

            Sql("UPDATE dbo.tbl_order_items SET cln_order_item_quantity = 4 WHERE cln_order_id = 125 AND cln_item_id = 563");
            Sql("UPDATE dbo.tbl_order_items SET cln_order_item_quantity = 5 WHERE cln_order_id = 125 AND cln_item_id = 652");
            Sql("UPDATE dbo.tbl_order_items SET cln_order_item_quantity = 32 WHERE cln_order_id = 125 AND cln_item_id = 851");
            Sql("UPDATE dbo.tbl_order_items SET cln_order_item_quantity = 500 WHERE cln_order_id = 126 AND cln_item_id = 563");
            Sql("UPDATE dbo.tbl_order_items SET cln_order_item_quantity = 700 WHERE cln_order_id = 126 AND cln_item_id = 652");

        }
        
        public override void Down()
        {
            DropColumn("dbo.tbl_order_items", "cln_order_item_quantity");
        }
    }
}
