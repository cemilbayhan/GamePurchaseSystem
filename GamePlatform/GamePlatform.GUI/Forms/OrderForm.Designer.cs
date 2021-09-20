
namespace GamePlatform.GUI.Forms
{
    partial class OrderForm
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
            this.dgvBuyGame = new System.Windows.Forms.DataGridView();
            this.OrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GameID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GameName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PackageName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PackageID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCouponID = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPackageType = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGameName = new System.Windows.Forms.TextBox();
            this.btnSatinAl = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuyGame)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBuyGame
            // 
            this.dgvBuyGame.AllowUserToAddRows = false;
            this.dgvBuyGame.AllowUserToDeleteRows = false;
            this.dgvBuyGame.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBuyGame.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuyGame.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderID,
            this.GameID,
            this.GameName,
            this.PackageName,
            this.Price,
            this.PackageID});
            this.dgvBuyGame.Location = new System.Drawing.Point(12, 12);
            this.dgvBuyGame.Name = "dgvBuyGame";
            this.dgvBuyGame.ReadOnly = true;
            this.dgvBuyGame.RowHeadersWidth = 51;
            this.dgvBuyGame.RowTemplate.Height = 24;
            this.dgvBuyGame.Size = new System.Drawing.Size(1316, 390);
            this.dgvBuyGame.TabIndex = 0;
            this.dgvBuyGame.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBuyGame_RowEnter);
            // 
            // OrderID
            // 
            this.OrderID.DataPropertyName = "OrderID";
            this.OrderID.HeaderText = "Order ID";
            this.OrderID.MinimumWidth = 6;
            this.OrderID.Name = "OrderID";
            this.OrderID.ReadOnly = true;
            // 
            // GameID
            // 
            this.GameID.DataPropertyName = "GameID";
            this.GameID.HeaderText = "Game ID";
            this.GameID.MinimumWidth = 6;
            this.GameID.Name = "GameID";
            this.GameID.ReadOnly = true;
            this.GameID.Visible = false;
            // 
            // GameName
            // 
            this.GameName.DataPropertyName = "GameName";
            this.GameName.HeaderText = "Game Name";
            this.GameName.MinimumWidth = 6;
            this.GameName.Name = "GameName";
            this.GameName.ReadOnly = true;
            // 
            // PackageName
            // 
            this.PackageName.DataPropertyName = "PackageName";
            this.PackageName.HeaderText = "Package Name";
            this.PackageName.MinimumWidth = 6;
            this.PackageName.Name = "PackageName";
            this.PackageName.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // PackageID
            // 
            this.PackageID.DataPropertyName = "PackageID";
            this.PackageID.HeaderText = "Package ID";
            this.PackageID.MinimumWidth = 6;
            this.PackageID.Name = "PackageID";
            this.PackageID.ReadOnly = true;
            this.PackageID.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(982, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Coupon ID:";
            this.label5.UseCompatibleTextRendering = true;
            // 
            // txtCouponID
            // 
            this.txtCouponID.Location = new System.Drawing.Point(1060, 32);
            this.txtCouponID.Name = "txtCouponID";
            this.txtCouponID.Size = new System.Drawing.Size(214, 22);
            this.txtCouponID.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtPackageType);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtGameName);
            this.groupBox3.Controls.Add(this.btnSatinAl);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtCouponID);
            this.groupBox3.Controls.Add(this.txtOrderID);
            this.groupBox3.Location = new System.Drawing.Point(12, 408);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1316, 136);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Seçimler";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(596, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "Seçilen Tür";
            // 
            // txtPackageType
            // 
            this.txtPackageType.Location = new System.Drawing.Point(692, 32);
            this.txtPackageType.Name = "txtPackageType";
            this.txtPackageType.ReadOnly = true;
            this.txtPackageType.Size = new System.Drawing.Size(256, 22);
            this.txtPackageType.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Oyun";
            // 
            // txtGameName
            // 
            this.txtGameName.Location = new System.Drawing.Point(321, 32);
            this.txtGameName.Name = "txtGameName";
            this.txtGameName.ReadOnly = true;
            this.txtGameName.Size = new System.Drawing.Size(256, 22);
            this.txtGameName.TabIndex = 8;
            // 
            // btnSatinAl
            // 
            this.btnSatinAl.Location = new System.Drawing.Point(1150, 76);
            this.btnSatinAl.Name = "btnSatinAl";
            this.btnSatinAl.Size = new System.Drawing.Size(147, 44);
            this.btnSatinAl.TabIndex = 6;
            this.btnSatinAl.Text = "Satın Al";
            this.btnSatinAl.UseVisualStyleBackColor = true;
            this.btnSatinAl.Click += new System.EventHandler(this.btnSatinAl_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Order ID";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(83, 32);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.ReadOnly = true;
            this.txtOrderID.Size = new System.Drawing.Size(140, 22);
            this.txtOrderID.TabIndex = 4;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 549);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dgvBuyGame);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuyGame)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBuyGame;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCouponID;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPackageType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGameName;
        private System.Windows.Forms.Button btnSatinAl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn GameID;
        private System.Windows.Forms.DataGridViewTextBoxColumn GameName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PackageName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn PackageID;
    }
}