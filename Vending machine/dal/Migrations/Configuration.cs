namespace VendingMachine.Dal.Migrations
{
    using System;
    using System.ComponentModel;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using VendingMachine.Dal.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<VendingMachine.Dal.Models.VendingMachineDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(VendingMachine.Dal.Models.VendingMachineDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            if (!context.Machine.Any())
            {
                context.Machine.AddOrUpdate(new Machine()
                {
                    Name = "Inter-Galactic Vendoor",
                    ImageName = null,
                    Message = (int)Message.None,
                    Button1 = null,
                    Button2 = null,
                    VendedProducts = null,
                });
            }
            if (!context.MoneyTypes.Any())
            {
                context.MoneyTypes.AddOrUpdate(new MoneyType()
                {
                    Name = "Coin"
                });
                context.MoneyTypes.AddOrUpdate(new MoneyType()
                {
                    Name = "Note"
                });
                context.MoneyTypes.AddOrUpdate(new MoneyType()
                {
                    Name = "NotAcceptable"
                });
            }
            if (!context.MoneyValidate.Any())
            {
                context.MoneyValidate.AddOrUpdate(new MoneyValidate()
                {
                    Name = "Accepted"
                });
                context.MoneyValidate.AddOrUpdate(new MoneyValidate()
                {
                    Name = "Rejected"
                });
            }
            if (!context.Moneys.Any())
            {
                context.Moneys.AddOrUpdate(new Money()
                {
                    Value = 0.05f,
                    ImageName = "5p.jpg",
                    MoneyTypeRefId = 1,
                    MoneyValidateRefId = 1,
                    MachineRefId = 1
                });
                context.Moneys.AddOrUpdate(new Money()
                {
                    Value = 0.10f,
                    ImageName = "10p.jpg",
                    MoneyTypeRefId = 1,
                    MoneyValidateRefId = 1,
                    MachineRefId = 1
                });
                context.Moneys.AddOrUpdate(new Money()
                {
                    Value = 0.20f,
                    ImageName = "20p.jpg",
                    MoneyTypeRefId = 1,
                    MoneyValidateRefId = 1,
                    MachineRefId = 1
                });
                context.Moneys.AddOrUpdate(new Money()
                {
                    Value = 0.50f,
                    ImageName = "50p.jpg",
                    MoneyTypeRefId = 1,
                    MoneyValidateRefId = 1,
                    MachineRefId = 1
                });
                context.Moneys.AddOrUpdate(new Money()
                {
                    Value = 1,
                    ImageName = "1pound.jpg",
                    MoneyTypeRefId = 1,
                    MoneyValidateRefId = 1,
                    MachineRefId = 1
                });
                context.Moneys.AddOrUpdate(new Money()
                {
                    Value = 2,
                    ImageName = "2pound.jpg",
                    MoneyTypeRefId = 1,
                    MoneyValidateRefId = 1,
                    MachineRefId = 1
                });
                context.Moneys.AddOrUpdate(new Money()
                {
                    Value = 5,
                    ImageName = "5pound.jpg",
                    MoneyTypeRefId = 2,
                    MoneyValidateRefId = 1,
                    MachineRefId = 1
                });
                context.Moneys.AddOrUpdate(new Money()
                {
                    Value = 10,
                    ImageName = "10pound.jpg",
                    MoneyTypeRefId = 2,
                    MoneyValidateRefId = 1,
                    MachineRefId = 1
                });
                context.Moneys.AddOrUpdate(new Money()
                {
                    Value = 0.01f,
                    ImageName = "1p.jpg",
                    MoneyTypeRefId = 3,
                    MoneyValidateRefId = 2,
                    MachineRefId = 1
                });
                context.Moneys.AddOrUpdate(new Money()
                {
                    Value = 0.02f,
                    ImageName = "2p.jpg",
                    MoneyTypeRefId = 3,
                    MoneyValidateRefId = 2,
                    MachineRefId = 1
                });
            }
            if (!context.Products.Any())
            {
                context.Products.AddOrUpdate(new Product()
                {
                    Name = null,
                    Price = 0,
                    ImageName = "x.jpg",

                });
                context.Products.AddOrUpdate(new Product()
                {
                    Name = "Pop Eleven",
                    Price = 19.95f,
                    ImageName = "elevenpopfigure.jpg",

                });
                context.Products.AddOrUpdate(new Product()
                {
                    Name = "Floppy Disc Coasters",
                    Price = 12.50f,
                    ImageName = "floppydisccoasters.jpg",
                });
                context.Products.AddOrUpdate(new Product()
                {
                    Name = "2019 Bubble Wrap Calendar",
                    Price = 20.95f,
                    ImageName = "bubblewrapcalendar.jpg",
                });
                context.Products.AddOrUpdate(new Product()
                {
                    Name = "NES Mini",
                    Price = 76,
                    ImageName = "nesmini.jpg",
                });
                context.Products.AddOrUpdate(new Product()
                {
                    Name = "AirSelfie AS2",
                    Price = 299.95f,
                    ImageName = "selfieflyingcamera.jpg",
                });
                context.Products.AddOrUpdate(new Product()
                {
                    Name = "Lego Falcon",
                    Price = 1099.95f,
                    ImageName = "legofalcon.jpg",
                });
                context.Products.AddOrUpdate(new Product()
                {
                    Name = "Arduino Starter Kit",
                    Price = 126,
                    ImageName = "arduinostarterkit.jpg",
                });
                context.Products.AddOrUpdate(new Product()
                {
                    Name = "Einstein DNA Sample",
                    Price = 6000000000,
                    ImageName = "dna.jpg",
                });
                context.Products.AddOrUpdate(new Product()
                {
                    Name = "Rick & Morty Stickers",
                    Price = 3.45f,
                    ImageName = "rickandmortystickers.jpg",
                });
                context.Products.AddOrUpdate(new Product()
                {
                    Name = "Steampunk Skull",
                    Price = 26.50f,
                    ImageName = "skull.jpg"
                });
            }
            if (!context.ProductSlots.Any())
            {
                context.ProductSlots.AddOrUpdate(new ProductSlot()
                {
                    ProductRefId = 2,
                    Row = "A",
                    Column = 0,
                    MachineRefId = 1
                });
                context.ProductSlots.AddOrUpdate(new ProductSlot()
                {
                    ProductRefId = 2,
                    Row = "A",
                    Column = 1,
                    MachineRefId = 1
                });
                context.ProductSlots.AddOrUpdate(new ProductSlot()
                {
                    ProductRefId = 3,
                    Row = "A",
                    Column = 2,
                    MachineRefId = 1
                });
                context.ProductSlots.AddOrUpdate(new ProductSlot()
                {
                    ProductRefId = 3,
                    Row = "A",
                    Column = 3,
                    MachineRefId = 1
                });
                context.ProductSlots.AddOrUpdate(new ProductSlot()
                {
                    ProductRefId = 4,
                    Row = "A",
                    Column = 4,
                    MachineRefId = 1
                });
                context.ProductSlots.AddOrUpdate(new ProductSlot()
                {
                    ProductRefId = 4,
                    Row = "A",
                    Column = 5,
                    MachineRefId = 1
                });
                context.ProductSlots.AddOrUpdate(new ProductSlot()
                {
                    ProductRefId = 5,
                    Row = "A",
                    Column = 6,
                    MachineRefId = 1
                });
                context.ProductSlots.AddOrUpdate(new ProductSlot()
                {
                    ProductRefId = 5,
                    Row = "A",
                    Column = 7,
                    MachineRefId = 1
                });
                context.ProductSlots.AddOrUpdate(new ProductSlot()
                {
                    ProductRefId = 6,
                    Row = "B",
                    Column = 0,
                    MachineRefId = 1
                });
                context.ProductSlots.AddOrUpdate(new ProductSlot()
                {
                    ProductRefId = 6,
                    Row = "B",
                    Column = 1,
                    MachineRefId = 1
                });
                context.ProductSlots.AddOrUpdate(new ProductSlot()
                {
                    ProductRefId = 7,
                    Row = "B",
                    Column = 2,
                    MachineRefId = 1
                });
                context.ProductSlots.AddOrUpdate(new ProductSlot()
                {
                    ProductRefId = 7,
                    Row = "B",
                    Column = 3,
                    MachineRefId = 1
                });
                context.ProductSlots.AddOrUpdate(new ProductSlot()
                {
                    ProductRefId = 8,
                    Row = "B",
                    Column = 4,
                    MachineRefId = 1
                });
                context.ProductSlots.AddOrUpdate(new ProductSlot()
                {
                    ProductRefId = 1,
                    Row = "B",
                    Column = 5,
                    MachineRefId = 1
                });
                context.ProductSlots.AddOrUpdate(new ProductSlot()
                {
                    ProductRefId = 9,
                    Row = "B",
                    Column = 6,
                    MachineRefId = 1
                });
                context.ProductSlots.AddOrUpdate(new ProductSlot()
                {
                    ProductRefId = 10,
                    Row = "B",
                    Column = 7,
                    MachineRefId = 1
                });
                context.ProductSlots.AddOrUpdate(new ProductSlot()
                {
                    ProductRefId = 10,
                    Row = "C",
                    Column = 0,
                    MachineRefId = 1
                });
                context.ProductSlots.AddOrUpdate(new ProductSlot()
                {
                    ProductRefId = 2,
                    Row = "C",
                    Column = 1,
                    MachineRefId = 1
                });
                context.ProductSlots.AddOrUpdate(new ProductSlot()
                {
                    ProductRefId = 11,
                    Row = "C",
                    Column = 2,
                    MachineRefId = 1
                });
                context.ProductSlots.AddOrUpdate(new ProductSlot()
                {
                    ProductRefId = 1,
                    Row = "C",
                    Column = 3,
                    MachineRefId = 1
                });
                context.ProductSlots.AddOrUpdate(new ProductSlot()
                {
                    ProductRefId = 1,
                    Row = "C",
                    Column = 4,
                    MachineRefId = 1
                });
                context.ProductSlots.AddOrUpdate(new ProductSlot()
                {
                    ProductRefId = 1,
                    Row = "C",
                    Column = 5,
                    MachineRefId = 1
                });
                context.ProductSlots.AddOrUpdate(new ProductSlot()
                {
                    ProductRefId = 3,
                    Row = "C",
                    Column = 6,
                    MachineRefId = 1
                });
                context.ProductSlots.AddOrUpdate(new ProductSlot()
                {
                    ProductRefId = 4,
                    Row = "C",
                    Column = 7,
                    MachineRefId = 1
                });
            }
        }
    }
}


