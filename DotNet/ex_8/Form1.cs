namespace ex_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = string.Format("Words in selected sentences: {0}", CountWordsInText());
        }
        private int CountWordsInText()
        {
            if (listBox1.SelectedItems != null)
            {
                int wordCount = 0;
                foreach (var item in listBox1.SelectedItems)
                {
                    string data = item.ToString();
                    wordCount += CountWords(data);
                }
                return wordCount;
            }
            else
            {
                MessageBox.Show("Please, choose a sentence");
                return 0;
            }
        }
        private int CountWords(string data)
        {
            if (string.IsNullOrWhiteSpace(data))
            {
                return 0;
            }

            string[] words = data.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }
    }
}
