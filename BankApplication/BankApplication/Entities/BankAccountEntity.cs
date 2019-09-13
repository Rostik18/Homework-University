using BankApplication.Enumerations;

namespace BankApplication.Entities {

    class BankAccountEntity : IBaseEntity {

        public int Id { get; set; }
        public int UserId { get; set; }
        public Currency Currency { get; set; }
        public decimal MoneyCount { get; set; }
        public bool IsFrozen { get; set; }
    }
}
