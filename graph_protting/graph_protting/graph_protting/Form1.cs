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
    const int numSample = 860;
    private double[] sampledData = new double[numSample];
    private int[] drawData = new int[numSample];
    Point Center = new Point();
    int axisinterval_X = 5;
    int axisinterval_Y = 4;
    int longdashinterval_X = 5;
    int longdashinterval_Y = 5;

    int voltageDiv = 2;

    public OSC()
    {
      InitializeComponent();
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

      Center.X = pictureBox1.Size.Width / 2;
      Center.Y = pictureBox1.Size.Height / 2;

      pictureBox1.Location = point_picbox;
    }

    private void form_sizechng(object sender, EventArgs e)
    {
      pictureBox1.Size = new Size(ClientSize.Width - 24, ClientSize.Height - 24);
      Center.X = pictureBox1.Size.Width / 2;
      Center.Y = pictureBox1.Size.Height / 2;
      pictureBox1.Invalidate();
    }

    private void picturebox1_paint(object sender, PaintEventArgs e)
    {
      DrawSolidXAxis(e.Graphics);
      DrawDotXAxis(e.Graphics);
      DrawSolidYAxis(e.Graphics);
      DrawDotYAxis(e.Graphics);
      DataInput();
      DataConvert();
      DrawReceivedData(e.Graphics);
    }

    private void DrawSolidXAxis(Graphics graphics)
    {
      int x1, y1, x2, y2;
      x1 = 0;
      x2 = pictureBox1.Width;
      y1 = y2 = pictureBox1.Height / 2;
      var pen = new Pen(Color.Wheat);
      graphics.DrawLine(pen, new Point(x1, y1), new Point(x2, y2));

      const int lengthSmallDiv = 4;
      const int lengthSmallDivL = 8;
      for (int j = 0; j < 3; ++j)
      {
        for (int i = 0; i < 2* longdashinterval_X * axisinterval_X + 1; ++i)
        {
          if (i % longdashinterval_X == 0)
          {
            y1 = -lengthSmallDivL / 2 + j * pictureBox1.Height / 2;
            y2 = +lengthSmallDivL / 2 + j * pictureBox1.Height / 2;
          }
          else
          {
            y1 = -lengthSmallDiv / 2 + j * pictureBox1.Height / 2;
            y2 = +lengthSmallDiv / 2 + j * pictureBox1.Height / 2;
          }
          x1 = x2 = i * pictureBox1.Width / (2 * longdashinterval_X * axisinterval_X);
          graphics.DrawLine(pen, new Point(x1, y1), new Point(x2, y2));
        }
      }
    }

    private void DrawDotXAxis(Graphics graphics)
    {
      int x1, y1, x2, y2;
      x1 = 0;
      x2 = pictureBox1.Width;
      var pen = new Pen(Color.Wheat);
      pen.DashPattern = new float[] { 1.0f, 7.0f };
      for (int i = 1; i < 2 * axisinterval_Y; ++i)
      {
        y1 = y2 = i * pictureBox1.Height / (2 * axisinterval_Y);
        graphics.DrawLine(pen, new Point(x1, y1), new Point(x2, y2));
      }
    }

    private void DrawSolidYAxis(Graphics graphics)
    {
      int x1, y1, x2, y2;
      y1 = 0;
      y2 = pictureBox1.Height;
      x1 = x2 = pictureBox1.Width / 2;
      var pen = new Pen(Color.Wheat);
      graphics.DrawLine(pen, new Point(x1, y1), new Point(x2, y2));

      const int lengthSmallDiv = 4;
      const int lengthSmallDivL = 8;
      for (int j = 0; j < 3; ++j)
      {
        for (int i = 0; i < 2 * longdashinterval_Y * axisinterval_Y + 1; ++i)
        {
          if (i % 5 == 0)
          {
            x1 = -lengthSmallDivL / 2 + j * pictureBox1.Width / 2;
            x2 = +lengthSmallDivL / 2 + j * pictureBox1.Width / 2;
          }
          else
          {
            x1 = -lengthSmallDiv / 2 + j * pictureBox1.Width / 2;
            x2 = +lengthSmallDiv / 2 + j * pictureBox1.Width / 2;
          }
          y1 = y2 = i * pictureBox1.Height / (2 * longdashinterval_Y * axisinterval_Y);
          graphics.DrawLine(pen, new Point(x1, y1), new Point(x2, y2));
        }
      }
    }

    private void DrawDotYAxis(Graphics graphics)
    {
      int x1, y1, x2, y2;
      y1 = 0;
      y2 = pictureBox1.Height;
      var pen = new Pen(Color.Wheat);
      pen.DashPattern = new float[] { 1.0f, 7.0f };
      for (int i = 1; i < 2 * axisinterval_X; ++i)
      {
        x1 = x2 = i * pictureBox1.Width / (2 * axisinterval_X);
        graphics.DrawLine(pen, new Point(x1, y1), new Point(x2, y2));
      }
    }

    private void DrawReceivedData(Graphics graphics)
    {
      var pen = new Pen(Color.YellowGreen);
      var points = new Point[numSample];
      for (int i = 0; i < numSample; i++)
      {
        points[i].X = i;
        //points[i].Y = (int)((((double)sampledData[i] - 512.0) * 1.0 / 1024.0 + 0.5) * pictureBox1.Height);
        //points[i].X = pictureBox1.Width / numSample * i;
        points[i].Y = (int)(Center.Y - drawData[i]);
      }
      graphics.DrawLines(pen, points);
    }

    //データ送受信とかして描画できるようになったらDataInputは消す．あくまでテスト描画用
    private void DataInput()
    {
      double inc_rate;
      inc_rate = Math.PI * 2 / numSample;

      for (int i = 0; i < numSample; i++)
      {
        sampledData[i] = Math.Sin(inc_rate * i);
      }
    }

    private void DataConvert()
    {
      for(int i = 0; i < numSample; i++)
      {
        drawData[i] = (int)(sampledData[i] * Center.Y / axisinterval_Y / voltageDiv);
      }
    }
  }
}