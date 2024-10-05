namespace ex_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SaveFileDialog saveFileDialog1;
        OpenFileDialog openFileDialog1;
        private bool m_doc_changed = false;
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK && saveFileDialog1.FileName.Length > 0)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName);
                this.Text = $"File [{saveFileDialog1.FileName}]";
                m_doc_changed = false;
            }
            this.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK && openFileDialog1.FileName.Length > 0)
            {
                try
                {
                    richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);
                }
                catch (Exception)
                {
                    richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                }
                this.Text = "File [" + openFileDialog1.FileName + "]";
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            m_doc_changed = true;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK && saveFileDialog1.FileName.Length > 0)
            {

            }
            richTextBox1.SaveFile(saveFileDialog1.FileName);
            this.Text = $"File [{saveFileDialog1.FileName}]";
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void sellectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog1.Color;
            }
        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                System.Drawing.Font currentfont = richTextBox1.Font;
                System.Drawing.FontStyle newfont;
                if (richTextBox1.SelectionFont.Bold == true)
                {
                    newfont = FontStyle.Regular;
                }
                else
                {
                    newfont = FontStyle.Bold;
                }
                richTextBox1.SelectionFont = new Font(currentfont.FontFamily, currentfont.Size, newfont);
            }
        }

        private void leftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void rightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void centerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                System.Drawing.Font currentfont = richTextBox1.Font;
                System.Drawing.FontStyle newfont;
                if (richTextBox1.SelectionFont.Italic == true)
                {
                    newfont = FontStyle.Regular;
                }
                else
                {
                    newfont = FontStyle.Italic;
                }
                richTextBox1.SelectionFont = new Font(currentfont.FontFamily, currentfont.Size, newfont);
            }
        }

        private void underlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                System.Drawing.Font currentfont = richTextBox1.Font;
                System.Drawing.FontStyle newfont;
                if (richTextBox1.SelectionFont.Underline == true)
                {
                    newfont = FontStyle.Regular;
                }
                else
                {
                    newfont = FontStyle.Underline;
                }
                richTextBox1.SelectionFont = new Font(currentfont.FontFamily, currentfont.Size, newfont);
            }
        }

        private void strikeoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                System.Drawing.Font currentfont = richTextBox1.Font;
                System.Drawing.FontStyle newfont;
                if (richTextBox1.SelectionFont.Strikeout == true)
                {
                    newfont = FontStyle.Regular;
                }
                else
                {
                    newfont = FontStyle.Strikeout;
                }
                richTextBox1.SelectionFont = new Font(currentfont.FontFamily, currentfont.Size, newfont);
            }
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fileToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            this.UpdateStatus(e.ClickedItem);
        }

        private void editToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            this.UpdateStatus(e.ClickedItem);
        }

        private void formatToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            this.UpdateStatus(e.ClickedItem);
        }
        private void UpdateStatus(ToolStripItem item)
        {
            if (item != null)
            {
                string msg = String.Format("{0} selected", item.Text);
                this.statusStrip1.Items[0].Text = msg;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (m_doc_changed)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK && saveFileDialog1.FileName.Length > 0)
                {
                    richTextBox1.SaveFile(saveFileDialog1.FileName);
                    this.Text = $"File [{saveFileDialog1.FileName}]";
                    m_doc_changed = false;
                }
            }
            richTextBox1.Clear();
        }

        private void findDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this.richTextBox1);
            form2.Show();
        }

        private void findAndReplaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(this.richTextBox1);
            form3.Show();
        }
    }
}
