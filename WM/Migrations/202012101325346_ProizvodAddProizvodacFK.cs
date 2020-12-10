namespace WM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProizvodAddProizvodacFK : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Proizvods", "ProizvodacId", c => c.Int(nullable: false));
            CreateIndex("dbo.Proizvods", "ProizvodacId");
            AddForeignKey("dbo.Proizvods", "ProizvodacId", "dbo.Proizvodacs", "Id", cascadeDelete: true);
            DropColumn("dbo.Proizvods", "Proizvodjac");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Proizvods", "Proizvodjac", c => c.String());
            DropForeignKey("dbo.Proizvods", "ProizvodacId", "dbo.Proizvodacs");
            DropIndex("dbo.Proizvods", new[] { "ProizvodacId" });
            DropColumn("dbo.Proizvods", "ProizvodacId");
        }
    }
}
