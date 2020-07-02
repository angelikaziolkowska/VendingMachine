namespace VendingMachine.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Machine",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 256),
                        Price = c.Single(nullable: false),
                        ImageName = c.String(maxLength: 256),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Money",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Value = c.Single(nullable: false),
                        ImageName = c.String(maxLength: 256),
                        MoneyTypeRefId = c.Int(nullable: false),
                        MoneyValidate_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MoneyType", t => t.MoneyTypeRefId, cascadeDelete: true)
                .ForeignKey("dbo.MoneyValidate", t => t.MoneyValidate_Id)
                .Index(t => t.MoneyTypeRefId)
                .Index(t => t.MoneyValidate_Id);
            
            CreateTable(
                "dbo.MoneyType",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MoneyInMachine",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MoneyRefId = c.Int(nullable: false),
                        MoneyValidateRefId = c.Int(nullable: false),
                        MachineRefId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Machine", t => t.MachineRefId, cascadeDelete: true)
                .ForeignKey("dbo.Money", t => t.MoneyRefId, cascadeDelete: true)
                .ForeignKey("dbo.MoneyValidate", t => t.MoneyValidateRefId, cascadeDelete: true)
                .Index(t => t.MoneyRefId)
                .Index(t => t.MoneyValidateRefId)
                .Index(t => t.MachineRefId);
            
            CreateTable(
                "dbo.MoneyValidate",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 256),
                        Price = c.Single(nullable: false),
                        ImageName = c.String(maxLength: 256),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProductSlot",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Row = c.Int(nullable: false),
                        Column = c.Int(nullable: false),
                        ProductRefId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Product", t => t.ProductRefId, cascadeDelete: true)
                .Index(t => t.ProductRefId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductSlot", "ProductRefId", "dbo.Product");
            DropForeignKey("dbo.MoneyInMachine", "MoneyValidateRefId", "dbo.MoneyValidate");
            DropForeignKey("dbo.Money", "MoneyValidate_Id", "dbo.MoneyValidate");
            DropForeignKey("dbo.MoneyInMachine", "MoneyRefId", "dbo.Money");
            DropForeignKey("dbo.MoneyInMachine", "MachineRefId", "dbo.Machine");
            DropForeignKey("dbo.Money", "MoneyTypeRefId", "dbo.MoneyType");
            DropIndex("dbo.ProductSlot", new[] { "ProductRefId" });
            DropIndex("dbo.MoneyInMachine", new[] { "MachineRefId" });
            DropIndex("dbo.MoneyInMachine", new[] { "MoneyValidateRefId" });
            DropIndex("dbo.MoneyInMachine", new[] { "MoneyRefId" });
            DropIndex("dbo.Money", new[] { "MoneyValidate_Id" });
            DropIndex("dbo.Money", new[] { "MoneyTypeRefId" });
            DropTable("dbo.ProductSlot");
            DropTable("dbo.Product");
            DropTable("dbo.MoneyValidate");
            DropTable("dbo.MoneyInMachine");
            DropTable("dbo.MoneyType");
            DropTable("dbo.Money");
            DropTable("dbo.Machine");
        }
    }
}
