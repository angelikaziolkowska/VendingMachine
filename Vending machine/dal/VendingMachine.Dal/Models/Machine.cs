using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VendingMachine.Dal.Models
{
    public class Machine
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
        /// Name of the image as it is saved as
        /// </summary>
        [MaxLength(256)]
        public string ImageName { get; set; }

        public List<Product> VendedProducts { get; set; }

        //public List<string> ButtonsPressed { get; set; }

        public string Button1 { get; set;}

        public string Button2 { get; set; }

        public int Message { get; set; }

        /// <summary>
        /// List of money for the return pile
        /// </summary>
        [JsonIgnore]
        public ICollection<Money> ReturnedMoney { get; protected set; } = new List<Money>();

        /// <summary>
        /// Collection of all slots, just so all stock is in one
        /// </summary>
        [JsonIgnore]
        public ICollection<ProductSlot> ProductSlots { get; protected set; } = new List<ProductSlot>();
    }
}