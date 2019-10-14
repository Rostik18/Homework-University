using BankApplication.Entities;
using BankApplication.Enumerations;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BankApplication.Forms {

    public partial class OpenUserDepositForm : Form {


        BankDbContext dbContext;

        BankAccountEntity _currentAccount;

        public OpenUserDepositForm( BankAccountEntity currentAccount ) {

            InitializeComponent();

            _currentAccount = currentAccount;

            currentAccountLabel.Text += " " + _currentAccount.Currency + " " + _currentAccount.MoneyCount;

            dbContext = new BankDbContext();

            depositTypeComboBox.DataSource = dbContext.DepositTypes.ToList();
        }

        private void OpenCreditButton_Click( object sender, EventArgs e ) {

            errorLabel.Text = String.Empty;

            if (_currentAccount == null) {

                errorLabel.Text = "Account not selected.";
                return;
            }

            DepositTypeEntity selectedDepositType;
            decimal startSum;

            try {

                selectedDepositType = (DepositTypeEntity)depositTypeComboBox.SelectedItem;
                startSum = Convert.ToDecimal( startSumTextBox.Text );
            } catch {

                errorLabel.Text = "Input correct data.";
                return;
            }

            if (_currentAccount.MoneyCount < startSum) {

                errorLabel.Text = "You don't have enough money.";
                return;
            }

            decimal currentBalance;

            if (selectedDepositType.PercentType == PercentType.Simple) {
                currentBalance = startSum * (decimal)(1 + ((double)selectedDepositType.PayoutPeriod / Constants.K) * selectedDepositType.InterestRate);
            } else {
                currentBalance = startSum * (decimal)Math.Pow( (1 + selectedDepositType.InterestRate), ((double)selectedDepositType.PayoutPeriod / Constants.K) );
            }

            var userDepositEntity = new UserDepositEntity {

                BankAccountId = _currentAccount.Id,
                DepositTypeId = selectedDepositType.Id,
                StartDate = DateTimeOffset.Now,
                StartSum = startSum,
                FinishDate = DateTimeOffset.Now + TimeSpan.FromDays( selectedDepositType.PayoutPeriod ),
                CurrentBalance = currentBalance
            };

            _currentAccount.MoneyCount -= startSum;

            dbContext.BankAccounts.Update( _currentAccount );
            dbContext.UserDeposits.Add( userDepositEntity );
            dbContext.SaveChanges();

            Close();

        }
    }
}
