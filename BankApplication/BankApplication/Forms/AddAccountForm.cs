using BankApplication.Entities;
using BankApplication.Enumerations;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BankApplication.Forms {

    public partial class AddAccountForm : Form {

        private readonly UserEntity currentUser;
        private BankDbContext dbContext;

        public AddAccountForm( UserEntity user) {

            InitializeComponent();

            dbContext = new BankDbContext();
            currentUser = user;
            currensyComboBox.DataSource = new List<Currency> { Currency.UAH, Currency.USD, Currency.EUR, Currency.RUB, Currency.PLN };
        }

        private void addAccountButton_Click( object sender, EventArgs e ) {

            errorLabel.Text = String.Empty;

            if (currentUser == null) {
                errorLabel.Text = "Current User is not selected. \nAre you forgot to login?";
                return;
            }

            decimal startSum;

            try {
                startSum = Convert.ToDecimal( startSumTextBox.Text);
            } catch {
                errorLabel.Text = "Start sum in not correct.";
                return;
            }

            if(startSum < 0) {
                errorLabel.Text = "Start sum can not be less then zero.";
                return;
            }

            var currency = (Currency)currensyComboBox.SelectedItem ;

            BankAccountEntity account = new BankAccountEntity {

                UserId = currentUser.Id,
                Currency = currency,
                MoneyCount = startSum,
                IsFrozen = false
            };

            dbContext.BankAccounts.Add( account );
            dbContext.SaveChanges();

            Close();
        }
    }
}
