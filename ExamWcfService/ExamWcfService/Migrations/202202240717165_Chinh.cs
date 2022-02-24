namespace ExamWcfService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Chinh : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false, identity: true),
                        EmployeeName = c.String(),
                        EmployeeSalary = c.String(),
                        MyPropertyDepartment = c.String(),
                        Department = c.String(),
                    })
                .PrimaryKey(t => t.EmployeeId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employees");
        }
    }
}
