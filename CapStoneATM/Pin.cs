using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ATM.DB.UOW;
using ATM.DB.Interfaces;
using ATM.Logic.Models;
using Dapper;
using ATM.DB.Repository;

namespace CapStoneATM
{
    public partial class PinForm : Form
    {
        public IConnectionFactory GetConnection { get; private set; }
        public string Value { get; set; }
        public PinForm()
        {
            InitializeComponent();
            GetConnection = new DatabaseConnectionFactory();
            var atm = new UnitOfWork(GetConnection);

        }
        
        //txtbox_pin

        private void button1_Click(object sender, EventArgs e)
        {
            txtbox_pin.Text = txtbox_pin.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtbox_pin.Text = txtbox_pin.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtbox_pin.Text = txtbox_pin.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtbox_pin.Text = txtbox_pin.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtbox_pin.Text = txtbox_pin.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtbox_pin.Text = txtbox_pin.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtbox_pin.Text = txtbox_pin.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtbox_pin.Text = txtbox_pin.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtbox_pin.Text = txtbox_pin.Text + "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            txtbox_pin.Text = txtbox_pin.Text + "0";
        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            
            AccountAndPinRepository accountAndPinRepository = new AccountAndPinRepository(GetConnection);
            if (txtbox_pin.TextLength == 4)
            {
                try
                {
                    int pin = Convert.ToInt32(txtbox_pin.Text);
                    bool exit = false;
                    //Will need to work on this when I can. it similar to the product update on the CKK project. 
                  exit =  accountAndPinRepository.GetPin(Value, pin);

                    if (exit.Equals(true))
                    {
                        this.Hide();
                        Withdrawal withdrawal = new Withdrawal();
                        withdrawal.Value = Value;
                        withdrawal.ShowDialog();
                        this.Close();
                    }
                }
                catch (Exception)
                {
                    string box_error = "Invalid entery";
                    MessageBox.Show(box_error);
                    this.Hide();
                    AccountForm accountForm = new AccountForm();
                    accountForm.ShowDialog();
                    this.Close();
                }
            }
            else {
                string box_error = "Invalid entery";
                MessageBox.Show(box_error);
                this.Hide();
                AccountForm accountForm = new AccountForm();
                accountForm.ShowDialog();
                this.Close();
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if ((String.Compare(txtbox_pin.Text, " ") < 0))
            {
                txtbox_pin.Text = txtbox_pin.Text.Substring(0, txtbox_pin.Text.Length - 1 + 1);
            }
            else
            {
                txtbox_pin.Text = txtbox_pin.Text.Substring(0, txtbox_pin.Text.Length - 1);

            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txtbox_pin.Clear();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            AccountForm accountForm = new AccountForm();
            accountForm.ShowDialog();
            this.Close();
        }
    }
}
