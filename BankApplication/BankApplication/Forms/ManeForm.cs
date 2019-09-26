using BankApplication.Entities;
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

    public partial class ManeForm : Form {

        UserEntity CurrentUser { get; set; }

        public ManeForm() {

            InitializeComponent();
        }

        private void ManeForm_Load( object sender, EventArgs e ) {

        }

        private void ChangeUserToolStripMenuItem_Click( object sender, EventArgs e ) {

            ChangeUserForm changeUserForm = new ChangeUserForm();

            if( changeUserForm.ShowDialog() == DialogResult.OK) {


            }
        }
    }
}
