using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetStandard
{
    public class DrawCircle
    {
        public int pt1x { get; set; }
        public int pt1y { get; set; }
        public int radius { get; set; } = 50;
        public int red { get; set; }
        public int green { get; set; }
        public int blue { get; set; }
        public int thickness { get; set; } = 1;
        public LineTypes types { get; set; } = LineTypes.Link4;
    }
}
