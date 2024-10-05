namespace ex_13
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK && saveFileDialog1.FileName.Length > 0)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName);
                this.Text = $"File [{saveFileDialog1.FileName}]";
                m_doc_changed = false;
            }
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            printToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            cutToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            sellectAllToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator6 = new ToolStripSeparator();
            findDialogToolStripMenuItem = new ToolStripMenuItem();
            formatToolStripMenuItem = new ToolStripMenuItem();
            fontToolStripMenuItem = new ToolStripMenuItem();
            colorToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            characterStyleToolStripMenuItem = new ToolStripMenuItem();
            boldToolStripMenuItem = new ToolStripMenuItem();
            italicToolStripMenuItem = new ToolStripMenuItem();
            underlineToolStripMenuItem = new ToolStripMenuItem();
            strikeoutToolStripMenuItem = new ToolStripMenuItem();
            paragraphAligmentToolStripMenuItem = new ToolStripMenuItem();
            leftToolStripMenuItem = new ToolStripMenuItem();
            rightToolStripMenuItem = new ToolStripMenuItem();
            centerToolStripMenuItem = new ToolStripMenuItem();
            newToolStringMenuItem = new ToolStripMenuItem();
            richTextBox1 = new RichTextBox();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            fontDialog1 = new FontDialog();
            colorDialog1 = new ColorDialog();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStripButton4 = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            toolStripButton5 = new ToolStripButton();
            toolStripButton6 = new ToolStripButton();
            toolStripButton7 = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            findAndReplaceToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, formatToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem, printToolStripMenuItem, toolStripSeparator1, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            fileToolStripMenuItem.DropDownItemClicked += fileToolStripMenuItem_DropDownItemClicked;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(128, 26);
            openToolStripMenuItem.Text = "&Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(128, 26);
            saveToolStripMenuItem.Text = "&Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // printToolStripMenuItem
            // 
            printToolStripMenuItem.Name = "printToolStripMenuItem";
            printToolStripMenuItem.Size = new Size(128, 26);
            printToolStripMenuItem.Text = "&Print";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(125, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(128, 26);
            exitToolStripMenuItem.Text = "&Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { undoToolStripMenuItem, toolStripSeparator2, cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem, deleteToolStripMenuItem, toolStripSeparator3, sellectAllToolStripMenuItem, toolStripSeparator6, findDialogToolStripMenuItem, findAndReplaceToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(49, 24);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.DropDownItemClicked += editToolStripMenuItem_DropDownItemClicked;
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.Size = new Size(224, 26);
            undoToolStripMenuItem.Text = "&Undo";
            undoToolStripMenuItem.Click += undoToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(221, 6);
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.Size = new Size(224, 26);
            cutToolStripMenuItem.Text = "&Cut";
            cutToolStripMenuItem.Click += cutToolStripMenuItem_Click;
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new Size(224, 26);
            copyToolStripMenuItem.Text = "&Copy";
            copyToolStripMenuItem.Click += copyToolStripMenuItem_Click;
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.Size = new Size(224, 26);
            pasteToolStripMenuItem.Text = "&Paste";
            pasteToolStripMenuItem.Click += pasteToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(224, 26);
            deleteToolStripMenuItem.Text = "&Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(221, 6);
            // 
            // sellectAllToolStripMenuItem
            // 
            sellectAllToolStripMenuItem.Name = "sellectAllToolStripMenuItem";
            sellectAllToolStripMenuItem.Size = new Size(224, 26);
            sellectAllToolStripMenuItem.Text = "&Select all";
            sellectAllToolStripMenuItem.Click += sellectAllToolStripMenuItem_Click;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(221, 6);
            // 
            // findDialogToolStripMenuItem
            // 
            findDialogToolStripMenuItem.Name = "findDialogToolStripMenuItem";
            findDialogToolStripMenuItem.Size = new Size(224, 26);
            findDialogToolStripMenuItem.Text = "&Find dialog";
            findDialogToolStripMenuItem.Click += findDialogToolStripMenuItem_Click;
            // 
            // formatToolStripMenuItem
            // 
            formatToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fontToolStripMenuItem, colorToolStripMenuItem, toolStripSeparator4, characterStyleToolStripMenuItem, paragraphAligmentToolStripMenuItem });
            formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            formatToolStripMenuItem.Size = new Size(70, 24);
            formatToolStripMenuItem.Text = "Format";
            formatToolStripMenuItem.DropDownItemClicked += formatToolStripMenuItem_DropDownItemClicked;
            // 
            // fontToolStripMenuItem
            // 
            fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            fontToolStripMenuItem.Size = new Size(222, 26);
            fontToolStripMenuItem.Text = "&Font";
            fontToolStripMenuItem.Click += fontToolStripMenuItem_Click;
            // 
            // colorToolStripMenuItem
            // 
            colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            colorToolStripMenuItem.Size = new Size(222, 26);
            colorToolStripMenuItem.Text = "&Color";
            colorToolStripMenuItem.Click += colorToolStripMenuItem_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(219, 6);
            // 
            // characterStyleToolStripMenuItem
            // 
            characterStyleToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { boldToolStripMenuItem, italicToolStripMenuItem, underlineToolStripMenuItem, strikeoutToolStripMenuItem });
            characterStyleToolStripMenuItem.Name = "characterStyleToolStripMenuItem";
            characterStyleToolStripMenuItem.Size = new Size(222, 26);
            characterStyleToolStripMenuItem.Text = "&Character style";
            // 
            // boldToolStripMenuItem
            // 
            boldToolStripMenuItem.Name = "boldToolStripMenuItem";
            boldToolStripMenuItem.Size = new Size(156, 26);
            boldToolStripMenuItem.Text = "Bold";
            boldToolStripMenuItem.Click += boldToolStripMenuItem_Click;
            // 
            // italicToolStripMenuItem
            // 
            italicToolStripMenuItem.Name = "italicToolStripMenuItem";
            italicToolStripMenuItem.Size = new Size(156, 26);
            italicToolStripMenuItem.Text = "Italic";
            italicToolStripMenuItem.Click += italicToolStripMenuItem_Click;
            // 
            // underlineToolStripMenuItem
            // 
            underlineToolStripMenuItem.Name = "underlineToolStripMenuItem";
            underlineToolStripMenuItem.Size = new Size(156, 26);
            underlineToolStripMenuItem.Text = "Underline";
            underlineToolStripMenuItem.Click += underlineToolStripMenuItem_Click;
            // 
            // strikeoutToolStripMenuItem
            // 
            strikeoutToolStripMenuItem.Name = "strikeoutToolStripMenuItem";
            strikeoutToolStripMenuItem.Size = new Size(156, 26);
            strikeoutToolStripMenuItem.Text = "Strikeout";
            strikeoutToolStripMenuItem.Click += strikeoutToolStripMenuItem_Click;
            // 
            // paragraphAligmentToolStripMenuItem
            // 
            paragraphAligmentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { leftToolStripMenuItem, rightToolStripMenuItem, centerToolStripMenuItem });
            paragraphAligmentToolStripMenuItem.Name = "paragraphAligmentToolStripMenuItem";
            paragraphAligmentToolStripMenuItem.Size = new Size(222, 26);
            paragraphAligmentToolStripMenuItem.Text = "&Paragraph aligment";
            // 
            // leftToolStripMenuItem
            // 
            leftToolStripMenuItem.Name = "leftToolStripMenuItem";
            leftToolStripMenuItem.Size = new Size(135, 26);
            leftToolStripMenuItem.Text = "Left";
            leftToolStripMenuItem.Click += leftToolStripMenuItem_Click;
            // 
            // rightToolStripMenuItem
            // 
            rightToolStripMenuItem.Name = "rightToolStripMenuItem";
            rightToolStripMenuItem.Size = new Size(135, 26);
            rightToolStripMenuItem.Text = "Right";
            rightToolStripMenuItem.Click += rightToolStripMenuItem_Click;
            // 
            // centerToolStripMenuItem
            // 
            centerToolStripMenuItem.Name = "centerToolStripMenuItem";
            centerToolStripMenuItem.Size = new Size(135, 26);
            centerToolStripMenuItem.Text = "Center";
            centerToolStripMenuItem.Click += centerToolStripMenuItem_Click;
            // 
            // newToolStringMenuItem
            // 
            newToolStringMenuItem.Name = "newToolStringMenuItem";
            newToolStringMenuItem.Size = new Size(225, 26);
            newToolStringMenuItem.Text = "&New";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 58);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(776, 366);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3, toolStripButton4, toolStripSeparator5, toolStripButton5, toolStripButton6, toolStripButton7 });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 27);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = Properties.Resources.New;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(29, 24);
            toolStripButton1.Text = "toolStripButton1";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = Properties.Resources.Open;
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(29, 24);
            toolStripButton2.Text = "toolStripButton2";
            toolStripButton2.Click += openToolStripMenuItem_Click;
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = Properties.Resources.Save;
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(29, 24);
            toolStripButton3.Text = "toolStripButton3";
            toolStripButton3.Click += saveToolStripMenuItem_Click;
            // 
            // toolStripButton4
            // 
            toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton4.Image = Properties.Resources.Print;
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(29, 24);
            toolStripButton4.Text = "toolStripButton4";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 27);
            // 
            // toolStripButton5
            // 
            toolStripButton5.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton5.Image = Properties.Resources.Cut;
            toolStripButton5.ImageTransparentColor = Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(29, 24);
            toolStripButton5.Text = "toolStripButton5";
            toolStripButton5.Click += cutToolStripMenuItem_Click;
            // 
            // toolStripButton6
            // 
            toolStripButton6.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton6.Image = Properties.Resources.Copy;
            toolStripButton6.ImageTransparentColor = Color.Magenta;
            toolStripButton6.Name = "toolStripButton6";
            toolStripButton6.Size = new Size(29, 24);
            toolStripButton6.Text = "toolStripButton6";
            toolStripButton6.Click += copyToolStripMenuItem_Click;
            // 
            // toolStripButton7
            // 
            toolStripButton7.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton7.Image = Properties.Resources.Paste;
            toolStripButton7.ImageTransparentColor = Color.Magenta;
            toolStripButton7.Name = "toolStripButton7";
            toolStripButton7.Size = new Size(29, 24);
            toolStripButton7.Text = "toolStripButton7";
            toolStripButton7.Click += pasteToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            statusStrip1.ItemClicked += statusStrip1_ItemClicked;
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(0, 16);
            // 
            // findAndReplaceToolStripMenuItem
            // 
            findAndReplaceToolStripMenuItem.Name = "findAndReplaceToolStripMenuItem";
            findAndReplaceToolStripMenuItem.Size = new Size(224, 26);
            findAndReplaceToolStripMenuItem.Text = "&Find and replace";
            findAndReplaceToolStripMenuItem.Click += findAndReplaceToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(richTextBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem newToolStringMenuItem;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem printToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private RichTextBox richTextBox1;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem sellectAllToolStripMenuItem;
        private ToolStripMenuItem formatToolStripMenuItem;
        private ToolStripMenuItem fontToolStripMenuItem;
        private ToolStripMenuItem colorToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem characterStyleToolStripMenuItem;
        private ToolStripMenuItem boldToolStripMenuItem;
        private ToolStripMenuItem italicToolStripMenuItem;
        private ToolStripMenuItem underlineToolStripMenuItem;
        private ToolStripMenuItem strikeoutToolStripMenuItem;
        private ToolStripMenuItem paragraphAligmentToolStripMenuItem;
        private ToolStripMenuItem leftToolStripMenuItem;
        private ToolStripMenuItem rightToolStripMenuItem;
        private ToolStripMenuItem centerToolStripMenuItem;
        private FontDialog fontDialog1;
        private ColorDialog colorDialog1;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton toolStripButton5;
        private ToolStripButton toolStripButton6;
        private ToolStripButton toolStripButton7;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripMenuItem findDialogToolStripMenuItem;
        private ToolStripMenuItem findAndReplaceToolStripMenuItem;
    }
}
