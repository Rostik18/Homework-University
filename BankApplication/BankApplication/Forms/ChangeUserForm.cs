﻿using BankApplication.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BankApplication.Forms {

    public partial class ChangeUserForm : Form {

        BankDbContext dbContext;

        public UserEntity User { get; set; }

        public ChangeUserForm() {

            InitializeComponent();

            dbContext = new BankDbContext();

            UsersDataGridView.DataSource = dbContext.Users.ToList();
        }

        private void AddUserButton_Click( object sender, EventArgs e ) {

            AddUserForm addUserForm = new AddUserForm();

            addUserForm.ShowDialog();
        }

        private void ChangeUserForm_Load( object sender, EventArgs e ) {

        }

        private void loginButton_Click( object sender, EventArgs e ) {

            loginErrorLabel.Text = String.Empty;

            var currentUser = dbContext.Users.AsNoTracking()
                .Include(user => user.BankAccounts )
                .ThenInclude( account => account.UserCredits )
                .Include( user => user.BankAccounts )
                .ThenInclude( account => account.UserDeposits )
                .SingleOrDefault( user => user.EmailAdress == loginEmailOrPhoneTextBox.Text ||
                                          user.PhoneNumber == loginEmailOrPhoneTextBox.Text );

            if (currentUser == null) {

                loginErrorLabel.Text = "Invalid login or password.";
                return;
            }

            if (currentUser.Password != passwordTextBox.Text) {

                loginErrorLabel.Text = "Invalid login or password.";
                return;
            }

            User = currentUser;

            Close();
        }
    }
}
