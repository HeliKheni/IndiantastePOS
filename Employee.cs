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
    public partial class Employee : Form
    {
        public AddEDetails addE;
        public Employee()
        {
            InitializeComponent();
            addE= new AddEDetails();    
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            this.Hide();
            addE.Show();

        }
    }
}
