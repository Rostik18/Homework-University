using BankApplication.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BankApplication.Forms {

    public partial class UserCreditsForm : Form {


        BankDbContext dbContext;
        UserEntity currentUser;
        List<UserCreditEntity> userCredits;

        public UserCreditsForm( UserEntity userEntity ) {

            InitializeComponent();

            currentUser = userEntity;
        }

        private void UserCreditsForm_Load( object sender, EventArgs e ) {

            dbContext = new BankDbContext();
            userCredits = new List<UserCreditEntity>();

            currentUserLabel.Text += " " + currentUser.ToString();

            var bankAccounts = dbContext.BankAccounts
                .Include( ba => ba.UserCredits )
                .ThenInclude( uc => uc.CreditType )
                .Where( ba => ba.UserId == currentUser.Id )
                .ToList();

            if (bankAccounts == null) {

                errorLabel.Text = "Bank accounts is null.";
                return;
            }

            foreach (var account in bankAccounts) {

                foreach (var credit in account.UserCredits) {

                    if (!credit.IsRepaid) {

                        userCredits.Add( credit );
                    }
                }
            }

            if (userCredits.Count == 0) {

                errorLabel.Text = "You have no open credits.";
                moneyReturnButton.Enabled = false;
            }

            userCreditsDataGridView.DataSource = userCredits;
        }

        private void MoneyReturnButton_Click( object sender, EventArgs e ) {

            errorLabel.Text = string.Empty;

            var selectedCredit = userCreditsDataGridView.SelectedRows[0].DataBoundItem as UserCreditEntity;

            if (selectedCredit == null) {

                errorLabel.Text = "Selected credit is null.";
                return;
            }

            decimal returnSum;

            try {

                returnSum = Convert.ToDecimal( payOffSymTextBox.Text );
            } catch {

                errorLabel.Text = "Invalid data.";
                return;
            }

            if (selectedCredit.BankAccount.MoneyCount < returnSum) {

                errorLabel.Text = "There is not enough money in this account.";
                return;
            }

            if (returnSum > selectedCredit.DebtBalance) {

                returnSum = selectedCredit.DebtBalance;
            }

            selectedCredit.BankAccount.MoneyCount -= returnSum;
            selectedCredit.DebtBalance -= returnSum;

            if(selectedCredit.DebtBalance == 0) {
                selectedCredit.IsRepaid = true;
            }

            dbContext.UserCredits.Update( selectedCredit );
            dbContext.SaveChanges();
        }
    }
}
