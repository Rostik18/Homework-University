using BankApplication.Entities.Base;
using System;

namespace BankApplication.Entities {

    class UserCreditEntity : IBaseEntity {

        public int Id { get; set; }
        public int BankAccountId { get; set; }
        public int CreditTypeId { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset FinishDate { get; set; }
        public decimal StartSum { get; set; }
        public decimal DebtBalance { get; set; }

        public BankAccountEntity BankAccount { get; set; }
        public CreditTypeEntity CreditType { get; set; }
    }
}
