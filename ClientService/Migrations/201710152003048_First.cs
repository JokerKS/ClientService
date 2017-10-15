namespace ClientService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        ClientId = c.Int(nullable: false, identity: true),
                        ClientName = c.String(),
                        Account = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        PlaceOfBirth = c.String(),
                        AddDate = c.DateTime(nullable: false),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Vip = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ClientId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Clients");
        }
    }
}
