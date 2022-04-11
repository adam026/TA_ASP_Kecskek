namespace TA_ASP_Kecskek.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedGazdakAndKecskek : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Kecskek VALUES ('Zylonna',3,'barna','zylonna.png','false')");
            Sql("INSERT INTO Kecskek VALUES ('Riley',4,'fekete','riley.png','false')");
            Sql("INSERT INTO Kecskek VALUES ('Skooter',4,'voros','skooter.png','false')");
            Sql("INSERT INTO Kecskek VALUES ('Hailey',3,'barna','hailey.png','false')");
            Sql("INSERT INTO Kecskek VALUES ('Jeremy',1,'feher','jeremy.png','true')");

            Sql("INSERT INTO Gazdak VALUES ('1982-04-21','Cserepes Virág',2660)");
            Sql("INSERT INTO Gazdak VALUES ('1991-07-11','Lapos Elemér',1139)");
            Sql("INSERT INTO Gazdak VALUES ('1978-01-12','Villányi Borbála',2687)");
        }

        public override void Down()
        {
        }
    }
}
