using BankApplication.Entities.Base;
using System;
using System.Collections.Generic;

namespace BankApplication.Entities {

    public class UserEntity : IBaseEntity {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTimeOffset BirthdayDate { get; set; }
        public DateTimeOffset RegistrationDate { get; set; }
        public string EmailAdress { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }

        public List<BankAccountEntity> BankAccounts { get; set; }
    }
}
