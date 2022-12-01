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
            conn = new SqlConnection(constr);
            conn.Open();
            Console.WriteLine("Connection open");

        }
        private void UpdateEmployeeDetails_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdateEmp_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update Employee set emp_name='" + txtNameU.Text + "',email= '" + txtEmailU.Text+ "',phone= '" + txtPhoneU.Text+ "',hours= '" + txtHoursU.Text + "' where emp_id='" + txtIdU.Text + "'", conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Updated Successfully.");
            employee.dataBind();    
            //SqlDataAdapter sap = new SqlDataAdapter("select emp_id, emp_name, email, phone, hours from Employee", conn);
            //DataTable dt = new DataTable();
            //sap.Fill(dt);
            //employee.dataGridView1.DataSource = dt;
        }
    }
}
