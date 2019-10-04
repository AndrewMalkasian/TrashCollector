namespace TrashCollectorRemade.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BalanceAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Balance", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Balance");
        }
    }
}
