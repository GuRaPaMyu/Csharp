using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace graph_protting
{
  public partial class OSC : Form
  {

    public OSC()
    {
      InitializeComponent();
    }

    private void form1Load(object sender, EventArgs e)
    {
    }

    private void form1Closed(object sender, FormClosedEventArgs e)
    {
    }

    private void form1SizeChanged(object sender, EventArgs e)
    {
      display1.Size = new Size(ClientSize.Width - 24, ClientSize.Height - 24);
    }
  }
}