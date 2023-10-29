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

        public string Description
        {
            get
            {
                return $"{Math.Round((decimal)Environment.WorkingSet / 1000_000, 2)}MB";
            }
        }

        public Opencv_dev()
        {
            _Version = Cv2.GetVersionString();


            
        }


    }
}
