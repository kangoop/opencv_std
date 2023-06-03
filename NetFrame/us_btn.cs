using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace NetFrame
{
    [ToolboxItem(true)]
    public partial class us_btn : Button
    {
        public us_btn()
        {
            this.Size = new Size(100, 50);
            InitializeComponent();
        }

        public string[] imgfiles;


        public bool OpenFileDialog()
        {
            using (var opendialog= new OpenFileDialog())
            {

                opendialog.Filter= "(*.bmp;*.png;*.jpg;*.jpeg)|*.BMP;*.JPG;*.PNG;*.JPEG";
                opendialog.Multiselect = true;


                if(opendialog.ShowDialog()== DialogResult.OK)
                {
                    imgfiles = opendialog.FileNames;
                    return true;
                }
               
            }
            return false;
        }
    }
}
