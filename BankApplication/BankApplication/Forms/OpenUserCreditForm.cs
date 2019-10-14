using BankApplication.Entities;
using BankApplication.Enumerations;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BankApplication.Forms {

    public partial class OpenUserCreditForm : Form {

        BankDbContext dbContext;

        BankAccountEntity _currentAccount;

        public OpenUserCreditForm( BankAccountEntity currentAccount ) {

            InitializeComponent();

            _currentAccount = currentAccount;

            currentAccountLabel.Text += " " + _currentAccount.Currency + " " + _currentAccount.MoneyCount;

            dbContext = new BankDbContext();

            creditTypeComboBox.DataSource = dbContext.CreditTypes.ToList();
        }

        private void openCreditButton_Click( object sender, EventArgs e ) {

            errorLabel.Text = String.Empty;

            if (_currentAccount == null) {

                errorLabel.Text = "Account not selected.";
                return;
            }

            CreditTypeEntity selectedCreditType;
            decimal startSum;

            try {

                selectedCreditType = (CreditTypeEntity)creditTypeComboBox.SelectedItem;
                startSum = Convert.ToDecimal( startSumTextBox.Text );
            } catch {

                errorLabel.Text = "Input correct data.";
                return;
            }

            decimal debtBalance;

            if (selectedCreditType.PercentType == PercentType.Simple) {
                debtBalance = startSum * (decimal)(1 + ((double)selectedCreditType.PayoutPeriod / Constants.K) * selectedCreditType.InterestRate);
            } else {
                debtBalance = startSum * (decimal)Math.Pow( (1 + selectedCreditType.InterestRate), ((double)selectedCreditType.PayoutPeriod / Constants.K) );
            }

            var userCreditEntity = new UserCreditEntity {

                BankAccountId = _currentAccount.Id,
                CreditTypeId = selectedCreditType.Id,
                StartDate = DateTimeOffset.Now,
                StartSum = startSum,
                FinishDate = DateTimeOffset.Now + TimeSpan.FromDays( selectedCreditType.PayoutPeriod ),
                DebtBalance = debtBalance
            };

            _currentAccount.MoneyCount += startSum;

            dbContext.BankAccounts.Update( _currentAccount );
            dbContext.UserCredits.Add( userCreditEntity );
            dbContext.SaveChanges();

            Close();
        }
    }
}
