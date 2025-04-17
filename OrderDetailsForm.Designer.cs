namespace resto.db
{
    partial class OrderDetailsForm
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
            this.totalpricee = new System.Windows.Forms.TextBox();
            this.totalprice = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.pricee = new System.Windows.Forms.TextBox();
            this.quantity = new System.Windows.Forms.Label();
            this.productid = new System.Windows.Forms.Label();
            this.fname = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.productidd = new System.Windows.Forms.TextBox();
            this.quantityy = new System.Windows.Forms.TextBox();
            this.orderid = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.totalpricee);
            this.panel1.Controls.Add(this.totalprice);
            this.panel1.Controls.Add(this.price);
            this.panel1.Controls.Add(this.pricee);
            this.panel1.Controls.Add(this.quantity);
            this.panel1.Controls.Add(this.productid);
            this.panel1.Controls.Add(this.fname);
            this.panel1.Controls.Add(this.delete);
            this.panel1.Controls.Add(this.edit);
            this.panel1.Controls.Add(this.add);
            this.panel1.Controls.Add(this.productidd);
            this.panel1.Controls.Add(this.quantityy);
            this.panel1.Controls.Add(this.orderid);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(72, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 374);
            this.panel1.TabIndex = 4;
            // 
            // totalpricee
            // 
            this.totalpricee.Location = new System.Drawing.Point(421, 75);
            this.totalpricee.Name = "totalpricee";
            this.totalpricee.Size = new System.Drawing.Size(192, 22);
            this.totalpricee.TabIndex = 16;
            // 
            // totalprice
            // 
            this.totalprice.AutoSize = true;
            this.totalprice.Location = new System.Drawing.Point(342, 78);
            this.totalprice.Name = "totalprice";
            this.totalprice.Size = new System.Drawing.Size(72, 16);
            this.totalprice.TabIndex = 15;
            this.totalprice.Text = "Total Price";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Location = new System.Drawing.Point(342, 38);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(38, 16);
            this.price.TabIndex = 13;
            this.price.Text = "Price";
            // 
            // pricee
            // 
            this.pricee.Location = new System.Drawing.Point(421, 38);
            this.pricee.Name = "pricee";
            this.pricee.Size = new System.Drawing.Size(192, 22);
            this.pricee.TabIndex = 12;
            // 
            // quantity
            // 
            this.quantity.AutoSize = true;
            this.quantity.Location = new System.Drawing.Point(35, 116);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(55, 16);
            this.quantity.TabIndex = 11;
            this.quantity.Text = "Quantity";
            // 
            // productid
            // 
            this.productid.AutoSize = true;
            this.productid.Location = new System.Drawing.Point(39, 78);
            this.productid.Name = "productid";
            this.productid.Size = new System.Drawing.Size(69, 16);
            this.productid.TabIndex = 10;
            this.productid.Text = "Product ID";
            // 
            // fname
            // 
            this.fname.AutoSize = true;
            this.fname.Location = new System.Drawing.Point(39, 41);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(57, 16);
            this.fname.TabIndex = 9;
            this.fname.Text = "Order ID";
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(449, 167);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(85, 29);
            this.delete.TabIndex = 8;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
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
            // productidd
            // 
            this.productidd.Location = new System.Drawing.Point(127, 72);
            this.productidd.Name = "productidd";
            this.productidd.Size = new System.Drawing.Size(192, 22);
            this.productidd.TabIndex = 5;
            // 
            // quantityy
            // 
            this.quantityy.Location = new System.Drawing.Point(127, 110);
            this.quantityy.Name = "quantityy";
            this.quantityy.Size = new System.Drawing.Size(192, 22);
            this.quantityy.TabIndex = 4;
            // 
            // orderid
            // 
            this.orderid.Location = new System.Drawing.Point(127, 35);
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
            this.dataGridView1.Size = new System.Drawing.Size(567, 122);
            this.dataGridView1.TabIndex = 0;
            // 
            // OrderDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "OrderDetailsForm";
            this.Text = "OrderDetailsForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label totalprice;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.TextBox pricee;
        private System.Windows.Forms.Label quantity;
        private System.Windows.Forms.Label productid;
        private System.Windows.Forms.Label fname;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox productidd;
        private System.Windows.Forms.TextBox quantityy;
        private System.Windows.Forms.TextBox orderid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox totalpricee;
    }
}