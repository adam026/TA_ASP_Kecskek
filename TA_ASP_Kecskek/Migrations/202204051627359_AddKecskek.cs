namespace TA_ASP_Kecskek.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddKecskek : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kecskek",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nev = c.String(),
                        Kor = c.Int(nullable: false),
                        Szin = c.String(),
                        Kep = c.String(),
                        HotDeal = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Kecskek");
        }
    }
}
