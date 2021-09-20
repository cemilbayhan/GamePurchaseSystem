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
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        CustomerManagement customerManagement = new CustomerManagement();
        private void List()
        {
            dgvCustomers.DataSource = customerManagement.GetAll();
        }

        private void Clear()
        {
            txtAddress.Clear();
            txtAge.Clear();
            txtCustomerId.Clear();
            txtEmail.Clear();
            txtLocation.Clear();
            txtNameSurname.Clear();
            txtNickname.Clear();
            txtPassword.Clear();
            txtPhone.Clear();
            dtpRegisterDate.Value = DateTime.Now;
        }
        private void CustomerForm_Load(object sender, EventArgs e)
        {
            List();
        }

        private void dgvCustomers_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRow = dgvCustomers.Rows[e.RowIndex];
            txtCustomerId.Text = selectedRow.Cells["CustomerID"].Value.ToString();
            txtNickname.Text = selectedRow.Cells["CustomerNickname"].Value.ToString();
            txtNameSurname.Text = selectedRow.Cells["NameSurname"].Value.ToString();
            txtAge.Text = selectedRow.Cells["Age"].Value.ToString();
            dtpRegisterDate.Value = Convert.ToDateTime(selectedRow.Cells["RegisterDate"].Value);
            txtPassword.Text = selectedRow.Cells["Password"].Value.ToString();
            txtLocation.Text = selectedRow.Cells["Location"].Value.ToString();
            txtAddress.Text = selectedRow.Cells["Address"].Value.ToString();
            txtPhone.Text = selectedRow.Cells["TelNumber"].Value.ToString();
            txtEmail.Text = selectedRow.Cells["Email"].Value.ToString();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bilgiler kaydedilecek. Emin misiniz?", "Onay", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                customerManagement.Insert(new Registration_Customer
                {
                    CustomerNickname = txtNickname.Text,
                    NameSurname = txtNameSurname.Text,
                    Age = Convert.ToInt32(txtAge.Text),
                    RegisterDate = dtpRegisterDate.Value,
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    Location = txtLocation.Text,
                    Address = txtAddress.Text,
                    TelNumber = txtPhone.Text
                });
                List();
                Clear();
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bilgiler güncellenecek. Emin misiniz?", "Onay", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                customerManagement.Update(new Registration_Customer
                {
                    CustomerID = Convert.ToInt32(txtCustomerId.Text),
                    CustomerNickname = txtNickname.Text,
                    NameSurname = txtNameSurname.Text,
                    Age = Convert.ToInt32(txtAge.Text),
                    RegisterDate = dtpRegisterDate.Value,
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    Location = txtLocation.Text,
                    Address = txtAddress.Text,
                    TelNumber = txtPhone.Text
                });
                List();
                Clear();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCustomerId.Text))
            {
                MessageBox.Show("Lütfen bir müşteri seçiniz!", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                var result = MessageBox.Show("Bilgiler silinecek. Emin misiniz?", "Onay", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    customerManagement.Delete(Convert.ToInt32(txtCustomerId.Text));
                    List();
                    Clear();
                }
            }

        }
    }
}
