using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gadgets
{
    public partial class CustomerRegistrationForm : Form
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string PhoneNumber { get; private set; }

        public CustomerRegistrationForm()
        {
            InitializeComponent();
        }

        private void CustomerRegistrationForm_Load(object sender, EventArgs e)
        {
        
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FirstName = txtFirstName.Text;
            LastName = txtLastName.Text;
            PhoneNumber = txtPhoneNumber.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
