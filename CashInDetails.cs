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
    public partial class CashInDetails : Form
    {
        private Form1 form1;
        public CashInDetails(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            form1.Show();
        }

        private void CashInDetails_Load(object sender, EventArgs e)
        {
            txtCash.Text = form1.total;
        }
    }
}