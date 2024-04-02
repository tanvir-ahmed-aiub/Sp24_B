namespace IntroEFCF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PKFKCategoryProduct : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "C_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Products", "C_Id");
            AddForeignKey("dbo.Products", "C_Id", "dbo.Categories", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "C_Id", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "C_Id" });
            DropColumn("dbo.Products", "C_Id");
        }
    }
}
