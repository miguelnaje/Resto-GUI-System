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
    public partial class EmployeesForm : Form
    {
        public EmployeesForm()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // In-memory storage (no database)
        private List<Employee> employees = new List<Employee>();

        // Simple class to represent an employee
        public class Employee
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Phone { get; set; }
            public string Email { get; set; }
            public string Position { get; set; }
            public string Salary { get; set; }
        }

        private void InitializeDataGridView()
        {
            dataGridView1.Columns.Add("FirstName", "First Name");
            dataGridView1.Columns.Add("LastName", "Last Name");
            dataGridView1.Columns.Add("Phone", "Phone");
            dataGridView1.Columns.Add("Email", "Email");
            dataGridView1.Columns.Add("Position", "Position");
            dataGridView1.Columns.Add("Salary", "Salary");
        }

        private void RefreshDataGridView()
        {
            dataGridView1.Rows.Clear();
            foreach (var emp in employees)
            {
                dataGridView1.Rows.Add(emp.FirstName, emp.LastName, emp.Phone, emp.Email, emp.Position, emp.Salary);
            }
        }

        private void ClearFields()
        {
            firstname.Clear();
            lastname.Clear();
            phonee.Clear();
            emaill.Clear();
            positions.Clear();
            salaryy.Clear();
        }

        // ADD button
        private void add_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee
            {
                FirstName = firstname.Text,
                LastName = lastname.Text,
                Phone = phonee.Text,
                Email = emaill.Text,
                Position = positions.Text,
                Salary = salaryy.Text
            };

            employees.Add(emp);
            RefreshDataGridView();
            ClearFields();
        }

        // EDIT button
        private void edit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;

                employees[index].FirstName = firstname.Text;
                employees[index].LastName = lastname.Text;
                employees[index].Phone = phonee.Text;
                employees[index].Email = emaill.Text;
                employees[index].Position = positions.Text;
                employees[index].Salary = salaryy.Text;

                RefreshDataGridView();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Please select a row to edit.");
            }
        }

        // DELETE button
        private void delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                employees.RemoveAt(index);
                RefreshDataGridView();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        // Optional: Populate fields when a row is selected
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                if (index < employees.Count)
                {
                    var emp = employees[index];
                    firstname.Text = emp.FirstName;
                    lastname.Text = emp.LastName;
                    phonee.Text = emp.Phone;
                    emaill.Text = emp.Email;
                    positions.Text = emp.Position;
                    salaryy.Text = emp.Salary;
                }
            }
        }
    }
}
