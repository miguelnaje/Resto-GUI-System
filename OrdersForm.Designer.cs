namespace resto.db
{
    partial class OrdersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.total = new System.Windows.Forms.Label();
            this.employee = new System.Windows.Forms.Label();
            this.fname = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.employeeid = new System.Windows.Forms.TextBox();
            this.totalamount = new System.Windows.Forms.TextBox();
            this.customerid = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderstatus = new System.Windows.Forms.TextBox();
            this.statusorder = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.orderdate = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.orderdate);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.statusorder);
            this.panel1.Controls.Add(this.orderstatus);
            this.panel1.Controls.Add(this.total);
            this.panel1.Controls.Add(this.employee);
            this.panel1.Controls.Add(this.fname);
            this.panel1.Controls.Add(this.delete);
            this.panel1.Controls.Add(this.edit);
            this.panel1.Controls.Add(this.add);
            this.panel1.Controls.Add(this.employeeid);
            this.panel1.Controls.Add(this.totalamount);
            this.panel1.Controls.Add(this.customerid);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(72, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 374);
            this.panel1.TabIndex = 3;
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Location = new System.Drawing.Point(35, 116);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(86, 16);
            this.total.TabIndex = 11;
            this.total.Text = "Total Amount";
            // 
            // employee
            // 
            this.employee.AutoSize = true;
            this.employee.Location = new System.Drawing.Point(39, 78);
            this.employee.Name = "employee";
            this.employee.Size = new System.Drawing.Size(85, 16);
            this.employee.TabIndex = 10;
            this.employee.Text = "Employee ID";
            // 
            // fname
            // 
            this.fname.AutoSize = true;
            this.fname.Location = new System.Drawing.Point(39, 41);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(80, 16);
            this.fname.TabIndex = 9;
            this.fname.Text = "Customer ID";
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(449, 167);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(85, 29);
            this.delete.TabIndex = 8;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click_1);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(282, 167);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(85, 29);
            this.edit.TabIndex = 7;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(117, 167);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(85, 29);
            this.add.TabIndex = 6;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // employeeid
            // 
            this.employeeid.Location = new System.Drawing.Point(127, 72);
            this.employeeid.Name = "employeeid";
            this.employeeid.Size = new System.Drawing.Size(192, 22);
            this.employeeid.TabIndex = 5;
            // 
            // totalamount
            // 
            this.totalamount.Location = new System.Drawing.Point(127, 110);
            this.totalamount.Name = "totalamount";
            this.totalamount.Size = new System.Drawing.Size(192, 22);
            this.totalamount.TabIndex = 4;
            // 
            // customerid
            // 
            this.customerid.Location = new System.Drawing.Point(127, 35);
            this.customerid.Name = "customerid";
            this.customerid.Size = new System.Drawing.Size(192, 22);
            this.customerid.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(42, 223);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(567, 122);
            this.dataGridView1.TabIndex = 0;
            // 
            // orderstatus
            // 
            this.orderstatus.Location = new System.Drawing.Point(421, 38);
            this.orderstatus.Name = "orderstatus";
            this.orderstatus.Size = new System.Drawing.Size(192, 22);
            this.orderstatus.TabIndex = 12;
            this.orderstatus.TextChanged += new System.EventHandler(this.orderstatus_TextChanged);
            // 
            // statusorder
            // 
            this.statusorder.AutoSize = true;
            this.statusorder.Location = new System.Drawing.Point(334, 41);
            this.statusorder.Name = "statusorder";
            this.statusorder.Size = new System.Drawing.Size(81, 16);
            this.statusorder.TabIndex = 13;
            this.statusorder.Text = "Order Status";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(421, 73);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(188, 22);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // orderdate
            // 
            this.orderdate.AutoSize = true;
            this.orderdate.Location = new System.Drawing.Point(342, 78);
            this.orderdate.Name = "orderdate";
            this.orderdate.Size = new System.Drawing.Size(73, 16);
            this.orderdate.TabIndex = 15;
            this.orderdate.Text = "Order Date";
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "OrdersForm";
            this.Text = "OrdersForm";
            this.Load += new System.EventHandler(this.OrdersForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label employee;
        private System.Windows.Forms.Label fname;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox employeeid;
        private System.Windows.Forms.TextBox totalamount;
        private System.Windows.Forms.TextBox customerid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label statusorder;
        private System.Windows.Forms.TextBox orderstatus;
        private System.Windows.Forms.Label orderdate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}