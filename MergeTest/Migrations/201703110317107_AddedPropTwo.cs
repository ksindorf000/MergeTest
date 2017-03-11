namespace MergeTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedPropTwo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Trips", "TestPropTwo", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Trips", "TestPropTwo");
        }
    }
}
