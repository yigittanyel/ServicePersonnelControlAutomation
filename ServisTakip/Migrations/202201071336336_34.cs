namespace ServisTakip.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _34 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Servis", "GidilenGuzergah", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Servis", "GidilenGuzergah", c => c.String(nullable: false));
        }
    }
}
