using BankApplication.Entities.Base;
using BankApplication.Enumerations;
using System.Collections.Generic;

namespace BankApplication.Entities {

    public class DepositTypeEntity : IBaseEntity {

        public int Id { get; set; }
        public string DepositTitle { get; set; }
        public PercentType PercentType { get; set; }
        public double InterestRate { get; set; }
        //In months.
        public int PayoutPeriod { get; set; }

        public List<UserDepositEntity> UserDeposits { get; set; }
    }
}
