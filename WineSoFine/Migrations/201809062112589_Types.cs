namespace WineSoFine.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Types : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Red')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'White')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Rose')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (4, 'Sparkling')");
        }
        
        public override void Down()
        {
        }
    }
}
