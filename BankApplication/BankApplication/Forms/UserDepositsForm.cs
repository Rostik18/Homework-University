using BankApplication.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BankApplication.Forms {

    public partial class UserDepositsForm : Form {

        BankDbContext dbContext;
        UserEntity currentUser;
        List<UserDepositEntity> userDeposits;

        public UserDepositsForm( UserEntity userEntity ) {

            InitializeComponent();

            currentUser = userEntity;
        }

        private void UserDepositsForm_Load( object sender, EventArgs e ) {

            dbContext = new BankDbContext();
            userDeposits = new List<UserDepositEntity>();

            currentUserLabel.Text += " " + currentUser.ToString();

            var bankAccounts = dbContext.BankAccounts
                .Include( ba => ba.UserDeposits )
                .ThenInclude( ud => ud.DepositType )
                .Where( ba => ba.UserId == currentUser.Id )
                .ToList();

            if (bankAccounts == null) {

                errorLabel.Text = "Bank accounts is null.";
                return;
            }

            foreach (var account in bankAccounts) {

                foreach (var deposit in account.UserDeposits) {

                    if (!deposit.IsPaid) {

                        userDeposits.Add( deposit );
                    }
                }
            }

            if (userDeposits.Count == 0) {

                errorLabel.Text = "You have no open deposits.";
                putMoneyButton.Enabled = false;
                moneyRetutnButton.Enabled = false;
            }

            userDepositsDataGridView.DataSource = userDeposits;
        }

        private void PutMoneyOnOpenedDepositButton_Click( object sender, EventArgs e ) {

            errorLabel.Text = string.Empty;

            var selectedDeposit = userDepositsDataGridView.SelectedRows[0].DataBoundItem as UserDepositEntity;

            if (selectedDeposit == null) {

                errorLabel.Text = "Selected deposit is null.";
                return;
            }

            if (selectedDeposit.DepositType.DepositTitle != "Classic+") {

                errorLabel.Text = "You cant put money to opened classic deposit.";
                return;
            }

            decimal addSum;

            try {

                addSum = Convert.ToDecimal( addSymTextBox.Text );
            } catch {

                errorLabel.Text = "Invalid data.";
                return;
            }

            if (selectedDeposit.BankAccount.MoneyCount < addSum) {

                errorLabel.Text = "There is not enough money in this account.";
                return;
            }

            int t = (selectedDeposit.FinishDate - DateTimeOffset.Now).Days;

            decimal addedSumWithPersent = addSum * (decimal)((1 + t / Constants.K) * selectedDeposit.DepositType.InterestRate);

            selectedDeposit.CurrentBalance += addedSumWithPersent;
            selectedDeposit.BankAccount.MoneyCount -= addSum;

            dbContext.UserDeposits.Update( selectedDeposit );
            dbContext.SaveChanges();
        }

        private void MoneyRetutnButton_Click( object sender, EventArgs e ) {

            errorLabel.Text = string.Empty;

            var selectedDeposit = userDepositsDataGridView.SelectedRows[0].DataBoundItem as UserDepositEntity;

            if (selectedDeposit == null) {

                errorLabel.Text = "Selected deposit is null.";
                return;
            }

            if (selectedDeposit.FinishDate > DateTimeOffset.Now) {

                errorLabel.Text = $"The deposit agreement expires on {selectedDeposit.FinishDate.ToString( "dd.mm.yyyy" )}.";
                return;
            }

            selectedDeposit.BankAccount.MoneyCount += selectedDeposit.CurrentBalance;
            selectedDeposit.IsPaid = true;

            dbContext.UserDeposits.Update( selectedDeposit );
            dbContext.SaveChanges();
        }
    }
}
