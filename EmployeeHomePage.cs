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
    public partial class EmployeeHomePage : Form
    {
        
        public EmployeeHomePage()
        {
            InitializeComponent();
          
        }
        

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            welcome welcomepage = new welcome();
            welcomepage.Show();
            this.Hide();
           
        }

        private void btnDineIn_Click(object sender, EventArgs e)
        {
            Menu menupage = new Menu();
            this.Hide();
            menupage.Show();
        }

        private void btnOrderHistory_Click(object sender, EventArgs e)
        {

        }

        private void btnChangeMenu_Click(object sender, EventArgs e)
        {
            
        }
    }
}
