namespace CloseLoopWalletPOC
{
    partial class AddMoney
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
            this.txtAddMoneyValue = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWalletBalance = new System.Windows.Forms.Label();
            this.btnAddMoney = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.DebitCardGrp = new System.Windows.Forms.GroupBox();
            this.txtDCcVV = new System.Windows.Forms.TextBox();
            this.txtDCExpiry = new System.Windows.Forms.TextBox();
            this.txtDCHolder = new System.Windows.Forms.TextBox();
            this.txtDC = new System.Windows.Forms.TextBox();
            this.lblDC = new System.Windows.Forms.Label();
            this.lblDCCVV = new System.Windows.Forms.Label();
            this.lblDCExpiry = new System.Windows.Forms.Label();
            this.lblDCHolder = new System.Windows.Forms.Label();
            this.NetBankingGrp = new System.Windows.Forms.GroupBox();
            this.txtIFSC = new System.Windows.Forms.TextBox();
            this.txtAccountHolder = new System.Windows.Forms.TextBox();
            this.txtAccountNo = new System.Windows.Forms.TextBox();
            this.lblAccountHolder = new System.Windows.Forms.Label();
            this.lblIFSC = new System.Windows.Forms.Label();
            this.lblAccountNo = new System.Windows.Forms.Label();
            this.CreditCardGrp = new System.Windows.Forms.GroupBox();
            this.txtCCcVV = new System.Windows.Forms.TextBox();
            this.txtCCExpiry = new System.Windows.Forms.TextBox();
            this.txtCCHolder = new System.Windows.Forms.TextBox();
            this.txtCCNo = new System.Windows.Forms.TextBox();
            this.lblCCNo = new System.Windows.Forms.Label();
            this.lblCCcVV = new System.Windows.Forms.Label();
            this.lblCCExpiry = new System.Windows.Forms.Label();
            this.lblCCHolderName = new System.Windows.Forms.Label();
            this.PaytmGrp = new System.Windows.Forms.GroupBox();
            this.txtPaytmNo = new System.Windows.Forms.TextBox();
            this.txtPaytmName = new System.Windows.Forms.TextBox();
            this.lblPaytmName = new System.Windows.Forms.Label();
            this.lblPaytmNo = new System.Windows.Forms.Label();
            this.AirtelGrp = new System.Windows.Forms.GroupBox();
            this.txtAir = new System.Windows.Forms.TextBox();
            this.txtAirtelName = new System.Windows.Forms.TextBox();
            this.lblAirtelName = new System.Windows.Forms.Label();
            this.lblAirtelNo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.DebitCardGrp.SuspendLayout();
            this.NetBankingGrp.SuspendLayout();
            this.CreditCardGrp.SuspendLayout();
            this.PaytmGrp.SuspendLayout();
            this.AirtelGrp.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAddMoneyValue
            // 
            this.txtAddMoneyValue.Location = new System.Drawing.Point(123, 50);
            this.txtAddMoneyValue.MaxLength = 5;
            this.txtAddMoneyValue.Name = "txtAddMoneyValue";
            this.txtAddMoneyValue.Size = new System.Drawing.Size(111, 20);
            this.txtAddMoneyValue.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAddMoneyValue);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblWalletBalance);
            this.groupBox1.Location = new System.Drawing.Point(35, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 94);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Money";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Amount To Add";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Available Balance :";
            // 
            // lblWalletBalance
            // 
            this.lblWalletBalance.AutoSize = true;
            this.lblWalletBalance.Location = new System.Drawing.Point(120, 28);
            this.lblWalletBalance.Name = "lblWalletBalance";
            this.lblWalletBalance.Size = new System.Drawing.Size(0, 13);
            this.lblWalletBalance.TabIndex = 1;
            // 
            // btnAddMoney
            // 
            this.btnAddMoney.Location = new System.Drawing.Point(159, 180);
            this.btnAddMoney.Name = "btnAddMoney";
            this.btnAddMoney.Size = new System.Drawing.Size(75, 23);
            this.btnAddMoney.TabIndex = 3;
            this.btnAddMoney.Text = "Add Money";
            this.btnAddMoney.UseVisualStyleBackColor = true;
            this.btnAddMoney.Click += new System.EventHandler(this.btnAddMoney_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddMoney);
            this.groupBox2.Controls.Add(this.cmbPaymentMethod);
            this.groupBox2.Controls.Add(this.lblPaymentMethod);
            this.groupBox2.Location = new System.Drawing.Point(35, 153);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 216);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Choose Payment Mode";
            // 
            // cmbPaymentMethod
            // 
            this.cmbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentMethod.Items.AddRange(new object[] {
            "--Select--",
            "Paytm",
            "Net Banking",
            "Credit Card",
            "Debit Card",
            "Airtel Wallet"});
            this.cmbPaymentMethod.Location = new System.Drawing.Point(123, 27);
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.Size = new System.Drawing.Size(111, 21);
            this.cmbPaymentMethod.TabIndex = 2;
            this.cmbPaymentMethod.SelectedIndexChanged += new System.EventHandler(this.cmbPaymentMethod_SelectedIndexChanged);
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Location = new System.Drawing.Point(6, 30);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(87, 13);
            this.lblPaymentMethod.TabIndex = 0;
            this.lblPaymentMethod.Text = "Payment Method";
            // 
            // DebitCardGrp
            // 
            this.DebitCardGrp.Controls.Add(this.txtDCcVV);
            this.DebitCardGrp.Controls.Add(this.txtDCExpiry);
            this.DebitCardGrp.Controls.Add(this.txtDCHolder);
            this.DebitCardGrp.Controls.Add(this.txtDC);
            this.DebitCardGrp.Controls.Add(this.lblDC);
            this.DebitCardGrp.Controls.Add(this.lblDCCVV);
            this.DebitCardGrp.Controls.Add(this.lblDCExpiry);
            this.DebitCardGrp.Controls.Add(this.lblDCHolder);
            this.DebitCardGrp.Location = new System.Drawing.Point(50, 220);
            this.DebitCardGrp.Name = "DebitCardGrp";
            this.DebitCardGrp.Size = new System.Drawing.Size(225, 110);
            this.DebitCardGrp.TabIndex = 4;
            this.DebitCardGrp.TabStop = false;
            this.DebitCardGrp.Text = "Debit Card Details";
            // 
            // txtDCcVV
            // 
            this.txtDCcVV.Location = new System.Drawing.Point(103, 81);
            this.txtDCcVV.MaxLength = 3;
            this.txtDCcVV.Name = "txtDCcVV";
            this.txtDCcVV.Size = new System.Drawing.Size(111, 20);
            this.txtDCcVV.TabIndex = 1;
            // 
            // txtDCExpiry
            // 
            this.txtDCExpiry.Location = new System.Drawing.Point(103, 58);
            this.txtDCExpiry.MaxLength = 10;
            this.txtDCExpiry.Name = "txtDCExpiry";
            this.txtDCExpiry.Size = new System.Drawing.Size(111, 20);
            this.txtDCExpiry.TabIndex = 1;
            // 
            // txtDCHolder
            // 
            this.txtDCHolder.Location = new System.Drawing.Point(103, 35);
            this.txtDCHolder.MaxLength = 30;
            this.txtDCHolder.Name = "txtDCHolder";
            this.txtDCHolder.Size = new System.Drawing.Size(111, 20);
            this.txtDCHolder.TabIndex = 1;
            // 
            // txtDC
            // 
            this.txtDC.Location = new System.Drawing.Point(103, 13);
            this.txtDC.MaxLength = 16;
            this.txtDC.Name = "txtDC";
            this.txtDC.Size = new System.Drawing.Size(111, 20);
            this.txtDC.TabIndex = 1;
            // 
            // lblDC
            // 
            this.lblDC.AutoSize = true;
            this.lblDC.Location = new System.Drawing.Point(3, 16);
            this.lblDC.Name = "lblDC";
            this.lblDC.Size = new System.Drawing.Size(42, 13);
            this.lblDC.TabIndex = 0;
            this.lblDC.Text = "DC No.";
            // 
            // lblDCCVV
            // 
            this.lblDCCVV.AutoSize = true;
            this.lblDCCVV.Location = new System.Drawing.Point(3, 84);
            this.lblDCCVV.Name = "lblDCCVV";
            this.lblDCCVV.Size = new System.Drawing.Size(28, 13);
            this.lblDCCVV.TabIndex = 0;
            this.lblDCCVV.Text = "CVV";
            // 
            // lblDCExpiry
            // 
            this.lblDCExpiry.AutoSize = true;
            this.lblDCExpiry.Location = new System.Drawing.Point(3, 62);
            this.lblDCExpiry.Name = "lblDCExpiry";
            this.lblDCExpiry.Size = new System.Drawing.Size(61, 13);
            this.lblDCExpiry.TabIndex = 0;
            this.lblDCExpiry.Text = "Expiry Date";
            // 
            // lblDCHolder
            // 
            this.lblDCHolder.AutoSize = true;
            this.lblDCHolder.Location = new System.Drawing.Point(3, 42);
            this.lblDCHolder.Name = "lblDCHolder";
            this.lblDCHolder.Size = new System.Drawing.Size(87, 13);
            this.lblDCHolder.TabIndex = 0;
            this.lblDCHolder.Text = "DC Holder Name";
            // 
            // NetBankingGrp
            // 
            this.NetBankingGrp.Controls.Add(this.txtIFSC);
            this.NetBankingGrp.Controls.Add(this.txtAccountHolder);
            this.NetBankingGrp.Controls.Add(this.txtAccountNo);
            this.NetBankingGrp.Controls.Add(this.lblAccountHolder);
            this.NetBankingGrp.Controls.Add(this.lblIFSC);
            this.NetBankingGrp.Controls.Add(this.lblAccountNo);
            this.NetBankingGrp.Location = new System.Drawing.Point(50, 220);
            this.NetBankingGrp.Name = "NetBankingGrp";
            this.NetBankingGrp.Size = new System.Drawing.Size(220, 100);
            this.NetBankingGrp.TabIndex = 4;
            this.NetBankingGrp.TabStop = false;
            this.NetBankingGrp.Text = "NetBanking Details";
            // 
            // txtIFSC
            // 
            this.txtIFSC.Location = new System.Drawing.Point(103, 66);
            this.txtIFSC.Name = "txtIFSC";
            this.txtIFSC.Size = new System.Drawing.Size(111, 20);
            this.txtIFSC.TabIndex = 1;
            this.txtIFSC.MaxLength = 10;
            // 
            // txtAccountHolder
            // 
            this.txtAccountHolder.Location = new System.Drawing.Point(103, 14);
            this.txtAccountHolder.Name = "txtAccountHolder";
            this.txtAccountHolder.Size = new System.Drawing.Size(111, 20);
            this.txtAccountHolder.TabIndex = 1;
            this.txtAccountHolder.MaxLength = 30;
            // 
            // txtAccountNo
            // 
            this.txtAccountNo.Location = new System.Drawing.Point(103, 40);
            this.txtAccountNo.Name = "txtAccountNo";
            this.txtAccountNo.Size = new System.Drawing.Size(111, 20);
            this.txtAccountNo.TabIndex = 1;
            this.txtAccountNo.MaxLength = 12;
            // 
            // lblAccountHolder
            // 
            this.lblAccountHolder.AutoSize = true;
            this.lblAccountHolder.Location = new System.Drawing.Point(6, 17);
            this.lblAccountHolder.Name = "lblAccountHolder";
            this.lblAccountHolder.Size = new System.Drawing.Size(87, 13);
            this.lblAccountHolder.TabIndex = 0;
            this.lblAccountHolder.Text = "Account Holder :";
            // 
            // lblIFSC
            // 
            this.lblIFSC.AutoSize = true;
            this.lblIFSC.Location = new System.Drawing.Point(6, 69);
            this.lblIFSC.Name = "lblIFSC";
            this.lblIFSC.Size = new System.Drawing.Size(64, 13);
            this.lblIFSC.TabIndex = 0;
            this.lblIFSC.Text = "IFSC Code :";
            // 
            // lblAccountNo
            // 
            this.lblAccountNo.AutoSize = true;
            this.lblAccountNo.Location = new System.Drawing.Point(6, 43);
            this.lblAccountNo.Name = "lblAccountNo";
            this.lblAccountNo.Size = new System.Drawing.Size(70, 13);
            this.lblAccountNo.TabIndex = 0;
            this.lblAccountNo.Text = "Account No :";
            // 
            // CreditCardGrp
            // 
            this.CreditCardGrp.Controls.Add(this.txtCCcVV);
            this.CreditCardGrp.Controls.Add(this.txtCCExpiry);
            this.CreditCardGrp.Controls.Add(this.txtCCHolder);
            this.CreditCardGrp.Controls.Add(this.txtCCNo);
            this.CreditCardGrp.Controls.Add(this.lblCCNo);
            this.CreditCardGrp.Controls.Add(this.lblCCcVV);
            this.CreditCardGrp.Controls.Add(this.lblCCExpiry);
            this.CreditCardGrp.Controls.Add(this.lblCCHolderName);
            this.CreditCardGrp.Location = new System.Drawing.Point(50, 220);
            this.CreditCardGrp.Name = "CreditCardGrp";
            this.CreditCardGrp.Size = new System.Drawing.Size(220, 110);
            this.CreditCardGrp.TabIndex = 4;
            this.CreditCardGrp.TabStop = false;
            this.CreditCardGrp.Text = "Credit Card Details";
            // 
            // txtCCcVV
            // 
            this.txtCCcVV.Location = new System.Drawing.Point(103, 84);
            this.txtCCcVV.Name = "txtCCcVV";
            this.txtCCcVV.Size = new System.Drawing.Size(111, 20);
            this.txtCCcVV.TabIndex = 1;
            this.txtCCcVV.MaxLength = 3;
            // 
            // txtCCExpiry
            // 
            this.txtCCExpiry.Location = new System.Drawing.Point(103, 62);
            this.txtCCExpiry.Name = "txtCCExpiry";
            this.txtCCExpiry.Size = new System.Drawing.Size(111, 20);
            this.txtCCExpiry.TabIndex = 1;
            this.txtCCExpiry.MaxLength = 10;
            // 
            // txtCCHolder
            // 
            this.txtCCHolder.Location = new System.Drawing.Point(103, 39);
            this.txtCCHolder.Name = "txtCCHolder";
            this.txtCCHolder.Size = new System.Drawing.Size(111, 20);
            this.txtCCHolder.TabIndex = 1;
            this.txtCCHolder.MaxLength = 30;
            // 
            // txtCCNo
            // 
            this.txtCCNo.Location = new System.Drawing.Point(103, 13);
            this.txtCCNo.Name = "txtCCNo";
            this.txtCCNo.Size = new System.Drawing.Size(111, 20);
            this.txtCCNo.TabIndex = 1;
            this.txtCCNo.MaxLength = 16;
            // 
            // lblCCNo
            // 
            this.lblCCNo.AutoSize = true;
            this.lblCCNo.Location = new System.Drawing.Point(3, 16);
            this.lblCCNo.Name = "lblCCNo";
            this.lblCCNo.Size = new System.Drawing.Size(41, 13);
            this.lblCCNo.TabIndex = 0;
            this.lblCCNo.Text = "CC No.";
            // 
            // lblCCcVV
            // 
            this.lblCCcVV.AutoSize = true;
            this.lblCCcVV.Location = new System.Drawing.Point(3, 84);
            this.lblCCcVV.Name = "lblCCcVV";
            this.lblCCcVV.Size = new System.Drawing.Size(28, 13);
            this.lblCCcVV.TabIndex = 0;
            this.lblCCcVV.Text = "CVV";
            // 
            // lblCCExpiry
            // 
            this.lblCCExpiry.AutoSize = true;
            this.lblCCExpiry.Location = new System.Drawing.Point(3, 62);
            this.lblCCExpiry.Name = "lblCCExpiry";
            this.lblCCExpiry.Size = new System.Drawing.Size(61, 13);
            this.lblCCExpiry.TabIndex = 0;
            this.lblCCExpiry.Text = "Expiry Date";
            // 
            // lblCCHolderName
            // 
            this.lblCCHolderName.AutoSize = true;
            this.lblCCHolderName.Location = new System.Drawing.Point(3, 42);
            this.lblCCHolderName.Name = "lblCCHolderName";
            this.lblCCHolderName.Size = new System.Drawing.Size(86, 13);
            this.lblCCHolderName.TabIndex = 0;
            this.lblCCHolderName.Text = "CC Holder Name";
            // 
            // PaytmGrp
            // 
            this.PaytmGrp.Controls.Add(this.txtPaytmNo);
            this.PaytmGrp.Controls.Add(this.txtPaytmName);
            this.PaytmGrp.Controls.Add(this.lblPaytmName);
            this.PaytmGrp.Controls.Add(this.lblPaytmNo);
            this.PaytmGrp.Location = new System.Drawing.Point(50, 220);
            this.PaytmGrp.Name = "PaytmGrp";
            this.PaytmGrp.Size = new System.Drawing.Size(225, 100);
            this.PaytmGrp.TabIndex = 4;
            this.PaytmGrp.TabStop = false;
            this.PaytmGrp.Text = "Paytm Wallet Details";
            // 
            // txtPaytmNo
            // 
            this.txtPaytmNo.Location = new System.Drawing.Point(103, 65);
            this.txtPaytmNo.Name = "txtPaytmNo";
            this.txtPaytmNo.Size = new System.Drawing.Size(111, 20);
            this.txtPaytmNo.TabIndex = 1;
            this.txtPaytmNo.MaxLength = 10;
            // 
            // txtPaytmName
            // 
            this.txtPaytmName.Location = new System.Drawing.Point(103, 34);
            this.txtPaytmName.Name = "txtPaytmName";
            this.txtPaytmName.Size = new System.Drawing.Size(111, 20);
            this.txtPaytmName.TabIndex = 1;
            this.txtPaytmName.MaxLength = 20;
            // 
            // lblPaytmName
            // 
            this.lblPaytmName.AutoSize = true;
            this.lblPaytmName.Location = new System.Drawing.Point(3, 37);
            this.lblPaytmName.Name = "lblPaytmName";
            this.lblPaytmName.Size = new System.Drawing.Size(81, 13);
            this.lblPaytmName.TabIndex = 0;
            this.lblPaytmName.Text = "Paytm ID Name";
            // 
            // lblPaytmNo
            // 
            this.lblPaytmNo.AutoSize = true;
            this.lblPaytmNo.Location = new System.Drawing.Point(3, 65);
            this.lblPaytmNo.Name = "lblPaytmNo";
            this.lblPaytmNo.Size = new System.Drawing.Size(76, 13);
            this.lblPaytmNo.TabIndex = 0;
            this.lblPaytmNo.Text = "Paytm Number";
            // 
            // AirtelGrp
            // 
            this.AirtelGrp.Controls.Add(this.txtAir);
            this.AirtelGrp.Controls.Add(this.txtAirtelName);
            this.AirtelGrp.Controls.Add(this.lblAirtelName);
            this.AirtelGrp.Controls.Add(this.lblAirtelNo);
            this.AirtelGrp.Location = new System.Drawing.Point(50, 220);
            this.AirtelGrp.Name = "AirtelGrp";
            this.AirtelGrp.Size = new System.Drawing.Size(220, 100);
            this.AirtelGrp.TabIndex = 4;
            this.AirtelGrp.TabStop = false;
            this.AirtelGrp.Text = "Aitel Wallet Details";
            // 
            // txtAir
            // 
            this.txtAir.Location = new System.Drawing.Point(103, 65);
            this.txtAir.Name = "txtAir";
            this.txtAir.Size = new System.Drawing.Size(111, 20);
            this.txtAir.TabIndex = 1;
            this.txtAir.MaxLength = 10;
            // 
            // txtAirtelName
            // 
            this.txtAirtelName.Location = new System.Drawing.Point(103, 34);
            this.txtAirtelName.Name = "txtAirtelName";
            this.txtAirtelName.Size = new System.Drawing.Size(111, 20);
            this.txtAirtelName.TabIndex = 1;
            this.txtAirtelName.MaxLength = 10;
            // 
            // lblAirtelName
            // 
            this.lblAirtelName.AutoSize = true;
            this.lblAirtelName.Location = new System.Drawing.Point(3, 37);
            this.lblAirtelName.Name = "lblAirtelName";
            this.lblAirtelName.Size = new System.Drawing.Size(75, 13);
            this.lblAirtelName.TabIndex = 0;
            this.lblAirtelName.Text = "Airtel ID Name";
            // 
            // lblAirtelNo
            // 
            this.lblAirtelNo.AutoSize = true;
            this.lblAirtelNo.Location = new System.Drawing.Point(3, 65);
            this.lblAirtelNo.Name = "lblAirtelNo";
            this.lblAirtelNo.Size = new System.Drawing.Size(70, 13);
            this.lblAirtelNo.TabIndex = 0;
            this.lblAirtelNo.Text = "Airtel Number";
            // 
            // AddMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 384);
            this.Controls.Add(this.DebitCardGrp);
            this.Controls.Add(this.CreditCardGrp);
            this.Controls.Add(this.AirtelGrp);
            this.Controls.Add(this.PaytmGrp);
            this.Controls.Add(this.NetBankingGrp);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddMoney";
            this.Text = "AddMoney";
            this.Load += new System.EventHandler(this.AddMoney_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.DebitCardGrp.ResumeLayout(false);
            this.DebitCardGrp.PerformLayout();
            this.NetBankingGrp.ResumeLayout(false);
            this.NetBankingGrp.PerformLayout();
            this.CreditCardGrp.ResumeLayout(false);
            this.CreditCardGrp.PerformLayout();
            this.PaytmGrp.ResumeLayout(false);
            this.PaytmGrp.PerformLayout();
            this.AirtelGrp.ResumeLayout(false);
            this.AirtelGrp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtAddMoneyValue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddMoney;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWalletBalance;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblIFSC;
        private System.Windows.Forms.Label lblAccountNo;
        private System.Windows.Forms.Label lblAccountHolder;
        private System.Windows.Forms.ComboBox cmbPaymentMethod;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.GroupBox NetBankingGrp;
        private System.Windows.Forms.TextBox txtIFSC;
        private System.Windows.Forms.TextBox txtAccountNo;
        private System.Windows.Forms.TextBox txtAccountHolder;
        private System.Windows.Forms.GroupBox CreditCardGrp;
        private System.Windows.Forms.TextBox txtCCHolder;
        private System.Windows.Forms.TextBox txtCCNo;
        private System.Windows.Forms.Label lblCCNo;
        private System.Windows.Forms.Label lblCCHolderName;
        private System.Windows.Forms.TextBox txtCCExpiry;
        private System.Windows.Forms.Label lblCCcVV;
        private System.Windows.Forms.Label lblCCExpiry;
        private System.Windows.Forms.GroupBox DebitCardGrp;
        private System.Windows.Forms.TextBox txtDCcVV;
        private System.Windows.Forms.TextBox txtDCExpiry;
        private System.Windows.Forms.TextBox txtDCHolder;
        private System.Windows.Forms.TextBox txtDC;
        private System.Windows.Forms.Label lblDC;
        private System.Windows.Forms.Label lblDCCVV;
        private System.Windows.Forms.Label lblDCExpiry;
        private System.Windows.Forms.Label lblDCHolder;
        private System.Windows.Forms.GroupBox PaytmGrp;
        private System.Windows.Forms.TextBox txtPaytmNo;
        private System.Windows.Forms.TextBox txtPaytmName;
        private System.Windows.Forms.Label lblPaytmName;
        private System.Windows.Forms.Label lblPaytmNo;
        private System.Windows.Forms.GroupBox AirtelGrp;
        private System.Windows.Forms.TextBox txtAir;
        private System.Windows.Forms.TextBox txtAirtelName;
        private System.Windows.Forms.Label lblAirtelName;
        private System.Windows.Forms.Label lblAirtelNo;
        private System.Windows.Forms.TextBox txtCCcVV;
    }
}