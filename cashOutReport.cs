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
    public partial class cashOutReport : Form
    {
        public cashOutReport()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        string constr;

        public void connect()
        {
            constr = @"data source=JANKI\MSSQLSERVER04;database=DbIndianTaste;integrated security=true";
            //constr = @"data source=DESKTOP-7N3FNPL\SQL;database=DbIndianTaste;integrated security=true";
            //constr = @"data source=KHENI;database=DbIndianTaste;integrated security=true";
            conn = new SqlConnection(constr);
            conn.Open();
            Console.WriteLine("Connection open");

        }
        private void cashOutReport_Load(object sender, EventArgs e)
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
            while (drreader.Read())
            {
                lbldate.Text = drreader.GetValue(2).ToString();
                lblobal.Text = drreader.GetValue(0).ToString();
                lblcbal.Text = drreader.GetValue(1).ToString();

                decimal sale = Convert.ToDecimal(lblcbal.Text) - Convert.ToDecimal(lblobal.Text);
                lblcashsale.Text = sale.ToString();
                lbldebitsale.Text = drreader.GetValue(3).ToString();
                lblcreditsale.Text = drreader.GetValue(4).ToString();
                lbltip.Text = drreader.GetValue(5).ToString();
                decimal totalsale = Convert.ToDecimal(lblcashsale.Text) + Convert.ToDecimal(lbldebitsale.Text)
                    + Convert.ToDecimal(lblcreditsale.Text) + Convert.ToDecimal(lbltip.Text);
                txtTotalSale.Text = totalsale.ToString();
            }
            conn.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            ManagerHomePage mpage = new ManagerHomePage();
            mpage.Show();
        }
    }
}
