namespace WcfServiceEAP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Employee_EAP : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false, identity: true),
                        EmployeeName = c.String(),
                        Salary = c.Double(nullable: false),
                        Deparment = c.String(),
                    })
                .PrimaryKey(t => t.EmployeeId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employees");
        }
    }
}
