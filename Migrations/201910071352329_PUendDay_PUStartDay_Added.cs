namespace TrashCollectorRemade.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PUendDay_PUStartDay_Added : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "PickUpStartDay", c => c.String());
            AddColumn("dbo.Customers", "PickUpEndDay", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "PickUpEndDay");
            DropColumn("dbo.Customers", "PickUpStartDay");
        }
    }
}
