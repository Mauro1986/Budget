using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryBudget.Models;

namespace WinUiBudget
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.Bisque;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadWallet();
            PopulateAmountType();
            PopulateType();
            PopulateBalance();
        }
        private void LoadWallet()
        {
            WalletRepo repo = new WalletRepo();
            grdWallets.DataSource = null;
            grdWallets.DataSource = repo.GetWallet();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Wallet wallet = new Wallet();
            wallet.Description = txtDescription.Text;
            wallet.MinPlus = (int)cmbAmountType.SelectedValue;
            wallet.Amount = int.Parse(txtAmount.Text);
            wallet.Type = (int)CmbType.SelectedValue;
            WalletRepo repo = new WalletRepo();
            repo.AddWallet(wallet);
            LoadWallet();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Wallet wallet = new Wallet();
            wallet.Id = int.Parse(lblId.Text);
            wallet.Description = txtDescription.Text;
            wallet.MinPlus = (int)cmbAmountType.SelectedValue;
            wallet.Amount = int.Parse(txtAmount.Text);
            wallet.Type = (int)CmbType.SelectedValue;

            WalletRepo repo = new WalletRepo();
            repo.UpdateWallet(wallet);
            LoadWallet();
        }

        private void grdWallets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblId.Text = grdWallets.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtDescription.Text = grdWallets.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtAmount.Text = grdWallets.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void PopulateAmountType()
        { 
            WalletRepo repo = new WalletRepo();
            cmbAmountType.DisplayMember = "TypeAmount";
            cmbAmountType.ValueMember = "Id";
            cmbAmountType.DataSource = repo.GetAmountTypes();
            LoadWallet();
        }

        private void PopulateType()
        {
            WalletRepo repo = new WalletRepo();
            CmbType.DisplayMember = "TypeName";
            CmbType.ValueMember = "Id";
            CmbType.DataSource = repo.GetTypes();
            LoadWallet();
        }

        private void PopulateBalance()
        {
            WalletRepo repo = new WalletRepo();
            txtBalance.Text = "graag balance hier"/*repo.GetWalletBalance()*/;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //WalletRepo repo = new WalletRepo();
            //string value = cmbAmountType.SelectedValue.ToString();
            //var list = repo.GetAmountTypeOfSelectedType((Convert.ToInt32(value)));
            //listBox1.DisplayMember = "Description";
            //listBox1.DataSource = list;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Wallet wallet = new Wallet();
            wallet.Id = int.Parse(lblId.Text);
            wallet.Description = txtDescription.Text;
            wallet.MinPlus = (int)cmbAmountType.SelectedValue;
            wallet.Amount = int.Parse(txtAmount.Text);
            wallet.Type = (int)CmbType.SelectedValue;

            WalletRepo repo = new WalletRepo();
            repo.DeleteWallet(wallet.Id);
            LoadWallet();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string value = null;

            if (rbIncoming.Checked)
            {
                value = "1".ToString();
                LoadInOut(1);
            }
            if (rbOutgoing.Checked)
            {
                value = "2".ToString();
               LoadInOut(2);
            }
            WalletRepo wallet = new WalletRepo();
            var list = wallet.GetDescriptionOfAmountType((Convert.ToInt32(value)));
        }

        private void LoadInOut(int id)
        {
            WalletRepo repo = new WalletRepo();
            grdIncomeOutcome.DataSource = null;
            grdIncomeOutcome.DataSource = repo.GetWalletInOut(id);
        }
    }
}
