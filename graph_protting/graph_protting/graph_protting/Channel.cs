using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace graph_protting
{
  public class Channel
  {
    public event EventHandler DataSet;
    public event EventHandler DataDrawAllow;

    public double[] SignalData = new double[NumSample];
    private System.Timers.Timer myTimer = new System.Timers.Timer();
    private int currentIndex;
    public int endIndex;
    private double historyData;
    public double TriggerLevel;
    public const int NumSample = 1000;
    public double voltageDiv;
    public double timeDiv_ms;
    public double realTimeInterval_ms;
    private int cnt = 0; //test

    public Channel()
    {
      realTimeInterval_ms = 0.001;
      timeDiv_ms = 0.1;
      voltageDiv = 1;
      TriggerLevel = 0;
      currentIndex = 0;
      NewTimer();
      StartTimer();
    }

    public void NewTimer()
    {
      myTimer = new System.Timers.Timer(1);
      myTimer.AutoReset = true;
      myTimer.Elapsed += new ElapsedEventHandler(OnTimerEvent);
    }

    private void OnTimerEvent(object source, ElapsedEventArgs e)
    {
      cnt++;
      cnt %= 2000;
      DataIn(Math.Sin(Math.PI * 2 * cnt/ NumSample * 6));
    }

    public void StartTimer()
    {
      myTimer.Start();
    }

    public void StopTimer()
    {
      myTimer.Stop();
    }

    public void DataIn(double data)
    {
      if((currentIndex == 0) && (data > TriggerLevel) && (historyData < TriggerLevel)) //立ち上がりトリガ
      {
        SignalData[currentIndex] = data;
        currentIndex++;
      }
      if(currentIndex != 0)
      {
        SignalData[currentIndex] = data;
        currentIndex ++;
        currentIndex %= NumSample;
      }

      //逐次表示なう
      //if(currentIndex == NumSample - 1)
      //{
        DataDrawAllow(this, EventArgs.Empty);
        DataSet(this, EventArgs.Empty);
      //}
      historyData = data;
    }
  }
}