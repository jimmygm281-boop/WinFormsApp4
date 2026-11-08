namespace WinFormsApp4
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
            closeToolStripMenuItem = new ToolStripMenuItem();
            graphicToolStripMenuItem = new ToolStripMenuItem();
            clearToolStripMenuItem = new ToolStripMenuItem();
            uzegToolStripMenuItem = new ToolStripMenuItem();
            unguToolStripMenuItem = new ToolStripMenuItem();
            colorDialog1 = new ColorDialog();
            toolStrip1 = new ToolStrip();
            toolStripComboBox1 = new ToolStripComboBox();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, graphicToolStripMenuItem, uzegToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { closeToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(44, 24);
            fileToolStripMenuItem.Text = "file";
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(126, 26);
            closeToolStripMenuItem.Text = "close";
            // 
            // graphicToolStripMenuItem
            // 
            graphicToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clearToolStripMenuItem });
            graphicToolStripMenuItem.Name = "graphicToolStripMenuItem";
            graphicToolStripMenuItem.Size = new Size(74, 24);
            graphicToolStripMenuItem.Text = "Graphic";
            // 
            // clearToolStripMenuItem
            // 
            clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            clearToolStripMenuItem.Size = new Size(124, 26);
            clearToolStripMenuItem.Text = "clear";
            // 
            // uzegToolStripMenuItem
            // 
            uzegToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { unguToolStripMenuItem });
            uzegToolStripMenuItem.Name = "uzegToolStripMenuItem";
            uzegToolStripMenuItem.Size = new Size(55, 24);
            uzegToolStripMenuItem.Text = "uzeg";
            // 
            // unguToolStripMenuItem
            // 
            unguToolStripMenuItem.Name = "unguToolStripMenuItem";
            unguToolStripMenuItem.Size = new Size(125, 26);
            unguToolStripMenuItem.Text = "ungu";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripComboBox1 });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 28);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripComboBox1
            // 
            toolStripComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            toolStripComboBox1.Items.AddRange(new object[] { "1, 2, 3, 4, 5, 6, 7, 8, 9, 10 " });
            toolStripComboBox1.Name = "toolStripComboBox1";
            toolStripComboBox1.Size = new Size(121, 28);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            MouseDown += Form1_MouseDown;
            MouseMove += Form1_MouseMove;
            MouseUp += Form1_MouseUp;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ColorDialog colorDialog1;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripMenuItem graphicToolStripMenuItem;
        private ToolStripMenuItem clearToolStripMenuItem;
        private ToolStripMenuItem uzegToolStripMenuItem;
        private ToolStripMenuItem unguToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripComboBox toolStripComboBox1;
    }
}
