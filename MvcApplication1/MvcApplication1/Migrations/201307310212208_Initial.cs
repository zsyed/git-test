namespace MvcApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Employees", "TestColumn");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "TestColumn", c => c.String());
        }
    }
}
