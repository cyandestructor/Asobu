namespace Asobu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGenreToGame : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Games", "GenreId", c => c.Int());
            CreateIndex("dbo.Games", "GenreId");
            AddForeignKey("dbo.Games", "GenreId", "dbo.Genres", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Games", "GenreId", "dbo.Genres");
            DropIndex("dbo.Games", new[] { "GenreId" });
            DropColumn("dbo.Games", "GenreId");
            DropTable("dbo.Genres");
        }
    }
}
