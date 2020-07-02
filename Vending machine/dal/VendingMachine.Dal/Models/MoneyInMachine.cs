using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VendingMachine.Dal.Models;

namespace VendingMachine.Dal
{
    public class MoneyInMachine
    {
        /// <summary>
        /// System-generated identity column
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Foreign key for the CodeLetter
        /// </summary>
        [ForeignKey("MoneyType")]
        public int MoneyTypeRefId { get; set; }
        public MoneyType MoneyType { get; set; }

        /// <summary>
        /// Foreign key for the CodeLetter
        /// </summary>
        [ForeignKey("Money")]
        public int MoneyRefId { get; set; }
        public Money Money { get; set; }

        ///// <summary>
        ///// Foreign key for the CodeLetter
        ///// </summary>
        [ForeignKey("Machine")]
        public int MachineRefId { get; set; }
        public Machine Machine { get; set; }
    }
}