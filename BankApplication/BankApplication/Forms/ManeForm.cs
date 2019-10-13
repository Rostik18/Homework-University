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

            accountsDataGridView.DataSource = CurrentUser.BankAccounts.ToList();
        }

        private void ChangeUserToolStripMenuItem_Click( object sender, EventArgs e ) {

            currentUserLable.Text = "Current User:";

            ChangeUserForm changeUserForm = new ChangeUserForm();

            changeUserForm.ShowDialog();

            CurrentUser = changeUserForm.User;

            currentUserLable.Text += " " + CurrentUser.FirstName + " " + CurrentUser.LastName;
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
    }
}
