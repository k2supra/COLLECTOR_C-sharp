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
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    txtFolderPath.Text = folderBrowserDialog.SelectedPath;
                }
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            listBoxResults.Items.Clear();
            string folder_path = txtFolderPath.Text;
            string search_pattern = txtSearchPattern.Text;
            if (Directory.Exists(folder_path))
            {
                try
                {
                    string[] files = Directory.GetFiles(folder_path, search_pattern);
                    foreach (string item in files)
                    {
                        listBoxResults.Items.Add(item);
                    }
                    if (files.Length == 0)
                    {
                        MessageBox.Show("Files not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: ", ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Folder doesn`t exists.");
            }
        }
    }
}
