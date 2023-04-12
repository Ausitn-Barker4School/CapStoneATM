//using DocumentFormat.OpenXml.Spreadsheet;
using Nest;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ATM.DB.UOW;
using ATM.DB.Interfaces;
using Dapper;


namespace CapStoneATM
{
    public partial class AccountForm : Form
    {
        public IConnectionFactory GetConnection { get; private set; }
        public AccountForm()
        {
            InitializeComponent();
            GetConnection = new DatabaseConnectionFactory();
            
            
        }
        
        
        

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if ((String.Compare(AccountLabel.Text, " ") < 0))
            {
                AccountLabel.Text = AccountLabel.Text.Substring(0, AccountLabel.Text.Length - 1 + 1);
            }
            else
            {
                AccountLabel.Text = AccountLabel.Text.Substring(0, AccountLabel.Text.Length - 1);

            }
        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            if (AccountLabel.TextLength <= 17 && AccountLabel.TextLength >= 8)
                //will need to have it check if it is in the data base. 
            {
                try {
                    string str = AccountLabel.Text;
                    
                  

            //        string connstring = "Data Source = (localdb)\\MSSLLocalDB;" +
            //"Initial Catalog =  CapeStoneATM;"
            //+ "Trusted_Connection = True;";
            //        SqlConnection con = new SqlConnection(connstring);
            //        con.Open();
            //        string check = "Select * from AccountAndPin Where AccountNumber = @str";
            //        SqlCommand cmd = new SqlCommand(check, con);



                    this.Hide();
                    PinForm pinForm = new PinForm();
                    pinForm.ShowDialog();
                    this.Close();

                }
                catch (Exception) {
                    string box_error = "Invalid entery";
                    MessageBox.Show(box_error);
                    AccountLabel.Clear();
                }
               
               
            }

            else {
                string box_error = "Invalid entery";
                MessageBox.Show(box_error);
                AccountLabel.Clear();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AccountLabel.Text = AccountLabel.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AccountLabel.Text = AccountLabel.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AccountLabel.Text = AccountLabel.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AccountLabel.Text = AccountLabel.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AccountLabel.Text = AccountLabel.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AccountLabel.Text = AccountLabel.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AccountLabel.Text = AccountLabel.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AccountLabel.Text = AccountLabel.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AccountLabel.Text = AccountLabel.Text + "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            AccountLabel.Text = AccountLabel.Text + "0";
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            AccountLabel.Clear();
        }
    }
}
