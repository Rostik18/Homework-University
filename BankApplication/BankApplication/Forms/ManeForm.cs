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
    }
}
