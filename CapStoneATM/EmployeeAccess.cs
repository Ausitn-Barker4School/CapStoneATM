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
    public partial class EmployeeAccess : Form
    {
        public EmployeeAccess()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_moneyEnter.Text = txt_moneyEnter.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_moneyEnter.Text = txt_moneyEnter.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txt_moneyEnter.Text = txt_moneyEnter.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txt_moneyEnter.Text = txt_moneyEnter.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txt_moneyEnter.Text = txt_moneyEnter.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txt_moneyEnter.Text = txt_moneyEnter.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txt_moneyEnter.Text = txt_moneyEnter.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txt_moneyEnter.Text = txt_moneyEnter.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txt_moneyEnter.Text = txt_moneyEnter.Text + "9";
        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            //Add money to the ATM
        }

        private void button0_Click(object sender, EventArgs e)
        {
            txt_moneyEnter.Text = txt_moneyEnter.Text + "0";
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if ((String.Compare(txt_moneyEnter.Text, " ") < 0))
            {
                txt_moneyEnter.Text = txt_moneyEnter.Text.Substring(0, txt_moneyEnter.Text.Length - 1 + 1);
            }
            else
            {
                txt_moneyEnter.Text = txt_moneyEnter.Text.Substring(0, txt_moneyEnter.Text.Length - 1);

            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_moneyEnter.Clear();
        }
    }
}
