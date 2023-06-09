﻿using System;
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
    public partial class EditAccount : Form
    {
        public IConnectionFactory GetConnection { get; private set; }
        public string Value { get; set; }
        public int checker { get; set; }
        public EditAccount()
        {
            InitializeComponent();
            GetConnection = new DatabaseConnectionFactory();
            var atm = new UnitOfWork(GetConnection);
        }

        //Statement button and get Statement information from SQL database
        private void btn_statement_Click(object sender, EventArgs e)
        {
            lstbox_bankStatement.Items.Clear();
            CustomerRepository customer = new CustomerRepository(GetConnection);
            AccountAndPhoneRepository accountAndPhoneRepository = new AccountAndPhoneRepository(GetConnection);

            customer.GetAccount(Value);
            foreach(var items in customer.GetAccount(Value))
            {
                lstbox_bankStatement.Items.Add("Account ID:" + items.AccountNumber + ".");
                lstbox_bankStatement.Items.Add("Name: " + items.FirstName + " " + items.LastName + ".");
                lstbox_bankStatement.Items.Add("Funds: $" + items.Funds);
            }
            foreach(var items in accountAndPhoneRepository.GetAccount(Value))
            {
                lstbox_bankStatement.Items.Add("Phone: " + items.PhoneNumber);
            }
            
        }
        

        // Pin buttons txtbox_pin
        private void button1_Click(object sender, EventArgs e)
        {
            txtbox_pin.Text = txtbox_pin.Text + "1";
        }

        private void btn_pin2_Click(object sender, EventArgs e)
        {
            txtbox_pin.Text = txtbox_pin.Text + "2";
        }

        private void btn_pin3_Click(object sender, EventArgs e)
        {
            txtbox_pin.Text = txtbox_pin.Text + "3";
        }

        private void btn_pin4_Click(object sender, EventArgs e)
        {
            txtbox_pin.Text = txtbox_pin.Text + "4";
        }

        private void btn_pin5_Click(object sender, EventArgs e)
        {
            txtbox_pin.Text = txtbox_pin.Text + "5";
        }

        private void btn_pin6_Click(object sender, EventArgs e)
        {
            txtbox_pin.Text = txtbox_pin.Text + "6";
        }

        private void btn_pin7_Click(object sender, EventArgs e)
        {
            txtbox_pin.Text = txtbox_pin.Text + "7";
        }

        private void btn_pin8_Click(object sender, EventArgs e)
        {
            txtbox_pin.Text = txtbox_pin.Text + "8";
        }

        private void btn_pin9_Click(object sender, EventArgs e)
        {
            txtbox_pin.Text = txtbox_pin.Text + "9";
        }

        private void btn_pin0_Click(object sender, EventArgs e)
        {
            txtbox_pin.Text = txtbox_pin.Text + "0";
        }

        private void btn_pinDelete_Click(object sender, EventArgs e)
        {
            if((String.Compare(txtbox_pin.Text, " ") < 0))
            {
                txtbox_pin.Text = txtbox_pin.Text.Substring(0, txtbox_pin.Text.Length - 1 + 1);
            }
            else
            {
                txtbox_pin.Text = txtbox_pin.Text.Substring(0, txtbox_pin.Text.Length - 1);

            }
        }

        private void btn_pinClear_Click(object sender, EventArgs e)
        {
            txtbox_pin.Clear();
        }

        private void btn_pinAdd_Click(object sender, EventArgs e)
        {
            AccountAndPinRepository accountAndPinRepository = new AccountAndPinRepository(GetConnection);
            if (txtbox_pin.TextLength == 4)
            {
                int newPin = 0;
                newPin =  Convert.ToInt32(txtbox_pin.Text);

                accountAndPinRepository.AddPin( new AccountAndPin { AccountNumber = Value, Pin = newPin });
                string success = "Success";
                MessageBox.Show(success);

                txtbox_pin.Clear();
            }
            else 
            {
                string box_error = "Invalid entery";
                MessageBox.Show(box_error);
                txtbox_pin.Clear();
            }
            // adds to the sql data base. 
        } 
        
        //Add phone number button.

        private void btn_phone1_Click(object sender, EventArgs e)
        {
            txtbox_Phone.Text = txtbox_Phone.Text + "1";
        }

        private void btn_phone2_Click(object sender, EventArgs e)
        {
            txtbox_Phone.Text = txtbox_Phone.Text + "2";
        }

        private void btn_phone3_Click(object sender, EventArgs e)
        {
            txtbox_Phone.Text = txtbox_Phone.Text + "3";
        }

        private void btn_phone4_Click(object sender, EventArgs e)
        {
            txtbox_Phone.Text = txtbox_Phone.Text + "4";
        }

        private void btn_phone5_Click(object sender, EventArgs e)
        {
            txtbox_Phone.Text = txtbox_Phone.Text + "5";
        }

        private void btn_phone6_Click(object sender, EventArgs e)
        {
            txtbox_Phone.Text = txtbox_Phone.Text + "6";
        }

        private void btn_phone7_Click(object sender, EventArgs e)
        {
            txtbox_Phone.Text = txtbox_Phone.Text + "7";
        }

        private void btn_phone8_Click(object sender, EventArgs e)
        {
            txtbox_Phone.Text = txtbox_Phone.Text + "8";
        }

        private void btn_phone9_Click(object sender, EventArgs e)
        {
            txtbox_Phone.Text = txtbox_Phone.Text + "9";
        }

        private void btn_phone0_Click(object sender, EventArgs e)
        {
            txtbox_Phone.Text = txtbox_Phone.Text + "0";
        }

        private void btn_phoneDelete_Click(object sender, EventArgs e)
        {
            if ((String.Compare(txtbox_Phone.Text, " ") < 0))
            {
                txtbox_Phone.Text = txtbox_Phone.Text.Substring(0, txtbox_Phone.Text.Length - 1 + 1);
            }
            else
            {
                txtbox_Phone.Text = txtbox_Phone.Text.Substring(0, txtbox_Phone.Text.Length - 1);

            }
        }

        private void btn_phoneClear_Click(object sender, EventArgs e)
        {
            txtbox_Phone.Clear();
        }

        private void btn_phoneAdd_Click(object sender, EventArgs e)
        {
            //adds to SQL
            if (txtbox_Phone.TextLength == 10)
            {

                string newPhone = txtbox_Phone.Text;
                AccountAndPhoneRepository accountAndPhone = new AccountAndPhoneRepository(GetConnection);

                accountAndPhone.AddPhone(new AccountAndPhone { AccountNumber = Value, PhoneNumber = newPhone });
                string success = "Success";
                MessageBox.Show(success);

                txtbox_Phone.Clear();
            }
            else
            {
                string box_error = "Invalid entery";
                MessageBox.Show(box_error);
                txtbox_Phone.Clear();
            }
        }

        private void btn_logOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            AccountForm accountForm = new AccountForm();
            accountForm.ShowDialog();
            this.Close();
        }

        private void btn_withdrawal_Click(object sender, EventArgs e)
        {
            this.Hide();
            Withdrawal withdrawal = new Withdrawal();
            withdrawal.Value = Value;
            withdrawal.checker = checker;
            withdrawal.ShowDialog();
            this.Close();
        }
    }
}
