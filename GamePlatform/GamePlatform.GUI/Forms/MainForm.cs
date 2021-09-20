using GamePlatform.GUI.DTO;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (User._loggedUser != null)
                tltCustomer.Text = $"  Welcome {User._loggedUser.NameSurname}";
        }

        private void gamesListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameForm gameForm = new GameForm();
            gameForm.MdiParent = this;
            gameForm.Show();

        }

        private void gamesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void customerListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.MdiParent = this;
            customerForm.Show();
        }

        private void setHorizantalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void setVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Programdan çıkmak istediğinizden emin miziniz?", "Sistem Çıkış", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
            if (result==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void buyGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            orderForm.MdiParent = this;
            orderForm.Show();
        }

        private void buyExtraPackageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderExtraPackageForm orderExtrasForm = new OrderExtraPackageForm();
            orderExtrasForm.MdiParent = this;
            orderExtrasForm.Show();
        }
    }
}
