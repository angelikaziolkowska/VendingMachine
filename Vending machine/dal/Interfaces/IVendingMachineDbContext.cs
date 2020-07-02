using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Dal.Models;

namespace VendingMachine.Dal
{
    public interface IVendingMachineDbContext
    {
        DbSet<Product> Products { get; set; }
        DbSet<Machine> Machine { get; set; }
        DbSet<ProductSlot> ProductSlots { get; set; }
        DbSet<Money> Moneys { get; set; }
        DbSet<MoneyType> MoneyTypes { get; set; }
        DbSet<MoneyValidate> MoneyValidate { get; set; }
        DbSet<MoneyInMachine> MoneysInMachine { get; set; }
    }
}
