using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graph_protting
{
    public partial class OSC : Form
    {
        public OSC()
        {
            InitializeComponent();
            Size = new Size(900, 500);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          picturebox1_init();
        }

        private void picturebox1_init()
        {
          Point point_picbox = new Point();
          point_picbox.X = 12;
          point_picbox.Y = 12;

          pictureBox1.Location = point_picbox;
        }

        private void form_sizechng(object sender, EventArgs e)
        {
          pictureBox1.Size = new Size(this.Size.Width - 40,  this.Size.Height - 62);
        }
    }
}
