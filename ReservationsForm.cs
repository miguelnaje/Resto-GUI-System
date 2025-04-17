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
    public partial class ReservationsForm : Form
    {
        public ReservationsForm()
        {
            InitializeComponent();

            // Populate ComboBox with reservation status
            comboBox1.Items.AddRange(new string[] { "Complete", "Cancelled", "Pending" });

            // Set up DataGridView columns
            dataGridView1.Columns.Add("CustomerID", "Customer ID");
            dataGridView1.Columns.Add("People", "No. of People");
            dataGridView1.Columns.Add("Date", "Date");
            dataGridView1.Columns.Add("Status", "Status");

            // Wire up button events
            add.Click += Add_Click;
            edit.Click += Edit_Click;
            delete.Click += Delete_Click;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Add_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(
                customerid.Text,
                peoples.Text,
                dateTimePicker1.Value.ToShortDateString(),
                comboBox1.SelectedItem?.ToString() ?? ""
            );

            ClearFields();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var row = dataGridView1.SelectedRows[0];
                row.Cells[0].Value = customerid.Text;
                row.Cells[1].Value = peoples.Text;
                row.Cells[2].Value = dateTimePicker1.Value.ToShortDateString();
                row.Cells[3].Value = comboBox1.SelectedItem?.ToString() ?? "";

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
            customerid.Clear();
            peoples.Clear();
            comboBox1.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now;
        }
    }
}
