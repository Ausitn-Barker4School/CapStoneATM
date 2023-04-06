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
    public partial class PinForm : Form
    {
        public PinForm()
        {
            InitializeComponent();
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
            if (txtbox_pin.TextLength == 4)
            {
                try {
                    string str = txtbox_pin.Text;
                    Convert.ToInt32(str);

                    this.Hide();
                    Withdrawal withdrawal = new Withdrawal();
                    withdrawal.ShowDialog();
                    this.Close();
                }
                catch (Exception)
                {
                    string box_error = "Invalid entery";
                    MessageBox.Show(box_error);
                    txtbox_pin.Clear();
                }
            }
            else {
                string box_error = "Invalid entery";
                MessageBox.Show(box_error);
                txtbox_pin.Clear();
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
