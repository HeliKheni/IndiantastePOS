using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ResturantPOS
{
    public partial class AllOrderHistory : Form
    {
        static string constr = "";
        static SqlConnection conn;

        public AllOrderHistory()
        {
            InitializeComponent();
            loadOrders();
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
        private void btnHome_Click(object sender, EventArgs e)
        {
            EmployeeHomePage m = new EmployeeHomePage();
            this.Close();
            m.Show();
        }
        public void loadOrders()
        {
            Connect();

            SqlCommand cmd;
            SqlDataReader drreader;
            String sql, output = "";
            DateTime now = DateTime.Now;
            sql = "select * from orders";
            cmd = new SqlCommand(sql, conn);
            drreader = cmd.ExecuteReader();
            int nu = 1;
            int x = 200;
            int y = 100;

            while (drreader.Read())
            {
                String orderid = drreader.GetValue(0).ToString();
                String datee = drreader.GetValue(1).ToString();
                String qty = drreader.GetValue(2).ToString();
                String TotalAmt = drreader.GetValue(3).ToString();
                String paidBy = drreader.GetValue(4).ToString();
                String type = drreader.GetValue(5).ToString();

                Panel dynamicPanel = new Panel();
                dynamicPanel.Location = new System.Drawing.Point(x, y);
                dynamicPanel.Name = orderid;
                dynamicPanel.Size = new System.Drawing.Size(500, 80);
                dynamicPanel.BackColor = Color.LightBlue;

                Label id = new Label();
                id.Text = "Bill: " + orderid;

                Label dat = new Label();
                dat.Location = new System.Drawing.Point(250, 1);
                dat.Text = "Date : " + datee;
                dat.Size = new System.Drawing.Size(250, 20);

                Label qtyl = new Label();
                qtyl.Text = "Qty : " + qty;
                qtyl.Location = new System.Drawing.Point(1, 20);
                qtyl.Size = new System.Drawing.Size(100, 20);

                Label al = new Label();
                al.Location = new System.Drawing.Point(250, 20);
                al.Text = "Total Amount : " + TotalAmt;
                al.Size = new System.Drawing.Size(250, 20);

                String[] arr = type.Split(",");
                 Label typel = new Label();
                typel.Location = new System.Drawing.Point(1, 40);
                if (arr.Length > 1)
                    typel.Text = arr[0] + ", " + arr[1];
                else
                    typel.Text = arr[0];
                typel.Size = new System.Drawing.Size(300, 20);

                Button dynamicButton = new Button();

                // Set Button properties
                dynamicButton.Location = new Point(370, 47);
                dynamicButton.Text = "View More";
                dynamicButton.Name = orderid;
                //dynamicButton.AutoSize = true;
                dynamicButton.Width = 120;
                dynamicButton.Height = 30;
                dynamicButton.BackColor = Color.HotPink;
                // Add a Button Click Event handler
                dynamicButton.Click += new EventHandler(dynamicButton_Click);
                // Add Button to the Form. Placement of the Button


                dynamicPanel.Controls.Add(id);
                dynamicPanel.Controls.Add(dat);
                dynamicPanel.Controls.Add(qtyl);
                dynamicPanel.Controls.Add(al);
                dynamicPanel.Controls.Add(typel);
                dynamicPanel.Controls.Add(dynamicButton);
                Controls.Add(dynamicPanel);
                y += 100;

            }
            conn.Close();
        }
        private void dynamicButton_Click(object sender, EventArgs e)
        {

            Button button = sender as Button;
            String id = button.Name;
            OrderItemsDisplay o = new OrderItemsDisplay(id);
            o.Show();
            this.Close();
        }
    }
}
