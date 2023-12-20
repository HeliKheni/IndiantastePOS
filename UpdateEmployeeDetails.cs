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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ResturantPOS
{
    public partial class UpdateEmployeeDetails : Form
    {
        Employee employee;
        static string constr = "";
        static SqlConnection conn;
        public UpdateEmployeeDetails(Employee employee)
        {
            Connect();
            InitializeComponent();
            this.employee = employee;
        }
        public void Connect()
        {
           constr = @"data source=JANKI\MSSQLSERVER04;database=DbIndianTaste;integrated security=true";
            //constr = @"data source=KHENI;database=DbIndianTaste;integrated security=true";
            // constr = @"data source=DESKTOP-7N3FNPL\SQL;database=DbIndianTaste;integrated security=true";
            conn = new SqlConnection(constr);
            conn.Open();
            Console.WriteLine("Connection open");

        }
        private void UpdateEmployeeDetails_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdateEmp_Click(object sender, EventArgs e)
        {

            string Pattern = @"[0-9]+";
            string phoneval = @"[0-9]{10}";
            string emailPattern = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
            string hoursePattern = @"[+-]?([0-9]*[.])?[0-9]+";
            Regex regex = new Regex(Pattern);
            Regex phoneregex = new Regex(phoneval);
            Regex emailregex = new Regex(emailPattern);
            Regex Hoursregex = new Regex(hoursePattern);
            if (txtIdU.Text == "" || txtNameU.Text == "" || txtHoursU.Text == "" || txtPhoneU.Text == "" || txtEmailU.Text == "")
            {
                MessageBox.Show("textbox must be filled.", "EMPTY", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!regex.IsMatch(txtIdU.Text))
            {
                MessageBox.Show("Id must be Digits only", "EMPTY", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (regex.IsMatch(txtNameU.Text))
            {
                MessageBox.Show("Name must be Letters only", "EMPTY", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!emailregex.IsMatch(txtEmailU.Text))
            {
                MessageBox.Show("Please enter valid Email", "EMPTY", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!phoneregex.IsMatch(txtPhoneU.Text))
            {
                MessageBox.Show(" please enter valid phone number", "EMPTY", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (!Hoursregex.IsMatch(txtHoursU.Text))
            {
                MessageBox.Show("Please enter valid hours.", "EMPTY", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Connect();
                SqlCommand cmd = new SqlCommand("update Employee set emp_name='" + txtNameU.Text + "',email= '" + txtEmailU.Text + "',phone= '" + txtPhoneU.Text + "',hours= '" + txtHoursU.Text + "' where emp_id='" + txtIdU.Text + "'", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Updated Successfully.");
                this.Close();
                employee.dataBind();
                clearEverything();
              
            }

        }
        public void clearEverything()
        {
            txtEmailU.Text = "";
            txtHoursU.Text = "";
            txtNameU.Text = "";
            txtIdU.Text = "";
            txtPhoneU.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtEmailU.Text = "";
            txtHoursU.Text = "";
            txtNameU.Text = "";
            txtIdU.Text = "";
            txtPhoneU.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
