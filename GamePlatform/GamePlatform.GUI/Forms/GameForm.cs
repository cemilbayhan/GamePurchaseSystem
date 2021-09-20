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
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
        }
        GameManagement gameManagement = new GameManagement();
        CompanyManagement companyManagement = new CompanyManagement();
        private void List()
        {
            dgvGame.DataSource = gameManagement.GetGames();
        }

        private void Clear()
        {
            txtAgeLimit.Clear();
            txtCPU.Clear();
            cmdDeveloperCompanies.SelectedIndex = 0;
            txtExplanation.Clear();
            txtGameID.Clear();
            txtGameName.Clear();
            txtMemory.Clear();
            txtOprSystem.Clear();
            cmbPublisherCompanies.SelectedIndex = 0;
            txtStorage.Clear();
            txtAvaragePoint.Clear();
            txtGraphics.Clear();
            dtpReleaseDate.Value = DateTime.Now;
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            List();
            GetDeveloperCompanies();
            GetPublisherCompanies();
        }

        private void dgvGame_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRow = dgvGame.Rows[e.RowIndex];
            txtGameID.Text = selectedRow.Cells["GameID"].Value.ToString();
            txtAgeLimit.Text = selectedRow.Cells["AgeLimit"].Value.ToString();
            txtCPU.Text = selectedRow.Cells["CPU"].Value.ToString();
            cmdDeveloperCompanies.SelectedValue = selectedRow.Cells["DeveloperID"].Value;
            txtExplanation.Text = selectedRow.Cells["Explanation"].Value.ToString();
            txtGameName.Text = selectedRow.Cells["GameName"].Value.ToString();
            txtMemory.Text = selectedRow.Cells["Memory"].Value.ToString();
            txtOprSystem.Text = selectedRow.Cells["OprSystem"].Value.ToString();
            cmbPublisherCompanies.SelectedValue = selectedRow.Cells["PublisherID"].Value;
            txtStorage.Text = selectedRow.Cells["Storage"].Value.ToString();
            dtpReleaseDate.Value = Convert.ToDateTime(selectedRow.Cells["ReleaseDate"].Value);
            txtAvaragePoint.Text = selectedRow.Cells["AvaragePoint"].Value.ToString();
            txtGraphics.Text = selectedRow.Cells["Graphics"].Value.ToString();
        }


        private void GetDeveloperCompanies()
        {
            var companies = companyManagement.GetAll();
            companies.Insert(0, new Registration_Company {CompanyID=0,CompanyName="Seçiniz..." });
            cmdDeveloperCompanies.DataSource = companies;
            cmdDeveloperCompanies.DisplayMember = "CompanyName";
            cmdDeveloperCompanies.ValueMember = "CompanyId";
        }

        private void GetPublisherCompanies()
        {
            var companies = companyManagement.GetAll();
            companies.Insert(0, new Registration_Company { CompanyID = 0, CompanyName = "Seçiniz..." });
            cmbPublisherCompanies.DataSource = companies;
            cmbPublisherCompanies.DisplayMember = "CompanyName";
            cmbPublisherCompanies.ValueMember = "CompanyId";
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bilgiler kaydedilecek. Emin misiniz?", "Onay", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                gameManagement.Insert(new Registration_Game
                {
                    GameName = txtGameName.Text,
                    ReleaseDate = dtpReleaseDate.Value,
                    AgeLimit = Convert.ToInt32(txtAgeLimit.Text),
                    DeveloperID = Convert.ToInt32(cmdDeveloperCompanies.SelectedValue),
                    PublisherID = Convert.ToInt32(cmbPublisherCompanies.SelectedValue),
                    Explanation = txtExplanation.Text,
                    AvaragePoint = Convert.ToDouble(txtAvaragePoint.Text),
                    OprSystem = txtOprSystem.Text,
                    CPU = txtCPU.Text,
                    Storage = txtStorage.Text,
                    Graphics = txtGraphics.Text,
                    Memory = txtMemory.Text
                });
                List();
                Clear();
            }

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
                gameManagement.Update(new Registration_Game
                {
                    GameID = Convert.ToInt32(txtGameID.Text),
                    GameName = txtGameName.Text,
                    ReleaseDate = dtpReleaseDate.Value,
                    AgeLimit = Convert.ToInt32(txtAgeLimit.Text),
                    DeveloperID = Convert.ToInt32(cmdDeveloperCompanies.SelectedValue),
                    PublisherID = Convert.ToInt32(cmbPublisherCompanies.SelectedValue),
                    Explanation = txtExplanation.Text,
                    AvaragePoint = Convert.ToDouble(txtAvaragePoint.Text),
                    OprSystem = txtOprSystem.Text,
                    CPU = txtCPU.Text,
                    Storage = txtStorage.Text,
                    Graphics = txtGraphics.Text,
                    Memory = txtMemory.Text
                });
                List();
                Clear();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtGameID.Text))
            {
                MessageBox.Show("Lütfen bir müşteri seçiniz!", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                var result = MessageBox.Show("Bilgiler silinecek. Emin misiniz?", "Onay", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    gameManagement.Delete(Convert.ToInt32(txtGameID.Text));
                    List();
                    Clear();
                }
            }

        }

    }



}
