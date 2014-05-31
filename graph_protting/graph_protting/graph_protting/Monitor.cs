using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace graph_protting
{
    public class Monitor
    {
        public int xAxisInterval;
        public int yAxisInterval;
        public int longDashInterval_X;
        public int longDashInterval_Y;

        public int Width;
        public int Height;

        public Monitor()
        {
            xAxisInterval = 5;
            yAxisInterval = 4;
            longDashInterval_X = 5;
            longDashInterval_Y = 5;
        }

        private void DrawSolidXAxis(Graphics graphics)
        {
            int x1, y1, x2, y2;
            x1 = 0;
            x2 = Width;
            y1 = y2 = Height / 2;
            var pen = new Pen(Color.Wheat);
            graphics.DrawLine(pen, new Point(x1, y1), new Point(x2, y2));

            const int lengthSmallDiv = 4;
            const int lengthSmallDivL = 8;
            for (int j = 0; j < 3; ++j)
            {
                for (int i = 0; i < 2 * longDashInterval_X * xAxisInterval + 1; ++i)
                {
                    if (i % longDashInterval_X == 0)
                    {
                        y1 = -lengthSmallDivL / 2 + j * Height / 2;
                        y2 = +lengthSmallDivL / 2 + j * Height / 2;
                    }
                    else
                    {
                        y1 = -lengthSmallDiv / 2 + j * Height / 2;
                        y2 = +lengthSmallDiv / 2 + j * Height / 2;
                    }
                    x1 = x2 = i * Width / (2 * longDashInterval_X * xAxisInterval);
                    graphics.DrawLine(pen, new Point(x1, y1), new Point(x2, y2));
                }
            }
        }

        private void DrawDotXAxis(Graphics graphics)
        {
            int x1, y1, x2, y2;
            x1 = 0;
            x2 = Width;
            var pen = new Pen(Color.Wheat);
            pen.DashPattern = new float[] { 1.0f, 7.0f };
            for (int i = 1; i < 2 * yAxisInterval; ++i)
            {
                y1 = y2 = i * Height / (2 * yAxisInterval);
                graphics.DrawLine(pen, new Point(x1, y1), new Point(x2, y2));
            }
        }

        private void DrawSolidYAxis(Graphics graphics)
        {
            int x1, y1, x2, y2;
            y1 = 0;
            y2 = Height;
            x1 = x2 = Width / 2;
            var pen = new Pen(Color.Wheat);
            graphics.DrawLine(pen, new Point(x1, y1), new Point(x2, y2));

            const int lengthSmallDiv = 4;
            const int lengthSmallDivL = 8;
            for (int j = 0; j < 3; ++j)
            {
                for (int i = 0; i < 2 * longDashInterval_Y * yAxisInterval + 1; ++i)
                {
                    if (i % 5 == 0)
                    {
                        x1 = -lengthSmallDivL / 2 + j * Width / 2;
                        x2 = +lengthSmallDivL / 2 + j * Width / 2;
                    }
                    else
                    {
                        x1 = -lengthSmallDiv / 2 + j * Width / 2;
                        x2 = +lengthSmallDiv / 2 + j * Width / 2;
                    }
                    y1 = y2 = i * Height / (2 * longDashInterval_Y * yAxisInterval);
                    graphics.DrawLine(pen, new Point(x1, y1), new Point(x2, y2));
                }
            }
        }
        
        private void DrawDotYAxis(Graphics graphics)
        {
            int x1, y1, x2, y2;
            y1 = 0;
            y2 = Height;
            var pen = new Pen(Color.Wheat);
            pen.DashPattern = new float[] { 1.0f, 7.0f };
            for (int i = 1; i < 2 * xAxisInterval; ++i)
            {
                x1 = x2 = i * Width / (2 * xAxisInterval);
                graphics.DrawLine(pen, new Point(x1, y1), new Point(x2, y2));
            }
        }

        public void DrawAxis(Graphics graphics)
        {
            DrawSolidXAxis(graphics);
            DrawDotXAxis(graphics);
            DrawSolidYAxis(graphics);
            DrawDotYAxis(graphics);
        }
    }
}
