namespace Asobu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAddedDateToGame : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Games", "DateAdded", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Games", "DateAdded");
        }
    }
}
