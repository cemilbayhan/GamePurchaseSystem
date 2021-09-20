
namespace GamePlatform.GUI.Forms
{
    partial class CustomerForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            this.dtpRegisterDate = new System.Windows.Forms.DateTimePicker();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtNameSurname = new System.Windows.Forms.TextBox();
            this.txtNickname = new System.Windows.Forms.TextBox();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.Order_Game = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Order_ExtraPackage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_Wishlist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerNickname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegisterDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnInsert);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.dtpRegisterDate);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtLocation);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtAge);
            this.groupBox1.Controls.Add(this.txtNameSurname);
            this.groupBox1.Controls.Add(this.txtNickname);
            this.groupBox1.Controls.Add(this.txtCustomerId);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1357, 438);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilgi Giriş Formu";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(195, 398);
            this.txtPhone.Mask = "(999) 000-0000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(192, 30);
            this.txtPhone.TabIndex = 9;
            // 
            // dtpRegisterDate
            // 
            this.dtpRegisterDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRegisterDate.Location = new System.Drawing.Point(195, 178);
            this.dtpRegisterDate.Name = "dtpRegisterDate";
            this.dtpRegisterDate.Size = new System.Drawing.Size(192, 30);
            this.dtpRegisterDate.TabIndex = 4;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(195, 325);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(192, 58);
            this.txtAddress.TabIndex = 8;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(195, 293);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(192, 30);
            this.txtLocation.TabIndex = 7;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(195, 255);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(192, 30);
            this.txtPassword.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(195, 217);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(192, 30);
            this.txtEmail.TabIndex = 5;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(195, 140);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(192, 30);
            this.txtAge.TabIndex = 3;
            // 
            // txtNameSurname
            // 
            this.txtNameSurname.Location = new System.Drawing.Point(195, 103);
            this.txtNameSurname.Name = "txtNameSurname";
            this.txtNameSurname.Size = new System.Drawing.Size(192, 30);
            this.txtNameSurname.TabIndex = 2;
            // 
            // txtNickname
            // 
            this.txtNickname.Location = new System.Drawing.Point(195, 67);
            this.txtNickname.Name = "txtNickname";
            this.txtNickname.Size = new System.Drawing.Size(192, 30);
            this.txtNickname.TabIndex = 1;
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Location = new System.Drawing.Point(195, 30);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.ReadOnly = true;
            this.txtCustomerId.Size = new System.Drawing.Size(192, 30);
            this.txtCustomerId.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 404);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "Phone Number";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 328);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Adress";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 299);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Location";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "E-Mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Register Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Name Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Age";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nickname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvCustomers);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 444);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1357, 355);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Müşteri Listesi";
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvCustomers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Order_Game,
            this.Order_ExtraPackage,
            this.Customer_Wishlist,
            this.CustomerID,
            this.CustomerNickname,
            this.NameSurname,
            this.Age,
            this.RegisterDate,
            this.Email,
            this.Password,
            this.Location,
            this.Address,
            this.TelNumber});
            this.dgvCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomers.Location = new System.Drawing.Point(3, 26);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.RowHeadersWidth = 51;
            this.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomers.Size = new System.Drawing.Size(1351, 326);
            this.dgvCustomers.TabIndex = 0;
            this.dgvCustomers.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomers_RowEnter);
            // 
            // Order_Game
            // 
            this.Order_Game.DataPropertyName = "Order_Game";
            this.Order_Game.HeaderText = "Order_Game";
            this.Order_Game.MinimumWidth = 6;
            this.Order_Game.Name = "Order_Game";
            this.Order_Game.ReadOnly = true;
            this.Order_Game.Visible = false;
            this.Order_Game.Width = 120;
            // 
            // Order_ExtraPackage
            // 
            this.Order_ExtraPackage.DataPropertyName = "Order_ExtraPackage";
            this.Order_ExtraPackage.HeaderText = "Order_ExtraPackage";
            this.Order_ExtraPackage.MinimumWidth = 6;
            this.Order_ExtraPackage.Name = "Order_ExtraPackage";
            this.Order_ExtraPackage.ReadOnly = true;
            this.Order_ExtraPackage.Visible = false;
            this.Order_ExtraPackage.Width = 169;
            // 
            // Customer_Wishlist
            // 
            this.Customer_Wishlist.DataPropertyName = "Customer_Wishlist";
            this.Customer_Wishlist.HeaderText = "Customer_Wishlist";
            this.Customer_Wishlist.MinimumWidth = 6;
            this.Customer_Wishlist.Name = "Customer_Wishlist";
            this.Customer_Wishlist.ReadOnly = true;
            this.Customer_Wishlist.Visible = false;
            this.Customer_Wishlist.Width = 153;
            // 
            // CustomerID
            // 
            this.CustomerID.DataPropertyName = "CustomerID";
            this.CustomerID.HeaderText = "Customer Id";
            this.CustomerID.MinimumWidth = 6;
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            this.CustomerID.Width = 135;
            // 
            // CustomerNickname
            // 
            this.CustomerNickname.DataPropertyName = "CustomerNickname";
            this.CustomerNickname.HeaderText = "Customer Nickname";
            this.CustomerNickname.MinimumWidth = 6;
            this.CustomerNickname.Name = "CustomerNickname";
            this.CustomerNickname.ReadOnly = true;
            this.CustomerNickname.Width = 199;
            // 
            // NameSurname
            // 
            this.NameSurname.DataPropertyName = "NameSurname";
            this.NameSurname.HeaderText = "Name Surname";
            this.NameSurname.MinimumWidth = 6;
            this.NameSurname.Name = "NameSurname";
            this.NameSurname.ReadOnly = true;
            this.NameSurname.Width = 163;
            // 
            // Age
            // 
            this.Age.DataPropertyName = "Age";
            this.Age.HeaderText = "Age";
            this.Age.MinimumWidth = 6;
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            this.Age.Width = 77;
            // 
            // RegisterDate
            // 
            this.RegisterDate.DataPropertyName = "RegisterDate";
            this.RegisterDate.HeaderText = "Register Date";
            this.RegisterDate.MinimumWidth = 6;
            this.RegisterDate.Name = "RegisterDate";
            this.RegisterDate.ReadOnly = true;
            this.RegisterDate.Width = 145;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "E-mail";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 96;
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Password";
            this.Password.MinimumWidth = 6;
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            this.Password.Width = 127;
            // 
            // Location
            // 
            this.Location.DataPropertyName = "Location";
            this.Location.HeaderText = "Location";
            this.Location.MinimumWidth = 6;
            this.Location.Name = "Location";
            this.Location.ReadOnly = true;
            this.Location.Width = 115;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Address";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 114;
            // 
            // TelNumber
            // 
            this.TelNumber.DataPropertyName = "TelNumber";
            this.TelNumber.HeaderText = "Phone Number";
            this.TelNumber.MinimumWidth = 6;
            this.TelNumber.Name = "TelNumber";
            this.TelNumber.ReadOnly = true;
            this.TelNumber.Width = 157;
            // 
            // btnClear
            // 
            this.btnClear.Image = global::GamePlatform.GUI.IconImages.kaboodleloop;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(781, 382);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(182, 46);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Formu Temizle";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::GamePlatform.GUI.IconImages.button_cancel;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(673, 382);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(102, 46);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Sil";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Image = global::GamePlatform.GUI.IconImages.filesaveas;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(534, 382);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(135, 46);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Image = global::GamePlatform.GUI.IconImages.filesave;
            this.btnInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsert.Location = new System.Drawing.Point(393, 382);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(135, 46);
            this.btnInsert.TabIndex = 10;
            this.btnInsert.Text = "Kaydet";
            this.btnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 799);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CustomerForm";
            this.Text = "Games Form";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNickname;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtPhone;
        private System.Windows.Forms.DateTimePicker dtpRegisterDate;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtNameSurname;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order_Game;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order_ExtraPackage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_Wishlist;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerNickname;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegisterDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelNumber;
    }
}