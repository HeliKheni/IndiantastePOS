using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ResturantPOS
{
    public partial class Employee : Form
    {
        public AddEDetails addE;
        static string constr = "";
        static SqlConnection conn;
        SqlDataReader drreader;
        public Employee()
        {
            Connect();
            InitializeComponent();
            addE= new AddEDetails(this);    
        }
        public void Connect()
        {
            constr = @"data source=JANKI\MSSQLSERVER04;database=DbIndianTaste;integrated security=true";
            conn = new SqlConnection(constr);
            conn.Open();
            Console.WriteLine("Connection open");

        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            addE.Show();

        }

        private void Employee_Load(object sender, EventArgs e)
        {
            SqlDataAdapter cmd = new SqlDataAdapter("select emp_id, emp_name, email, phone, hours from Employee", conn);
            DataTable dt = new DataTable();
            cmd.Fill(dt);
            dataGridView1.DataSource = dt;
           

        }
    }
}
