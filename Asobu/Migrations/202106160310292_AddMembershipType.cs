namespace Asobu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMembershipType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MembershipTypes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        SignUpFee = c.Short(nullable: false),
                        DurationInMonths = c.Byte(nullable: false),
                        DiscountRate = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Players", "MembershipTypeId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Players", "MembershipTypeId");
            AddForeignKey("dbo.Players", "MembershipTypeId", "dbo.MembershipTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Players", "MembershipTypeId", "dbo.MembershipTypes");
            DropIndex("dbo.Players", new[] { "MembershipTypeId" });
            DropColumn("dbo.Players", "MembershipTypeId");
            DropTable("dbo.MembershipTypes");
        }
    }
}
