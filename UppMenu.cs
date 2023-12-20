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
    public partial class UppMenu : Form
    {
        janki cf;
        static string constr = "";
        static SqlConnection conn;
        public UppMenu(janki cf)
        {
            Connect();
            InitializeComponent();
            this.cf = cf;
        }
        public void Connect()
        {
            constr = @"data source=JANKI\MSSQLSERVER04;database=DbIndianTaste;integrated security=true";
          //  constr = @"data source=KHENI;database=DbIndianTaste;integrated security=true";
            // constr = @"data source=DESKTOP-7N3FNPL\SQL;database=DbIndianTaste;integrated security=true";
            conn = new SqlConnection(constr);
            conn.Open();
            Console.WriteLine("Connection open");

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
       
        private void btnUpdateU_Click(object sender, EventArgs e)
        {
            string Pattern = @"[0-9]+";
            string PricePattern = @"[+-]?([0-9]*[.])?[0-9]+";
            Regex regex = new Regex(Pattern);
            Regex Priceregex = new Regex(PricePattern);
            if ( txtNameU.Text == "" || txtCategoryU.Text == "" || txtPriceU.Text == "")
            {
                MessageBox.Show("textbox must be filled.", "EMPTY", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            else if (regex.IsMatch(txtNameU.Text))
            {
                MessageBox.Show("Name must be Letters only", "EMPTY", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (regex.IsMatch(txtCategoryU.Text))
            {
                MessageBox.Show("Please enter valid Category Name", "EMPTY", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            else if (!Priceregex.IsMatch(txtPriceU.Text))
            {
                MessageBox.Show("Please enter valid Price.", "EMPTY", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Connect();
              
                SqlCommand cmd = new SqlCommand("update Menu set item_name='" + txtNameU.Text + "',Category= '" + txtCategoryU.Text + "',price= '" + txtPriceU.Text + "' where item_name='" + txtNameU.Text + "'", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Updated Successfully.");
                this.Close();
                cf.dataBind();
                clearEverything();

            }
        }
        public void clearEverything()
        {
            txtCategoryU.Text = "";
            txtPriceU.Text = "";
            txtNameU.Text = "";
           

        }

        private void ClearU_Click(object sender, EventArgs e)
        {
            txtCategoryU.Text = "";
            txtPriceU.Text = "";
            txtNameU.Text = "";
           

        }

        private void CancelU_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
