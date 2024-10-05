using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Design.AxImporter;

namespace ex_13
{
    public partial class Form3 : Form
    {
        private RichTextBox rtb;
        public Form3(RichTextBox richTextBox)
        {
            InitializeComponent();
            this.rtb = richTextBox;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RichTextBoxFinds options = checkBox1.Checked ? RichTextBoxFinds.MatchCase : RichTextBoxFinds.None;
            string find_text = textBox1.Text;
            int start = rtb.SelectionStart + rtb.SelectionLength;
            int found = rtb.Find(find_text, start, options);
            if (found != -1)
            {
                rtb.Select(found, find_text.Length);

                rtb.ScrollToCaret();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string find_text = textBox1.Text;
            string replace_text = textBox2.Text;

            RichTextBoxFinds options = checkBox1.Checked ? RichTextBoxFinds.MatchCase : RichTextBoxFinds.None;

            int start = rtb.SelectionStart;
            int found = rtb.Find(find_text, start, options);

            if (found != -1)
            {
                rtb.Select(found, find_text.Length);
                rtb.SelectedText = replace_text;
                rtb.ScrollToCaret();
            }
            else
            {
                found = rtb.Find(find_text, 0, options);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string find_text = textBox1.Text;
            string replace_text = textBox2.Text;

            RichTextBoxFinds options = checkBox1.Checked ? RichTextBoxFinds.MatchCase : RichTextBoxFinds.None;

            int start = 0;
            int found = rtb.Find(find_text, start, options);

            if (found != -1)
            {
                rtb.Select(found, find_text.Length);
                rtb.SelectedText = replace_text;
                rtb.ScrollToCaret();
                found = rtb.Find(find_text, start, options  );
            }
        }
    }
}
