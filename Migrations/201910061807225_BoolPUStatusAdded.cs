namespace TrashCollectorRemade.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BoolPUStatusAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "PickUpStatus", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "PickUpStatus");
        }
    }
}
