namespace TrashCollectorRemade.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SinglePickUpDay : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "SpecialOneTimePickUp", c => c.String());
            AddColumn("dbo.Employees", "PickUpDay", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "PickUpDay");
            DropColumn("dbo.Customers", "SpecialOneTimePickUp");
        }
    }
}
