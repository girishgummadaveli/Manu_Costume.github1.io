namespace testingproject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Table_OrderDetails : DbMigration
    {
        public override void Up()
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
        
        public override void Down()
        {
            DropTable("dbo.OrderDetails");
        }
    }
}
