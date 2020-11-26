namespace PreViewImport.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SettingTableAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Settings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Logo = c.String(),
                        Email = c.String(nullable: false, maxLength: 50),
                        Phone = c.String(nullable: false, maxLength: 50),
                        Address = c.String(nullable: false, maxLength: 150),
                        Facebook = c.String(),
                        Linkedin = c.String(),
                        Slogan = c.String(),
                        Lat = c.String(),
                        Long = c.String(),
                        OpeningHours = c.DateTime(nullable: false),
                        ClosingHours = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Settings");
        }
    }
}
