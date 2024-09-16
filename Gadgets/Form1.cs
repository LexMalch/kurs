using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Gadgets
{
    public partial class Form1 : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["POPUTKA"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            CustomerLoginForm loginForm = new CustomerLoginForm();

            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                string phoneNumber = loginForm.PhoneNumber;

                bool customerExists = CheckCustomerExists(phoneNumber);

                if (customerExists)
                {
                    int customerID = GetCustomerID(phoneNumber);
                    MessageBox.Show("Customer successfully authenticated.");
                    CustomerForm customerForm = new CustomerForm(customerID);
                    customerForm.Show();
                    Hide();
                }
                else
                {
                    DialogResult result = MessageBox.Show("Customer not found. Do you want to register?", "Registration", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        CustomerRegistrationForm registrationForm = new CustomerRegistrationForm();

                        if (registrationForm.ShowDialog() == DialogResult.OK)
                        {
                            string firstName = registrationForm.FirstName;
                            string lastName = registrationForm.LastName;
                            phoneNumber = registrationForm.PhoneNumber;

                            // Register new customer
                            RegisterCustomer(firstName, lastName, phoneNumber);

                            MessageBox.Show("Customer successfully registered.");
                            CustomerForm customerForm = new CustomerForm(GetCustomerID(phoneNumber));
                            customerForm.Show();
                            Hide();
                        }
                    }
                }
            }
        }
        private int GetCustomerID(string phoneNumber)
        {
            int customerID = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT client_id FROM clients WHERE phone_number = @PhoneNumber";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                        customerID = (int)command.ExecuteScalar();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error getting customer ID: " + ex.Message);
                }
            }

            return customerID;
        }

        private bool CheckCustomerExists(string phoneNumber)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM clients WHERE phone_number = @PhoneNumber";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                        int count = (int)command.ExecuteScalar();

                        return count > 0;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error checking customer existence: " + ex.Message);
                    return false;
                }
            }
        }

        private void RegisterCustomer(string firstName, string lastName, string phoneNumber)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO clients(client_name, phone_number) VALUES (@ClientName, @PhoneNumber)";
                    using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@ClientName", firstName + " " + lastName);
                        insertCommand.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                        insertCommand.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error registering customer: " + ex.Message);
                }
            }
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            EmployeePasswordForm passwordForm = new EmployeePasswordForm();
            if (passwordForm.ShowDialog() == DialogResult.OK)
            {
                string password = passwordForm.Password;

                if (password == "12345")
                {
                    EmployeeForm employeeForm = new EmployeeForm();
                    employeeForm.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Неверный пароль. Пожалуйста, попробуйте снова.");
                }
            }
        }
    }
}
