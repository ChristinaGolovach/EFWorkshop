namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tbl_items",
                c => new
                    {
                        cln_item_id = c.Int(nullable: false, identity: true),
                        cln_item_description = c.String(),
                        cln_item_price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.cln_item_id);

            Sql(@"SET IDENTITY_INSERT dbo.tbl_items ON " +                
                "INSERT INTO dbo.tbl_items (cln_item_id, cln_item_description, cln_item_price) " +
                "VALUES (563, '56'' Blue Freen', 3.50), " +
                       "(652, '3'' Red Freen', 0.25 ), " +
                       "(851, 'Spline End (Xtra Large)', 12.00) " +
                 "SET IDENTITY_INSERT dbo.tbl_items OFF");
            
        }

        
        
        public override void Down()
        {
            DropTable("dbo.tbl_items");
        }
    }
}
