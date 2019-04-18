namespace CloseLoopWalletPOC
{
    partial class Details
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
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblWalletBal = new System.Windows.Forms.Label();
            this.UPPCL = new System.Windows.Forms.Label();
            this.btnAddMoney = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnWalletHistory = new System.Windows.Forms.Button();
            this.lblWalletBalanceValue = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.btnViewTrans = new System.Windows.Forms.Button();
            this.btnGetBillDetails = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.lblPaymentDate = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtBillNo = new System.Windows.Forms.TextBox();
            this.lblBillNo = new System.Windows.Forms.Label();
            this.lblConsumerNo = new System.Windows.Forms.Label();
            this.txtPaymentDate = new System.Windows.Forms.TextBox();
            this.txtConsumerNo = new System.Windows.Forms.TextBox();
            this.walletDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.walletDBDataSet = new CloseLoopWalletPOC.WalletDBDataSet();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConsumerNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridBillPaid = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.walletDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.walletDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBillPaid)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWalletBal
            // 
            this.lblWalletBal.AutoSize = true;
            this.lblWalletBal.Location = new System.Drawing.Point(9, 26);
            this.lblWalletBal.Name = "lblWalletBal";
            this.lblWalletBal.Size = new System.Drawing.Size(110, 13);
            this.lblWalletBal.TabIndex = 0;
            this.lblWalletBal.Text = "Your Wallet Balance:-";
            // 
            // UPPCL
            // 
            this.UPPCL.AutoSize = true;
            this.UPPCL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UPPCL.Location = new System.Drawing.Point(189, 19);
            this.UPPCL.Name = "UPPCL";
            this.UPPCL.Size = new System.Drawing.Size(47, 13);
            this.UPPCL.TabIndex = 2;
            this.UPPCL.Text = "UPPCL";
            // 
            // btnAddMoney
            // 
            this.btnAddMoney.Location = new System.Drawing.Point(243, 19);
            this.btnAddMoney.Name = "btnAddMoney";
            this.btnAddMoney.Size = new System.Drawing.Size(100, 23);
            this.btnAddMoney.TabIndex = 3;
            this.btnAddMoney.Text = "Add Money";
            this.btnAddMoney.UseVisualStyleBackColor = true;
            this.btnAddMoney.Click += new System.EventHandler(this.btnAddMoney_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnWalletHistory);
            this.groupBox1.Controls.Add(this.lblWalletBalanceValue);
            this.groupBox1.Controls.Add(this.lblWalletBal);
            this.groupBox1.Controls.Add(this.btnAddMoney);
            this.groupBox1.Location = new System.Drawing.Point(22, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 57);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wallet";
            // 
            // btnWalletHistory
            // 
            this.btnWalletHistory.Location = new System.Drawing.Point(396, 19);
            this.btnWalletHistory.Name = "btnWalletHistory";
            this.btnWalletHistory.Size = new System.Drawing.Size(102, 23);
            this.btnWalletHistory.TabIndex = 4;
            this.btnWalletHistory.Text = "Wallet History";
            this.btnWalletHistory.UseVisualStyleBackColor = true;
            this.btnWalletHistory.Click += new System.EventHandler(this.btnWalletHistory_Click);
            // 
            // lblWalletBalanceValue
            // 
            this.lblWalletBalanceValue.AutoSize = true;
            this.lblWalletBalanceValue.Location = new System.Drawing.Point(120, 26);
            this.lblWalletBalanceValue.Name = "lblWalletBalanceValue";
            this.lblWalletBalanceValue.Size = new System.Drawing.Size(0, 13);
            this.lblWalletBalanceValue.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblAmount);
            this.groupBox2.Controls.Add(this.btnViewTrans);
            this.groupBox2.Controls.Add(this.btnGetBillDetails);
            this.groupBox2.Controls.Add(this.btnPay);
            this.groupBox2.Controls.Add(this.lblPaymentDate);
            this.groupBox2.Controls.Add(this.txtAmount);
            this.groupBox2.Controls.Add(this.txtBillNo);
            this.groupBox2.Controls.Add(this.lblBillNo);
            this.groupBox2.Controls.Add(this.lblConsumerNo);
            this.groupBox2.Controls.Add(this.txtPaymentDate);
            this.groupBox2.Controls.Add(this.txtConsumerNo);
            this.groupBox2.Location = new System.Drawing.Point(22, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(514, 137);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Billing";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(349, 66);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(43, 13);
            this.lblAmount.TabIndex = 5;
            this.lblAmount.Text = "Amount";
            // 
            // btnViewTrans
            // 
            this.btnViewTrans.Location = new System.Drawing.Point(398, 28);
            this.btnViewTrans.Name = "btnViewTrans";
            this.btnViewTrans.Size = new System.Drawing.Size(100, 23);
            this.btnViewTrans.TabIndex = 3;
            this.btnViewTrans.Text = "ViewTranscations";
            this.btnViewTrans.UseVisualStyleBackColor = true;
            this.btnViewTrans.Click += new System.EventHandler(this.btnViewTrans_Click);
            // 
            // btnGetBillDetails
            // 
            this.btnGetBillDetails.Location = new System.Drawing.Point(243, 27);
            this.btnGetBillDetails.Name = "btnGetBillDetails";
            this.btnGetBillDetails.Size = new System.Drawing.Size(100, 23);
            this.btnGetBillDetails.TabIndex = 3;
            this.btnGetBillDetails.Text = "Get Bill Details";
            this.btnGetBillDetails.UseVisualStyleBackColor = true;
            this.btnGetBillDetails.Click += new System.EventHandler(this.btnGetBillDetailss);
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(398, 108);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(100, 23);
            this.btnPay.TabIndex = 3;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPayMoney_Click);
            // 
            // lblPaymentDate
            // 
            this.lblPaymentDate.AutoSize = true;
            this.lblPaymentDate.Location = new System.Drawing.Point(6, 63);
            this.lblPaymentDate.Name = "lblPaymentDate";
            this.lblPaymentDate.Size = new System.Drawing.Size(74, 13);
            this.lblPaymentDate.TabIndex = 4;
            this.lblPaymentDate.Text = "Payment Date";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(398, 63);
            this.txtAmount.MaxLength = 5;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 3;
            // 
            // txtBillNo
            // 
            this.txtBillNo.Location = new System.Drawing.Point(243, 60);
            this.txtBillNo.MaxLength = 10;
            this.txtBillNo.Name = "txtBillNo";
            this.txtBillNo.ReadOnly = true;
            this.txtBillNo.Size = new System.Drawing.Size(100, 20);
            this.txtBillNo.TabIndex = 3;
            // 
            // lblBillNo
            // 
            this.lblBillNo.AutoSize = true;
            this.lblBillNo.Location = new System.Drawing.Point(197, 66);
            this.lblBillNo.Name = "lblBillNo";
            this.lblBillNo.Size = new System.Drawing.Size(40, 13);
            this.lblBillNo.TabIndex = 2;
            this.lblBillNo.Text = "Bill No.";
            // 
            // lblConsumerNo
            // 
            this.lblConsumerNo.AutoSize = true;
            this.lblConsumerNo.Location = new System.Drawing.Point(6, 33);
            this.lblConsumerNo.Name = "lblConsumerNo";
            this.lblConsumerNo.Size = new System.Drawing.Size(74, 13);
            this.lblConsumerNo.TabIndex = 0;
            this.lblConsumerNo.Text = "Consumer No.";
            // 
            // txtPaymentDate
            // 
            this.txtPaymentDate.Location = new System.Drawing.Point(91, 60);
            this.txtPaymentDate.Name = "txtPaymentDate";
            this.txtPaymentDate.ReadOnly = true;
            this.txtPaymentDate.Size = new System.Drawing.Size(100, 20);
            this.txtPaymentDate.TabIndex = 1;
            // 
            // txtConsumerNo
            // 
            this.txtConsumerNo.Location = new System.Drawing.Point(91, 30);
            this.txtConsumerNo.MaxLength = 10;
            this.txtConsumerNo.Name = "txtConsumerNo";
            this.txtConsumerNo.Size = new System.Drawing.Size(100, 20);
            this.txtConsumerNo.TabIndex = 1;
            // 
            // walletDBDataSetBindingSource
            // 
            this.walletDBDataSetBindingSource.DataSource = this.walletDBDataSet;
            this.walletDBDataSetBindingSource.Position = 0;
            // 
            // walletDBDataSet
            // 
            this.walletDBDataSet.DataSetName = "WalletDBDataSet";
            this.walletDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // ConsumerNo
            // 
            this.ConsumerNo.HeaderText = "ConsumerNo";
            this.ConsumerNo.Name = "ConsumerNo";
            this.ConsumerNo.ReadOnly = true;
            // 
            // BillNo
            // 
            this.BillNo.HeaderText = "BillNo";
            this.BillNo.Name = "BillNo";
            this.BillNo.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // dataGridBillPaid
            // 
            this.dataGridBillPaid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBillPaid.Location = new System.Drawing.Point(22, 251);
            this.dataGridBillPaid.Name = "dataGridBillPaid";
            this.dataGridBillPaid.ReadOnly = true;
            this.dataGridBillPaid.Size = new System.Drawing.Size(514, 150);
            this.dataGridBillPaid.TabIndex = 6;
            // 
            // Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 409);
            this.Controls.Add(this.dataGridBillPaid);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.UPPCL);
            this.Name = "Details";
            this.Text = "Close Loop Wallet";
            this.Activated += new System.EventHandler(this.Details_Activated);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.walletDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.walletDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBillPaid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWalletBal;
        private System.Windows.Forms.Label UPPCL;
        private System.Windows.Forms.Button btnAddMoney;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblBillNo;
        private System.Windows.Forms.Label lblConsumerNo;
        private System.Windows.Forms.TextBox txtConsumerNo;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblPaymentDate;
        private System.Windows.Forms.TextBox txtBillNo;
        private System.Windows.Forms.TextBox txtPaymentDate;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnViewTrans;
        public System.Windows.Forms.Label lblWalletBalanceValue;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource walletDBDataSetBindingSource;
        private WalletDBDataSet walletDBDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsumerNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridView dataGridBillPaid;
        private System.Windows.Forms.Button btnGetBillDetails;
        private System.Windows.Forms.Button btnWalletHistory;
    }
}

