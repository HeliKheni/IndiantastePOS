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
        public orderOpetions orderOpetions;
        public String data = "";
        public List<String> item_names = new List<String>();
        public Menu(orderOpetions op,String data)
        {
            InitializeComponent();
            orderOpetions = new orderOpetions();
            //listBox1.Items.Add(orderOpetions.Tag);
            this.data = data;
            //listBox1.Items.Add(data);
            foreach(String d in data.Split(','))
            {
                listBox1.Items.Add(d);
            };
            listBox1.Items.Add("-------------------");
        }
        

        private void btnHome_Click(object sender, EventArgs e)

        {
            
            this.Hide();
            orderOpetions.Show();
        }
        public void Connect()
        {
            //constr = @"data source=JANKI\MSSQLSERVER04;database=DbIndianTaste;integrated security=true";
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
        decimal finalprice;
        private void dynamicButton_Click(object sender, EventArgs e)
        {
           // string tr = this.Tag.ToString();
            
            //listBox1.Items.Add(tr);

            listBox2.Items.Clear();
            Button button = sender as Button;
            
            Connect();
            SqlCommand cmd2;
            SqlDataReader drreader2;
            String sql2, output = "";
            sql2 = "select Price from Menu where item_name='" + button.Text + "'";
            cmd2 = new SqlCommand(sql2, conn);
            drreader2 = cmd2.ExecuteReader();

            item_names.Add(button.Text);

            while (drreader2.Read())
            {
                price += Convert.ToDecimal(drreader2.GetValue(0).ToString());
                listBox1.Items.Add(button.Text + " - " + drreader2.GetValue(0).ToString());
                qty++;
               
                listBox2.Items.Add("Total: " + price +"$");
                listBox2.Items.Add("Qty: " + qty);
                decimal tax= ((price * 13) / 100);
                finalprice = price + tax;
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

        private void Menu_Load(object sender, EventArgs e)
        {

           
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void btnCan_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void btnDebit_Click(object sender, EventArgs e)
        {
            addOrderData("Debit");
        }
        private void btnCredit_Click(object sender, EventArgs e)
        {
            addOrderData("Credit");
        }
        private void btnCash_Click(object sender, EventArgs e)
        {
            addOrderData("Cash");
        }
        public void addOrderData(String type)
        {
            //Adding data in Order table
            Connect();
            SqlCommand cmd2 = new SqlCommand("INSERT orders "
            + "(Qty,TotalAmt,paidBy,orderType) " + "VALUES (@qty,@totalamt,@paidby,@type)", conn);
            cmd2.Parameters.AddWithValue("qty", qty);
            cmd2.Parameters.AddWithValue("totalamt", finalprice);
            cmd2.Parameters.AddWithValue("paidby", type);
            cmd2.Parameters.AddWithValue("type", data);
            cmd2.ExecuteNonQuery();
            MessageBox.Show("Order data added Sucessfully");
            conn.Close();

            //Getting Orderid of last added record in order table
            Connect();
            int orderid;
            String sql3 = "select @@identity";
            SqlCommand cmd3 = new SqlCommand(sql3, conn);
            SqlDataReader drreader3 = cmd3.ExecuteReader();
            while (drreader3.Read())
            {
                orderid = Convert.ToInt32(drreader3.GetValue(0).ToString());
            }
            conn.Close();

            //Adding data in orderItem table
            SqlCommand cmd4 = new SqlCommand("INSERT orders "
            + "(Qty,TotalAmt,paidBy,orderType) " + "VALUES (@qty,@totalamt,@paidby,@type)", conn);
            cmd3.Parameters.AddWithValue("qty", qty);
            cmd3.Parameters.AddWithValue("totalamt", finalprice);
            cmd3.Parameters.AddWithValue("paidby", type);
            cmd3.Parameters.AddWithValue("type", data);
            cmd3.ExecuteNonQuery();
            MessageBox.Show("Order data added Sucessfully");
            conn.Close();

        }
        
    }
}
