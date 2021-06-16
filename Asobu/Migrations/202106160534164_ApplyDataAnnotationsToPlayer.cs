namespace Asobu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplyDataAnnotationsToPlayer : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Players", "Username", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Players", "Username", c => c.String());
        }
    }
}
