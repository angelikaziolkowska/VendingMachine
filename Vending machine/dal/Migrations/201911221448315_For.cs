namespace VendingMachine.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class For : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ProductSlot", "Machine_Id", "dbo.Machine");
            DropForeignKey("dbo.Money", "Machine_Id", "dbo.Machine");
            DropIndex("dbo.ProductSlot", new[] { "Machine_Id" });
            DropIndex("dbo.Money", new[] { "Machine_Id" });
            DropIndex("dbo.MoneyInMachine", new[] { "MoneytypeRefId" });
            RenameColumn(table: "dbo.ProductSlot", name: "Machine_Id", newName: "MachineRefId");
            RenameColumn(table: "dbo.Money", name: "Machine_Id", newName: "MachineRefId");
            AlterColumn("dbo.ProductSlot", "MachineRefId", c => c.Int(nullable: true));
            AlterColumn("dbo.Money", "MachineRefId", c => c.Int(nullable: true));
            CreateIndex("dbo.ProductSlot", "MachineRefId");
            CreateIndex("dbo.Money", "MachineRefId");
            CreateIndex("dbo.MoneyInMachine", "MoneyTypeRefId");
            AddForeignKey("dbo.ProductSlot", "MachineRefId", "dbo.Machine", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Money", "MachineRefId", "dbo.Machine", "Id", cascadeDelete: false);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Money", "MachineRefId", "dbo.Machine");
            DropForeignKey("dbo.ProductSlot", "MachineRefId", "dbo.Machine");
            DropIndex("dbo.MoneyInMachine", new[] { "MoneyTypeRefId" });
            DropIndex("dbo.Money", new[] { "MachineRefId" });
            DropIndex("dbo.ProductSlot", new[] { "MachineRefId" });
            AlterColumn("dbo.Money", "MachineRefId", c => c.Int());
            AlterColumn("dbo.ProductSlot", "MachineRefId", c => c.Int());
            RenameColumn(table: "dbo.Money", name: "MachineRefId", newName: "Machine_Id");
            RenameColumn(table: "dbo.ProductSlot", name: "MachineRefId", newName: "Machine_Id");
            CreateIndex("dbo.MoneyInMachine", "MoneytypeRefId");
            CreateIndex("dbo.Money", "Machine_Id");
            CreateIndex("dbo.ProductSlot", "Machine_Id");
            AddForeignKey("dbo.Money", "Machine_Id", "dbo.Machine", "Id");
            AddForeignKey("dbo.ProductSlot", "Machine_Id", "dbo.Machine", "Id");
        }
    }
}
