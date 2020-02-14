using BankApplication.Entities;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BankApplication.Forms {

    public partial class ManeForm : Form {

        UserEntity CurrentUser { get; set; }
        BankDbContext dbContext;

        public ManeForm() {

            InitializeComponent();

            dbContext = new BankDbContext();
        }

        private void ManeForm_Load( object sender, EventArgs e ) {

            ChangeUserToolStripMenuItem_Click( sender, e );
            RefreshButton_Click( sender, e );
        }

        private void ChangeUserToolStripMenuItem_Click( object sender, EventArgs e ) {

            currentUserLable.Text = "Current User:";

            ChangeUserForm changeUserForm = new ChangeUserForm();

            changeUserForm.ShowDialog();

            CurrentUser = changeUserForm.User;

            currentUserLable.Text += " " + CurrentUser.ToString();
        }

        private void AddAccountButton_Click( object sender, EventArgs e ) {

            var addAccountForm = new AddAccountForm( CurrentUser );

            addAccountForm.ShowDialog();
        }

        private void AddCreditTypeToolStripMenuItem_Click( object sender, EventArgs e ) {

            var addCreditTypeForm = new AddCreditTypeForm();

            addCreditTypeForm.ShowDialog();
        }

        private void AddDepositTypeToolStripMenuItem_Click( object sender, EventArgs e ) {

            var addDepositTypeForm = new AddDepositTypeForm();

            addDepositTypeForm.ShowDialog();
        }

        private void AccountsDataGridView_SelectionChanged( object sender, EventArgs e ) {

            openCreditButton.Enabled = true;
            openDepositeButton.Enabled = true;
        }

        private void OpenCreditButton_Click( object sender, EventArgs e ) {

            BankAccountEntity bankAccount;
            try {

                bankAccount = accountsDataGridView.SelectedRows[0].DataBoundItem as BankAccountEntity;
            } catch {

                return;
            }

            var openUserCreditForm = new OpenUserCreditForm( bankAccount );

            openUserCreditForm.ShowDialog();
        }

        private void OpenDepositeButton_Click( object sender, EventArgs e ) {

            BankAccountEntity bankAccount;
            try {

                bankAccount = accountsDataGridView.SelectedRows[0].DataBoundItem as BankAccountEntity;
            } catch {

                return;
            }

            var openUserDepositForm = new OpenUserDepositForm( bankAccount );

            openUserDepositForm.ShowDialog();
        }

        private void PutMoneyButton_Click( object sender, EventArgs e ) {

            errorLabel.Text = string.Empty;

            BankAccountEntity bankAccount;
            try {

                bankAccount = accountsDataGridView.SelectedRows[0].DataBoundItem as BankAccountEntity;
                bankAccount.MoneyCount += Convert.ToDecimal( getSetMoneyTextBox.Text );

            } catch {

                errorLabel.Text = "Invalid data.";
                return;
            }

            dbContext.BankAccounts.Update( bankAccount );
            dbContext.SaveChanges();
        }

        private void GetMoneyButton_Click( object sender, EventArgs e ) {

            errorLabel.Text = string.Empty;

            BankAccountEntity bankAccount;

            decimal getMoney;
            try {

                bankAccount = accountsDataGridView.SelectedRows[0].DataBoundItem as BankAccountEntity;
                getMoney = Convert.ToDecimal( getSetMoneyTextBox.Text );

            } catch {

                errorLabel.Text = "Invalid data.";
                return;
            }

            if(bankAccount.MoneyCount < getMoney) {

                errorLabel.Text = "You can't take more money than you have.";
                return;
            }
            bankAccount.MoneyCount -= getMoney;

            dbContext.BankAccounts.Update( bankAccount );
            dbContext.SaveChanges();
        }

        private void RefreshButton_Click( object sender, EventArgs e ) {

            CurrentUser.BankAccounts = dbContext.BankAccounts.Where( ba => ba.UserId == CurrentUser.Id ).ToList();

            accountsDataGridView.DataSource = CurrentUser.BankAccounts;
        }

        private void OpenedCreditsButton_Click( object sender, EventArgs e ) {

            var userCreditsForm = new UserCreditsForm( CurrentUser );

            userCreditsForm.ShowDialog();
        }

        private void OpenedDepositsButton_Click( object sender, EventArgs e ) {

            var userDepositsForm = new UserDepositsForm( CurrentUser );

            userDepositsForm.ShowDialog();
        }

        private void openDepositCalculatorButton_Click( object sender, EventArgs e ) {

            var calculatorForm = new DepositCalculatorForm();

            calculatorForm.ShowDialog();
        }
    }
}
