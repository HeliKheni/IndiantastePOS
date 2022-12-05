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
    public partial class ManagerHomePage : Form
    {
        private welcome welcome;
        private Form1 cashIn;
        private cashOut cashOut;
        public ManagerHomePage(welcome welcome)
        {
            InitializeComponent();
            this.welcome = welcome;
            cashIn = new Form1(this);
            cashOut = new cashOut(this);
        }

        private void Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            welcome.Show();
        }

        private void btnCashIn_Click(object sender, EventArgs e)
        {
           this.Hide();
            cashIn.Show();
        }

        private void btncashout_Click(object sender, EventArgs e)
        {

            this.Hide();
            cashOut.Show();
        }
    }
}
