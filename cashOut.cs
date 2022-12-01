using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResturantPOS
{
    public partial class cashOut : Form
    {
        public cashOut()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTotalcashOut_Click(object sender, EventArgs e)
        {
            decimal totalcash = 0;
            decimal cash=0, credit=0, debit=0, tips=0;
           /* decimal cash = Convert.ToDecimal(txtCash.Text);
            decimal credit = Convert.ToDecimal(txtCredit.Text);
            decimal debit = Convert.ToDecimal(txtDebit.Text);
            decimal tips = Convert.ToDecimal(txtTips.Text);*/
            if(IsNull(txtCash) && IsDecimal(txtCash) && IsWithinRange(txtDebit, 0, 10000))
            {
                 cash = Convert.ToDecimal(txtCash.Text);
                cash += cash * 1;
            }
            if (IsNull(txtCredit) && IsDecimal(txtCredit) && IsWithinRange(txtCredit, 0, 10000))
            {
                 credit = Convert.ToDecimal(txtCredit.Text);
                credit += credit * 1;
            }
            if (IsNull(txtDebit) && IsDecimal(txtDebit) && IsWithinRange(txtDebit, 0, 10000))
            {
                 debit = Convert.ToDecimal(txtDebit.Text);
                debit += debit * 1;
            }
            if (IsNull(txtTips) && IsDecimal(txtTips) && IsWithinRange(txtTips, 0, 10000))
            {
                 tips = Convert.ToDecimal(txtTips.Text);
                tips += tips * 1;
            }
            totalcash = cash + credit + tips + debit;
            txtTotalCashout.Text = totalcash.ToString("c2");
        }
        private bool IsDecimal(TextBox textBox)
        {
            decimal num = 0m;
            if (Decimal.TryParse(textBox.Text, out num))
                return true;
            else
            {
                MessageBox.Show(textBox.Text + "  should be a decimal Number", "Error");
                textBox.Focus();
                return false;

            }
        }
        private bool IsNull(TextBox textbox)
        {
            if (textbox.Text == "")
            {
                MessageBox.Show("Value for subtotal is required! ", "Error");
                textbox.Focus();
                return false;
            }
            else
                return true;

        }
        private bool IsWithinRange(TextBox textbox, int min, int max)
        {
            //int value = Convert.ToInt32(textbox.Text);
            decimal value = Convert.ToDecimal(textbox.Text);
            if (value >= min && value <= max)
                return true;
            else
            {
                MessageBox.Show("Value of subtotal must be positivie");
                return false;
            }

        }

        private void txtDebit_TextChanged(object sender, EventArgs e)
        {
            txtTotalCashout.Clear();
        }

        private void txtCredit_TextChanged(object sender, EventArgs e)
        {
            txtTotalCashout.Clear();
        }

        private void txtCash_TextChanged(object sender, EventArgs e)
        {
            txtTotalCashout.Clear();
        }

        private void txtTips_TextChanged(object sender, EventArgs e)
        {
            txtTotalCashout.Clear();
        }
    }
}
