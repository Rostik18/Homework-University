using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApplication.Forms {

    public partial class DepositCalculatorForm : Form {

        double startSum, persent, finishSum;
        DateTime startTime, finishTime;
        int persentType = 0;

        public DepositCalculatorForm() {

            InitializeComponent();
        }

        private void calculateButton_Click( object sender, EventArgs e ) {

            try {

                startSum = Convert.ToDouble( startSumTextBox.Text );
                persent = Convert.ToDouble( yearPersentTextBox.Text ) / 100;
                startTime = startDateTimePicker.Value;
                finishTime = finishDateTimePicker.Value;
                persentType = persentTypeComboBox.SelectedIndex;
            } catch {

                errorLabel.Text = "Incorrect data.";
                return;
            }

            if (startTime.Date == finishTime.Date) {

                errorLabel.Text = "Incorrect time.";
                return;
            }

            if (persentType == 0) {

                int t = (finishTime - startTime).Days;

                finishSum = startSum * (1 + (t / Constants.K) * persent);
            } else if (persentType == 1) {

                int t = (finishTime - startTime).Days;

                finishSum = startSum * Math.Pow( (1 + persent), (t / Constants.K) );
            } else {

                errorLabel.Text = "Select type.";
                return;
            }

            rezultTextBox.Text = finishSum.ToString();
        }

        private void recalculateButton_Click( object sender, EventArgs e ) {

            double addSum;
            DateTime addDate;

            try {

                addSum = Convert.ToDouble( addMoneyTextBox.Text );
                addDate = addMoneyDateTimePicker.Value;
            } catch {

                errorLabel.Text = "Incorrect data.";
                return;
            }

            if (addDate <= startTime || addDate >= finishTime) {

                errorLabel.Text = "Incirrect time.";
                return;
            }

            if (persentType == 0) {

                int t = (finishTime - addDate).Days;

                finishSum += addSum * (1 + (t / Constants.K) * persent);
            } else if (persentType == 1) {

                int t = (finishTime - startTime).Days;

                finishSum += addSum * Math.Pow( (1 + persent), (t / Constants.K) );
            } else {

                errorLabel.Text = "Select type.";
                return;
            }

            rezultTextBox.Text = finishSum.ToString();
        }
    }
}
