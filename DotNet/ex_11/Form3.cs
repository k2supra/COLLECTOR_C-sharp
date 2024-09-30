using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex_11
{
    public partial class Form3 : Form
    {
        public Form3(string text, ListBox listBox)
        {
            InitializeComponent();
            label2.Text = text;
            for (int i = 0; i < listBox.Items.Count; i++)
            {
                listBox1.Items.Add(listBox.Items[i]);
            }
            //listBox1 = listBox;
        }
    }
}
