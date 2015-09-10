using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace graph_protting
{
  public partial class Display : UserControl
  {
    private int xAxisPartNum;
    private int yAxisPartNum;
    private int xLongDashInterval;
    private int yLongDashInterval;
    private int xDivSeparatorLength;
    private int xDivLargeSeparatorLength;
    private int yDivSeparatorLength;
    private int yDivLargeSeparatorLength;
    private double[] drawData = new double[Channel.NumSample];

    //Channel channel1 = new Channel();
    SerialPort serial = new SerialPort();

    public Display()
    {
      xAxisPartNum = 5;
      yAxisPartNum = 4;
      xLongDashInterval = 5;
      yLongDashInterval = 5;
      xDivSeparatorLength = 4;
      xDivLargeSeparatorLength = 8;
      yDivSeparatorLength = 4;
      yDivLargeSeparatorLength = 8;
      //channel1.DataSet += channel1DataSet;
      //channel1.DataDrawAllow += channel1DrawDataAllow;

      serial.PortName = "COM4";
      serial.BaudRate = 9600;
      serial.Open();

      InitializeComponent();

      radioButton1.Select();
    }

    private void channel1DrawDataAllow(object sender, EventArgs e)
    {
      //drawData = channel1.SignalData;  //配列の中身はコピーできてないと思う
      pictureBox1.Invalidate();
    }

    private void channel1DataSet(object sender, EventArgs e)
    {
      pictureBox1.Invalidate();
    }

    private void drawSolidXAxis(Graphics graphics)
    {
      int x1, y1, x2, y2;
      x1 = 0;
      x2 = Width;
      y1 = y2 = Height / 2;
      var pen = new Pen(Color.Wheat);
      graphics.DrawLine(pen, new Point(x1, y1), new Point(x2, y2));
      for (int j = 0; j < 3; ++j)
      {
        for (int i = 0; i < 2 * xLongDashInterval * xAxisPartNum + 1; ++i)
        {
          if (i % xLongDashInterval == 0)
          {
            y1 = -xDivLargeSeparatorLength / 2 + j * Height / 2;
            y2 = +xDivLargeSeparatorLength / 2 + j * Height / 2;
          }
          else
          {
            y1 = -xDivSeparatorLength / 2 + j * Height / 2;
            y2 = +xDivSeparatorLength / 2 + j * Height / 2;
          }
          x1 = x2 = i * Width / (2 * xLongDashInterval * xAxisPartNum);
          graphics.DrawLine(pen, new Point(x1, y1), new Point(x2, y2));
        }
      }
    }

    private void drawDotXAxis(Graphics graphics)
    {
      int x1, y1, x2, y2;
      x1 = 0;
      x2 = Width;
      var pen = new Pen(Color.Wheat);
      pen.DashPattern = new float[] { 1.0f, 7.0f };
      for (int i = 1; i < 2 * yAxisPartNum; ++i)
      {
        y1 = y2 = i * Height / (2 * yAxisPartNum);
        graphics.DrawLine(pen, new Point(x1, y1), new Point(x2, y2));
      }
    }

    private void drawSolidYAxis(Graphics graphics)
    {
      int x1, y1, x2, y2;
      y1 = 0;
      y2 = Height;
      x1 = x2 = Width / 2;
      var pen = new Pen(Color.Wheat);
      graphics.DrawLine(pen, new Point(x1, y1), new Point(x2, y2));

      for (int j = 0; j < 3; ++j)
      {
        for (int i = 0; i < 2 * yLongDashInterval * yAxisPartNum + 1; ++i)
        {
          if (i % 5 == 0)
          {
            x1 = -yDivLargeSeparatorLength / 2 + j * Width / 2;
            x2 = +yDivLargeSeparatorLength / 2 + j * Width / 2;
          }
          else
          {
            x1 = -yDivSeparatorLength / 2 + j * Width / 2;
            x2 = +yDivSeparatorLength / 2 + j * Width / 2;
          }
          y1 = y2 = i * Height / (2 * yLongDashInterval * yAxisPartNum);
          graphics.DrawLine(pen, new Point(x1, y1), new Point(x2, y2));
        }
      }
    }

    private void drawDotYAxis(Graphics graphics)
    {
      int x1, y1, x2, y2;
      y1 = 0;
      y2 = Height;
      var pen = new Pen(Color.Wheat);
      pen.DashPattern = new float[] { 1.0f, 7.0f };
      for (int i = 1; i < 2 * xAxisPartNum; ++i)
      {
        x1 = x2 = i * Width / (2 * xAxisPartNum);
        graphics.DrawLine(pen, new Point(x1, y1), new Point(x2, y2));
      }
    }

    public void DrawAxis(Graphics graphics)
    {
      drawSolidXAxis(graphics);
      drawDotXAxis(graphics);
      drawSolidYAxis(graphics);
      drawDotYAxis(graphics);
    }

    public void DrawReceivedData(Graphics graphics)
    {
      var pen = new Pen(Color.YellowGreen);
      var points = new Point[Channel.NumSample];

      for (int i = 0; i < Channel.NumSample; i++)
      {
        points[i].X = (int)(this.Width * i / Channel.NumSample);  //時間軸との関連付け
        points[i].Y = (int)(Height / 2 - serial.ReadByte());

          //(int)(Height / 2 - (drawData[i] * Height / 2 /
          //yAxisPartNum / channel1.voltageDiv));
      }
      graphics.DrawCurve(pen, points);
    }

    private void DrawTriggerLevel(Graphics graphics)
    {
            /*
      var pen = new Pen(Color.Red);
      var points = new Point[2];

      points[0].X = 0;
      points[0].Y = (int)(this.Height / 2 - channel1.TriggerLevel * this.Height / 2
                          / yAxisPartNum / channel1.voltageDiv);
      points[1].X = this.Width;
      points[1].Y = (int)(this.Height / 2 - channel1.TriggerLevel * this.Height / 2
                          / yAxisPartNum / channel1.voltageDiv);

      graphics.DrawLine(pen, points[0], points[1]);
      */
    }

    private void DisplayLoad(object sender, EventArgs e)
    {
      Point origin = new Point();
      origin.X = 12;
      origin.Y = 12;
      Location = origin;

      label1.Text = numericUpDown1.Value.ToString() + " V/Div";
      label2.Text = numericUpDown2.Value.ToString() + " ms/Div";
    }

    public void DisplayPaint(object sender, PaintEventArgs e)
    {
      DrawAxis(e.Graphics);
      DrawReceivedData(e.Graphics);
      DrawTriggerLevel(e.Graphics);
    }

    private void VoltageValueChanged(object sender, EventArgs e)
    {
      //channel1.voltageDiv = (double)numericUpDown1.Value;
      label1.Text = numericUpDown1.Value.ToString() + " V/Div";
      pictureBox1.Invalidate();
    }

    private void TimeValueChanged(object sender, EventArgs e)
    {
      //channel1.timeDiv_ms = (double)numericUpDown2.Value;
      label2.Text = numericUpDown2.Value.ToString() + " ms/Div";
      pictureBox1.Invalidate();
    }

    private void DisplaySizeChanged(object sender, EventArgs e)
    {
      pictureBox1.Size = this.Size;
      pictureBox1.Invalidate();
    }

    private void triggerLevelChanged(object sender, EventArgs e)
    {
      //channel1.TriggerLevel = (double)numericUpDown3.Value;
      label3.Text = numericUpDown3.Value.ToString() + " V";
      pictureBox1.Invalidate();
    }

    private void triggerModeChanged(object sender, EventArgs e)
    {
      if(radioButton1.Checked)
      {
        //channel1.TriggerMode = 0;
      }else if(radioButton2.Checked)
      {
        //channel1.TriggerMode = 1;
      }
    }
  }
}