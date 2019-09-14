using BankApplication.Entities.Base;
using BankApplication.Enumerations;

namespace BankApplication.Entities {

    class DepositTypeEntity : IBaseEntity {

        public int Id { get; set; }
        public string DepositTitle { get; set; }
        public PercentType PercentType { get; set; }
        public double InterestRate { get; set; }
        //In months.
        public int PayoutPeriod { get; set; }
    }
}
