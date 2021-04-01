
namespace WinUiBudget
{
    partial class Form1
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
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblAmountType = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.CmbType = new System.Windows.Forms.ComboBox();
            this.cmbAmountType = new System.Windows.Forms.ComboBox();
            this.grdWallets = new System.Windows.Forms.DataGridView();
            this.lblShow = new System.Windows.Forms.Label();
            this.rbIncoming = new System.Windows.Forms.RadioButton();
            this.btnShow = new System.Windows.Forms.Button();
            this.rbOutgoing = new System.Windows.Forms.RadioButton();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.grdIncomeOutcome = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblIncome = new System.Windows.Forms.Label();
            this.lblOutgoing = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdWallets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdIncomeOutcome)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(610, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "---------------- My Balance App ----------------";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(21, 96);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(115, 25);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(152, 99);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(136, 24);
            this.txtDescription.TabIndex = 5;
            // 
            // lblAmountType
            // 
            this.lblAmountType.AutoSize = true;
            this.lblAmountType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountType.Location = new System.Drawing.Point(21, 151);
            this.lblAmountType.Name = "lblAmountType";
            this.lblAmountType.Size = new System.Drawing.Size(131, 25);
            this.lblAmountType.TabIndex = 6;
            this.lblAmountType.Text = "AmountType:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(21, 256);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(63, 25);
            this.lblType.TabIndex = 10;
            this.lblType.Text = "Type:";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(152, 205);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(136, 24);
            this.txtAmount.TabIndex = 9;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(21, 202);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(86, 25);
            this.lblAmount.TabIndex = 8;
            this.lblAmount.Text = "Amount:";
            // 
            // CmbType
            // 
            this.CmbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbType.FormattingEnabled = true;
            this.CmbType.Location = new System.Drawing.Point(152, 257);
            this.CmbType.Name = "CmbType";
            this.CmbType.Size = new System.Drawing.Size(136, 26);
            this.CmbType.TabIndex = 16;
            // 
            // cmbAmountType
            // 
            this.cmbAmountType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAmountType.FormattingEnabled = true;
            this.cmbAmountType.Location = new System.Drawing.Point(152, 152);
            this.cmbAmountType.Name = "cmbAmountType";
            this.cmbAmountType.Size = new System.Drawing.Size(136, 26);
            this.cmbAmountType.TabIndex = 17;
            // 
            // grdWallets
            // 
            this.grdWallets.AllowUserToAddRows = false;
            this.grdWallets.AllowUserToDeleteRows = false;
            this.grdWallets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdWallets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdWallets.Location = new System.Drawing.Point(307, 96);
            this.grdWallets.Name = "grdWallets";
            this.grdWallets.RowHeadersWidth = 51;
            this.grdWallets.RowTemplate.Height = 24;
            this.grdWallets.Size = new System.Drawing.Size(409, 238);
            this.grdWallets.TabIndex = 19;
            this.grdWallets.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdWallets_CellContentClick);
            // 
            // lblShow
            // 
            this.lblShow.AutoSize = true;
            this.lblShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShow.Location = new System.Drawing.Point(21, 375);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(68, 25);
            this.lblShow.TabIndex = 20;
            this.lblShow.Text = "Show:";
            // 
            // rbIncoming
            // 
            this.rbIncoming.AutoSize = true;
            this.rbIncoming.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbIncoming.Location = new System.Drawing.Point(95, 377);
            this.rbIncoming.Name = "rbIncoming";
            this.rbIncoming.Size = new System.Drawing.Size(89, 24);
            this.rbIncoming.TabIndex = 29;
            this.rbIncoming.TabStop = true;
            this.rbIncoming.Text = "Income";
            this.rbIncoming.UseVisualStyleBackColor = true;
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(72, 417);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(167, 32);
            this.btnShow.TabIndex = 28;
            this.btnShow.Text = "Apply Change";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // rbOutgoing
            // 
            this.rbOutgoing.AutoSize = true;
            this.rbOutgoing.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOutgoing.Location = new System.Drawing.Point(185, 377);
            this.rbOutgoing.Name = "rbOutgoing";
            this.rbOutgoing.Size = new System.Drawing.Size(103, 24);
            this.rbOutgoing.TabIndex = 27;
            this.rbOutgoing.TabStop = true;
            this.rbOutgoing.Text = "Outgoing";
            this.rbOutgoing.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(26, 298);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(80, 36);
            this.btnInsert.TabIndex = 30;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(116, 298);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(78, 36);
            this.btnUpdate.TabIndex = 31;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.Location = new System.Drawing.Point(204, 298);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(78, 36);
            this.BtnDelete.TabIndex = 32;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(152, 57);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(46, 17);
            this.lblId.TabIndex = 33;
            this.lblId.Text = "label2";
            this.lblId.Visible = false;
            // 
            // grdIncomeOutcome
            // 
            this.grdIncomeOutcome.AllowUserToAddRows = false;
            this.grdIncomeOutcome.AllowUserToDeleteRows = false;
            this.grdIncomeOutcome.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdIncomeOutcome.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.grdIncomeOutcome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdIncomeOutcome.Location = new System.Drawing.Point(307, 375);
            this.grdIncomeOutcome.Name = "grdIncomeOutcome";
            this.grdIncomeOutcome.RowHeadersWidth = 51;
            this.grdIncomeOutcome.RowTemplate.Height = 24;
            this.grdIncomeOutcome.Size = new System.Drawing.Size(409, 129);
            this.grdIncomeOutcome.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(302, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 30);
            this.label2.TabIndex = 36;
            this.label2.Text = "Incoming and Outgoing";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(302, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 30);
            this.label3.TabIndex = 37;
            this.label3.Text = "Incoming or Outgoing";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 473);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 31);
            this.label4.TabIndex = 39;
            this.label4.Text = "Total Balance";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(108, 507);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(105, 48);
            this.lblBalance.TabIndex = 40;
            this.lblBalance.Text = "0,00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(59, 523);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 25);
            this.label5.TabIndex = 42;
            this.label5.Text = "€";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(260, 520);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 29);
            this.label6.TabIndex = 43;
            this.label6.Text = "=";
            // 
            // lblIncome
            // 
            this.lblIncome.AutoSize = true;
            this.lblIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncome.Location = new System.Drawing.Point(330, 514);
            this.lblIncome.Name = "lblIncome";
            this.lblIncome.Size = new System.Drawing.Size(78, 36);
            this.lblIncome.TabIndex = 44;
            this.lblIncome.Text = "0,00";
            // 
            // lblOutgoing
            // 
            this.lblOutgoing.AutoSize = true;
            this.lblOutgoing.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutgoing.Location = new System.Drawing.Point(482, 514);
            this.lblOutgoing.Name = "lblOutgoing";
            this.lblOutgoing.Size = new System.Drawing.Size(78, 36);
            this.lblOutgoing.TabIndex = 45;
            this.lblOutgoing.Text = "0,00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(438, 514);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 29);
            this.label9.TabIndex = 46;
            this.label9.Text = "-";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(774, 298);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(80, 36);
            this.lblDate.TabIndex = 47;
            this.lblDate.Text = "Date";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 568);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblOutgoing);
            this.Controls.Add(this.lblIncome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grdIncomeOutcome);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.rbIncoming);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.rbOutgoing);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.grdWallets);
            this.Controls.Add(this.cmbAmountType);
            this.Controls.Add(this.CmbType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblAmountType);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "My Balance App";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdWallets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdIncomeOutcome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblAmountType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.ComboBox CmbType;
        private System.Windows.Forms.ComboBox cmbAmountType;
        private System.Windows.Forms.DataGridView grdWallets;
        private System.Windows.Forms.Label lblShow;
        private System.Windows.Forms.RadioButton rbIncoming;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.RadioButton rbOutgoing;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.DataGridView grdIncomeOutcome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblIncome;
        private System.Windows.Forms.Label lblOutgoing;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblDate;
    }
}

