using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace resto.db
{
    public partial class MenuForm : Form
    {
        public class MenuItem
        {
            public string ItemName { get; set; }
            public string Price { get; set; }
            public string Category { get; set; }
            public bool Available { get; set; }
        }

        private List<MenuItem> menuItems = new List<MenuItem>();

        public MenuForm()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            dataGridView1.Columns.Add("ItemName", "Item Name");
            dataGridView1.Columns.Add("Price", "Price");
            dataGridView1.Columns.Add("Category", "Category");
            dataGridView1.Columns.Add("Available", "Available");
        }

        private void RefreshDataGridView()
        {
            dataGridView1.Rows.Clear();
            foreach (var item in menuItems)
            {
                dataGridView1.Rows.Add(item.ItemName, item.Price, item.Category, item.Available ? "Yes" : "No");
            }
        }

        private void ClearFields()
        {
            itemname.Clear();
            price.Clear();
            category.Clear();
            checkBox1.Checked = false;
        }

        private void add_Click(object sender, EventArgs e)
        {
            MenuItem item = new MenuItem
            {
                ItemName = itemname.Text,
                Price = price.Text,
                Category = category.Text,
                Available = checkBox1.Checked
            };
            menuItems.Add(item);
            RefreshDataGridView();
            ClearFields();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                MenuItem selectedItem = menuItems[index];

                selectedItem.ItemName = itemname.Text;
                selectedItem.Price = price.Text;
                selectedItem.Category = category.Text;
                selectedItem.Available = checkBox1.Checked;

                RefreshDataGridView();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Please select an item to edit.");
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                menuItems.RemoveAt(index);
                RefreshDataGridView();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Please select an item to delete.");
            }
        }

        private void fname_Click(object sender, EventArgs e)
        {

        }

        private void lname_Click(object sender, EventArgs e)
        {

        }
    }
}
