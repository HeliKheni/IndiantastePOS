using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResturantPOS
{
    public partial class Menu : Form
    {
        static string constr = "";
        static SqlConnection conn;
        public  int qty = 0;
        public decimal price = 0;
        public Menu()
        {
            InitializeComponent();
        }
        

        private void btnHome_Click(object sender, EventArgs e)
        {
            EmployeeHomePage emp = new EmployeeHomePage();
            this.Hide();
            emp.Show();
        }
        public void Connect()
        {
            constr = @"data source=KHENI;database=DbIndianTaste;integrated security=true";
            conn = new SqlConnection(constr);
            conn.Open();
            Console.WriteLine("Connection open");

        }
        private void btnApptizer_Click(object sender, EventArgs e)
        {
            Connect();
            selectByType("Appetizer");
        }
        public void selectByType(String type)
        {
           panel1.Controls.Clear();
           
            String menutype = type;
            SqlCommand cmd;
            SqlDataReader drreader;
            String sql, output = "";
            sql = "select item_name from Menu where Category='" + menutype+"'";
            cmd = new SqlCommand(sql, conn);

            int sizex = 15;
            int sizey = 30;
            drreader = cmd.ExecuteReader();
            int nu = 1;
            while (drreader.Read())
            {
                String item_name = drreader.GetValue(0).ToString();
                //MessageBox.Show(drreader.GetValue(0).ToString());
                Button dynamicButton = new Button();

                // Set Button properties
                dynamicButton.Location = new Point(sizex, sizey);
                dynamicButton.Text = item_name;
                dynamicButton.Name = item_name;
                //dynamicButton.AutoSize = true;
                dynamicButton.Width = 150;
                dynamicButton.Height = 40;

                // Add a Button Click Event handler
                dynamicButton.Click += new EventHandler(dynamicButton_Click);

                // Add Button to the Form. Placement of the Button
               panel1.Controls.Add(dynamicButton);
                
                if (nu % 3 == 0)
                {
                    sizey += 70;
                    sizex = 15;
                }
                else
                    sizex += 160;
                nu++;
            }
            Console.Write(output);
            Console.ReadLine();

            conn.Close();
        }
        private void dynamicButton_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            Button button = sender as Button;
            
            Connect();
            SqlCommand cmd2;
            SqlDataReader drreader2;
            String sql2, output = "";
            sql2 = "select Price from Menu where item_name='" + button.Text + "'";
            cmd2 = new SqlCommand(sql2, conn);
            drreader2 = cmd2.ExecuteReader();
            while (drreader2.Read())
            {
                price += Convert.ToDecimal(drreader2.GetValue(0).ToString());
                listBox1.Items.Add(button.Text + " - " + drreader2.GetValue(0).ToString());
                qty++;
               
                listBox2.Items.Add("Total: " + price +"$");
                listBox2.Items.Add("Qty: " + qty);
                decimal tax= ((price * 13) / 100);
                decimal finalprice = price + tax;
                listBox2.Items.Add("Tax: " + tax +"$");
                listBox2.Items.Add("Final Amount: " + finalprice+"$");
            }

        }

        private void btnVeg_Click(object sender, EventArgs e)
        {
            Connect();
            selectByType("Vegetarian");
        }

        private void btnNonveg_Click(object sender, EventArgs e)
        {
            Connect();
            selectByType("Meat");
        }

        private void btnBread_Click(object sender, EventArgs e)
        {
            Connect();
            selectByType("Bread");
        }

        private void btnDessert_Click(object sender, EventArgs e)
        {
            Connect();
            selectByType("Dessert");
        }
    }
}
