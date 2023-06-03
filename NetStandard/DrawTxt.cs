using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetStandard
{
    public class DrawTxt
    {
        public string Txt { get; set; }
        public int px { get; set; }
        public int py { get; set; }        
        public HersheyFonts hersheyFonts { get; set; }
        public double fontsize { get; set; }
        public int red { get; set; }
        public int green { get; set; }
        public int blue { get; set; }
        public int thickness { get; set; } = 1;
        public LineTypes types { get; set; } = LineTypes.Link4;
    }
}
