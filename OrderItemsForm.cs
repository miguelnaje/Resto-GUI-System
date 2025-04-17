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
    public partial class OrderItemsForm : Form
    {
        public OrderItemsForm()
        {
            InitializeComponent();

            // Initialize DataGridView columns
            dataGridView1.Columns.Add("OrderID", "Order ID");
            dataGridView1.Columns.Add("MenuID", "Menu ID");
            dataGridView1.Columns.Add("Quantity", "Quantity");
            dataGridView1.Columns.Add("Price", "Price");

            // Wire up button click events
            add.Click += Add_Click;
            edit.Click += Edit_Click;
            delete.Click += Delete_Click;
        }

        private void fname_Click(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(
                orderid.Text,
                menuid.Text,
                quantity.Text,
                price.Text
            );

            ClearFields();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var row = dataGridView1.SelectedRows[0];
                row.Cells[0].Value = orderid.Text;
                row.Cells[1].Value = menuid.Text;
                row.Cells[2].Value = quantity.Text;
                row.Cells[3].Value = price.Text;

                ClearFields();
            }
            else
            {
                MessageBox.Show("Please select a row to edit.");
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                ClearFields();
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void ClearFields()
        {
            orderid.Clear();
            menuid.Clear();
            quantity.Clear();
            price.Clear();
        }
    }
}
