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
        public welcome()
        {
            InitializeComponent();
            cashOut = new cashOut();
            cashIn = new Form1();
            menu = new Menu();
            form2= new Form2();
            form2= new Form2();

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
    }
}
