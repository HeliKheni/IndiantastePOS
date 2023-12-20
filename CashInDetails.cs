using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResturantPOS
{
    public partial class CashInDetails : Form
    {
        
        public CashInDetails()
        {
            InitializeComponent();
           
        }
        SqlConnection conn;
        string constr;
       
        public void connect()
        {
            constr = @"data source=JANKI\MSSQLSERVER04;database=DbIndianTaste;integrated security=true";
            //constr = @"data source=DESKTOP-7N3FNPL\SQL;database=DbIndianTaste;integrated security=true";
         //   constr = @"data source=KHENI;database=DbIndianTaste;integrated security=true";
            conn = new SqlConnection(constr);
            conn.Open();
            Console.WriteLine("Connection open");

        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerHomePage mpage = new ManagerHomePage();
            mpage.Show();
           // form1.Show();
        }

        private void CashInDetails_Load(object sender, EventArgs e)
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
                txtDate.Text = drreader.GetValue(2).ToString();
                txtCash.Text = drreader.GetValue(0).ToString();
            }
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}