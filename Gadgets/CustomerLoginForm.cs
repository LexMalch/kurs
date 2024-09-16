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
    public partial class CustomerLoginForm : Form
    {
        public string PhoneNumber { get; private set; }
        public CustomerLoginForm()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            PhoneNumber = txtPhoneNumber.Text;
            DialogResult = DialogResult.OK;
        }
    }
}
