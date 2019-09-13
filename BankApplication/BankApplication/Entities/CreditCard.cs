using BankApplication.Enumerations;
using System;

namespace BankApplication.Entities {

    class CreditCard : IBaseEntity {

        public int Id { get; set; }
        public int BankAccountId { get; set; }
        public CardType CardType { get; set; }
        public string PIN { get; set; }
        public DateTimeOffset ExpirationDate { get; set; }
    }
}
