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

    private double[] signalData = new double[NumSample];
    private double[] drawData = new double[NumSample];
    private System.Timers.Timer myTimer = new System.Timers.Timer();
    private int currentIndex;
    private int triggeredIndex;
    private double historyTriggerVoltage;
    public double TriggerLevel;
    public const int NumSample = 1000;
    public double voltageDiv;
    public double timeDiv_ms;
    public double realTimeInterval_ms;

    public Channel()
    {
      realTimeInterval_ms = 0.001;
      timeDiv_ms = 0.1;
      voltageDiv = 1;
      TriggerLevel = 0;
      currentIndex = 0;
      triggeredIndex = 0;
      NewTimer();
      StartTimer();
    }

    public void NewTimer()
    {
      myTimer = new System.Timers.Timer();
      myTimer.Enabled = true;
      myTimer.AutoReset = true;
      myTimer.Interval = 0.01;
      myTimer.Elapsed += new ElapsedEventHandler(OnTimerEvent);
    }

    private void OnTimerEvent(object source, ElapsedEventArgs e)
    {
      DataIn(Math.Sin(Math.PI * 2 / (NumSample - 100) * currentIndex * 3));
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
      signalData[currentIndex % NumSample] = data;
      currentIndex++;
      DataSet(this, EventArgs.Empty);
    }

    public double[] GetDrawData()
    {
      dataConvert();
      return drawData;
    }

    private void dataConvert()
    {
      for (int i = 0; i < NumSample; i++)
      {
        drawData[i] = signalData[(triggeredIndex + i) % NumSample];
      }
    }

    private void setTriggerPoint()
    {
      double buffer = 0;

      for (int i = 0; i < 10; i++)
      {
        buffer += signalData[(currentIndex + 1 + i) % NumSample];
      }
      buffer /= 10;

      if ((buffer > historyTriggerVoltage) && buffer > TriggerLevel)
      {
        triggeredIndex = currentIndex;
      }
      historyTriggerVoltage = buffer;
    }
  }
}