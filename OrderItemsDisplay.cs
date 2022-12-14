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

namespace ResturantPOS
{
    public partial class OrderItemsDisplay : Form
    {
        static string constr = "";
        static SqlConnection conn;
        public OrderItemsDisplay(String i)
        {
            InitializeComponent();
            displayitems(i);
        }
        public void Connect()
        {
            //  constr = @"data source=JANKI\MSSQLSERVER04;database=DbIndianTaste;integrated security=true";
            constr = @"data source=KHENI;database=DbIndianTaste;integrated security=true";
            // constr = @"data source=DESKTOP-7N3FNPL\SQL;database=DbIndianTaste;integrated security=true";
            conn = new SqlConnection(constr);
            conn.Open();
            Console.WriteLine("Connection open");

        }
        public void displayitems(String i)
        {
            Connect();

            SqlCommand cmd;
            SqlDataReader drreader;
            String sql = "";

            sql = "select * from OrderItems where OrderId = " + i;
            cmd = new SqlCommand(sql, conn);
            drreader = cmd.ExecuteReader();
            int nu = 1;
            int x = 200;
            int y = 200;

            Label da = new Label();
            da.Location = new System.Drawing.Point(x, y-30);
            da.Text = "Item ID";
            da.Size = new System.Drawing.Size(100, 30);
            da.BackColor = System.Drawing.Color.Khaki;
            da.Font = new Font("Arial", 14);

            Label da2 = new Label();
            da2.Location = new System.Drawing.Point(x + 150, y - 30);
            da2.Text = "Item Name";
            da2.Size = new System.Drawing.Size(150, 30);
            da2.BackColor = System.Drawing.Color.Khaki;
            da2.Font = new Font("Arial", 12);
            

            Label da3 = new Label();
            da3.Location = new System.Drawing.Point(x+400, y -30);
            da3.Text = "Item Price";
            da3.Size = new System.Drawing.Size(150, 30);
            da3.BackColor = System.Drawing.Color.Khaki;
            da3.Font = new Font("Arial", 12);
            Controls.Add(da);
            Controls.Add(da2);
            Controls.Add(da3);

            while (drreader.Read())
            {
                String itemid = drreader.GetValue(1).ToString();
                Label dat = new Label();
                dat.Location = new System.Drawing.Point(x, y);
                dat.Text = itemid;
                dat.Size = new System.Drawing.Size(100, 35);
              
                Controls.Add(dat);

                constr = @"data source=KHENI;database=DbIndianTaste;integrated security=true";
                // constr = @"data source=DESKTOP-7N3FNPL\SQL;database=DbIndianTaste;integrated security=true";
                SqlConnection conn2 = new SqlConnection(constr);
                conn2.Open();
                SqlCommand cmd2;
                SqlDataReader drreader2;
                String sql2 = "";
                sql2 = "select * from Menu where Item_id= " + itemid;
                cmd2 = new SqlCommand(sql2, conn2);
                Controls.Add(dat);
                drreader2 = cmd2.ExecuteReader();
                while (drreader2.Read())
                {
                    
                    String itemname = drreader2.GetValue(1).ToString();
                    String price = drreader2.GetValue(3).ToString();

                    Label dat2 = new Label();
                    dat2.Location = new System.Drawing.Point(x + 150, y);
                    dat2.Text = " " + itemname;
                    dat2.Size = new System.Drawing.Size(200, 35);

                    Label dat3 = new Label();
                    dat3.Location = new System.Drawing.Point(x + 400, y);
                    dat3.Text = " " + price;
                    dat3.Size = new System.Drawing.Size(100, 35);
                    Controls.Add(dat2);
                    Controls.Add(dat3);
                }
                conn2.Close(); 
               

                y += 30;
            }
        }
        private void btnback_Click(object sender, EventArgs e)
        {
            AllOrderHistory o = new AllOrderHistory();
            o.Show();
            this.Close();
        }
    }
}
