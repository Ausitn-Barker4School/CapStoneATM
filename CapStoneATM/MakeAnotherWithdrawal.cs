using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapStoneATM
{
    public partial class MakeAnotherWithdrawal : Form
    {   

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
            withdrawal.ShowDialog();
            this.Close();
        }

        private void btn_editAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditAccount editAccount = new EditAccount();
            editAccount.ShowDialog();
            this.Close();
        }
    }
}
