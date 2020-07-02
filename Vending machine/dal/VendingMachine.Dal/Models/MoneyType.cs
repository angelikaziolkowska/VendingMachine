using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VendingMachine.Dal.Models
{
    public class MoneyType
    {
        /// <summary>
        /// System-generated identity column
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Name of the image as it is saved as
        /// </summary>
        [MaxLength(256)]
        public string Name { get; set; }

        /// <summary>
        /// List of vehicles for this manufacturer
        /// </summary>
        [JsonIgnore]
        public ICollection<Money> Moneys { get; protected set; } = new List<Money>();
    }
}