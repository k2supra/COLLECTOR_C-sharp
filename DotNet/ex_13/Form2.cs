using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex_13
{
    public partial class Form2 : Form
    {
        private RichTextBox rtb;
        public Form2(RichTextBox richTextBox)
        {
            InitializeComponent();
            this.rtb = richTextBox;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string find_text = textBox1.Text;
            RichTextBoxFinds options = RichTextBoxFinds.None;
            if (checkBox1.Checked)
            {
                options |= RichTextBoxFinds.MatchCase;
            }

            if (radioButton2.Checked)
            {
                int start = rtb.SelectionStart + rtb.SelectionLength;
                int found = rtb.Find(find_text, start, options);
                if (found != -1)
                {
                    rtb.Select(found, find_text.Length);

                    rtb.ScrollToCaret();
                }
                else
                {
                    found = rtb.Find(find_text, 0, options);
                }
            }
            else if (radioButton1.Checked)
            {
                int start = rtb.SelectionStart;
                int found = rtb.Find(find_text, 0, start, options | RichTextBoxFinds.Reverse);
                if (found != -1)
                {
                    rtb.Select(found, find_text.Length);

                    rtb.ScrollToCaret();
                }
                else
                {
                    found = rtb.Find(find_text, 0, options | RichTextBoxFinds.Reverse);
                }
            }
        }
    }
}
