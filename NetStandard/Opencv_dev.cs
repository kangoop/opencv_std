using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetStandard
{
    public class Opencv_dev
    {
        private string _Version;

        public string Version
        {
            get
            {
                return _Version;  
            }
        }

        public Opencv_dev()
        {
            _Version = Cv2.GetVersionString();

        }


    }
}
