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
    public partial class OrderDetailsForm : Form
    {
        public OrderDetailsForm()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        // Order detail model
        public class OrderDetail
        {
            public string OrderID { get; set; }
            public string ProductID { get; set; }
            public string Quantity { get; set; }
            public string Price { get; set; }
            public string TotalPrice { get; set; }
        }

        // List to store data temporarily
        private List<OrderDetail> orderDetails = new List<OrderDetail>();

        // Setup DataGridView
        private void InitializeDataGridView()
        {
            dataGridView1.Columns.Add("OrderID", "Order ID");
            dataGridView1.Columns.Add("ProductID", "Product ID");
            dataGridView1.Columns.Add("Quantity", "Quantity");
            dataGridView1.Columns.Add("Price", "Price");
            dataGridView1.Columns.Add("TotalPrice", "Total Price");
        }

        private void RefreshGrid()
        {
            dataGridView1.Rows.Clear();
            foreach (var od in orderDetails)
            {
                dataGridView1.Rows.Add(od.OrderID, od.ProductID, od.Quantity, od.Price, od.TotalPrice);
            }
        }

        private void ClearFields()
        {
            orderid.Text = "";
            productidd.Text = "";
            quantityy.Text = "";
            pricee.Text = "";
            totalpricee.Text = "";
        }

        private void add_Click(object sender, EventArgs e)
        {
            var newDetail = new OrderDetail
            {
                OrderID = orderid.Text,
                ProductID = productidd.Text,
                Quantity = quantityy.Text,
                Price = pricee.Text,
                TotalPrice = totalpricee.Text
            };

            orderDetails.Add(newDetail);
            RefreshGrid();
            ClearFields();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int i = dataGridView1.SelectedRows[0].Index;
                orderDetails[i].OrderID = orderid.Text;
                orderDetails[i].ProductID = productidd.Text;
                orderDetails[i].Quantity = quantityy.Text;
                orderDetails[i].Price = pricee.Text;
                orderDetails[i].TotalPrice = totalpricee.Text;

                RefreshGrid();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Please select a row to edit.");
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int i = dataGridView1.SelectedRows[0].Index;
                orderDetails.RemoveAt(i);

                RefreshGrid();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }
    }
}
