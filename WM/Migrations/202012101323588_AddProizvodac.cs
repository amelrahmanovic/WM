namespace WM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProizvodac : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Proizvodacs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Naziv = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Proizvodacs");
        }
    }
}
