using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
        public UpdateEmployeeDetails uppE;
        static string constr = "";
        static SqlConnection conn;
        int EmpId;
        //SqlDataReader drreader;
        public Employee()
        {
            Connect();
            InitializeComponent();
            addE= new AddEDetails(this);
            uppE= new UpdateEmployeeDetails(this);
        }
        public void Connect()
        {
            constr = @"data source=JANKI\MSSQLSERVER04;database=DbIndianTaste;integrated security=true";
           //constr = @"data source=KHENI;database=DbIndianTaste;integrated security=true";
            //constr = @"data source=DESKTOP-7N3FNPL\SQL;database=DbIndianTaste;integrated security=true";
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

    

        private void button2_Click(object sender, EventArgs e)
        {
            if (EmpId == 0)
            {
                MessageBox.Show("please select gridView to update data.");

            }
            else
            {
               
                uppE.Show();

            }
        }

        private void cellClick(object sender, DataGridViewCellEventArgs e)
        {
           

            int index = e.RowIndex;
            DataGridViewRow selectedRow = new DataGridViewRow();
            selectedRow = dataGridView1.Rows[index];
            uppE.txtIdU.Text= this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            EmpId = Int32.Parse(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            uppE.txtNameU.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            uppE.txtEmailU.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            uppE.txtPhoneU.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            uppE.txtHoursU.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(EmpId>0)
            {
                SqlCommand cmd = new SqlCommand("Delete from Employee where emp_id= '" + EmpId + "'", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("deleted successfully.");
                dataBind();

            }
            else
            {
                MessageBox.Show("Please select gridview to delete data.");
            }
            
        }
        public void dataBind()
        {
            Connect();
            SqlDataAdapter sap = new SqlDataAdapter("select emp_id, emp_name, email, phone, hours from Employee", conn);
            DataTable dt = new DataTable();
            sap.Fill(dt);
            dataGridView1.DataSource = dt;
            
        }

     
        private void button3_Click(object sender, EventArgs e)
        {
          
                String compareValue = Combosearch.SelectedItem.ToString();
            if (compareValue == "Name")
            {
                SqlDataAdapter cmd = new SqlDataAdapter("select  emp_id, emp_name, email, phone, hours from Employee where emp_name= '" + txtSearch.Text + "'", conn);

                DataTable dt = new DataTable();
                cmd.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (compareValue == "ID")
            {
                SqlDataAdapter cmd = new SqlDataAdapter("select  emp_id, emp_name, email, phone, hours from Employee where emp_id= '" + txtSearch.Text + "'", conn);
                DataTable dt = new DataTable();
                cmd.Fill(dt);
                dataGridView1.DataSource = dt;
                }
            else if (compareValue == "Email")
            {
                SqlDataAdapter cmd = new SqlDataAdapter("select  emp_id, emp_name, email, phone, hours from Employee where email= '" + txtSearch.Text + "'", conn);
                DataTable dt = new DataTable();
                cmd.Fill(dt);
                dataGridView1.DataSource = dt;
             
                }
            else if (compareValue == "Phone")
            {
                SqlDataAdapter cmd = new SqlDataAdapter("select  emp_id, emp_name, email, phone, hours from Employee where phone= '" + txtSearch.Text + "'", conn);
                DataTable dt = new DataTable();
                cmd.Fill(dt);
                dataGridView1.DataSource = dt;
                }
            else if (compareValue == "Hours")
            {
                SqlDataAdapter cmd = new SqlDataAdapter("select  emp_id, emp_name, email, phone, hours from Employee where hours= '" + txtSearch.Text + "'", conn);
                DataTable dt = new DataTable();
                cmd.Fill(dt);
                dataGridView1.DataSource = dt;
                }
            else if (compareValue == "All")
            {
                SqlDataAdapter cmd = new SqlDataAdapter("select  emp_id, emp_name, email, phone, hours from Employee ", conn);
                DataTable dt = new DataTable();
                cmd.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            ManagerHomePage emp = new ManagerHomePage();
            emp.Show();
        }

       
    }
    }

