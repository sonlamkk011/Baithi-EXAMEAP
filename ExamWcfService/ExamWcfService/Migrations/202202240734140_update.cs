namespace ExamWcfService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Employees", "MyPropertyDepartment");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "MyPropertyDepartment", c => c.String());
        }
    }
}
