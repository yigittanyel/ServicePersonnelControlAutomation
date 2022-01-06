namespace ServisTakip.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class delete_gidilenguzergah_toKisi : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Kisis", "GidilenGuzergah");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Kisis", "GidilenGuzergah", c => c.String(nullable: false));
        }
    }
}
