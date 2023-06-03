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
using cvPoint = OpenCvSharp.Point;


namespace NetFrame
{
    public partial class FormOpenCVDraw : Form
    {
        public FormOpenCVDraw()
        {
            InitializeComponent();

            trackBar.Minimum = 0;
            trackBar.Maximum = 100;
            trackBar.Value = 0;
            trackBar.TickFrequency = 5;
            trackbarvalue.Text = trackBar.Value.ToString();
        }

        private string img_files;
        private Mat line_img;
        private DrawLine drawline;
        private DrawCircle drawCircle;
        private DrawTxt drawtxt;

        private void btn_imgRead_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openfiledialog = new OpenFileDialog())
            {
                openfiledialog.Filter = "(*.bmp;*.png;*.jpg;*.jpeg)|*.BMP;*.JPG;*.PNG;*.JPEG";
                openfiledialog.Multiselect = false;

                if (openfiledialog.ShowDialog() == DialogResult.OK)
                {
                    img_files = openfiledialog.FileName;
                }
            }
        }

        private void btn_imgOpen_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(img_files))
            {
                line_img = new Mat(500, 500, MatType.CV_8UC3,new Scalar(255,255,255));

                picturebox.Size = new System.Drawing.Size(line_img.Width, line_img.Height);

                picturebox.Image = line_img.ToBitmap();
            }
            else
            {
                line_img = Cv2.ImRead(img_files);

                picturebox.Size = new System.Drawing.Size(line_img.Width, line_img.Height);

                picturebox.Image = line_img.ToBitmap();
            }

        }

        private void btn_line_Click(object sender, EventArgs e)
        {
            Cv2.Line(line_img, drawline.pt1x, drawline.pt1y, drawline.pt2x, drawline.pt2y,
                new Scalar(drawline.blue, drawline.green, drawline.red)
                , drawline.thickness,drawline.types);

            picturebox.Image = line_img.ToBitmap();
        }

        private void btn_lineset_Click(object sender, EventArgs e)
        {
            using (var popup = new Popup())
            {
                var result = popup.ShowDialog();

                drawline = popup.drawline;
            }
        }

        private void btn_reactset_Click(object sender, EventArgs e)
        {
            using(var popup = new Popup(1))
            {
                var result = popup.ShowDialog();

                drawline = popup.drawline;
            }
        }

        private void btn_circleset_Click(object sender, EventArgs e)
        {
            using (var popup = new Popup(2))
            {
                var result = popup.ShowDialog();

                drawCircle = popup.drawcircle;
            }
        }

        private void btn_txtset_Click(object sender, EventArgs e)
        {
            using (var popup = new Popup(3))
            {
                var result = popup.ShowDialog();

                drawtxt = popup.DrawTxt;
            }
        }

        private void btn_rectdraw_Click(object sender, EventArgs e)
        {          
            Cv2.Rectangle(line_img, new cvPoint( drawline.pt1x, drawline.pt1y),
                new cvPoint(drawline.pt2x, drawline.pt2y),
                new Scalar(drawline.blue, drawline.green, drawline.red)
                , drawline.thickness, drawline.types);

            picturebox.Image = line_img.ToBitmap();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cv2.Rectangle(line_img, new cvPoint(drawline.pt1x, drawline.pt1y),
                new cvPoint(drawline.pt2x, drawline.pt2y),
                new Scalar(drawline.blue, drawline.green, drawline.red)
                ,-1);

            picturebox.Image = line_img.ToBitmap();
        }


        private void btn_circledraw_Click(object sender, EventArgs e)
        {
            Cv2.Circle(line_img,new cvPoint(drawCircle.pt1x,drawCircle.pt1y),drawCircle.radius, new Scalar(drawCircle.blue, drawCircle.green, drawCircle.red)
                ,drawCircle.thickness, drawCircle.types);

            picturebox.Image = line_img.ToBitmap();
        }

        private void btn_txtdraw_Click(object sender, EventArgs e)
        {
            Cv2.PutText(line_img, string.IsNullOrEmpty(drawtxt.Txt) ? drawtxt.hersheyFonts.ToString(): drawtxt.Txt,
                new cvPoint(drawtxt.px, drawtxt.py), drawtxt.hersheyFonts, drawtxt.fontsize,
                new Scalar(drawtxt.blue, drawtxt.green, drawtxt.red), drawtxt.thickness, drawtxt.types);

            picturebox.Image = line_img.ToBitmap();
        }

        private void trackBar_ValueChanged(object sender, EventArgs e)
        {
            trackbarvalue.Text = $"trackBar Value :{trackBar.Value.ToString()}";
        }
    }
}
