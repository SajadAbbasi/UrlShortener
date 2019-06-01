namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Urls",
                c => new
                    {
                        UrlId = c.Long(nullable: false, identity: true),
                        LongUrl = c.String(nullable: false, maxLength: 100),
                        ShortUrl = c.String(maxLength: 100),
                        CreateDateTime = c.String(maxLength: 19),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.UrlId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Urls");
        }
    }
}
