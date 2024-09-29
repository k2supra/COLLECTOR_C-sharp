namespace ex_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int r = int.Parse(textBox1.Text);
            int c = int.Parse(textBox2.Text);
            Random random = new Random();
            dataGridView1.RowCount = r;
            dataGridView1.ColumnCount = c;
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = random.Next(-10, 10);
                    dataGridView1.Columns[j].Width = 35;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int r = dataGridView1.RowCount;
            int c = dataGridView1.ColumnCount;
            int[] arr = new int[r * c];

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    arr[i * dataGridView1.ColumnCount + j] = Convert.ToInt32(dataGridView1.Rows[i].Cells[j].Value);
                }
            }
            listBox1.Items.Clear();
            foreach (int i in arr) listBox1.Items.Add(i);
        }
    }
}
