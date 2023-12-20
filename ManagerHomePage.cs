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
    public partial class ManagerHomePage : Form
    {
        private welcome welcome;
        private Form1 cashIn;
        private cashOut cashOut;
        SqlConnection conn;
        string constr;
        public ManagerHomePage(welcome welcome)
        {
            InitializeComponent();
            this.welcome = welcome;
            cashIn = new Form1(this);
            cashOut = new cashOut(this);
        }
        public ManagerHomePage()
        {
            InitializeComponent();
           
           
        }
        private void Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            welcome welcomepage = new welcome();
            welcomepage.Show();
        }

        private void btnCashIn_Click(object sender, EventArgs e)
        {
            connect();

            SqlCommand cmd;
            SqlDataReader drreader;
            String sql, output = "";
            DateTime now = DateTime.Now;
           
            sql = "select * from calCash where added_at='" + now.ToShortDateString() + "'";
            cmd = new SqlCommand(sql, conn);
            drreader = cmd.ExecuteReader();
           
            if (drreader.Read())
            {
                MessageBox.Show("YOU Already cash In for Today");
                CashInDetails cashpage = new CashInDetails();
                cashpage.Show();
                this.Close();

            }
            else
            {
                this.Hide();
                Form1 cashpage = new Form1();
                cashpage.Show();
            }
            conn.Close();
           
        }

        private void btncashout_Click(object sender, EventArgs e)
        {
            connect();

            SqlCommand cmd;
            SqlDataReader drreader;
            String sql, output = "";
            DateTime now = DateTime.Now;

            sql = "select * from calCash where added_at='" + now.ToShortDateString() + "'";
            cmd = new SqlCommand(sql, conn);
            drreader = cmd.ExecuteReader();
            int nu = 1;
            if (drreader.Read())
            {
                decimal amt = Convert.ToDecimal(drreader.GetValue(1).ToString());
                if(amt > 0)
                {
                    MessageBox.Show("You already cashout for today");
                    this.Hide();
                    cashOutReport cashopage = new cashOutReport();
                    cashopage.Show();
                }
                else
                {
                    this.Hide();
                    cashOut cashopage = new cashOut();
                    cashopage.Show();
                }
                

            }
            else
            {
                MessageBox.Show("Sorry YOU didn't cash in for today");
            }
        }
        public void connect()
        {
            constr = @"data source=JANKI\MSSQLSERVER04;database=DbIndianTaste;integrated security=true";
            //constr = @"data source=DESKTOP-7N3FNPL\SQL;database=DbIndianTaste;integrated security=true";
           // constr = @"data source=KHENI;database=DbIndianTaste;integrated security=true";
            conn = new SqlConnection(constr);
            conn.Open();
            Console.WriteLine("Connection open");

        }

        private void btnManageDetails_Click(object sender, EventArgs e)
        {
            //EmployeeHomePage emp = new EmployeeHomePage();
            Employee emp = new Employee();
            this.Close();
            emp.Show();
        }

        private void btnChangeMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            //ChangeForm c = new ChangeForm();
            //c.Show();
            janki j = new janki();
            j.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
