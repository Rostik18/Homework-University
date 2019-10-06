using BankApplication.Entities;
using BankApplication.Enumerations;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BankApplication.Forms {

    public partial class AddCreditTypeForm : Form {

        private BankDbContext dbContext;

        public AddCreditTypeForm() {

            InitializeComponent();

            dbContext = new BankDbContext();

            percentTypeComboBox.DataSource = new List<PercentType> { PercentType.Simple, PercentType.Complex };
        }

        private void AddCreditTypebutton_Click( object sender, EventArgs e ) {

            errorLabel.Text = String.Empty;

            if (String.IsNullOrWhiteSpace( creditTitleTextBox.Text )) {
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

            CreditTypeEntity creditType = new CreditTypeEntity {

                CreditTitle = creditTitleTextBox.Text,
                InterestRate = interestRate,
                PayoutPeriod = days,
                PercentType = (PercentType)percentTypeComboBox.SelectedItem
            };

            dbContext.CreditTypes.Add( creditType );
            dbContext.SaveChanges();

            Close();
        }
    }
}
