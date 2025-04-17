using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace resto.db
{
    public partial class CustomersForm : Form
    {
        private int selectedCustomerId = -1;
        private DataTable customerTable = new DataTable();

        public CustomersForm()
        {
            InitializeComponent();
            SetupCustomerTable(); // Set up columns and structure
            LoadDummyCustomers(); // Load sample data
            LoadCustomers();      // Display data in DataGridView

            // Event bindings
            add.Click += add_Click;
            Edit.Click += edit_Click;
            delete.Click += delete_Click;
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void SetupCustomerTable()
        {
            customerTable.Columns.Add("CustomerID", typeof(int));
            customerTable.Columns.Add("FirstName", typeof(string));
            customerTable.Columns.Add("LastName", typeof(string));
            customerTable.Columns.Add("Phone", typeof(string));
            customerTable.Columns.Add("Email", typeof(string));
            customerTable.Columns.Add("Address", typeof(string));

            customerTable.PrimaryKey = new DataColumn[] { customerTable.Columns["CustomerID"] };
        }

        private void LoadDummyCustomers()
        {
            customerTable.Rows.Add(1, "Juan", "Dela Cruz", "09171234567", "juan@email.com", "123 Manila St.");
            customerTable.Rows.Add(2, "Maria", "Santos", "09991234567", "maria@email.com", "456 Cebu Ave.");
        }

        private void LoadCustomers()
        {
            dataGridView1.DataSource = customerTable;
        }

        private void ClearForm()
        {
            firstname.Text = "";
            lastname.Text = "";
            phonee.Text = "";
            emaill.Text = "";
            addresss.Text = "";
            selectedCustomerId = -1;
        }

        private void add_Click(object sender, EventArgs e)
        {
            int newId = customerTable.Rows.Count > 0 ?
                customerTable.AsEnumerable().Max(row => row.Field<int>("CustomerID")) + 1 : 1;

            customerTable.Rows.Add(newId, firstname.Text, lastname.Text, phonee.Text, emaill.Text, addresss.Text);
            LoadCustomers();
            ClearForm();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            if (selectedCustomerId == -1)
            {
                MessageBox.Show("Please select a customer to edit.");
                return;
            }

            DataRow row = customerTable.Rows.Find(selectedCustomerId);
            if (row != null)
            {
                row["FirstName"] = firstname.Text;
                row["LastName"] = lastname.Text;
                row["Phone"] = phonee.Text;
                row["Email"] = emaill.Text;
                row["Address"] = addresss.Text;
            }

            LoadCustomers();
            ClearForm();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (selectedCustomerId == -1)
            {
                MessageBox.Show("Please select a customer to delete.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this customer?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DataRow row = customerTable.Rows.Find(selectedCustomerId);
                if (row != null)
                {
                    customerTable.Rows.Remove(row);
                }

                LoadCustomers();
                ClearForm();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                selectedCustomerId = Convert.ToInt32(row.Cells["CustomerID"].Value);
                firstname.Text = row.Cells["FirstName"].Value.ToString();
                lastname.Text = row.Cells["LastName"].Value.ToString();
                phonee.Text = row.Cells["Phone"].Value.ToString();
                emaill.Text = row.Cells["Email"].Value.ToString();
                addresss.Text = row.Cells["Address"].Value.ToString();
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
