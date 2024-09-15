namespace ex_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        protected double uahToUsd = 0.024;
        protected double uahToEuro = 0.022;
        protected double euroToUah = 45.85;
        protected double usdToUah = 41.38;
        protected double usdToEuro = 0.9;
        protected double euroTousd = 1.11;
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            string text = textBox1.Text;
            int n = text.IndexOf(",");
            if (!Char.IsDigit(ch) && !Char.IsControl(ch) && !(ch == ',' && n == -1)) e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double amount = double.Parse(textBox1.Text);
            string fc = comboBox1.SelectedItem.ToString();
            string tc = comboBox2.SelectedItem.ToString();
            if (fc == "UAH" && tc == "UAH") textBox2.Text = (amount * 1).ToString();
            if (fc == "UAH" && tc == "USD") textBox2.Text = (amount * uahToUsd).ToString();
            if (fc == "UAH" && tc == "EURO") textBox2.Text = (amount * uahToEuro).ToString();
            if (fc == "USD" && tc == "UAH") textBox2.Text = (amount * usdToUah).ToString();
            if (fc == "USD" && tc == "USD") textBox2.Text = (amount * 1).ToString();
            if (fc == "USD" && tc == "EURO") textBox2.Text = (amount * usdToEuro).ToString();
            if (fc == "EURO" && tc == "UAH") textBox2.Text = (amount * euroToUah).ToString();
            if (fc == "EURO" && tc == "USD") textBox2.Text = (amount * euroTousd).ToString();
            if (fc == "EURO" && tc == "EURO") textBox2.Text = (amount * 1).ToString();
        }
    }
}
