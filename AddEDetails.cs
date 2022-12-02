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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            //constr = @"data source=JANKI\MSSQLSERVER04;database=DbIndianTaste;integrated security=true";
            constr = @"data source=KHENI;database=DbIndianTaste;integrated security=true";

            conn = new SqlConnection(constr);
            conn.Open();
            Console.WriteLine("Connection open");

        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Employee values('" + txtId.Text + "', '" + txtName.Text + "', '" + txtEmail.Text + "', '"+  txtPhone.Text+  "', '" + txtHours.Text + "')", conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("inserted successfully.");
            
            employee.dataBind();
            //SqlDataAdapter sap = new SqlDataAdapter("select emp_id, emp_name, email, phone, hours from Employee", conn);
            //DataTable dt = new DataTable();
            //sap.Fill(dt);
            //employee.dataGridView1.DataSource = dt;
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
