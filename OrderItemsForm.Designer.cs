namespace resto.db
{
    partial class OrderItemsForm
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
            this.reservation = new System.Windows.Forms.Label();
            this.paymentmethod = new System.Windows.Forms.Label();
            this.amountpaid = new System.Windows.Forms.Label();
            this.fname = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.menuid = new System.Windows.Forms.TextBox();
            this.orderid = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.quantity = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.price);
            this.panel1.Controls.Add(this.quantity);
            this.panel1.Controls.Add(this.reservation);
            this.panel1.Controls.Add(this.paymentmethod);
            this.panel1.Controls.Add(this.amountpaid);
            this.panel1.Controls.Add(this.fname);
            this.panel1.Controls.Add(this.delete);
            this.panel1.Controls.Add(this.edit);
            this.panel1.Controls.Add(this.add);
            this.panel1.Controls.Add(this.menuid);
            this.panel1.Controls.Add(this.orderid);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(58, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 389);
            this.panel1.TabIndex = 7;
            // 
            // reservation
            // 
            this.reservation.AutoSize = true;
            this.reservation.Location = new System.Drawing.Point(372, 44);
            this.reservation.Name = "reservation";
            this.reservation.Size = new System.Drawing.Size(38, 16);
            this.reservation.TabIndex = 15;
            this.reservation.Text = "Price";
            // 
            // paymentmethod
            // 
            this.paymentmethod.AutoSize = true;
            this.paymentmethod.Location = new System.Drawing.Point(35, 116);
            this.paymentmethod.Name = "paymentmethod";
            this.paymentmethod.Size = new System.Drawing.Size(55, 16);
            this.paymentmethod.TabIndex = 11;
            this.paymentmethod.Text = "Quantity";
            // 
            // amountpaid
            // 
            this.amountpaid.AutoSize = true;
            this.amountpaid.Location = new System.Drawing.Point(35, 78);
            this.amountpaid.Name = "amountpaid";
            this.amountpaid.Size = new System.Drawing.Size(56, 16);
            this.amountpaid.TabIndex = 10;
            this.amountpaid.Text = "Menu ID";
            // 
            // fname
            // 
            this.fname.AutoSize = true;
            this.fname.Location = new System.Drawing.Point(35, 41);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(57, 16);
            this.fname.TabIndex = 9;
            this.fname.Text = "Order ID";
            this.fname.Click += new System.EventHandler(this.fname_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(449, 167);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(85, 29);
            this.delete.TabIndex = 8;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(282, 167);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(85, 29);
            this.edit.TabIndex = 7;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = true;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(117, 167);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(85, 29);
            this.add.TabIndex = 6;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            // 
            // menuid
            // 
            this.menuid.Location = new System.Drawing.Point(117, 75);
            this.menuid.Name = "menuid";
            this.menuid.Size = new System.Drawing.Size(192, 22);
            this.menuid.TabIndex = 5;
            // 
            // orderid
            // 
            this.orderid.Location = new System.Drawing.Point(117, 35);
            this.orderid.Name = "orderid";
            this.orderid.Size = new System.Drawing.Size(192, 22);
            this.orderid.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(42, 223);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(596, 122);
            this.dataGridView1.TabIndex = 0;
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(117, 110);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(192, 22);
            this.quantity.TabIndex = 19;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(416, 38);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(192, 22);
            this.price.TabIndex = 20;
            // 
            // OrderItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "OrderItemsForm";
            this.Text = "OrderItemsForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label reservation;
        private System.Windows.Forms.Label paymentmethod;
        private System.Windows.Forms.Label amountpaid;
        private System.Windows.Forms.Label fname;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox menuid;
        private System.Windows.Forms.TextBox orderid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox quantity;
    }
}