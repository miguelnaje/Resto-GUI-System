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
    public partial class PaymentsForm : Form
    {
        public PaymentsForm()
        {
            InitializeComponent();

            // Populate ComboBox options
            comboBox1.Items.AddRange(new string[] { "Gcash", "Cash", "Paypal", "Credit Card" });

            // Set up DataGridView columns
            dataGridView1.Columns.Add("OrderID", "Order ID");
            dataGridView1.Columns.Add("AmountPaid", "Amount Paid");
            dataGridView1.Columns.Add("PaymentMethod", "Payment Method");
            dataGridView1.Columns.Add("PaymentDate", "Payment Date");

            // Wire up button events
            add.Click += Add_Click;
            edit.Click += Edit_Click;
            delete.Click += Delete_Click;
        }

        private void quantityy_TextChanged(object sender, EventArgs e)
        {

        }

        private void paymentdate_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            // Add new row to DataGridView
            dataGridView1.Rows.Add(
                orderid.Text,
                amountpaidd.Text,
                comboBox1.SelectedItem?.ToString() ?? "",
                dateTimePicker1.Value.ToShortDateString()
            );

            ClearFields();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var row = dataGridView1.SelectedRows[0];
                row.Cells[0].Value = orderid.Text;
                row.Cells[1].Value = amountpaidd.Text;
                row.Cells[2].Value = comboBox1.SelectedItem?.ToString() ?? "";
                row.Cells[3].Value = dateTimePicker1.Value.ToShortDateString();

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
            amountpaidd.Clear();
            comboBox1.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now;
        }
    }
}
