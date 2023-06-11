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

        private void thresholding_btn_Click(object sender, EventArgs e)
        {
            var img = picturebox_basic.Image.Clone();
            Mat mat = BitmapConverter.ToMat((Bitmap)img);

            Mat svc = mat.Clone();

            Cv2.Threshold(mat, svc, 127, 255, ThresholdTypes.Binary);
            //127 이하는 0 127  초과는 255 로 변경 
            /*
             * threshold_type : 다음 중 하나5임계값 작업.
             *   0: 이진수
                 1: 이진 반전
                 2: 임계값 잘림
                 3: 임계값을 0으로
                 4: 임계값을 0으로 반전됨
           */
            

            picturebox.Size = new System.Drawing.Size(mat.Width, mat.Height);

            picturebox.Image = svc.ToBitmap();
        }

        private void btn_thresholding_otsu_Click(object sender, EventArgs e)
        {
            if (this.us_btn1.OpenFileDialog() == true)
            {
                files = this.us_btn1.imgfiles;

                var mat = Cv2.ImRead(files[0], ImreadModes.Grayscale);


                Mat svc = mat.Clone();


                Cv2.Threshold(mat, svc,-1,-1,ThresholdTypes.Binary |ThresholdTypes.Otsu);

                
                picturebox_basic.Size = new System.Drawing.Size(mat.Width, mat.Height);

                picturebox_basic.Image = mat.ToBitmap();

                picturebox.Size = new System.Drawing.Size(mat.Width, mat.Height);

                picturebox.Image = svc.ToBitmap();

            }

        }

        private void btn_thresholding_apaptivethreshold_Click(object sender, EventArgs e)
        {
            if(this.btn_thresholding_apaptivethreshold.OpenFileDialog() == true)
            {
                files = this.btn_thresholding_apaptivethreshold.imgfiles;

                var mat = Cv2.ImRead(files[0], ImreadModes.Grayscale);

                picturebox_basic.Size = new System.Drawing.Size(mat.Width, mat.Height);

                picturebox_basic.Image = mat.ToBitmap();


                var svc = mat.Clone();
                var svc2 = mat.Clone();
                var svc3 = mat.Clone();


                Cv2.AdaptiveThreshold(mat, svc, 255, AdaptiveThresholdTypes.MeanC, ThresholdTypes.Binary,  5, 5);
                //픽셀의 임계값을 계산하는 데 사용되는 픽셀 이웃의 크기: 3, 5, 7 등.
                //평균 또는 가중 평균에서 상수를 뺍니다(아래 세부 정보 참조). 일반적으로 양수이지만 0 또는 음수일 수도 있습니다.

                picturebox.Size = new System.Drawing.Size(mat.Width, mat.Height);

                picturebox.Image = svc.ToBitmap();


                Cv2.Threshold(mat, svc2, 0, 255, ThresholdTypes.Binary |  ThresholdTypes.Otsu);

                picturebox_sub1.Size = new System.Drawing.Size(mat.Width, mat.Height);

                picturebox_sub1.Image = svc2.ToBitmap();

            }
        }
    }
}
