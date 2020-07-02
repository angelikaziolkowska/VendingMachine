using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VendingMachine.Dal.Models
{
    public class ProductSlot
    {
        /// <summary>
        /// System-generated identity column
        /// </summary>
        [Key]
        public int Id { get; set; }

        //int that refers to CodeLetter enum
        public string Row { get; set; }

        public int Column { get; set; } 

        /// <summary>
        /// Foreign key for the Product
        /// </summary>
        [ForeignKey("Product")]
        public int ProductRefId { get; set; }
        public Product Product { get; set; }
        //public int MachineRefId { get; internal set; }

        /// <summary>
        /// Foreign key for the Product
        /// </summary>
        [ForeignKey("Machine")]
        public int MachineRefId { get; set; }
        public Machine Machine { get; set; }

    }
}