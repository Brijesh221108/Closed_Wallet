using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.Data.SqlClient;

namespace CloseLoopWalletPOC
{
    public partial class AddMoney : Form
    {
        string s = System.DateTime.Now.ToString("dd-MM-yyyy");
  
        public AddMoney()
        {
            InitializeComponent();
        }

        public void AddMoney_Load(object sender, EventArgs e)
        {
                cmbPaymentMethod.SelectedIndex = 0;
                btnAddMoney.Enabled = false;
                refreshForm();
               
        }

        //public string LabelText
        //{
        //    get
        //    {
        //        return this.lblWalletBalance.Text;
        //    }
        //    set
        //    {
        //        this.lblWalletBalance.Text = value;
        //    }
        //}

        public void refreshForm()
        {
            
            string test = string.Empty;
            using (var connection = new SqlCeConnection(@"Data Source = |DataDirectory|\WalletDB.sdf"))
            {
                var cmd = new SqlCeCommand();
                cmd.Connection = connection;
                connection.Open();
                cmd.CommandText = "SELECT Amount from AddAmount";
                var result = cmd.ExecuteReader();
                while (result.Read())
                {
                    test = result.GetValue(0).ToString();
                }

                lblWalletBalance.Text = test;
   
            }             
        }

        private void btnAddMoney_Click(object sender, EventArgs e)
        {

            if (txtAccountNo.Text != string.Empty || txtAccountHolder.Text != string.Empty || txtIFSC.Text != string.Empty
                ||txtPaytmName.Text != string.Empty || txtPaytmNo.Text != string.Empty 
                ||txtCCHolder.Text != string.Empty || txtCCNo.Text != string.Empty || txtCCcVV.Text != string.Empty || txtCCExpiry.Text != string.Empty
                ||txtDCHolder.Text != string.Empty ||  txtDCcVV.Text != string.Empty || txtDCExpiry.Text != string.Empty
                ||txtAirtelName.Text != string.Empty || txtAir.Text != string.Empty)
            {

            decimal totalAmount = 0.0m;
            string test= string.Empty;
            using (var connection = new SqlCeConnection(@"Data Source = |DataDirectory|\WalletDB.sdf"))
            {
                var cmd = new SqlCeCommand();
                cmd.Connection = connection;
                connection.Open();
                cmd.CommandText = "SELECT Amount from AddAmount";
                 var result = cmd.ExecuteReader();
                 while (result.Read())
                 {
                     test = result.GetValue(0).ToString();
                 }
                 if (txtAddMoneyValue.Text != string.Empty)
                 {

                     totalAmount = Convert.ToDecimal(txtAddMoneyValue.Text) + Convert.ToDecimal(test);
                     cmd.CommandText = "insert into AddAmount(ID,Amount,Date) Values(@ID,@Amount,@Date)";
                     cmd.Parameters.AddWithValue("@ID", "UPPCL"+ s);
                     cmd.Parameters.AddWithValue("@Amount", totalAmount);
                     cmd.Parameters.AddWithValue("@Date", s);
                     int x = cmd.ExecuteNonQuery();
                     if (x > 0)
                     {
                         refreshForm();
                         string message = "Amount added successfully";
                         MessageBox.Show(message);
                         cmd.CommandText = "insert into AvailableBalance(ID,Balance,Status,AddedBy,Date) Values(@IDAB,@Balance,@Status,@AddedBy,@DateAB)";
                         cmd.Parameters.AddWithValue("@IDAB", "UPPCL" + s);
                         cmd.Parameters.AddWithValue("@Balance", txtAddMoneyValue.Text);
                         cmd.Parameters.AddWithValue("@Status", "Added");

                         if (cmbPaymentMethod.SelectedIndex == 1)
                         {
                             cmd.Parameters.AddWithValue("@AddedBy", "Paytm Wallet");
                         }
                         else if (cmbPaymentMethod.SelectedIndex == 2)
                         {
                             cmd.Parameters.AddWithValue("@AddedBy", "NetBanking");
                         }
                         else if (cmbPaymentMethod.SelectedIndex == 3)
                         {
                             cmd.Parameters.AddWithValue("@AddedBy", "Credit Card");
                         }
                         else if (cmbPaymentMethod.SelectedIndex == 4)
                         {
                             cmd.Parameters.AddWithValue("@AddedBy", "Debit Card");
                         }
                         else if (cmbPaymentMethod.SelectedIndex == 5)
                         {
                             cmd.Parameters.AddWithValue("@AddedBy", "Airtel Wallet");
                         }

                         cmd.Parameters.AddWithValue("@DateAB", s);

                         x=cmd.ExecuteNonQuery();
                         var form = new AddMoney();
                         this.Close();
                        // string s = Convert.ToString(totalAmount);
                         Details detailForm = new Details();
                         detailForm.refreshForm();
                         //detailForm.lblWalletBalanceValue.Text = this.lblWalletBalance.Text;
                         //Form f = new Details();
                         //foreach (Control c in f.Controls)
                         //    if (c.Name == "lblWalletBalanceValue")
                         //    {
                         //        c.Text = Convert.ToString(totalAmount);
                         //        return;
                         //    }
                     }

                 }
                 else
                 {
                     MessageBox.Show("Please enter money");
                 }
            }
            }
            else
            {
                MessageBox.Show("Please enter details");

            }

        }

       

        private void cmbPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbPaymentMethod.SelectedIndex == 0)
            {
    
                PaytmGrp.Visible = false;
                CreditCardGrp.Visible = false;
                DebitCardGrp.Visible = false;
                NetBankingGrp.Visible = false;
                AirtelGrp.Visible = false;

            }
            else if (cmbPaymentMethod.SelectedIndex == 1)
            {
                PaytmGrp.Visible = true;
                CreditCardGrp.Visible = false;
                DebitCardGrp.Visible = false;
                NetBankingGrp.Visible = false;
                AirtelGrp.Visible = false;

                btnAddMoney.Enabled = true;
            }

            else if (cmbPaymentMethod.SelectedIndex == 2)
            {

                PaytmGrp.Visible = false;
                CreditCardGrp.Visible = false;
                DebitCardGrp.Visible = false;
                NetBankingGrp.Visible = true;
                AirtelGrp.Visible = false;

                btnAddMoney.Enabled = true;
            }

            else if (cmbPaymentMethod.SelectedIndex == 3)
            {

                PaytmGrp.Visible = false;
                CreditCardGrp.Visible = true;
                DebitCardGrp.Visible = false;
                NetBankingGrp.Visible = false;
                AirtelGrp.Visible = false;

               

                btnAddMoney.Enabled = true;

            }
            else if (cmbPaymentMethod.SelectedIndex == 4)
            {

                PaytmGrp.Visible = false;
                CreditCardGrp.Visible = false;
                DebitCardGrp.Visible = true;
                NetBankingGrp.Visible = false;
                AirtelGrp.Visible = false;

                btnAddMoney.Enabled = true;
            }
            else
            {

                PaytmGrp.Visible = false;
                CreditCardGrp.Visible = false;
                DebitCardGrp.Visible = false;
                NetBankingGrp.Visible = false;
                AirtelGrp.Visible = true;

               
                btnAddMoney.Enabled = true;
        
            }
        }    
}
}

