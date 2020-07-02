using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VendingMachine.Dal.Models
{
    public class Money
    {
        /// <summary>
        /// System-generated identity column
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// The value of the coin or note
        /// </summary>
        public double Value { get; set; }

        /// <summary>
        /// Name of the image as it is saved as
        /// </summary>
        [MaxLength(256)]
        public string ImageName { get; set; }

        /// <summary>
        /// Foreign key for the CodeLetter
        /// </summary>
        [ForeignKey("MoneyType")]
        public int MoneyTypeRefId { get; set; }
        public MoneyType MoneyType { get; set; }

        /// <summary>
        /// Foreign key for the CodeLetter
        /// </summary>
        [ForeignKey("MoneyValidate")]
        public int MoneyValidateRefId { get; set; }
        public MoneyValidate MoneyValidate { get; set; }

        ///// <summary>
        ///// Foreign key for the CodeLetter
        ///// </summary>
        [ForeignKey("Machine")]
        public int MachineRefId { get; set; }
        public Machine Machine { get; set; }
    }
}