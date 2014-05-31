using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace graph_protting
{
  public class Channel
  {
    private const int numSample = 1000;
    private double[] drawData = new double[numSample];
    private double[] signalData = new double[numSample];
    private int width = 860;
    private int height = 438;
    private int xAxisInterval = 5;
    private int yAxisInterval = 4;

    public double voltageDiv;
    public double timeDiv_ms;
    public double realTimeInterval_ms;

    public Channel()
    {
        realTimeInterval_ms = 0.001;
        timeDiv_ms = 0.1;
        voltageDiv = 1;
    }

    //データ送受信とかして描画できるようになったらDataInputは消す．あくまでテスト描画用
    public void DataInput()
    {
      double inc_rate;
      inc_rate = Math.PI * 2 / numSample;

      for (int i = 0; i < numSample; i++)
      {
        signalData[i] = Math.Sin(inc_rate * i);
      }
    }

   public void DrawReceivedData(Graphics graphics)
    {
        var pen = new Pen(Color.YellowGreen);
        var points = new Point[numSample];
        for (int i = 0; i < numSample; i++)
        {
            points[i].X = (int)((width * realTimeInterval_ms * i)
                            / (2 * xAxisInterval * timeDiv_ms));
            points[i].Y = (int)(height / 2 - drawData[i]);
        }
       graphics.DrawLines(pen, points);
    }

    public void DataConvert()
    {
        for (int i = 0; i < numSample; i++)
        {
            drawData[i] = (int)(signalData[i] * height / 2 / yAxisInterval / voltageDiv);
        }
    }
  }
}
