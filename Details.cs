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
    public partial class Details : Form
    {
        
        string s = System.DateTime.Now.ToString("dd-MM-yyyy");
        public Details()
        {
            InitializeComponent();
        }

        private void Details_Activated(object sender, EventArgs e)
        {
            refreshForm(); 
        }
        

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

                lblWalletBalanceValue.Text = test;
            }


            
        }



        public void bindgirdview()
        {

            using (var connection = new SqlCeConnection(@"Data Source = |DataDirectory|\WalletDB.sdf"))
            {

                if (txtConsumerNo.Text != "")
                {
                    string consumerno = txtConsumerNo.Text;
                    string query = string.Format("Select ConsumerNo,BillNo,Amount,Date,Status from BillPaid where ConsumerNo = {0}", consumerno);
                    SqlCeDataAdapter das = new SqlCeDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    das.Fill(dt);
                    dataGridBillPaid.DataSource = dt;
                }

                else {
                    string message = "Please enter consumer no";
                    MessageBox.Show(message);
                
                }

            }
        
        }

        private void btnAddMoney_Click(object sender, EventArgs e)
        {
            var form = new AddMoney();
            form.Show();
          
            refreshForm();
        }

        private void btnPayMoney_Click(object sender, EventArgs e)
        {

            if (txtBillNo.Text == string.Empty || txtConsumerNo.Text == string.Empty || txtAmount.Text == string.Empty)
            {
                string message = "All Fields are mandatory";
                MessageBox.Show(message);

            }
            else
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

                    if (!(string.IsNullOrEmpty(txtAmount.Text)))
                    {

                        if (Convert.ToDecimal(test) >= Convert.ToDecimal(txtAmount.Text))
                        {
                            decimal totalAmount = Convert.ToDecimal(test) - Convert.ToDecimal(txtAmount.Text);
                            cmd.CommandText = "insert into BillPaid(ID,Amount,ConsumerNo,BillNo,Date,Status) Values(@ID,@Amount,@ConsumerNo,@BillNo,@Date,@Status) ";
                            cmd.Parameters.AddWithValue("@ID", "UPPCL" + txtConsumerNo.Text);
                            cmd.Parameters.AddWithValue("@Amount", txtAmount.Text);
                            cmd.Parameters.AddWithValue("@ConsumerNo", txtConsumerNo.Text);
                            cmd.Parameters.AddWithValue("@BillNo", txtBillNo.Text);
                            cmd.Parameters.AddWithValue("@Date", s);
                            cmd.Parameters.AddWithValue("@Status","Paid");

                            int x = cmd.ExecuteNonQuery();
                            if (x > 0)
                            {
                                
                                
                                string message = "Amount paid successfully";
                                MessageBox.Show(message);
                                cmd.CommandText = "insert into AvailableBalance(ID,Balance,Status,PaidTo,Date) Values(@ID,@Balance,@Status,@PaidTo,@Date) ";
                                cmd.Parameters.Clear();
                                cmd.Parameters.AddWithValue("@ID", "UPPCL"+ System.DateTime.Now);
                                cmd.Parameters.AddWithValue("@Balance", txtAmount.Text);
                                cmd.Parameters.AddWithValue("@Status", "Paid");
                                cmd.Parameters.AddWithValue("@PaidTo", txtConsumerNo.Text);
                                cmd.Parameters.AddWithValue("@Date", s);

                                x = cmd.ExecuteNonQuery();

                                cmd.CommandText = "insert into AddAmount(ID,Amount,Date) Values(@IDA,@Amount,@DateA)";
                                cmd.Parameters.AddWithValue("@IDA", "UPPCL" + System.DateTime.Now);
                                cmd.Parameters.AddWithValue("@Amount", totalAmount);
                                cmd.Parameters.AddWithValue("@DateA",  s);

                                x = cmd.ExecuteNonQuery();

                                BillDue();
                                refreshForm();
                                txtAmount.Text = string.Empty;
                                txtConsumerNo.Text = string.Empty;
                                txtBillNo.Text = string.Empty;
                                txtPaymentDate.Text = string.Empty;
            
                                if (!(x > 0))
                                {
                                    message = "Amount is not deducted";
                                    MessageBox.Show(message);
                                    var form = new AddMoney();
                                    this.Close();

                                }

                            }

                            //update availble balance


                        }
                        else
                        {
                            string message = "Wallet balance is not sufficient";
                            MessageBox.Show(message);
                            txtAmount.Text = string.Empty;
                            txtConsumerNo.Text = string.Empty;
                            txtBillNo.Text = string.Empty;
                            txtPaymentDate.Text = string.Empty;
                            refreshForm();

                        }

                    }

                    else
                     {    
                        refreshForm();
                        string message = "Please add amount";
                        MessageBox.Show(message);
                        txtAmount.Text = string.Empty;
                        txtConsumerNo.Text = string.Empty;
                        txtBillNo.Text = string.Empty;
                        txtPaymentDate.Text = string.Empty;
                    }


                }
            }

           


        }

        private void btnViewTrans_Click(object sender, EventArgs e)
        {
            bindgirdview();
            
           
        }

        private void btnGetBillDetailss(object sender, EventArgs e)
        {
            bindgirdviewBillDue();
            string BillNo = string.Empty;
            string PaymentDate = string.Empty;
            string Amount = string.Empty;

            if (txtConsumerNo.Text != string.Empty)
            {
                using (var connection = new SqlCeConnection(@"Data Source = |DataDirectory|\WalletDB.sdf"))
                {
                    var cmd = new SqlCeCommand();
                    cmd.Connection = connection;
                    connection.Open();
                    cmd.CommandText = "Select * from BillDue where CosumerNo=@CosumerNo";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@CosumerNo", txtConsumerNo.Text);
                    var result = cmd.ExecuteReader();

                    
                        while (result.Read())
                        {
                            txtBillNo.Text = result.GetValue(2).ToString();
                            txtAmount.Text = result.GetValue(3).ToString();
                            txtPaymentDate.Text = result.GetValue(4).ToString();
                        }
                    
                if( txtBillNo.Text == string.Empty)
                    {
                        MessageBox.Show("Please enter  valid consumer number");
                        txtConsumerNo.Text = string.Empty;
                        txtPaymentDate.Text = string.Empty;
                        txtAmount.Text = string.Empty;
                    }
                else if (txtAmount.Text == "0.00")
                {
                    MessageBox.Show("There is no due/pending bills");
                    txtConsumerNo.Text = string.Empty;
                    txtBillNo.Text = string.Empty;
                    txtPaymentDate.Text = string.Empty;
                    txtAmount.Text = string.Empty;
                }
                }
            }

            else
            {
                MessageBox.Show("Please enter consumer number");
                txtAmount.Text = string.Empty;
                txtConsumerNo.Text = string.Empty;
                txtBillNo.Text = string.Empty;
                txtPaymentDate.Text = string.Empty;
            }


        }



        public void bindgirdviewBillDue()
        {

            using (var connection = new SqlCeConnection(@"Data Source = |DataDirectory|\WalletDB.sdf"))
            {

                if (txtConsumerNo.Text != "")
                {
                    string consumerno = txtConsumerNo.Text;
                    string query = string.Format("Select CosumerNo,BillNo,Amount,Date,Status  from BillDue where CosumerNo = {0}", consumerno);
                    SqlCeDataAdapter das = new SqlCeDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    das.Fill(dt);
                    dataGridBillPaid.DataSource = dt;
                }

                else
                {
                    string message = "Please enter consumer no";
                    MessageBox.Show(message);
                    txtAmount.Text = string.Empty;
                    txtConsumerNo.Text = string.Empty;
                    txtBillNo.Text = string.Empty;
                    txtPaymentDate.Text = string.Empty;

                }

            }

        }

        private void btnWalletHistory_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlCeConnection(@"Data Source = |DataDirectory|\WalletDB.sdf"))
            {
                    string query = string.Format("Select ID,Balance,Status,PaidTo,AddedBy,Date from AvailableBalance");
                    SqlCeDataAdapter das = new SqlCeDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    das.Fill(dt);
                    dataGridBillPaid.DataSource = dt;

            }
        }

        private void BillDue()
        {
            if (txtBillNo.Text == string.Empty || txtConsumerNo.Text == string.Empty || txtAmount.Text == string.Empty)
            {
                string message = "All fields are mandatory";
                MessageBox.Show(message);

            }
            else
            {
                string test = string.Empty;
                using (var connection = new SqlCeConnection(@"Data Source = |DataDirectory|\WalletDB.sdf"))
                {
                    var cmd = new SqlCeCommand();
                    cmd.Connection = connection;
                    connection.Open();
                    cmd.CommandText = "Select Amount from BillDue where CosumerNo=@CosumerNo";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@CosumerNo", txtConsumerNo.Text);
                    var result = cmd.ExecuteReader();
                    while (result.Read())
                    {
                        test = result.GetValue(0).ToString();
                    }

                    if (!(string.IsNullOrEmpty(txtAmount.Text)))
                    {

                        if (Convert.ToDecimal(test) >= Convert.ToDecimal(txtAmount.Text))
                        {
                            decimal totalAmount = Convert.ToDecimal(test) - Convert.ToDecimal(txtAmount.Text);
                            cmd.CommandText = "insert into BillDue(ID,Amount,CosumerNo,BillNo,Date,Status) Values(@IDBD,@AmountBD,@CosumerNoBD,@BillNoBD,@DateBD,@StatusBD)";
                            cmd.Parameters.AddWithValue("@IDBD", "UPPCL" + System.DateTime.Now);
                            cmd.Parameters.AddWithValue("@AmountBD", totalAmount);
                            cmd.Parameters.AddWithValue("@CosumerNoBD", txtConsumerNo.Text);
                            cmd.Parameters.AddWithValue("@BillNoBD", txtBillNo.Text);
                            cmd.Parameters.AddWithValue("@DateBD", s);
                            cmd.Parameters.AddWithValue("@StatusBD", "Due Amount");
                            int x = cmd.ExecuteNonQuery();

                        }
                        else
                        {

                            //MessageBox.Show("Sorry, you cannot pay more than the bill due");
                            //txtAmount.Text = string.Empty;
                            //txtConsumerNo.Text = string.Empty;
                            //txtBillNo.Text = string.Empty;
                            //txtPaymentDate.Text = string.Empty;

                        }
                    }
                }
            }

        }

       
        

    }
}