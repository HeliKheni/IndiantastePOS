using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            txtDebit.Text = displaySum("Debit").ToString();
            txtCredit.Text = displaySum("Credit").ToString();
        }

        public cashOut()
        {
            InitializeComponent();
            txtDebit.Text = displaySum("Debit").ToString();
            txtCredit.Text = displaySum("Credit").ToString();

        }
        public double displaySum(string type)
        {
            connect();
            SqlCommand cmd;
            SqlDataReader drreader;
            String sql;
            DateTime now = DateTime.Now;

            sql = "SELECT SUM(TotalAmt) FROM orders WHERE AddedAt = @AddedAt AND paidBy = @Type";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@AddedAt", now.ToShortDateString());
            cmd.Parameters.AddWithValue("@Type", type);

            try
            {
                conn.Open();
                drreader = cmd.ExecuteReader();

                if (drreader.Read())
                {
                    double amt = Convert.ToDouble(drreader.GetValue(0).ToString());
                    return amt;
                }

                return 0; // If no records are found, return 0.
            }
            catch (Exception ex)
            {
                // Handle the exception (e.g., log it or throw a custom exception)
                Console.WriteLine("Error: " + ex.Message);
                return 0;
            }
            finally
            {
                conn.Close(); // Make sure to close the connection in the finally block.
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTotalcashOut_Click(object sender, EventArgs e)
        {
            decimal totalcash = 0;
            decimal cash=0, credit=0, debit=0, tips=0;
            if(IsNull(txtCash) && IsDecimal(txtCash) && IsWithinRange(txtDebit, 0))
            {
                cash = Convert.ToDecimal(txtCash.Text);
                connect();

                SqlCommand cmd;
                SqlDataReader drreader;
                String sql, output = "";
                DateTime now = DateTime.Now;
                sql = "select openAmount from calCash where added_at='" + now.ToShortDateString() + "'";
                cmd = new SqlCommand(sql, conn);
                drreader = cmd.ExecuteReader();
                decimal amt = 0;
                while (drreader.Read())
                {
                    amt = Convert.ToDecimal(drreader.GetValue(0).ToString());
                }
                conn.Close();
                if(cash < amt)
                {
                    MessageBox.Show("Sorry! Your Cashout cash is less than opening amount");
                }
                else
                {
                    credit = Convert.ToDecimal(txtCredit.Text);
                    debit = Convert.ToDecimal(txtDebit.Text);
                    if (IsNull(txtTips) && IsDecimal(txtTips) && IsWithinRange(txtTips, 0))
                    {
                        tips = Convert.ToDecimal(txtTips.Text);
                        totalcash = cash + credit + tips + debit;
                        txtTotalCashout.Text = totalcash.ToString("c2");
                    }
                   
                    
                }
               
            }
            
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
                MessageBox.Show(" All values are required! ", "Error");
                textbox.Focus();
                return false;
            }
            else
                return true;

        }
        private bool IsWithinRange(TextBox textbox, int min)
        {
            decimal value = Convert.ToDecimal(textbox.Text);
            if (value >= min)
                return true;
            else
            {
                MessageBox.Show(" All Values must be positivie");
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
            ManagerHomePage m = new ManagerHomePage();
            m.Show();
        }
        SqlConnection conn;
        string constr;
        public void connect()
        {
            //constr = @"data source=KHENI;database=DbIndianTaste;integrated security=true";
            //constr = @"data source=DESKTOP-7N3FNPL\SQL;database=DbIndianTaste;integrated security=true";
            constr = @"data source=JANKI\MSSQLSERVER04;database=DbIndianTaste;integrated security=true";

            conn = new SqlConnection(constr);
            conn.Open();
        }
        private void btncashOut_Click(object sender, EventArgs e)
        {
            if(txtTotalCashout.Text == "")
            {
                MessageBox.Show("Please Do total first");
            }
            else
            {
                connect();
                SqlCommand cmd;
                SqlDataReader drreader;
                DateTime now = DateTime.Now;

                String sql = "update calCash set closeAmount = " + Convert.ToDecimal(txtCash.Text) +
                    " , debitAmount = " + Convert.ToDecimal(txtDebit.Text) +
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
}
