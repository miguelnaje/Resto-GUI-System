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
    public partial class OrdersForm : Form
    {
        // Class to represent an Order
        public class Order
        {
            public string CustomerID { get; set; }
            public string EmployeeID { get; set; }
            public DateTime OrderDate { get; set; }
            public string TotalAmount { get; set; }
            public string OrderStatus { get; set; }
        }

        // List to store orders temporarily (in memory)
        private List<Order> orders = new List<Order>();

        public OrdersForm()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            dataGridView1.Columns.Add("CustomerID", "Customer ID");
            dataGridView1.Columns.Add("EmployeeID", "Employee ID");
            dataGridView1.Columns.Add("OrderDate", "Order Date");
            dataGridView1.Columns.Add("TotalAmount", "Total Amount");
            dataGridView1.Columns.Add("OrderStatus", "Order Status");
        }

        private void orderstatus_TextChanged(object sender, EventArgs e)
        {
        }

        // Add button click handler
        private void add_Click(object sender, EventArgs e)
        {
            Order newOrder = new Order
            {
                CustomerID = customerid.Text,
                EmployeeID = employeeid.Text,
                OrderDate = dateTimePicker1.Value,
                TotalAmount = totalamount.Text,
                OrderStatus = orderstatus.Text
            };

            orders.Add(newOrder);
            RefreshDataGridView();
            ClearFields();
        }

        // Edit button click handler
        private void edit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                orders[index].CustomerID = customerid.Text;
                orders[index].EmployeeID = employeeid.Text;
                orders[index].OrderDate = dateTimePicker1.Value;
                orders[index].TotalAmount = totalamount.Text;
                orders[index].OrderStatus = orderstatus.Text;

                RefreshDataGridView();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Please select an order to edit.");
            }
        }

        // Delete button click handler
        private void delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                orders.RemoveAt(index);
                RefreshDataGridView();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Please select an order to delete.");
            }
        }

        // Refresh DataGridView with updated order list
        private void RefreshDataGridView()
        {
            dataGridView1.Rows.Clear();
            foreach (var order in orders)
            {
                dataGridView1.Rows.Add(order.CustomerID, order.EmployeeID, order.OrderDate.ToShortDateString(), order.TotalAmount, order.OrderStatus);
            }
        }

        // Clear all fields
        private void ClearFields()
        {
            customerid.Clear();
            employeeid.Clear();
            totalamount.Clear();
            orderstatus.Clear();
            dateTimePicker1.Value = DateTime.Now;
        }

        private void delete_Click_1(object sender, EventArgs e)
        {

        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {

        }
    }
}
