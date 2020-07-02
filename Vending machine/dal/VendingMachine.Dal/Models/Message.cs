using System.ComponentModel;

namespace VendingMachine.Dal
{
    public enum Message
    {
        [field: Description(" ")]
        None,

        [field: Description("Money Rejected")]
        MoneyRejected,

        [field: Description("Code Invalid")]
        CodeInvalid,

        [field: Description("Vending")]
        Vending
    }
}