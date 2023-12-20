using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ResturantPOS
{
    public partial class AddMennu : Form
    {
        janki cf;
        static string constr = "";
        static SqlConnection conn;
        public AddMennu(janki cf)
        {
            Connect();
            InitializeComponent();
            this.cf = cf;
        }
        public void Connect()
        {
            constr = @"data source=JANKI\MSSQLSERVER04;database=DbIndianTaste;integrated security=true";
           //constr = @"data source=KHENI;database=DbIndianTaste;integrated security=true";
           //  constr = @"data source=JANKI\MSSQLSERVER04;database=DbIndianTaste;integrated security=true";
            conn = new SqlConnection(constr);
            conn.Open();
            Console.WriteLine("Connection open");

        }
        private void btnAddM_Click(object sender, EventArgs e)
        {
            string Pattern = @"[0-9]+";
            string PricePattern = @"[+-]?([0-9]*[.])?[0-9]+";
            Regex regex = new Regex(Pattern);
            Regex Priceregex = new Regex(PricePattern);
            if ( txtNameM.Text == "" || txtCategoryM.Text == "" || txtPriceM.Text == "" )
            {
                MessageBox.Show("textbox must be filled.", "EMPTY", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            else if (regex.IsMatch(txtNameM.Text))
            {
                MessageBox.Show("Name must be Letters only", "EMPTY", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (regex.IsMatch(txtCategoryM.Text))
            {
                MessageBox.Show("Please enter valid Category Name", "EMPTY", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

            else if (!Priceregex.IsMatch(txtPriceM.Text))
            {
                MessageBox.Show("Please enter valid Price.", "EMPTY", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MenuIDCheck();

            }
            clearEverything();

        }
        public void MenuIDCheck()
        {
          
            Connect();
            SqlCommand c = new SqlCommand("insert into Menu(item_name,Category,price) values (@item_name,@Category, @price)", conn);
            c.Parameters.AddWithValue("@item_name", txtNameM.Text);
            c.Parameters.AddWithValue("@Category", txtCategoryM.Text);
            c.Parameters.AddWithValue("@price", txtPriceM.Text);
            
            c.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Record Inserted Successfully");
            cf.dataBind();

            clearEverything();
            this.Close();
}
        public void clearEverything()
        {
            txtCategoryM.Text = "";
           
            txtPriceM.Text = "";
            txtNameM.Text = "";
          
        }

        private void ClearM_Click(object sender, EventArgs e)
        {
            txtCategoryM.Text = "";
            txtPriceM.Text = "";
            txtNameM.Text = "";
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
