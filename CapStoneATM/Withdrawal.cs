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
    public partial class Withdrawal : Form
    {
        public Withdrawal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtbox_Withdrawal.Text = txtbox_Withdrawal.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtbox_Withdrawal.Text = txtbox_Withdrawal.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtbox_Withdrawal.Text = txtbox_Withdrawal.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtbox_Withdrawal.Text = txtbox_Withdrawal.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtbox_Withdrawal.Text = txtbox_Withdrawal.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtbox_Withdrawal.Text = txtbox_Withdrawal.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtbox_Withdrawal.Text = txtbox_Withdrawal.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtbox_Withdrawal.Text = txtbox_Withdrawal.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtbox_Withdrawal.Text = txtbox_Withdrawal.Text + "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            txtbox_Withdrawal.Text = txtbox_Withdrawal.Text + "0";
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if ((String.Compare(txtbox_Withdrawal.Text, " ") < 0))
            {
                txtbox_Withdrawal.Text = txtbox_Withdrawal.Text.Substring(0, txtbox_Withdrawal.Text.Length - 1 + 1);
            }
            else
            {
                txtbox_Withdrawal.Text = txtbox_Withdrawal.Text.Substring(0, txtbox_Withdrawal.Text.Length - 1);

            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txtbox_Withdrawal.Clear();
        }

        private void btn_withDraw20_Click(object sender, EventArgs e)
        {
            //Withdrawals 20 from the data base
            this.Hide();
            MakeAnotherWithdrawal makeAnotherWithdrawal = new MakeAnotherWithdrawal();
            makeAnotherWithdrawal.ShowDialog();
            this.Close();

        }

        private void btn_withDraw40_Click(object sender, EventArgs e)
        {
            //withdrawals 2 20 from the data base
            this.Hide();
            MakeAnotherWithdrawal makeAnotherWithdrawal = new MakeAnotherWithdrawal();
            makeAnotherWithdrawal.ShowDialog();
            this.Close();

        }

        private void btn_withDraw60_Click(object sender, EventArgs e)
        {
            //withdrawals 3 20 from the data base
            this.Hide();
            MakeAnotherWithdrawal makeAnotherWithdrawal = new MakeAnotherWithdrawal();
            makeAnotherWithdrawal.ShowDialog();
            this.Close();

        }

        private void btn_withDraw100_Click(object sender, EventArgs e)
        {
            //withdrawals 5 20 from the data base
            this.Hide();
            MakeAnotherWithdrawal makeAnotherWithdrawal = new MakeAnotherWithdrawal();
            makeAnotherWithdrawal.ShowDialog();
            this.Close();

        }

        private void btn_withdrawal_Click(object sender, EventArgs e)
        {
            string str = txtbox_Withdrawal.Text;
            try
            {
                decimal withdrawal = 0;
                withdrawal = Convert.ToDecimal(str);
                if (withdrawal % 20 == 0)
                {
                    if (withdrawal > 1000)
                    {
                        string box_error = "Invalid entery";
                        MessageBox.Show(box_error);
                        txtbox_Withdrawal.Clear();
                    }
                    else
                    {
                        //withdrawals the amount

                        this.Hide();
                        MakeAnotherWithdrawal makeAnotherWithdrawal = new MakeAnotherWithdrawal();
                        makeAnotherWithdrawal.ShowDialog();
                        this.Close();
                    }

                    }
                else
                {
                    string box_error = "Invalid entery";
                    MessageBox.Show(box_error);
                    txtbox_Withdrawal.Clear();
                }

            }
            catch (Exception)
            {
                string box_error = "Invalid entery";
                MessageBox.Show(box_error);
                txtbox_Withdrawal.Clear();
            }
        }

        private void btn_logOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            AccountForm accountForm = new AccountForm();
            accountForm.ShowDialog();
            this.Close();
        }

        private void btn_EditFile_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditAccount editAccount = new EditAccount();
            editAccount.ShowDialog();
            this.Close();
        }
    }
}
