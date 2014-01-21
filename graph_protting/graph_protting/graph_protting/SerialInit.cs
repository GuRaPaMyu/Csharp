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

    public void SerialSet(string port, int baudrate)
    {
      serial.PortName = port;
      serial.BaudRate = baudrate;
    }

    public void SerialOpen()
    {
      serial.Open();
    }

    public void SerialClose()
    {
      serial.Close();
    }
  }
}
