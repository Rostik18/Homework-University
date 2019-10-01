using BankApplication.Entities.Base;
using System;

namespace BankApplication.Entities {

    public class UserDepositEntity : IBaseEntity {

        public int Id { get; set; }
        public int BankAccountId { get; set; }
        public int DepositTypeId { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset FinishDate { get; set; }
        public decimal StartSum { get; set; }
        public decimal CurrentBalance { get; set; }

        public BankAccountEntity BankAccount { get; set; }
        public DepositTypeEntity DepositType { get; set; }
    }
}
