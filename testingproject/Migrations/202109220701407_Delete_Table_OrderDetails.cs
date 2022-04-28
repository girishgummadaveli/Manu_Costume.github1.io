namespace testingproject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Delete_Table_OrderDetails : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.OrderDetails");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ORDERID = c.String(),
                        ORDERNAME = c.String(),
                        NAME = c.String(),
                        EMAILID = c.String(),
                        MOBILENUMBER = c.String(),
                        LOCATION = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
