namespace Asobu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Name) VALUES ('Action')");
            Sql("INSERT INTO Genres (Name) VALUES ('Adventure')");
            Sql("INSERT INTO Genres (Name) VALUES ('Shooter')");
            Sql("INSERT INTO Genres (Name) VALUES ('Sandbox')");
            Sql("INSERT INTO Genres (Name) VALUES ('Fighting')");
            Sql("INSERT INTO Genres (Name) VALUES ('Puzzle')");
        }
        
        public override void Down()
        {
        }
    }
}
