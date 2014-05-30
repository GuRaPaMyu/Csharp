using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graph_protting
{
  class OscChannel
  {
    private int numSample;
    private double[] DrawData = new double[1000];
    private double[] SignalData = new double[1000];

    public double voltageDiv;
    public double timeDiv_ms;
    public double realTimeInterval_ms;

    public OscChannel()
    {
    }


    //データ送受信とかして描画できるようになったらDataInputは消す．あくまでテスト描画用
    private void DataInput()
    {
      double inc_rate;
      inc_rate = Math.PI * 2 / numSample;

      for (int i = 0; i < numSample; i++)
      {
        SignalData[i] = Math.Sin(inc_rate * i);
      }
    }
  }
}
