using System;

namespace BankApplication.Entities {

    class UserCredit {

        public int BankAccountId { get; set; }
        public int CreditTypeId { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset FinishDate { get; set; }
        public decimal StartSum { get; set; }
        public decimal DebtBalance { get; set; }
    }
}
