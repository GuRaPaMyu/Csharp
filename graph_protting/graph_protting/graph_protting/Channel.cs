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
    private double historyData;
    public double TriggerLevel;
    public const int NumSample = 50;
    public double voltageDiv;
    public double timeDiv_ms;
    public double realTimeInterval_ms;
    private int cnt = 0; //test
    public int TriggerMode; //0:Upper, 1:Lower Edge

    public Channel()
    {
      realTimeInterval_ms = 0.001;
      timeDiv_ms = 0.1;
      voltageDiv = 1;
      TriggerLevel = 0;
      currentIndex = 0;
      TriggerMode = 0;
    }

    public void DataIn(double data)
    {
      if(currentIndex == 0)
      {
        if(TriggerMode == 0)
        {
          if ((data > TriggerLevel) && (historyData < TriggerLevel)) //立ち上がりトリガ
          {
            SignalData[currentIndex] = data;
            currentIndex++;
          }
        }else if(TriggerMode == 1)
        {
          if((data < TriggerLevel) && (historyData > TriggerLevel)) //立ち上がりトリガ
          {
            SignalData[currentIndex] = data;
            currentIndex++;
          }
        }
      }else{
        SignalData[currentIndex] = data;
        currentIndex ++;
        currentIndex %= NumSample;
      }

      //逐次表示なう.　1描画ごとにするときはCurrentIndex == 0のifの中に．
      DataDrawAllow(this, EventArgs.Empty);
      DataSet(this, EventArgs.Empty);

      historyData = data;
    }
  }
}