using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace K_mean_Clustering.Entities
{
    class Cluster
    {
        public int Number { get; set; }
        public int XPoint { get; set; }
        public int YPoint { get; set; }
        public Color ColorOfPoint { get; set; }

        public int XTotal { get; set; }
        public int YTotal { get; set; }
        public int TotalDataPoints { get; set; }

        public int OldXPoint { get; set; }
        public int OldYPoint { get; set; }
        public int OldTotalDataPoints { get; set; }

        public Cluster(int number, int xPoint, int yPoint, Color colorOfPoint)
        {
            Number = number;
            XPoint = xPoint;
            YPoint = yPoint;
            ColorOfPoint = colorOfPoint;

            XTotal = 0;
            YTotal = 0;
            TotalDataPoints = 0;
        }

        public void SetToDefaultTotal()
        {
            OldTotalDataPoints = TotalDataPoints;

            XTotal = 0;
            YTotal = 0;
            TotalDataPoints = 0;
        }

        public void setXPoint(int xPoint)
        {
            OldXPoint = XPoint;
            XPoint = xPoint;
        }

        public void setYPoint(int yPoint)
        {
            OldYPoint = YPoint;
            YPoint = yPoint;
        }
    }
}
