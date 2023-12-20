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
        public List<int> item_id = new List<int>();
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
            constr = @"data source=JANKI\MSSQLSERVER04;database=DbIndianTaste;integrated security=true";
            //constr = @"data source=KHENI;database=DbIndianTaste;integrated security=true";
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
           pael1.Controls.Clear();
           
            String menutype = type;
            SqlCommand cmd;
            SqlDataReader drreader;
            String sql, output = "";
            sql = "select * from Menu where Category='" + menutype+"'";
            cmd = new SqlCommand(sql, conn);

            int sizex = 15; 
            int sizey = 30;
            drreader = cmd.ExecuteReader();
            int nu = 1;
            while (drreader.Read())
            {
                String item_name = drreader.GetValue(1).ToString();
                int item_id = Convert.ToInt32(drreader.GetValue(0).ToString());
                //MessageBox.Show(drreader.GetValue(0).ToString());
                Button dynamicButton = new Button();

                // Set Button properties
                dynamicButton.Location = new Point(sizex, sizey);
                dynamicButton.Text = item_name;
                dynamicButton.Name = item_id.ToString();
                //dynamicButton.AutoSize = true;
                dynamicButton.Width = 150;
                dynamicButton.Height = 40;
                dynamicButton.BackColor = Color.PaleGreen;

                // Add a Button Click Event handler
                dynamicButton.Click += new EventHandler(dynamicButton_Click);

                // Add Button to the Form. Placement of the Button
               pael1.Controls.Add(dynamicButton);
                
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
           
            listBox2.Items.Clear();
            Button button = sender as Button;
            
            Connect();
            SqlCommand cmd2;
            SqlDataReader drreader2;
            String sql2, output = "";
            sql2 = "select Price from Menu where item_id='" + Convert.ToInt32(button.Name) + "'";
            cmd2 = new SqlCommand(sql2, conn);
            drreader2 = cmd2.ExecuteReader();

            item_id.Add(Convert.ToInt32(button.Name));
            decimal totalp = 0;
            while (drreader2.Read())
            {
                price += Convert.ToDecimal(drreader2.GetValue(0).ToString());
                listBox1.Items.Add(button.Text + " - " + drreader2.GetValue(0).ToString());
                qty++;
                
            }
            listBox2.Items.Add("Total: " + price + "$");
            listBox2.Items.Add("Qty: " + qty);
            decimal tax = ((price * 13) / 100);
            finalprice = price + tax;
            listBox2.Items.Add("Tax: " + tax + "$");
            listBox2.Items.Add("Final Amount: " + finalprice + "$");
           
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
            if (item_id.Count == 0) {
                MessageBox.Show("Please Enter item first");
            }
            else
            {
                panelPay.Visible = true;
                panelMenuOpetions.Visible = false;
                //panelDownButton.Visible = false;
                pael1.Visible = false;
            }
          
            //panel4.Visible = false;
          
        }

        private void btnCan_Click(object sender, EventArgs e)
        {
            panelPay.Visible = false;
            panelMenuOpetions.Visible = true;
           // panelDownButton.Visible = true;
            pael1.Visible = true;
        }

        private void btnDebit_Click(object sender, EventArgs e)
        {
            addOrderData("Debit");
            panelPay.Visible = false;
            orderOpetions op=new orderOpetions();
            this.Close();
            op.Show();
        }
        private void btnCredit_Click(object sender, EventArgs e)
        {
            addOrderData("Credit");
            panelPay.Visible = false;
            orderOpetions op = new orderOpetions();
            this.Close();
            op.Show();
        }
        private void btnCash_Click(object sender, EventArgs e)
        {
            addOrderData("Cash");
            panelPay.Visible = false;
            orderOpetions op = new orderOpetions();
            this.Close();
            op.Show();
        }
        public void addOrderData(String type)
        {
            String t = type;
            //Adding data in Order table
            Connect();
            SqlCommand cmd2 = new SqlCommand("INSERT orders "
            + "(Qty,TotalAmt,paidBy,orderType) " + "VALUES (@qty,@totalamt,@paidby,@type)", conn);
            cmd2.Parameters.AddWithValue("qty", qty);
            cmd2.Parameters.AddWithValue("totalamt", finalprice);
            cmd2.Parameters.AddWithValue("paidby", t);
            cmd2.Parameters.AddWithValue("type", data);
            cmd2.ExecuteNonQuery();
            MessageBox.Show("Order data added Sucessfully");
            conn.Close();

            //Getting Orderid of last added record in order table
            Connect();
            int orderid=0;
            String sql3 = "select max(OrderId) from orders";
            SqlCommand cmd3 = new SqlCommand(sql3, conn);
            SqlDataReader drreader3 = cmd3.ExecuteReader();
            while (drreader3.Read())
            {
                orderid = Convert.ToInt32(drreader3.GetValue(0).ToString());
            }
            conn.Close();

            //Adding data in orderItem table
            foreach(int it in item_id)
            {
                Connect();
                SqlCommand cmd4 = new SqlCommand("INSERT orderItems "
           + "(itemId, OrderId) " + "VALUES (@itemId, @orderId)", conn);
                cmd4.Parameters.AddWithValue("itemId", it);
                cmd4.Parameters.AddWithValue("orderId", orderid);
                cmd4.ExecuteNonQuery();
              
                conn.Close();
            }
           

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            item_id.Clear();
            qty = 0;
            price = 0;
        }

        private void btnVoid_Click(object sender, EventArgs e)
        {
            //panel4.Visible = true;
            /* */
            panelVoid.Visible = true;
            listBox3.Items.Clear();
            disItemName();
        }

        int q = 0;
        decimal p = 0;
        public void disItemName()
        {
            p = 0;
            q = 0;
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            foreach (String d in data.Split(','))
            {
                listBox1.Items.Add(d);
            };
            listBox1.Items.Add("-------------------");
            foreach (int it in item_id)
            {
                Connect();
                String sql2 = "select * from Menu where item_id=" + it;
                SqlCommand cmd2 = new SqlCommand(sql2, conn);
                SqlDataReader drreader2 = cmd2.ExecuteReader();
               
                while (drreader2.Read())
                {
                    listBox3.Items.Add(drreader2.GetValue(1).ToString() + " - " + drreader2.GetValue(3).ToString());
                    listBox1.Items.Add(drreader2.GetValue(1).ToString() + " - " + drreader2.GetValue(3).ToString());
                    q = item_id.Count();
                    p = p + Convert.ToDecimal(drreader2.GetValue(3).ToString());
                }
              
            }
            listBox2.Items.Add("Total: " + p + "$");
            listBox2.Items.Add("Qty: " + q);
            decimal tax = ((p * 13) / 100);
            finalprice = p + tax;
            listBox2.Items.Add("Tax: " + tax + "$");
            listBox2.Items.Add("Final Amount: " + finalprice + "$");
            conn.Close();


        }
        private void btnClearAll_Click(object sender, EventArgs e)
        {

        }


        private void btnVoidItem_Click_1(object sender, EventArgs e)
        {

            String item = listBox3.SelectedItem.ToString();
            String[] iname = item.Split("-");
            Connect();

            String sql2 = "select item_id from Menu where item_name='" + iname[0] + "'";
            SqlCommand cmd2 = new SqlCommand(sql2, conn);
            SqlDataReader drreader2 = cmd2.ExecuteReader();
            int c = 0; 
            List<int> ir = new List<int>();
            foreach(int im in item_id)
            {
                ir.Add(im);
            }
          
            
            while(drreader2.Read())
            {
                foreach (int i in ir)
                {
                    c = Convert.ToInt32(drreader2.GetValue(0).ToString());
                    if (i == c)
                    {
                        item_id.Remove(c);
                    }
                }
            }
            listBox3.Items.Clear();
            disItemName();
        }

        private void btnVoidAll_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
           
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            item_id.Clear();
            qty = 0;
            price = 0;
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            panelVoid.Visible = false;
            disItemName();
        }

        private void btnVoid_Click_1(object sender, EventArgs e)
        {
            panelVoid.Visible = true;
            listBox3.Items.Clear();
            disItemName();
        }
    }
}
