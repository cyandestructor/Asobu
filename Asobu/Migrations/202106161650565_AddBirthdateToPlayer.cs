namespace Asobu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBirthdateToPlayer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Players", "Birthdate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Players", "Birthdate");
        }
    }
}
