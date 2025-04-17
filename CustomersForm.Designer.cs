namespace resto.db
{
    partial class CustomersForm
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
            this.address = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.Label();
            this.lname = new System.Windows.Forms.Label();
            this.fname = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.lastname = new System.Windows.Forms.TextBox();
            this.phonee = new System.Windows.Forms.TextBox();
            this.emaill = new System.Windows.Forms.TextBox();
            this.addresss = new System.Windows.Forms.TextBox();
            this.firstname = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.address);
            this.panel1.Controls.Add(this.email);
            this.panel1.Controls.Add(this.Phone);
            this.panel1.Controls.Add(this.lname);
            this.panel1.Controls.Add(this.fname);
            this.panel1.Controls.Add(this.delete);
            this.panel1.Controls.Add(this.Edit);
            this.panel1.Controls.Add(this.add);
            this.panel1.Controls.Add(this.lastname);
            this.panel1.Controls.Add(this.phonee);
            this.panel1.Controls.Add(this.emaill);
            this.panel1.Controls.Add(this.addresss);
            this.panel1.Controls.Add(this.firstname);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(86, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 374);
            this.panel1.TabIndex = 0;
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Location = new System.Drawing.Point(342, 78);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(58, 16);
            this.address.TabIndex = 13;
            this.address.Text = "Address";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(345, 41);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(41, 16);
            this.email.TabIndex = 12;
            this.email.Text = "Email";
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Location = new System.Drawing.Point(39, 116);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(46, 16);
            this.Phone.TabIndex = 11;
            this.Phone.Text = "Phone";
            // 
            // lname
            // 
            this.lname.AutoSize = true;
            this.lname.Location = new System.Drawing.Point(39, 78);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(72, 16);
            this.lname.TabIndex = 10;
            this.lname.Text = "Last Name";
            // 
            // fname
            // 
            this.fname.AutoSize = true;
            this.fname.Location = new System.Drawing.Point(39, 41);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(72, 16);
            this.fname.TabIndex = 9;
            this.fname.Text = "First Name";
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
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(276, 167);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(85, 29);
            this.Edit.TabIndex = 7;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(117, 167);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(85, 29);
            this.add.TabIndex = 6;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.button1_Click);
            // 
            // lastname
            // 
            this.lastname.Location = new System.Drawing.Point(117, 72);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(192, 22);
            this.lastname.TabIndex = 5;
            this.lastname.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // phonee
            // 
            this.phonee.Location = new System.Drawing.Point(117, 110);
            this.phonee.Name = "phonee";
            this.phonee.Size = new System.Drawing.Size(192, 22);
            this.phonee.TabIndex = 4;
            this.phonee.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // emaill
            // 
            this.emaill.Location = new System.Drawing.Point(410, 35);
            this.emaill.Name = "emaill";
            this.emaill.Size = new System.Drawing.Size(199, 22);
            this.emaill.TabIndex = 3;
            // 
            // addresss
            // 
            this.addresss.Location = new System.Drawing.Point(410, 72);
            this.addresss.Name = "addresss";
            this.addresss.Size = new System.Drawing.Size(199, 22);
            this.addresss.TabIndex = 2;
            // 
            // firstname
            // 
            this.firstname.Location = new System.Drawing.Point(117, 35);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(192, 22);
            this.firstname.TabIndex = 1;
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
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "CustomersForm";
            this.Text = "Customers Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.TextBox phonee;
        private System.Windows.Forms.TextBox emaill;
        private System.Windows.Forms.TextBox addresss;
        private System.Windows.Forms.TextBox firstname;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.Label lname;
        private System.Windows.Forms.Label fname;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button add;
    }
}

