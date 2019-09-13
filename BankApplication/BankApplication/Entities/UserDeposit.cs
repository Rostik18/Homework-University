using System;

namespace BankApplication.Entities {

    class UserDeposit {

        public int BankAccountId { get; set; }
        public int DepositTypeId { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset FinishDate { get; set; }
        public decimal StartSum { get; set; }
        public decimal CurrentBalance { get; set; }
    }
}
