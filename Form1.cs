namespace ResturantPOS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnTotalCash_Click(object sender, EventArgs e)
        {
           
                decimal totalCash = 0;
                decimal D100 = Convert.ToDecimal(txt100.Text);
                decimal D50 = Convert.ToDecimal(txt50.Text);
                decimal D20 = Convert.ToDecimal(txt20.Text);
                decimal D10 = Convert.ToDecimal(txt10.Text);
                decimal D5 = Convert.ToDecimal(txt5.Text);
                decimal D2 = Convert.ToDecimal(txt2.Text);
                decimal D1 = Convert.ToDecimal(txt1.Text);
                decimal Cent25 = Convert.ToDecimal(txt25cent.Text);
                decimal Cent10 = Convert.ToDecimal(txt10cent.Text);
                decimal Cent5 = Convert.ToDecimal(txt5cent.Text);

                if (IsNull(txt100) && IsDecimal(txt100) && IsWithinRange(txt100, 0, 10000))
                {
               
                D100 = D100 * 100;
                }
                 if (IsNull(txt50) && IsDecimal(txt50) && IsWithinRange(txt50, 0, 10000))
                {
                    D50 = D50 * 50;
                }
                 if (IsNull(txt20) && IsDecimal(txt20) && IsWithinRange(txt20, 0, 10000))
                {
                    D20 = D20 * 20;
                }
                 if (IsNull(txt10) && IsDecimal(txt10) && IsWithinRange(txt10, 0, 10000))
                {
                    D10 = D10 * 10;
                }

                 if (IsNull(txt5) && IsDecimal(txt5) && IsWithinRange(txt5, 0, 10000))
                {
                    D5 = D5 * 5;
                }
                 if (IsNull(txt2) && IsDecimal(txt2) && IsWithinRange(txt2, 0, 10000))
                {
                    D2 = D2 * 2;
                }
                 if (IsNull(txt1) && IsDecimal(txt1) && IsWithinRange(txt1, 0, 10000))
                {
                    D1 = D1 * 1;
                }
                if (IsNull(txt25cent) && IsDecimal(txt25cent) && IsWithinRange(txt25cent, 0, 10000))
                {
                    Cent25 = Cent25 * .25m;
                }
                 if (IsNull(txt10cent) && IsDecimal(txt10cent) && IsWithinRange(txt10cent, 0, 10000))
                {
                    Cent10 = Cent10 * .10m;
                }
                if (IsNull(txt5cent) && IsDecimal(txt5cent) && IsWithinRange(txt5cent, 0, 10000))
                {
                    Cent5 = Cent5 * .5m;
                }
                totalCash = D100 + D20 + D50 + D10 + D5 + D1 + D2
                         + Cent25 + Cent10 + Cent5;
                txtToalCashIn.Text = totalCash.ToString("c2");

            
            
        }

        private void txt100_TextChanged(object sender, EventArgs e)
        {
            txtToalCashIn.Clear();
        }

        private void txt50_TextChanged(object sender, EventArgs e)
        {
            txtToalCashIn.Clear();
        }

        private void txt20_TextChanged(object sender, EventArgs e)
        {
            txtToalCashIn.Clear();
        }

        private void txt10_TextChanged(object sender, EventArgs e)
        {
            txtToalCashIn.Clear();
        }

        private void txt5_TextChanged(object sender, EventArgs e)
        {
            txtToalCashIn.Clear();
        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {
            txtToalCashIn.Clear();
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {
            txtToalCashIn.Clear();
        }

        private void txt25cent_TextChanged(object sender, EventArgs e)
        {
            txtToalCashIn.Clear();
        }

        private void txt10cent_TextChanged(object sender, EventArgs e)
        {
            txtToalCashIn.Clear();
        }

        private void label10_TextChanged(object sender, EventArgs e)
        {
            txtToalCashIn.Clear();
        }
        private bool IsDecimal(TextBox textBox)
        {
            decimal num = 0m;
            if (Decimal.TryParse(textBox.Text, out num))
                return true;
            else
            {
                MessageBox.Show(textBox.Text + "  should be a decimal Number", "Error");
                textBox.Focus();
                return false;

            }
        }
        private bool IsNull(TextBox textbox)
        {
            if (textbox.Text == "")
            {
                MessageBox.Show("Value for subtotal is required! ", "Error");
                textbox.Focus();
                return false;
            }
            else
                return true;

        }
        private bool IsWithinRange(TextBox textbox, int min, int max)
        {
            //int value = Convert.ToInt32(textbox.Text);
            decimal value = Convert.ToDecimal(textbox.Text);
            if (value >= min && value <= max)
                return true;
            else
            {
                MessageBox.Show("Value of subtotal must be positivie");
                return false;
            }

        }
    }
}