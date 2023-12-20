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
    public partial class janki : Form
    {
        public AddMennu addM;
        public UppMenu uppM;
        static string constr = "";
        static SqlConnection conn;
        int EmpId;
        public janki()
        {
            Connect();
            addM = new AddMennu(this);
            uppM = new UppMenu(this);
            InitializeComponent();

        }
        public void Connect()
        {
            constr = @"data source=JANKI\MSSQLSERVER04;database=DbIndianTaste;integrated security=true";
           // constr = @"data source=KHENI;database=DbIndianTaste;integrated security=true";
            //constr = @"data source=DESKTOP-7N3FNPL\SQL;database=DbIndianTaste;integrated security=true";
            conn = new SqlConnection(constr);
            conn.Open();
            Console.WriteLine("Connection open");

        }
        public void dataBind()
        {
            Connect();
            SqlDataAdapter sap = new SqlDataAdapter("select item_id, item_name, Category, price from Menu", conn);
            DataTable dt = new DataTable();
            sap.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        private void janki_Load(object sender, EventArgs e)
        {
            SqlDataAdapter cmd = new SqlDataAdapter("select item_id, item_name, Category, price from Menu", conn);
            DataTable dt = new DataTable();
            cmd.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnAddM_Click(object sender, EventArgs e)
        {
            addM.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (EmpId == 0)
            {
                MessageBox.Show("please select gridView to update data.");

            }
            else
            {

                uppM.Show();

            }
        }

        private void celClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = new DataGridViewRow();
            selectedRow = dataGridView1.Rows[index];
           // uppM.txtIDU.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            EmpId = Int32.Parse(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            uppM.txtNameU.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            uppM.txtCategoryU.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            uppM.txtPriceU.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void lblSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String compareValue = CombosearchMenu.SelectedItem.ToString();
            if (compareValue == "Name")
            {
                SqlDataAdapter cmd = new SqlDataAdapter("select item_id, item_name, Category, price from Menu where item_name= '" + txtSearchMenu.Text + "'", conn);

                DataTable dt = new DataTable();
                cmd.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (compareValue == "ID")
            {
                SqlDataAdapter cmd = new SqlDataAdapter("select  item_id,item_name, Category, price from Menu where item_id= '" + txtSearchMenu.Text + "'", conn);
                DataTable dt = new DataTable();
                cmd.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (compareValue == "Category")
            {
                SqlDataAdapter cmd = new SqlDataAdapter("select  item_id,item_name, Category, price from Menu where Category= '" + txtSearchMenu.Text + "'", conn);
                DataTable dt = new DataTable();
                cmd.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            else if (compareValue == "Price")
            {
                SqlDataAdapter cmd = new SqlDataAdapter("select  item_id,item_name, Category, price from Menu where price= '" + txtSearchMenu.Text + "'", conn);
                DataTable dt = new DataTable();
                cmd.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (compareValue == "All")
            {
                SqlDataAdapter cmd = new SqlDataAdapter("select  item_id,item_name, Category, price from Menu", conn);
                DataTable dt = new DataTable();
                cmd.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (EmpId > 0)
            {
                SqlCommand cmd = new SqlCommand("Delete from Menu where item_id= '" + EmpId + "'", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("deleted successfully.");
                dataBind();

            }
            else
            {
                MessageBox.Show("Please select gridview to delete data.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            ManagerHomePage emp = new ManagerHomePage();
            emp.Show();
        }
    }
}
