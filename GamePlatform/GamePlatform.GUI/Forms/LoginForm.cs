using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GamePlatform.Business;
using GamePlatform.Business.Repository.Concrete;
using GamePlatform.Entities;
using GamePlatform.GUI.DTO;

namespace GamePlatform.GUI.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        UserManagement userManagement = new UserManagement();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user = userManagement.Get(u => u.CustomerNickname == txtUsername.Text && u.Password == txtPassword.Text);
            if (user!=null)
            {
                User.Login(user); //Statik sinifta statik bir user degiskeninde giris yapan kullaniciyi tut.
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Visible = false;
                
            }
            else
            {
                MessageBox.Show("User does not exist","Uyarı",MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation);
            }
        }
    }
}
