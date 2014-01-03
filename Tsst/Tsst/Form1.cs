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
        public Form1()
        {
            InitializeComponent();
        }

        private void Mouse_Clicked(object sender, MouseEventArgs e)
        {
          MessageBox.Show("botton was clicked!", "ahoho", MessageBoxButtons.OK, MessageBoxIcon.Information);
          
        }

    }
}
