namespace ex_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double[] price = { 4.32, 3.85 };

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            try
            {
                label1.Text = trackBar1.Value.ToString();
                string[] parts = price[(int)(numericUpDown1.Value - 1)].ToString().Split(",");
                double value = price[(int)(numericUpDown1.Value - 1)] * trackBar1.Value;
                if (!value.ToString().Contains(','))
                {
                    textBox1.Text = string.Format("{0}grn. {1}cop. kW/h", value, 0);
                }
                else
                {
                    string[] parts2 = Math.Round(price[(int)(numericUpDown1.Value - 1)] * trackBar1.Value, 2).ToString().Split(",");
                    textBox1.Text = string.Format("{0}grn. {1}cop.", parts2[0], parts2[1]);
                }
                textBox2.Text = string.Format("{0}grn. {1}cop. kW/h", parts[0], parts[1]);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"WARNING \n{ex.Message}\n{ex.StackTrace}");
            }
            
        }
    }
}
