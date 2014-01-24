using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace graph_protting
{
  public partial class SerialInit : Form
  {
    SerialPort serial = new SerialPort();

    public SerialInit()
    {
      InitializeComponent();
    }

    public void SerialClose()
    {
      serial.Close();
    }

    private void ClickOpenPort(object sender, EventArgs e)
    {

      try
      {
        serial.Open();
        Close();
      }
      catch
      {
        serial.Close();
        MessageBox.Show("シリアルポートをOpenできませんでした．", "Cannot Open SerialPort", MessageBoxButtons.OK, MessageBoxIcon.Error);        
      }
    }
  }
}
