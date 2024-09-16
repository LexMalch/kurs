using System;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Office.Interop.Word;
using System.Reflection;
using DataTable = System.Data.DataTable;

namespace Gadgets
{
    public partial class EmployeeForm : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["POPUTKA"].ConnectionString;
        public EmployeeForm()
        {
            InitializeComponent();

            this.FormClosed += EmployeeForm_FormClosed;

        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gadgetsDataSet.repair_status". При необходимости она может быть перемещена или удалена.
            this.repair_statusTableAdapter.Fill(this.gadgetsDataSet.repair_status);
            DisplayOrders();
        }

        private void DisplayOrders()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT o.order_id, c.client_name, g.gadget_name, o.issue, o.status, o.price " +
                               "FROM orders o " +
                               "JOIN clients c ON o.client_id = c.client_id " +
                               "JOIN gadgets g ON o.gadget_id = g.gadget_id";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridViewOrders.DataSource = dataTable;

                dataGridViewOrders.Columns["order_id"].HeaderText = "Номер заказа";
                dataGridViewOrders.Columns["client_name"].HeaderText = "ФИО клиента";
                dataGridViewOrders.Columns["gadget_name"].HeaderText = "Гаджет";
                dataGridViewOrders.Columns["issue"].HeaderText = "Поломка";
                dataGridViewOrders.Columns["status"].HeaderText = "Статус";
                dataGridViewOrders.Columns["price"].HeaderText = "Стоимость";
            }
        }

        private void btnSortByStatus_Click(object sender, EventArgs e)
        {
            string selectedStatus = comboBoxStatus.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT o.order_id, c.client_name, g.gadget_name, o.issue, o.status, o.price " +
                               "FROM orders o " +
                               "JOIN clients c ON o.client_id = c.client_id " +
                               "JOIN gadgets g ON o.gadget_id = g.gadget_id " +
                               "WHERE o.status = @status";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@status", selectedStatus);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridViewOrders.DataSource = dataTable;

                dataGridViewOrders.Columns["order_id"].HeaderText = "Номер заказа";
                dataGridViewOrders.Columns["client_name"].HeaderText = "ФИО клиента";
                dataGridViewOrders.Columns["gadget_name"].HeaderText = "Гаджет";
                dataGridViewOrders.Columns["issue"].HeaderText = "Поломка";
                dataGridViewOrders.Columns["status"].HeaderText = "Статус";
                dataGridViewOrders.Columns["price"].HeaderText = "Стоимость";
            }
        }
        private void btnResetSort_Click(object sender, EventArgs e)
        {
            DisplayOrders();
        }

        private void btnChangeStatus_Click(object sender, EventArgs e)
        {
            int selectedOrderId = Convert.ToInt32(dataGridViewOrders.SelectedRows[0].Cells["order_id"].Value);
            string selectedStatus = comboBoxStatusChange.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE orders SET status = @status WHERE order_id = @orderId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@status", selectedStatus);
                command.Parameters.AddWithValue("@orderId", selectedOrderId);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

            DisplayOrders();
        }

        private void btnChangePrice_Click(object sender, EventArgs e)
        {
            int selectedOrderId = Convert.ToInt32(dataGridViewOrders.SelectedRows[0].Cells["order_id"].Value);
            int selectedStatus = Convert.ToInt32(textBoxPrice.Text);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE orders SET price = @price WHERE order_id = @orderId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@price", selectedStatus);
                command.Parameters.AddWithValue("@orderId", selectedOrderId);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

            DisplayOrders();
        }

        private void ExportToWord(DataTable dataTable)
        {
            Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
            Microsoft.Office.Interop.Word.Document wordDoc = wordApp.Documents.Add();

            Microsoft.Office.Interop.Word.Paragraph paraTitle = wordDoc.Content.Paragraphs.Add();
            paraTitle.Range.Text = "Search Results";
            paraTitle.Range.Font.Bold = 1;
            paraTitle.Format.SpaceAfter = 24;
            paraTitle.Range.InsertParagraphAfter();

            Microsoft.Office.Interop.Word.Table table = wordDoc.Tables.Add(paraTitle.Range, dataTable.Rows.Count + 1, dataTable.Columns.Count);

            for (int i = 0; i < dataTable.Columns.Count; i++)
            {
                table.Cell(1, i + 1).Range.Text = dataTable.Columns[i].ColumnName;
            }

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                for (int j = 0; j < dataTable.Columns.Count; j++)
                {
                    table.Cell(i + 2, j + 1).Range.Text = dataTable.Rows[i][j].ToString();
                }
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Word Documents (*.docx)|*.docx";
            saveFileDialog.FileName = "SearchResults.docx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                object fileName = saveFileDialog.FileName;
                wordDoc.SaveAs2(ref fileName);
                wordApp.Visible = true;
            }
            else
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal minPrice = Convert.ToDecimal(textBoxMinPrice.Text);
            decimal maxPrice = Convert.ToDecimal(textBoxMaxPrice.Text);
            string selectedStatus = comboBoxSearchStatus.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT o.order_id, c.client_name, g.gadget_name, o.issue, o.status, o.price " +
                               "FROM orders o " +
                               "JOIN clients c ON o.client_id = c.client_id " +
                               "JOIN gadgets g ON o.gadget_id = g.gadget_id " +
                               "WHERE o.price >= @minPrice AND o.price <= @maxPrice AND o.status = @status";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@minPrice", minPrice);
                command.Parameters.AddWithValue("@maxPrice", maxPrice);
                command.Parameters.AddWithValue("@status", selectedStatus);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                ExportToWord(dataTable);
            }
        }

        private void EmployeeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Form1 mainForm = new Form1();
            mainForm.Show();
        }
    }
}
