namespace WM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Dobavljacs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Naziv = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Kategorijas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Naziv = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Proizvods",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Naziv = c.String(),
                        Opis = c.String(),
                        KategorijaId = c.Int(nullable: false),
                        Proizvodjac = c.String(),
                        DobavljacId = c.Int(nullable: false),
                        Cena = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Dobavljacs", t => t.DobavljacId, cascadeDelete: true)
                .ForeignKey("dbo.Kategorijas", t => t.KategorijaId, cascadeDelete: true)
                .Index(t => t.KategorijaId)
                .Index(t => t.DobavljacId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Proizvods", "KategorijaId", "dbo.Kategorijas");
            DropForeignKey("dbo.Proizvods", "DobavljacId", "dbo.Dobavljacs");
            DropIndex("dbo.Proizvods", new[] { "DobavljacId" });
            DropIndex("dbo.Proizvods", new[] { "KategorijaId" });
            DropTable("dbo.Proizvods");
            DropTable("dbo.Kategorijas");
            DropTable("dbo.Dobavljacs");
        }
    }
}
