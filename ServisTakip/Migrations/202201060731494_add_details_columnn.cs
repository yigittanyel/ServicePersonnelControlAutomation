namespace ServisTakip.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_details_columnn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Servis", "GuzergahDetay", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Servis", "GuzergahDetay");
        }
    }
}
