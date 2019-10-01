using BankApplication.Entities;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BankApplication.Forms {

    public partial class AddUserForm : Form {

        BankDbContext dbContext;

        public AddUserForm() {

            InitializeComponent();

            dbContext = new BankDbContext();
        }

        private void AddUserForm_Load( object sender, EventArgs e ) {

        }

        private void RegisterButton_Click( object sender, EventArgs e ) {

            errorLabel.Text = String.Empty;

            if (String.IsNullOrEmpty( fNameTextBox.Text ) ||
                String.IsNullOrEmpty( lNameTextBox.Text ) ||
                DateTime.Now <= bDayDateTimePicker.Value ||
                String.IsNullOrEmpty( emailTextBox.Text ) ||
                String.IsNullOrEmpty( phoneTextBox.Text ) ||
                String.IsNullOrEmpty( newPasswordTextBox.Text )) {

                errorLabel.Text = "Fill in all the fields.";
                return;
            }

            bool areEmailAndPhoneUnavailable = dbContext.Users.Any( user => user.EmailAdress == emailTextBox.Text ||
                                                                            user.PhoneNumber == phoneTextBox.Text );

            if (areEmailAndPhoneUnavailable) {

                errorLabel.Text = "Email or phone is unavailable.";
                return;
            }

            if (newPasswordTextBox.Text != confirmNewPasswordTextBox.Text) {

                errorLabel.Text = "Passwords do not match.";
                return;
            }

            UserEntity newUser = new UserEntity {
                FirstName = fNameTextBox.Text,
                LastName = lNameTextBox.Text,
                BirthdayDate = bDayDateTimePicker.Value,
                EmailAdress = emailTextBox.Text,
                PhoneNumber = phoneTextBox.Text,
                Password = newPasswordTextBox.Text
            };

            dbContext.Users.Add( newUser );
            dbContext.SaveChanges();

            Close();
        }
    }
}
