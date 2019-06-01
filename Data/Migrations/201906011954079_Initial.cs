namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Urls", "Click", c => c.Long(nullable: false));
            AlterColumn("dbo.Urls", "LongUrl", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Urls", "LongUrl", c => c.String(nullable: false, maxLength: 100));
            DropColumn("dbo.Urls", "Click");
        }
    }
}
