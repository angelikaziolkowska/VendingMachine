using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VendingMachine.Dal.Models
{
    public class Product
    {
        /// <summary>
        /// System-generated identity column
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Name of the product
        /// </summary>
        [MaxLength(256)]
        public string Name { get; set; }

        /// <summary>
        /// Price of the product
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Name of the image as it is saved as
        /// </summary>
        [MaxLength(256)]
        public string ImageName { get; set; }

        /// <summary>
        /// List of vehicles for this manufacturer
        /// </summary>
        //public ICollection<ProductSlot> ProductSlots { get; protected set; } = new List<ProductSlot>();
    }
}