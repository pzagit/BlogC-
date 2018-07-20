namespace BlogRough.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ImageFile : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Post", "ImageFile", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Post", "ImageFile");
        }
    }
}
