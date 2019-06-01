namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Urls", "Key", c => c.String(nullable: false, maxLength: 5));
            AlterColumn("dbo.Urls", "LongUrl", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Urls", "ShortUrl", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Urls", "CreateDateTime", c => c.String(nullable: false, maxLength: 19));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Urls", "CreateDateTime", c => c.String(maxLength: 19));
            AlterColumn("dbo.Urls", "ShortUrl", c => c.String(maxLength: 100));
            AlterColumn("dbo.Urls", "LongUrl", c => c.String(maxLength: 100));
            DropColumn("dbo.Urls", "Key");
        }
    }
}
