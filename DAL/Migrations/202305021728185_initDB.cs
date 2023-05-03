namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DeliveryMen",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UN = c.Int(nullable: false),
                        Phone = c.String(nullable: false),
                        Password = c.String(nullable: false, maxLength: 100),
                        Address = c.String(nullable: false, maxLength: 200),
                        AddedBy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Restaurants", t => t.AddedBy, cascadeDelete: true)
                .Index(t => t.AddedBy);
            
            CreateTable(
                "dbo.Restaurants",
                c => new
                    {
                        UN = c.Int(nullable: false, identity: true),
                        Address = c.String(nullable: false, maxLength: 50),
                        Phone = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.UN);
            
            CreateTable(
                "dbo.Menu_Items",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(nullable: false, maxLength: 500),
                        Price = c.String(nullable: false, maxLength: 200),
                        AddedBy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Restaurants", t => t.AddedBy, cascadeDelete: true)
                .Index(t => t.AddedBy);
            
            CreateTable(
                "dbo.Order_Items",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Quantity = c.String(nullable: false, maxLength: 500),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DeliveryMen", "AddedBy", "dbo.Restaurants");
            DropForeignKey("dbo.Menu_Items", "AddedBy", "dbo.Restaurants");
            DropIndex("dbo.Menu_Items", new[] { "AddedBy" });
            DropIndex("dbo.DeliveryMen", new[] { "AddedBy" });
            DropTable("dbo.Order_Items");
            DropTable("dbo.Menu_Items");
            DropTable("dbo.Restaurants");
            DropTable("dbo.DeliveryMen");
        }
    }
}
