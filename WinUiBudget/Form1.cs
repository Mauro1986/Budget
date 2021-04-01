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
            GetBalance();
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
            GetBalance();
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
            GetBalance();
        }

        private void grdWallets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblId.Text = grdWallets.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtDescription.Text = grdWallets.Rows[e.RowIndex].Cells[1].Value.ToString();
            var minplusId = grdWallets.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmbAmountType.SelectedIndex = Convert.ToInt32(minplusId) - 1;
            txtAmount.Text = grdWallets.Rows[e.RowIndex].Cells[3].Value.ToString();
            var typeId = grdWallets.Rows[e.RowIndex].Cells[4].Value.ToString();
            CmbType.SelectedIndex = Convert.ToInt32(typeId) - 1;
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
            GetBalance();
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

        private void GetBalance()
        {
            int incoming = 0;
            int outgoing = 0;
            int balance = 0;
            int minPlus = 0;
            foreach (DataGridViewRow row in grdWallets.Rows)
            {
                minPlus = Convert.ToInt32(row.Cells["MinPlus"].Value);
                if (minPlus == 1)
                {
                incoming += Convert.ToInt32(row.Cells["Amount"].Value);
                }
                if (minPlus == 2)
                {
                    outgoing += Convert.ToInt32(row.Cells["Amount"].Value);
                }
            }
            lblIncome.ForeColor = Color.Green;
            lblIncome.Text = Convert.ToString(incoming);
            lblOutgoing.ForeColor = Color.Red;
            lblOutgoing.Text = Convert.ToString(outgoing);
            balance = incoming - outgoing;
            if (balance < 0)
            {
                lblBalance.ForeColor = Color.Red;
            }
            if (balance > 0)
            {
                lblBalance.ForeColor = Color.Green;
            }
            lblBalance.Text = Convert.ToString(balance);
        }
    }
}
