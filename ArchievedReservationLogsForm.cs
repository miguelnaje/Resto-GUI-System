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
    public partial class ArchievedReservationLogsForm : Form
    {
        public ArchievedReservationLogsForm()
        {
            InitializeComponent();

            // Set up DataGridView columns
            dataGridView1.Columns.Add("ReservationID", "Reservation ID");
            dataGridView1.Columns.Add("Action", "Action");
            dataGridView1.Columns.Add("StartDate", "Start Date");
            dataGridView1.Columns.Add("EndDate", "End Date");

            // Wire up event handlers for buttons
            add.Click += Add_Click;
            edit.Click += Edit_Click;
            delete.Click += Delete_Click;
        }

        private void fname_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(
                reservationid.Text,
                actionn.Text,
                dateTimePicker1.Value.ToString("g"),
                dateTimePicker2.Value.ToString("g")
            );
            ClearFields();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var row = dataGridView1.SelectedRows[0];
                row.Cells[0].Value = reservationid.Text;
                row.Cells[1].Value = actionn.Text;
                row.Cells[2].Value = dateTimePicker1.Value.ToString("g");
                row.Cells[3].Value = dateTimePicker2.Value.ToString("g");

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
            reservationid.Clear();
            actionn.Clear();
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
        }

        private void reservationid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
