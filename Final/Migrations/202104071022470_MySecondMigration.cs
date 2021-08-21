namespace Final.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MySecondMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "RegisterAs", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "RegisterAs");
        }
    }
}
