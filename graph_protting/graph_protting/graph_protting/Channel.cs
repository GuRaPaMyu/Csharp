using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Timers;

namespace graph_protting
{
  public class Channel
  {
    private double[] signalData = new double[NumSample];
    private System.Timers.Timer myTimer;
    private int currentIndex;

    public const int NumSample = 1000;
    public double voltageDiv;
    public double timeDiv_ms;
    public double realTimeInterval_ms;

    public Channel()    
    {
      realTimeInterval_ms = 0.001;
      timeDiv_ms = 0.1;
      voltageDiv = 1;
      currentIndex = 0;
      NewTimer();
      StartTimer();
    }

    public void NewTimer()
    {
        myTimer = new System.Timers.Timer();
        myTimer.Enabled = true;
        myTimer.AutoReset = true;
        myTimer.Interval = 10;
        myTimer.Elapsed += new ElapsedEventHandler(OnTimerEvent);
    }

    private void OnTimerEvent(object source, ElapsedEventArgs e)
    {
        DataIn(Math.Sin(Math.PI * 2 / NumSample * currentIndex));
    }

    public void StartTimer()
    {
        myTimer.Start();
    }

    public void StopTimer()
    {
        myTimer.Stop();
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

    public void DataIn(double data)
    {
        signalData[currentIndex % NumSample] = data;
        currentIndex ++;
    }

    public double[] GetSignalData()
    {
      return signalData;
    }
  }
}
