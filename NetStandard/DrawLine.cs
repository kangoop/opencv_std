using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetStandard
{
    public class DrawLine
    {
        public int pt1x { get; set; } 
        public int pt1y { get; set; }
        public int pt2x { get; set; }
        public int pt2y { get; set; }
        public int red  { get; set; }
        public int green { get; set; }
        public int blue  { get; set; }
        public int thickness { get; set; } = 1;
        public LineTypes types { get; set; } = LineTypes.Link4;
    }
}
