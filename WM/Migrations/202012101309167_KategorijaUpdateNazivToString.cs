namespace WM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class KategorijaUpdateNazivToString : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Kategorijas", "Naziv", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Kategorijas", "Naziv", c => c.Int(nullable: false));
        }
    }
}
