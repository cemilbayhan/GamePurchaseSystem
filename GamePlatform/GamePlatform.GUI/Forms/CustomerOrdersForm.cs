using GamePlatform.Business.Repository.Concrete;
using GamePlatform.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamePlatform.GUI.Forms
{
    public partial class CustomerOrdersForm : Form
    {
        OrderManagement orderManagement = new OrderManagement();
        UserManagement userManagement = new UserManagement();

        public CustomerOrdersForm()
        {
            InitializeComponent();
        }

        private void List()
        {
          //  dgvOrderGames.DataSource = orderManagement.GetOrderGames();
        }


        private void CustomerOrdersForm_Load(object sender, EventArgs e)
        {
            List();

        }

        private void dgvOrderGames_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRow = dgvOrderGames.Rows[e.RowIndex];
            txtPurchaseID.Text =selectedRow.Cells["PurchaseID"].Value.ToString();
            txtCustomerID.Text =selectedRow.Cells["CustomerID"].Value.ToString();
            txtNickname.Text =selectedRow.Cells["CustomerNickname"].Value.ToString();
            txtPassword.Text =selectedRow.Cells["Password"].Value.ToString();
            txtCouponName.Text =selectedRow.Cells["CouponName"].Value.ToString();
            txtGameName.Text =  selectedRow.Cells["GameName"].Value.ToString();          
            txtPackageName.Text =selectedRow.Cells["PackageName"].Value.ToString();
            txtUploadOnDesktop.Text = selectedRow.Cells["UploadOnDesktop"].Value.ToString();
            txtPrice.Text = selectedRow.Cells["Price"].Value.ToString();
            txtPaymentDate.Text =selectedRow.Cells["PaymentDate"].Value.ToString();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            var user = userManagement.Get(u => u.CustomerNickname == txtNName.Text && u.CustomerID == Convert.ToInt32(txtCId.Text));
            if (user != null)
            {
                userManagement.GetById(user.CustomerID);
                if(user.CustomerID == Convert.ToInt32(dgvOrderGames.DataSource.Equals(CustomerID)))
                {
                   //******************/////
                }
            }
            else
            {
                MessageBox.Show("Müşteri bulunamadı", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
        }
    }
}
