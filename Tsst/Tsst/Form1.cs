using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tsst
{
    public partial class Form1 : Form
    {
        private int i = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Mouse_Clicked(object sender, MouseEventArgs e)
        {
          i++;
          MessageBox.Show("botton was clicked!", "ahoho", MessageBoxButtons.OK, MessageBoxIcon.Information);
          Invalidate();          
        }

        private void Paint_Form(object sender, PaintEventArgs e)
        {
          Graphics g;
          g = e.Graphics;

          Font fnt = new Font("ＭＳ　明朝", 10);
          string str;
          str = string.Format("test siteru {0}", i);

          g.DrawString(str, fnt, SystemBrushes.WindowText, 0.0F, 0.0F);
        }

        private void CliantSizeChanged(object sender, EventArgs e)
        {
          pictureBox1.SetBounds(12, 12, ClientSize.Width - 24, ClientSize.Height - 100);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
