using NetStandard;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using cvpoint = OpenCvSharp.Point;

namespace NetFrame
{
    public partial class FormOpenCVimgprocessbasic : Form
    {
        public FormOpenCVimgprocessbasic()
        {
            InitializeComponent();
        }


        private string[] files;

        private void us_btn1_Click(object sender, EventArgs e)
        {
            if (this.us_btn1.OpenFileDialog() == true)
            {
                files = this.us_btn1.imgfiles;
            }
        }


        //imgopen
        private void us_btn2_Click(object sender, EventArgs e)
        {
            var mat = Cv2.ImRead(files[0], ImreadModes.Unchanged);

            picturebox_basic.Size = new System.Drawing.Size(mat.Width, mat.Height);

            picturebox_basic.Image = mat.ToBitmap();
        }


        //ROI(region of interest)
        private void us_btn3_Click(object sender, EventArgs e)
        {
            var img = picturebox_basic.Image.Clone();

            Mat mat = BitmapConverter.ToMat((Bitmap)img);

            Cv2.Rectangle(mat, new cvpoint(320, 160), new cvpoint(370, 190), Scalar.Green, 3);

            picturebox.Size = new System.Drawing.Size(mat.Width, mat.Height);

            picturebox.Image = mat.ToBitmap();
        }


        //ROI만 자르기 
        private void us_btn4_Click(object sender, EventArgs e)
        {
            var img = picturebox_basic.Image.Clone();

            Mat mat = BitmapConverter.ToMat((Bitmap)img);

            Mat submat = mat.SubMat(160,190,320,370);//Cv2.Rectangle(mat, new OpenCvSharp.Point(320, 160), new OpenCvSharp.Point(370, 190), Scalar.Green, 3);

            picturebox.Size = new System.Drawing.Size(submat.Width, submat.Height);

            picturebox.Image = submat.ToBitmap();
        }

        private void us_btn5_Click(object sender, EventArgs e)
        {
            var mat = Cv2.ImRead(files[0], ImreadModes.Unchanged);
         
            Mat submat = mat.SubMat(160, 190, 320, 370);

            mat[160, 190, 370, 420] = submat.Clone(); //옆으로 복사 
            mat[130, 160, 320, 370] = submat.Clone(); //위으로 복사 

            picturebox.Size = new System.Drawing.Size(mat.Width, mat.Height);

            picturebox.Image = mat.ToBitmap();
        }

        private void picturebox_basic_MouseMove(object sender, MouseEventArgs e)
        {
            label_location.Text = Utils.ToStringPoint(Cursor.Position)+", ";
            label_location.Text += Utils.ToStringPoint((this.picturebox_basic.PointToClient(Cursor.Position)));
        }


    }
}
