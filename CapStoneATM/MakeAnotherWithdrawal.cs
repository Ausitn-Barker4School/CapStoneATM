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
    public partial class MakeAnotherWithdrawal : Form
    {
        public IConnectionFactory GetConnection { get; private set; }
        public string Value { get; set; }
        public int checker { get; set; }
        public MakeAnotherWithdrawal()
        {
            InitializeComponent();
        }

        private void btn_logOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            AccountForm accountForm = new AccountForm();
            accountForm.ShowDialog();
            this.Close();
        }

        private void btn_anotherWithdrawal_Click(object sender, EventArgs e)
        {
            this.Hide();
            Withdrawal withdrawal = new Withdrawal();
            withdrawal.Value = Value;
            withdrawal.checker = checker;
            withdrawal.ShowDialog();
            this.Close();
        }

        private void btn_editAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditAccount editAccount = new EditAccount();
            editAccount.checker = checker;
            editAccount.Value = Value;
            editAccount.ShowDialog();
            this.Close();
        }
    }
}
