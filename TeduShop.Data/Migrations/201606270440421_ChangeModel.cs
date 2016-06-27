namespace TeduShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "CreatedDate", c => c.DateTime());
            AddColumn("dbo.ProductCategories", "CreatedDate", c => c.DateTime());
            AddColumn("dbo.PostCategories", "CreatedDate", c => c.DateTime());
            AddColumn("dbo.Posts", "CreatedDate", c => c.DateTime());
            DropColumn("dbo.Products", "CreatedTime");
            DropColumn("dbo.ProductCategories", "CreatedTime");
            DropColumn("dbo.PostCategories", "CreatedTime");
            DropColumn("dbo.Posts", "CreatedTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Posts", "CreatedTime", c => c.DateTime());
            AddColumn("dbo.PostCategories", "CreatedTime", c => c.DateTime());
            AddColumn("dbo.ProductCategories", "CreatedTime", c => c.DateTime());
            AddColumn("dbo.Products", "CreatedTime", c => c.DateTime());
            DropColumn("dbo.Posts", "CreatedDate");
            DropColumn("dbo.PostCategories", "CreatedDate");
            DropColumn("dbo.ProductCategories", "CreatedDate");
            DropColumn("dbo.Products", "CreatedDate");
        }
    }
}
