namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FKPKDeptCourse : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "DId", c => c.Int(nullable: false));
            CreateIndex("dbo.Courses", "DId");
            AddForeignKey("dbo.Courses", "DId", "dbo.Departments", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "DId", "dbo.Departments");
            DropIndex("dbo.Courses", new[] { "DId" });
            DropColumn("dbo.Courses", "DId");
        }
    }
}
