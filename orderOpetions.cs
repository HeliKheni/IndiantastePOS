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
    public partial class orderOpetions : Form
    {
       
        public orderOpetions()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if(radDineIN.Checked == false || radTakeOut.Checked == false)
            {
                MessageBox.Show("Please select any option");
            }
            else if(radDineIN.Checked)
            {
                if(table == 0)
                {
                    MessageBox.Show("Please select Table");
                }
                else 
                {
                    MessageBox.Show("Table " + table + " is open");
                    Menu menupage = new Menu();
                    menupage.Tag = "Table: "+table;
                    menupage.Show();
                    this.Close();
                }
                
            }
        }
        int table;
        private void button1_Click(object sender, EventArgs e)
        {
            table = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            table = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            table = 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            table = 4;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            table = 5;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            table = 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            table = 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            table = 8;
        }

        private void radDineIN_CheckedChanged(object sender, EventArgs e)
        {
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;    
            button7.Visible = true;
            button8.Visible = true;

        }

        private void radTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
        }
    }
}
