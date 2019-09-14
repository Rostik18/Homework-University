using BankApplication.Entities.Base;
using System;

namespace BankApplication.Entities {
    class UserEntity : IBaseEntity {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTimeOffset BirthdayDate { get; set; }
        public DateTimeOffset RegistrationDate { get; set; }
        public string EmailAdress { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
    }
}
