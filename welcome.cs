using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResturantPOS
{
    public partial class welcome : Form
    {
        public cashOut cashOut;
        public Form1 cashIn;
        public Menu menu;
        public Form2 form2;
        public AdminHomePage adminHomePage;
       
        public string pass = "";
        public welcome()
        {
            InitializeComponent();
            cashOut = new cashOut();
            cashIn = new Form1();
            menu = new Menu();
            form2= new Form2();
            form2= new Form2();
            adminHomePage = new AdminHomePage();
           
            pass = "";

        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            this.Hide();
            cashOut.Show();
        }

        private void btnCashin_Click(object sender, EventArgs e)
        {
            this.Hide();
            cashIn.Show();
        }

        private void btnDine_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu.Show();
        }

        private void btnEmp_Click(object sender, EventArgs e)
        {
            this.Hide();
            form2.Show();
        }

        private void btnNum1_Click(object sender, EventArgs e)
        {
            pass = pass + "1";
            txtNumInput.Text = pass;
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            pass = pass + "2";
            txtNumInput.Text = pass;
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            pass = pass + "3";
            txtNumInput.Text = pass;
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            pass = pass + "4";
            txtNumInput.Text = pass;
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            pass = pass + "5";
            txtNumInput.Text = pass;
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            pass = pass + "6";
            txtNumInput.Text = pass;
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            pass = pass + "7";
            txtNumInput.Text = pass;
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            pass = pass + "8";
            txtNumInput.Text = pass;
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            pass = pass + "9";
            txtNumInput.Text = pass;
        }

        private void btnNumC_Click(object sender, EventArgs e)
        {
            pass = "";
            txtNumInput.Text = pass;
        }

        private void btnNumOK_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
           if (!radAdmin.Checked && !radManager.Checked && !radEmployee.Checked)
            {
                MessageBox.Show("Please Select Any Option. You are login As ?");
            }
            else if (radAdmin.Checked && pass == "1234")
            {
                MessageBox.Show(pass + " Admin Password Match");
                this.Hide();
                adminHomePage.Show();
            }
            else if (radManager.Checked && pass == "2345")
            {
                MessageBox.Show(pass + " Manager Password Match");
                this.Hide();
                cashOut.Show();
            }
            else if (radEmployee.Checked && pass == "3456")
            {
               MessageBox.Show(pass + " Employee Password Match");
                EmployeeHomePage emphome=new EmployeeHomePage();
                emphome.Show();
                this.Hide();
               
            }
            else
            {
                MessageBox.Show("Password doesn't Match");
            }
        }
    }
}
