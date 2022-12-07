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

namespace ResturantPOS
{
    public partial class cashOut : Form
    {
        private ManagerHomePage managerHomePage;

        public cashOut(ManagerHomePage managerHomePage)
        {
            InitializeComponent();
            this.managerHomePage = managerHomePage;
        }

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
            if(IsNull(txtCash) && IsDecimal(txtCash) && IsWithinRange(txtDebit, 0, 10000))
            {
                 cash = Convert.ToDecimal(txtCash.Text);
              //  cash += cash * 1;
            }
            if (IsNull(txtCredit) && IsDecimal(txtCredit) && IsWithinRange(txtCredit, 0, 10000))
            {
                 credit = Convert.ToDecimal(txtCredit.Text);
              //  credit += credit * 1;
            }
            if (IsNull(txtDebit) && IsDecimal(txtDebit) && IsWithinRange(txtDebit, 0, 10000))
            {
                 debit = Convert.ToDecimal(txtDebit.Text);
                //debit += debit * 1;
            }
            if (IsNull(txtTips) && IsDecimal(txtTips) && IsWithinRange(txtTips, 0, 10000))
            {
                 tips = Convert.ToDecimal(txtTips.Text);
               // tips += tips * 1;
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
                MessageBox.Show(textBox.Text + "Entered value should be a decimal Number", "Error");
                textBox.Focus();
                return false;

            }
        }
        private bool IsNull(TextBox textbox)
        {
            if (textbox.Text == "")
            {
                MessageBox.Show(" All values for subtotal is required! ", "Error");
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
                MessageBox.Show(" All Values for subtotal must be positivie");
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            managerHomePage.Show();
        }
        SqlConnection conn;
        string constr;
        public void connect()
        {

            //constr = @"data source=DESKTOP-7N3FNPL\SQL;database=DbIndianTaste;integrated security=true";
            constr = @"data source=KHENI;database=DbIndianTaste;integrated security=true";

            conn = new SqlConnection(constr);
            conn.Open();
        }
        private void btncashOut_Click(object sender, EventArgs e)
        {
           
            connect();
            SqlCommand cmd;
            SqlDataReader drreader;
            DateTime now = DateTime.Now;
            
            String sql = "update calCash set closeAmount = " + Convert.ToDecimal(txtCash.Text) +
                " , debitAmount = " + Convert.ToDecimal(txtDebit.Text)+
                 " , creditAmount = " + Convert.ToDecimal(txtCredit.Text) +
                  " , tipsAmount = " + Convert.ToDecimal(txtTips.Text) +
                " where " +
                "added_at='" + now.ToShortDateString() + "'";
            SqlCommand cmd2 = new SqlCommand(sql, conn);
           
            cmd2.ExecuteNonQuery();
           // MessageBox.Show("Inserted Sucessfully");
            conn.Close();
            this.Hide();
            cashOutReport cr = new cashOutReport();
            cr.Show();
        }
    }
}
