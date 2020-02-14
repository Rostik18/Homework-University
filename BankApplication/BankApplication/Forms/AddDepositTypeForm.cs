using BankApplication.Entities;
using BankApplication.Enumerations;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BankApplication.Forms {

    public partial class AddDepositTypeForm : Form {

        BankDbContext dbContext;

        public AddDepositTypeForm() {

            InitializeComponent();

            dbContext = new BankDbContext();

            percentTypeComboBox.DataSource = new List<PercentType> { PercentType.Simple, PercentType.Complex };
        }

        private void addCreditTypebutton_Click( object sender, EventArgs e ) {

            errorLabel.Text = String.Empty;

            if (String.IsNullOrWhiteSpace( depositTitleTextBox.Text )) {
                errorLabel.Text = "Fill the title.";
                return;
            }

            double interestRate;
            int days;

            try {
                interestRate = Convert.ToDouble( interestRateTextBox.Text );
                days = Convert.ToInt32( interestPeriodTextBox.Text );
            } catch {
                errorLabel.Text = "Fill the correct data.";
                return;
            }

            interestRate /= 100.0;

            DepositTypeEntity depositType = new DepositTypeEntity {

                DepositTitle = depositTitleTextBox.Text,
                InterestRate = interestRate,
                PayoutPeriod = days,
                PercentType = (PercentType)percentTypeComboBox.SelectedItem
            };

            dbContext.DepositTypes.Add( depositType );
            dbContext.SaveChanges();

            Close();

        }
    }
}
