namespace ex_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(pc_components);
        }
        static public List<string> gpu = new List<string>() { "RX 7900 XT - 100$", "RX 7900 XTX  - 100$", "RX 7900 GRE - 100$", "RX 7800 XT - 200$", "NVIDIA GTX1660 - 200$", "NVIDIA GTX1670 - 200$", "NVIDIA GTX1680 - 200$" };
        static public List<string> cpu = new List<string>() { "AMD 2000 - 150$", "AMD 3000 - 150$", "AMD 4000 - 150$", "AMD 5000 - 150$", "Intel Core i9 - 120$", "Intel Core i8 - 120$", "Intel Core i7 - 120$" };
        static public List<string> motherboard = new List<string>() { "A320M - 100$", "A320M Pro4 - 100$", "A320M-DGS - 100$", "A320M-HDV - 100$", "A520M Phantom Gaming 4 - 200$", "A520M Pro4 - 100$", "A520M-HDV - 160$" };
        static public List<string> monitor = new List<string>() { "Odyssey Gaming G50D - 160$", "Odyssey Gaming G75NB - 160$", "Odyssey Gaming G80SD - 160$", "Odyssey Gaming G60SD - 180$", "Odyssey ARK A2 - 180$", "Odyssey Neo G9 - 180$", "Business S43C - 170$" };
        static public List<List<string>> lists = new List<List<string>>() { gpu, cpu, motherboard, monitor };
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            lists[comboBox1.SelectedIndex].Sort();
            foreach (string item in lists[comboBox1.SelectedIndex])
            {
                listBox2.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (string item in listBox2.SelectedItems)
            {
                listBox1.Items.Add(item);
                string[] parts = item.Split(' ');
                int price = int.Parse(parts[parts.Length - 1].Split('$')[0]);
                int old_price = Convert.ToInt32(label4.Text);
                label4.Text = (old_price + price).ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            if (form2.ShowDialog() == DialogResult.OK)
            {
                var result = form2.Tag as dynamic;
                if (result != null)
                {
                    string new_component = result.Component;
                    int index = result.Index;

                    lists[index].Add(new_component);
                    
                }
            }
        }
    }
}
