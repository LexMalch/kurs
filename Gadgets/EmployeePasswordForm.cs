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
    public partial class EmployeePasswordForm : Form
    {
        public string Password { get; private set; }

        public EmployeePasswordForm()
        {
            InitializeComponent();
        }

        private void EmployeePasswordForm_Load(object sender, EventArgs e)
        {
           
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Password = txtPassword.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
