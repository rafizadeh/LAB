namespace PreViewImport.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DoctorSlugColAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Doctors", "Slug", c => c.String(nullable: false, maxLength: 200));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Doctors", "Slug");
        }
    }
}
