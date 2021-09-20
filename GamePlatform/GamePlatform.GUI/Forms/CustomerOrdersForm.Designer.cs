
namespace GamePlatform.GUI.Forms
{
    partial class CustomerOrdersForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNickname = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.dgvOrderGames = new System.Windows.Forms.DataGridView();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPurchaseID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCouponName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGameName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPackageName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUploadOnDesktop = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPaymentDate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCId = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.PurchaseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerNickname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CouponName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GameName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PackageName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UploadOnDesktop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderGames)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvOrderGames);
            this.groupBox1.Location = new System.Drawing.Point(12, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1520, 467);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Oyun Bilgileri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // txtNickname
            // 
            this.txtNickname.Location = new System.Drawing.Point(173, 79);
            this.txtNickname.Name = "txtNickname";
            this.txtNickname.ReadOnly = true;
            this.txtNickname.Size = new System.Drawing.Size(153, 22);
            this.txtNickname.TabIndex = 2;
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFind.Location = new System.Drawing.Point(398, 125);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(164, 40);
            this.btnFind.TabIndex = 4;
            this.btnFind.Text = "Ara";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // dgvOrderGames
            // 
            this.dgvOrderGames.AllowUserToAddRows = false;
            this.dgvOrderGames.AllowUserToDeleteRows = false;
            this.dgvOrderGames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderGames.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PurchaseID,
            this.CustomerID,
            this.CustomerNickname,
            this.Password,
            this.NameSurname,
            this.CouponName,
            this.GameName,
            this.PackageName,
            this.UploadOnDesktop,
            this.Price,
            this.PaymentDate});
            this.dgvOrderGames.Location = new System.Drawing.Point(6, 18);
            this.dgvOrderGames.Name = "dgvOrderGames";
            this.dgvOrderGames.ReadOnly = true;
            this.dgvOrderGames.RowHeadersWidth = 51;
            this.dgvOrderGames.RowTemplate.Height = 24;
            this.dgvOrderGames.Size = new System.Drawing.Size(1511, 429);
            this.dgvOrderGames.TabIndex = 0;
            this.dgvOrderGames.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderGames_CellContentClick);
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(173, 42);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.ReadOnly = true;
            this.txtCustomerID.Size = new System.Drawing.Size(153, 22);
            this.txtCustomerID.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kullanıcı ID";
            // 
            // txtPurchaseID
            // 
            this.txtPurchaseID.Location = new System.Drawing.Point(822, 149);
            this.txtPurchaseID.Name = "txtPurchaseID";
            this.txtPurchaseID.ReadOnly = true;
            this.txtPurchaseID.Size = new System.Drawing.Size(100, 22);
            this.txtPurchaseID.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(659, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Satış ID";
            // 
            // txtCouponName
            // 
            this.txtCouponName.Location = new System.Drawing.Point(453, 39);
            this.txtCouponName.Name = "txtCouponName";
            this.txtCouponName.Size = new System.Drawing.Size(146, 22);
            this.txtCouponName.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(353, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kupon Adı";
            // 
            // txtGameName
            // 
            this.txtGameName.Location = new System.Drawing.Point(453, 79);
            this.txtGameName.Name = "txtGameName";
            this.txtGameName.Size = new System.Drawing.Size(146, 22);
            this.txtGameName.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(353, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Oyun Adı";
            // 
            // txtPackageName
            // 
            this.txtPackageName.Location = new System.Drawing.Point(453, 115);
            this.txtPackageName.Name = "txtPackageName";
            this.txtPackageName.Size = new System.Drawing.Size(146, 22);
            this.txtPackageName.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(351, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Paket Adı";
            // 
            // txtUploadOnDesktop
            // 
            this.txtUploadOnDesktop.Location = new System.Drawing.Point(822, 39);
            this.txtUploadOnDesktop.Name = "txtUploadOnDesktop";
            this.txtUploadOnDesktop.Size = new System.Drawing.Size(100, 22);
            this.txtUploadOnDesktop.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(659, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Bilgisayara Yüklü mü?";
            // 
            // txtPaymentDate
            // 
            this.txtPaymentDate.Location = new System.Drawing.Point(822, 79);
            this.txtPaymentDate.Name = "txtPaymentDate";
            this.txtPaymentDate.ReadOnly = true;
            this.txtPaymentDate.Size = new System.Drawing.Size(100, 22);
            this.txtPaymentDate.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(659, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Satış Tarihi";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(822, 113);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(100, 22);
            this.txtPrice.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(659, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Fiyat";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(173, 117);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(153, 22);
            this.txtPassword.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(48, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Şifre";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCId);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtNName);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.btnFind);
            this.groupBox2.Location = new System.Drawing.Point(961, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(568, 181);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Müşteri Arama";
            // 
            // txtCId
            // 
            this.txtCId.Location = new System.Drawing.Point(180, 48);
            this.txtCId.Name = "txtCId";
            this.txtCId.Size = new System.Drawing.Size(286, 22);
            this.txtCId.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(55, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 25);
            this.label11.TabIndex = 9;
            this.label11.Text = "Kullanıcı ID";
            // 
            // txtNName
            // 
            this.txtNName.Location = new System.Drawing.Point(180, 92);
            this.txtNName.Name = "txtNName";
            this.txtNName.Size = new System.Drawing.Size(286, 22);
            this.txtNName.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(55, 88);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 25);
            this.label12.TabIndex = 7;
            this.label12.Text = "Kullanıcı Adı";
            // 
            // PurchaseID
            // 
            this.PurchaseID.DataPropertyName = "PurchaseID";
            this.PurchaseID.HeaderText = "Purchase ID";
            this.PurchaseID.MinimumWidth = 6;
            this.PurchaseID.Name = "PurchaseID";
            this.PurchaseID.ReadOnly = true;
            this.PurchaseID.Width = 125;
            // 
            // CustomerID
            // 
            this.CustomerID.DataPropertyName = "CustomerID";
            this.CustomerID.HeaderText = "CustomerID";
            this.CustomerID.MinimumWidth = 6;
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            this.CustomerID.Width = 125;
            // 
            // CustomerNickname
            // 
            this.CustomerNickname.DataPropertyName = "CustomerNickname";
            this.CustomerNickname.HeaderText = "Nickname";
            this.CustomerNickname.MinimumWidth = 6;
            this.CustomerNickname.Name = "CustomerNickname";
            this.CustomerNickname.ReadOnly = true;
            this.CustomerNickname.Width = 125;
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Password";
            this.Password.MinimumWidth = 6;
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            this.Password.Width = 125;
            // 
            // NameSurname
            // 
            this.NameSurname.DataPropertyName = "NameSurname";
            this.NameSurname.HeaderText = "Name Surname";
            this.NameSurname.MinimumWidth = 6;
            this.NameSurname.Name = "NameSurname";
            this.NameSurname.ReadOnly = true;
            this.NameSurname.Width = 125;
            // 
            // CouponName
            // 
            this.CouponName.DataPropertyName = "CouponName";
            this.CouponName.HeaderText = "Coupon Name";
            this.CouponName.MinimumWidth = 6;
            this.CouponName.Name = "CouponName";
            this.CouponName.ReadOnly = true;
            this.CouponName.Width = 125;
            // 
            // GameName
            // 
            this.GameName.DataPropertyName = "GameName";
            this.GameName.HeaderText = "Game Name";
            this.GameName.MinimumWidth = 6;
            this.GameName.Name = "GameName";
            this.GameName.ReadOnly = true;
            this.GameName.Width = 125;
            // 
            // PackageName
            // 
            this.PackageName.DataPropertyName = "PackageName";
            this.PackageName.HeaderText = "Package Name";
            this.PackageName.MinimumWidth = 6;
            this.PackageName.Name = "PackageName";
            this.PackageName.ReadOnly = true;
            this.PackageName.Width = 125;
            // 
            // UploadOnDesktop
            // 
            this.UploadOnDesktop.DataPropertyName = "UploadOnDesktop";
            this.UploadOnDesktop.HeaderText = "Upload On Desktop";
            this.UploadOnDesktop.MinimumWidth = 6;
            this.UploadOnDesktop.Name = "UploadOnDesktop";
            this.UploadOnDesktop.ReadOnly = true;
            this.UploadOnDesktop.Width = 125;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 125;
            // 
            // PaymentDate
            // 
            this.PaymentDate.DataPropertyName = "PaymentDate";
            this.PaymentDate.HeaderText = "PaymentDate";
            this.PaymentDate.MinimumWidth = 6;
            this.PaymentDate.Name = "PaymentDate";
            this.PaymentDate.ReadOnly = true;
            this.PaymentDate.Width = 125;
            // 
            // CustomerOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1544, 689);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPaymentDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtUploadOnDesktop);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPackageName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtGameName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCouponName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPurchaseID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNickname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CustomerOrdersForm";
            this.Text = "CustomerOrdersForm";
            this.Load += new System.EventHandler(this.CustomerOrdersForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderGames)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvOrderGames;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNickname;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPurchaseID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCouponName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGameName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPackageName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUploadOnDesktop;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPaymentDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerNickname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn CouponName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GameName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PackageName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UploadOnDesktop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentDate;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNName;
        private System.Windows.Forms.Label label12;
    }
}