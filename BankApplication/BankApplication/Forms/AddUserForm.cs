using BankApplication.Entities;
using System;
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



            if (newPasswordTextBox.Text != confirmNewPasswordTextBox.Text) {

                errorLabel.Text = "Passwords do not match.";
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
        }
    }
}
