
namespace GamePlatform.GUI.Forms
{
    partial class OrderExtraPackageForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.btnSatinAl = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGameName = new System.Windows.Forms.TextBox();
            this.txtExtraPackage = new System.Windows.Forms.TextBox();
            this.txtCouponID = new System.Windows.Forms.TextBox();
            this.dgvExtraPakcage = new System.Windows.Forms.DataGridView();
            this.OrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GameName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExtraPackageName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExtraPakcage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(50, 520);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "OrderID";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(177, 523);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.ReadOnly = true;
            this.txtOrderID.Size = new System.Drawing.Size(171, 22);
            this.txtOrderID.TabIndex = 2;
            // 
            // btnSatinAl
            // 
            this.btnSatinAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatinAl.Location = new System.Drawing.Point(1012, 611);
            this.btnSatinAl.Name = "btnSatinAl";
            this.btnSatinAl.Size = new System.Drawing.Size(170, 40);
            this.btnSatinAl.TabIndex = 3;
            this.btnSatinAl.Text = "Satın Al";
            this.btnSatinAl.UseVisualStyleBackColor = true;
            this.btnSatinAl.Click += new System.EventHandler(this.btnSatinAl_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(409, 523);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Oyun Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label3.Location = new System.Drawing.Point(49, 577);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ekstra Paket Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label4.Location = new System.Drawing.Point(797, 520);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "Coupon ID";
            // 
            // txtGameName
            // 
            this.txtGameName.Location = new System.Drawing.Point(530, 524);
            this.txtGameName.Name = "txtGameName";
            this.txtGameName.ReadOnly = true;
            this.txtGameName.Size = new System.Drawing.Size(182, 22);
            this.txtGameName.TabIndex = 2;
            // 
            // txtExtraPackage
            // 
            this.txtExtraPackage.Location = new System.Drawing.Point(264, 581);
            this.txtExtraPackage.Name = "txtExtraPackage";
            this.txtExtraPackage.ReadOnly = true;
            this.txtExtraPackage.Size = new System.Drawing.Size(447, 22);
            this.txtExtraPackage.TabIndex = 2;
            // 
            // txtCouponID
            // 
            this.txtCouponID.Location = new System.Drawing.Point(971, 523);
            this.txtCouponID.Name = "txtCouponID";
            this.txtCouponID.Size = new System.Drawing.Size(190, 22);
            this.txtCouponID.TabIndex = 2;
            // 
            // dgvExtraPakcage
            // 
            this.dgvExtraPakcage.AllowUserToAddRows = false;
            this.dgvExtraPakcage.AllowUserToDeleteRows = false;
            this.dgvExtraPakcage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExtraPakcage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExtraPakcage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderID,
            this.GameName,
            this.ExtraPackageName,
            this.Price});
            this.dgvExtraPakcage.Location = new System.Drawing.Point(12, 12);
            this.dgvExtraPakcage.Name = "dgvExtraPakcage";
            this.dgvExtraPakcage.ReadOnly = true;
            this.dgvExtraPakcage.RowHeadersWidth = 51;
            this.dgvExtraPakcage.RowTemplate.Height = 24;
            this.dgvExtraPakcage.Size = new System.Drawing.Size(1205, 470);
            this.dgvExtraPakcage.TabIndex = 4;
            this.dgvExtraPakcage.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExtraPakcage_RowEnter);
            // 
            // OrderID
            // 
            this.OrderID.DataPropertyName = "OrderID";
            this.OrderID.HeaderText = "Order ID";
            this.OrderID.MinimumWidth = 6;
            this.OrderID.Name = "OrderID";
            this.OrderID.ReadOnly = true;
            // 
            // GameName
            // 
            this.GameName.DataPropertyName = "GameName";
            this.GameName.HeaderText = "Game Name";
            this.GameName.MinimumWidth = 6;
            this.GameName.Name = "GameName";
            this.GameName.ReadOnly = true;
            // 
            // ExtraPackageName
            // 
            this.ExtraPackageName.DataPropertyName = "ExtraPackageName";
            this.ExtraPackageName.HeaderText = "Extra Package Name";
            this.ExtraPackageName.MinimumWidth = 6;
            this.ExtraPackageName.Name = "ExtraPackageName";
            this.ExtraPackageName.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // OrderExtraPackageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 683);
            this.Controls.Add(this.dgvExtraPakcage);
            this.Controls.Add(this.btnSatinAl);
            this.Controls.Add(this.txtCouponID);
            this.Controls.Add(this.txtExtraPackage);
            this.Controls.Add(this.txtGameName);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OrderExtraPackageForm";
            this.Text = "ExtraPackageForm";
            this.Load += new System.EventHandler(this.OrderExtraPackageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExtraPakcage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Button btnSatinAl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGameName;
        private System.Windows.Forms.TextBox txtExtraPackage;
        private System.Windows.Forms.TextBox txtCouponID;
        private System.Windows.Forms.DataGridView dgvExtraPakcage;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn GameName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExtraPackageName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}