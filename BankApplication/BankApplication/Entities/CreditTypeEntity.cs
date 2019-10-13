using BankApplication.Entities.Base;
using BankApplication.Enumerations;
using System.Collections.Generic;

namespace BankApplication.Entities {

    public class CreditTypeEntity : IBaseEntity {

        public int Id { get; set; }
        public string CreditTitle { get; set; }
        public PercentType PercentType { get; set; }
        public double InterestRate { get; set; }
        //In days.
        public int PayoutPeriod { get; set; }

        public List<UserCreditEntity> UserCredits { get; set; }

        public override string ToString() {
            return CreditTitle;
        }
    }
}
