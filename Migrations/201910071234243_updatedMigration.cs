namespace TrashCollectorRemade.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "PickUpStatus", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "PickUpStatus");
        }
    }
}
