using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Dal.Models
{
    /// <summary>
    /// Entity Framework DB Context for OnlineShop database
    /// </summary>
    public class VendingMachineDbContext : DbContext, IVendingMachineDbContext
    {
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Machine> Machine { get; set; }
        public virtual DbSet<ProductSlot> ProductSlots { get; set; }
        public virtual DbSet<Money> Moneys { get; set; }
        public virtual DbSet<MoneyInMachine> MoneysInMachine { get; set; }
        public virtual DbSet<MoneyValidate> MoneyValidate { get; set; }
        public virtual DbSet<MoneyType> MoneyTypes { get; set; }
        public VendingMachineDbContext() : base("name=VendingMachineDbContext") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
