using System;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Gadgets
{
    public partial class CustomerForm : Form
    {
        private int customerID;
        private string connectionString = ConfigurationManager.ConnectionStrings["POPUTKA"].ConnectionString;
        private SqlDataAdapter dataAdapter;
        private DataSet dataSet;
        public CustomerForm(int customerID)
        {
            InitializeComponent();
            this.customerID = customerID;
            dataAdapter = new SqlDataAdapter();
            dataSet = new DataSet();
            LoadCustomerInfo();
            LoadOrders();

            this.FormClosed += CustomerForm_FormClosed;
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {

        }
        private void LoadCustomerInfo()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT client_name, phone_number FROM clients WHERE client_id = @CustomerID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@CustomerID", customerID);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        lblCustomerName.Text = reader["client_name"].ToString();
                        lblPhoneNumber.Text = reader["phone_number"].ToString();
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error loading customer information: " + ex.Message);
                }
            }
        }

        private void LoadOrders()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT orders.order_id, gadgets.gadget_name, orders.issue, orders.status, orders.price " +
                                    "FROM orders " +
                                    "INNER JOIN clients ON orders.client_id = clients.client_id " +
                                    "INNER JOIN gadgets ON orders.gadget_id = gadgets.gadget_id " +
                                    "WHERE orders.client_id = @CustomerID";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@CustomerID", customerID);

                    dataAdapter.SelectCommand = command;
                    dataSet.Clear();
                    dataAdapter.Fill(dataSet, "Orders");

                    ordersDataGridView.DataSource = dataSet.Tables["Orders"];

                    ordersDataGridView.Columns["order_id"].HeaderText = "Номер заказа";
                    ordersDataGridView.Columns["gadget_name"].HeaderText = "Гаджет";
                    ordersDataGridView.Columns["issue"].HeaderText = "Поломка";
                    ordersDataGridView.Columns["status"].HeaderText = "Статус";
                    ordersDataGridView.Columns["price"].HeaderText = "Стоимость";
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error loading orders: " + ex.Message);
                }
            }
        }

        private void CompleteOrder(int orderID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE orders SET status = @Status WHERE order_id = @OrderID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Status", "Completed");
                        command.Parameters.AddWithValue("@OrderID", orderID);
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Order completed successfully.");
                    LoadOrders();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error completing order: " + ex.Message);
                }
            }
        }

        private void ordersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int orderID = Convert.ToInt32(ordersDataGridView.Rows[e.RowIndex].Cells["order_id"].Value);
                CompleteOrder(orderID);
            }
        }

        private void btnSubmitOrder_Click(object sender, EventArgs e)
        {
            int selectedGadgetID = AddNewGadget(GadgetName.Text); 

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO orders (client_id, gadget_id, issue, status) VALUES (@ClientID, @GadgetID, @Issue, @Status)";
                    SqlCommand command = new SqlCommand(query, connection);

                   
                    string issueDescription = txtIssueDescription.Text; 
                    string status = "В обработке";

                    command.Parameters.AddWithValue("@ClientID", customerID);
                    command.Parameters.AddWithValue("@GadgetID", selectedGadgetID);
                    command.Parameters.AddWithValue("@Issue", issueDescription);
                    command.Parameters.AddWithValue("@Status", status);

                    command.ExecuteNonQuery();

                    MessageBox.Show("New order submitted successfully.");
                    LoadOrders();

                    GadgetName.Clear();
                    txtIssueDescription.Clear();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error submitting new order: " + ex.Message);
                }
            }
        }

        private int AddNewGadget(string gadgetName)
        {
            int insertedGadgetId = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO gadgets (gadget_name) VALUES (@GadgetName); SELECT SCOPE_IDENTITY();";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@GadgetName", gadgetName);
                    insertedGadgetId = Convert.ToInt32(command.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding new gadget: " + ex.Message);
                }
            }
            return insertedGadgetId;
        }

        private void CustomerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Form1 mainForm = new Form1();
            mainForm.Show();
        }
    }
}
