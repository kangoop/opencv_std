using NetStandard;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
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


                Cv2.AdaptiveThreshold(mat, svc3, 255, AdaptiveThresholdTypes.GaussianC, ThresholdTypes.Binary, 9, 5);
                //픽셀의 임계값을 계산하는 데 사용되는 픽셀 이웃의 크기: 3, 5, 7 등.
                //평균 또는 가중 평균에서 상수를 뺍니다(아래 세부 정보 참조). 일반적으로 양수이지만 0 또는 음수일 수도 있습니다.

                picturebox_sub2.Size = new System.Drawing.Size(mat.Width, mat.Height);

                picturebox_sub2.Image = svc3.ToBitmap();

            }
        }

        private void us_btn_img_arithmentic_Click(object sender, EventArgs e)
        {
            var mata = new Mat(1, 1, MatType.CV_8UC1, new Scalar(50));
            var matb = new Mat(1, 1, MatType.CV_8UC1, new Scalar(100));
            

            var addmat= new Mat(1, 1, MatType.CV_8UC1);


                Cv2.Add(mata, matb, addmat);

            var add = $"{addmat.At<byte>(0,0)}\r\n";

            var substrmat = new Mat(1, 1, MatType.CV_8UC1);

                Cv2.Subtract(matb,mata, substrmat);

            var substr = $"{substrmat.At<byte>(0, 0)}\r\n";

            var multiplymat = new Mat(1, 1, MatType.CV_8UC1);

                Cv2.Multiply(mata, matb, multiplymat);

            var multiply = $"{multiplymat.At<byte>(0, 0)}\r\n";

            var dividemat = new Mat(1, 1, MatType.CV_8UC1);

                Cv2.Divide(matb,mata , dividemat);

            var divide = $"{dividemat.At<byte>(0, 0)}\r\n";

            label_value.Text = $"{mata.At<byte>(0, 0)},{matb.At<byte>(0, 0)}\r\n";
            label_value.Text += add;
            label_value.Text += substr;
            label_value.Text += multiply;
            label_value.Text += divide;

            mata = new Mat(1, 1, MatType.CV_8UC1, new Scalar(200));
            matb = new Mat(1, 1, MatType.CV_8UC1, new Scalar(100));


            addmat = new Mat(1, 1, MatType.CV_8UC1);

            Cv2.Add(mata, matb, addmat,mata);

            add = $"{addmat.At<byte>(0, 0)}\r\n";

            substrmat = new Mat(1, 1, MatType.CV_8UC1);

            Cv2.Subtract(matb, mata, substrmat);

            substr = $"{substrmat.At<byte>(0, 0)}\r\n";

            multiplymat = new Mat(1, 1, MatType.CV_8UC1);

            Cv2.Multiply(mata, matb, multiplymat);

            multiply = $"{multiplymat.At<byte>(0, 0)}\r\n";


            dividemat = new Mat(1, 1, MatType.CV_8UC1);

            Cv2.Divide(matb, mata, dividemat);

            divide = $"{dividemat.At<byte>(0, 0)}\r\n";

            label_value.Text += $"{mata.At<byte>(0, 0)},{matb.At<byte>(0, 0)}\r\n";
            label_value.Text += add;
            label_value.Text += substr;
            label_value.Text += multiply;
            label_value.Text += divide;

        }

        private void us_btn6_Click(object sender, EventArgs e)
        {
            string a_filepath,b_filepath;
            a_filepath = b_filepath = string.Empty;

            if (this.us_btn1.OpenFileDialog() == true)
            {
                a_filepath = this.us_btn1.imgfiles[0];
            }

            if (this.us_btn1.OpenFileDialog() == true)
            {
                b_filepath = this.us_btn1.imgfiles[0];
            }

            Mat img_a = Cv2.ImRead(a_filepath, ImreadModes.Unchanged);
            Mat img_b = Cv2.ImRead(b_filepath, ImreadModes.Unchanged);

            Mat img_add = new Mat(img_a.Width, img_a.Height, MatType.CV_8UC3);

            Cv2.Add(img_a, img_b,img_add);

            picturebox_basic.Size = new System.Drawing.Size(img_add.Width, img_add.Height);

            picturebox_basic.Image = img_add.ToBitmap();

            Mat img_alpha = new Mat(img_a.Width, img_a.Height, MatType.CV_8UC3);

            Cv2.AddWeighted(img_a,0.5,img_b,0.5,0,img_alpha);

            picturebox_sub1.Size = new System.Drawing.Size(img_add.Width, img_add.Height);

            picturebox_sub1.Image = img_alpha.ToBitmap();

        }

        private void us_btn7_Click(object sender, EventArgs e)
        {

            Mat img1 = new Mat(200, 400, MatType.CV_8UC1, new Scalar(255)); //height,width //검은색 값 0 흰색 값 255
            Mat img2 = new Mat(200, 400, MatType.CV_8UC1, new Scalar(0));

            for(int i = 0; i < img1.Rows; i++)
            {
               for(int j=0; j < img1.Cols; j++)
                {
                    if (j > 200)
                    {
                        img1.Set<byte>(i, j,0);
                    }

                    if (i > 100)
                    {
                        img2.Set<byte>(i, j, 255);
                    }

                }
            }

            Mat imgand = new Mat(200, 400, MatType.CV_8UC1);
            Cv2.BitwiseAnd(img1, img2, imgand);

            Mat imgor = new Mat(200, 400, MatType.CV_8UC1);
            Cv2.BitwiseOr(img1, img2, imgor);

            Mat imgxor= new Mat(200, 400, MatType.CV_8UC1);
            Cv2.BitwiseXor(img1, img2, imgxor);

            Mat imgnot = new Mat(200, 400, MatType.CV_8UC1);
            Cv2.BitwiseNot(img1, img2, imgnot);


            picturebox_basic.Size = new System.Drawing.Size(400, 200);
            picturebox_basic.Image = imgand.ToBitmap();


            picturebox_sub1.Size = new System.Drawing.Size(400, 200);
            picturebox_sub1.Image = imgor.ToBitmap();

            picturebox.Size = new System.Drawing.Size(400, 200);
            picturebox.Image = imgxor.ToBitmap();


            picturebox_sub2.Size = new System.Drawing.Size(400, 200);
            picturebox_sub2.Image = imgnot.ToBitmap();




        }

        private void us_btn8_Click(object sender, EventArgs e)
        {
            string a_filepath, b_filepath;
            a_filepath = b_filepath = string.Empty;

            if (this.us_btn8.OpenFileDialog() == true)
            {
                a_filepath = this.us_btn8.imgfiles[0];
            }

            if (this.us_btn8.OpenFileDialog() == true)
            {
                b_filepath = this.us_btn8.imgfiles[0];
            }


            Mat img_a = Cv2.ImRead(a_filepath);
            Mat img_b = Cv2.ImRead(b_filepath);

            Mat img_a_gray = img_a.CvtColor(ColorConversionCodes.RGB2GRAY, 1);
            Mat img_b_gray = img_b.CvtColor(ColorConversionCodes.RGB2GRAY, 1);

            Mat img_diff = new Mat(img_a.Rows, img_a.Cols, MatType.CV_8UC3);

            Cv2.Absdiff(img_a_gray,img_b_gray, img_diff);
            Cv2.Threshold(img_diff, img_diff, 1, 255, ThresholdTypes.Binary);

            picturebox_basic.Size = new System.Drawing.Size(img_a.Width,img_a.Height);
            picturebox_basic.Image = img_a.ToBitmap();


            List<errorpoint> errorpoints = new List<errorpoint>();
            for (int i = 0; i < img_diff.Rows; i++)
            {
                for (int j = 0; j < img_diff.Cols; j++)
                {
                    var onebyte = img_diff.Get<byte>(i, j);

                    if (onebyte==255)
                    {
                        errorpoints.Add(new errorpoint(i, j));
                    }
                }

            }


            Mat img_diff_color = img_diff.CvtColor(ColorConversionCodes.GRAY2RGB);

            picturebox.Size = new System.Drawing.Size(img_b.Width, img_b.Height);
            picturebox.Image = img_b.ToBitmap();

            Mat xor = new Mat(img_a.Rows, img_a.Cols, MatType.CV_8UC3);

            Cv2.BitwiseXor(img_b, img_diff_color, xor);

            foreach(var item in errorpoints)
            {
                xor.Set<Vec3b>(item.x,item.y, new Vec3b(0, 0, 255)); //opencv blue,green,red 
            }

            

            picturebox_sub1.Size = new System.Drawing.Size(xor.Width, xor.Height);
            picturebox_sub1.Image = xor.ToBitmap();
        }

        private void us_btn9_Click(object sender, EventArgs e)
        {
            string a_filepath, b_filepath;
            a_filepath = b_filepath = string.Empty;

            if (this.us_btn9.OpenFileDialog() == true)
            {
                a_filepath = this.us_btn9.imgfiles[0];
            }

            if (this.us_btn9.OpenFileDialog() == true)
            {
                b_filepath = this.us_btn9.imgfiles[0];
            }

            Mat img_fg = Cv2.ImRead(a_filepath,ImreadModes.Unchanged);

            Mat img_bg= Cv2.ImRead(b_filepath);

            picturebox_basic.Size = new System.Drawing.Size(img_fg.Width,img_fg.Height);
            picturebox_basic.Image = img_fg.ToBitmap();

            picturebox_sub1.Size = new System.Drawing.Size(img_bg.Width, img_bg.Height);
            picturebox_sub1.Image = img_bg.ToBitmap();





        }

    }

    public class errorpoint
    {
        public int x { get; set; }
        public int y { get; set; }

        public errorpoint()
        {
            
        }

        public errorpoint(int x,int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
