namespace testingproject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_Two_More_Column_In_Order_Details : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OrderDetails", "Updated_User", c => c.String());
            AddColumn("dbo.OrderDetails", "Updated_Date", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.OrderDetails", "Updated_Date");
            DropColumn("dbo.OrderDetails", "Updated_User");
        }
    }
}
