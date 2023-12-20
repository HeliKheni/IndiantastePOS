using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ResturantPOS
{
    
    public partial class AddEDetails : Form
    {
        Employee employee;
        static string constr = "";
        static SqlConnection conn;

        public AddEDetails(Employee employee)
        {
            Connect();
            InitializeComponent();
            this.employee = employee;
        }
        public void Connect()
        {
           constr = @"data source=JANKI\MSSQLSERVER04;database=DbIndianTaste;integrated security=true";
          // constr = @"data source=KHENI;database=DbIndianTaste;integrated security=true";
           // constr = @"data source=DESKTOP-7N3FNPL\SQL;database=DbIndianTaste;integrated security=true";
            conn = new SqlConnection(constr);
            conn.Open();
            Console.WriteLine("Connection open");

        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            string Pattern = @"[0-9]+";
            string phoneval = @"[0-9]{10}";
            string emailPattern = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
            string hoursePattern = @"[+-]?([0-9]*[.])?[0-9]+";
            Regex regex = new Regex(Pattern);
            Regex phoneregex = new Regex(phoneval);
            Regex emailregex = new Regex(emailPattern);
            Regex Hoursregex = new Regex(hoursePattern);
            if (txtId.Text == "" || txtName.Text == "" || txtHours.Text == "" || txtPhone.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("All Data are Required! .", "EMPTY", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!regex.IsMatch(txtId.Text))
            {
                MessageBox.Show("Id must be Digits only", "EMPTY", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (regex.IsMatch(txtName.Text))
            {
                MessageBox.Show("Name must be Letters only", "EMPTY", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!emailregex.IsMatch(txtEmail.Text))
            {
                MessageBox.Show("Please enter valid Email", "EMPTY", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!phoneregex.IsMatch(txtPhone.Text))
            {
                MessageBox.Show(" please enter valid phone number", "EMPTY", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            else if (!Hoursregex.IsMatch(txtHours.Text))
            {
                MessageBox.Show("Please enter valid hours.", "EMPTY", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                EmployeeIDCheck();
                
            }
           
        }
        public void EmployeeIDCheck()
        {
            Boolean flag = false;
            Connect();
            SqlCommand cmd = new SqlCommand("Select * from Employee ", conn);
           
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr[0].ToString()==txtId.Text)
                {
                    flag = true;
                    break;
                }

            }
            if(flag == true)
            {
                MessageBox.Show("already exist");
            }
            else
            {
                Connect();
                SqlCommand c = new SqlCommand("insert into Employee values('" + txtId.Text + "', '" + txtName.Text + "', '" + txtEmail.Text + "', '" + txtPhone.Text + "', '" + txtHours.Text + "')", conn);
                c.ExecuteNonQuery();
                MessageBox.Show("inserted successfully.");
                employee.dataBind();
                conn.Close();
                this.Close();
            }
            conn.Close();

            clearEverything();
        }
        public void clearEverything()
        {
            txtEmail.Text = "";
            txtHours.Text = "";
            txtName.Text = "";
            txtId.Text = "";
            txtPhone.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "";
            txtHours.Text = "";
            txtName.Text = "";
            txtId.Text = "";
            txtPhone.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
