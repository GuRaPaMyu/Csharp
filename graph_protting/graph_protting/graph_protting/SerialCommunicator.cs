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
  public partial class SerialCommunicator : Form
  {
    SerialPort serial = new SerialPort();

    public SerialCommunicator()
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
        serial.PortName = comboBox1.SelectedText;
        serial.BaudRate = int.Parse(comboBox2.SelectedText);
        serial.Open();
      }
      catch
      {
        serial.Close();
        MessageBox.Show("シリアルポートをOpenできませんでした．", "Cannot Open SerialPort", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      this.Close();
    }

    private void GetSerialData(double[] data, int getnum)
    {
      for (int i=0;i<getnum;i++)
      {
        data[i] = double.Parse(serial.ReadLine());
      }
    }

  }
}
