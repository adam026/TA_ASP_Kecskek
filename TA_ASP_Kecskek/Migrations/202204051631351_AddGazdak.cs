namespace TA_ASP_Kecskek.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGazdak : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Gazdak",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SzulDatum = c.DateTime(),
                        Nev = c.String(),
                        IrSzam = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Gazdak");
        }
    }
}
