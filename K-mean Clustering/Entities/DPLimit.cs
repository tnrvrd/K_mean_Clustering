using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace K_mean_Clustering.Entities
{
    class DPLimit
    {
        public int XLimit { get; set; }
        public int YLimit { get; set; }
        public int XStart { get; set; }
        public int YStart { get; set; }

        public DPLimit(int xLimit, int yLimit, int xStart, int yStart)
        {
            XLimit = xLimit;
            YLimit = yLimit;
            XStart = xStart;
            YStart = yStart;
        }
    }
}
