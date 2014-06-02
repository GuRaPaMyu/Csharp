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
    private double[] signalData = new double[NumSample];
    private int xAxisInterval = 5;
    private int yAxisInterval = 4;

    public const int NumSample = 1000;
    public double voltageDiv;
    public double timeDiv_ms;
    public double realTimeInterval_ms;

    public Channel()
    {
        realTimeInterval_ms = 0.001;
        timeDiv_ms = 0.1;
        voltageDiv = 1;
        DataInput();
    }

    //データ送受信とかして描画できるようになったらDataInputは消す．あくまでテスト描画用
    public void DataInput()
    {
      double inc_rate;
      inc_rate = Math.PI * 2 / NumSample;

      for (int i = 0; i < NumSample; i++)
      {
        signalData[i] = Math.Sin(inc_rate * i);
      }
    }

    public double[] GetSignalData()
    {
      return signalData;
    }
  }
}
