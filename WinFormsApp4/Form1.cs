using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        Graphics g;
        Pen p;

        int x0, y0;
        bool draw = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            p = new Pen(Color.Black, 1);

            toolStripComboBox1.SelectedIndex = 0;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                draw = true;
                x0 = e.X;
                y0 = e.Y;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (draw)
            {
                g.DrawLine(p, x0, y0, e.X, e.Y);

                x0 = e.X;
                y0 = e.Y;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            draw = false;
        }
    }
}
