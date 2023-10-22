using OpenCvSharp;
using OpenCvSharp.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using opencvsize = OpenCvSharp.Size;
using windowsize = System.Drawing.Size;

namespace NetFrame
{
    public partial class FormOpenCVInit : Form
    {
        public FormOpenCVInit()
        {
            InitializeComponent();
        }

        private string[] img_files;
        private string[] video_files;
  

        private void btnImgread_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openfiledialog = new OpenFileDialog())
            {
                openfiledialog.Filter = "(*.bmp;*.png;*.jpg;*.jpeg)|*.BMP;*.JPG;*.PNG;*.JPEG";
                openfiledialog.Multiselect = true;

                if(openfiledialog.ShowDialog() == DialogResult.OK)
                {
                    img_files = openfiledialog.FileNames;
                }
            }
        }

        private void btn_imgread_Click(object sender, EventArgs e)
        {
            var select_img = Cv2.ImRead(img_files[0], ImreadModes.Color);

            string txt = "";


            txt = $"Mat Cols:{select_img.Cols} Rows:{select_img.Rows}\r\n";

            //StringBuilder sb = new StringBuilder();

            //for(int i=0; i < select_img.Rows; i++)
            //{
            //    //var row = select_img.Get<Vec3b>(i,i);
            //    //sb.AppendLine(Cv2.Format(row, FormatType.CSV));

            //    for(int j=0; j < select_img.Cols; j++)
            //    {
            //        var col = select_img.Get<Vec3b>(i, j);
            //        sb.Append(Cv2.Format(col, FormatType.CSV));
            //    }

            //    sb.AppendLine();
            //}

            txtbox.Text = txt + select_img.ToString();

            Cv2.ImShow("SELECT IMG", select_img);

            picturebox.Image = select_img.ToBitmap();
        }


        private void btnInit_Click(object sender, EventArgs e)
        {
            var InitMat = new Mat(32, 32, MatType.CV_8UC3,new Scalar(0, 0, 255));

            string values = "";


            for(int i = 0; i < InitMat.Rows; i++)
            {
                int j = 0;
                var MatValues_Rows = InitMat.Get<Vec3b>(i);
                values += $"i : {i}, j : {j}\r\n";
                values += MatValues_Rows.Item0 + ", ";
                values += MatValues_Rows.Item1 + ", ";
                values += MatValues_Rows.Item2 + "\r\n";

                for (j = 1; j < InitMat.Cols; j++)
                {
                    var MatValues_Cols = InitMat.Get<Vec3b>(i,j);
                    values += $"i : {i}, j : {j}\r\n";
                    values += MatValues_Cols.Item0 + ", ";
                    values += MatValues_Cols.Item1 + ", ";
                    values += MatValues_Cols.Item2 + "\r\n";
                }
            }

            txtbox.Text = values;


            picturebox.Image = InitMat.ToBitmap();


            var Init2Mat = new Mat(32, 32, MatType.CV_8UC4, new Scalar(0,255,0,125));

            values = "\r\n 3Dims \r\n";


            for (int i = 0; i < Init2Mat.Rows; i++)
            {
                int j = 0;
                var MatValues_Rows = Init2Mat.Get<Vec4b>(i);
                values += $"i : {i}, j : {j}\r\n";
                values += MatValues_Rows.Item0 + ", ";
                values += MatValues_Rows.Item1 + ", ";
                values += MatValues_Rows.Item2 + ", ";
                values += MatValues_Rows.Item3 + "\r\n";

                for (j = 1; j < Init2Mat.Cols; j++)
                {
                    var MatValues_Cols = Init2Mat.Get<Vec4b>(i, j);
                    values += $"i : {i}, j : {j}\r\n";
                    values += MatValues_Cols.Item0 + ", ";
                    values += MatValues_Cols.Item1 + ", ";
                    values += MatValues_Cols.Item2 + ", ";
                    values += MatValues_Cols.Item3 + "\r\n";
                }
            }

            txtbox.Text += values;

            pictureBox1.Image = Init2Mat.ToBitmap();


            var Init3Mat = new Mat(32,32, MatType.CV_8UC3);

            Cv2.Randu(Init3Mat, new Scalar(0,0,0), new Scalar(255,255,255)); //랜덤으로 값을 생성 

            values = "\r\n Random \r\n";


            for (int i = 0; i < Init3Mat.Rows; i++)
            {
                int j = 0;
                var MatValues_Rows = Init3Mat.Get<Vec3b>(i);
                values += $"i : {i}, j : {j}\r\n";
                values += MatValues_Rows.Item0 + ", ";
                values += MatValues_Rows.Item1 + ", ";
                values += MatValues_Rows.Item2 + "\r\n";

                for (j = 1; j < Init3Mat.Cols; j++)
                {
                    var MatValues_Cols = Init3Mat.Get<Vec3b>(i, j);
                    values += $"i : {i}, j : {j}\r\n";
                    values += MatValues_Cols.Item0 + ", ";
                    values += MatValues_Cols.Item1 + ", ";
                    values += MatValues_Cols.Item2 + "\r\n";
                }
            }

            txtbox.Text += values;

            pictureBox2.Image = Init3Mat.ToBitmap();
        }

        private bool video_chk = true;
        private bool video_save = false;
        private bool capture_video = false;
        private string video_filessave_path = string.Empty;

        private VideoCapture video_capture;
        private VideoWriter video_write;

        private void btn_video_Click(object sender, EventArgs e)
        {
            video_capture = VideoCapture.FromCamera(1);

            txtbox.Text = $"Width  : {video_capture.Get(VideoCaptureProperties.FrameWidth)} Height : {video_capture.Get(VideoCaptureProperties.FrameHeight)}";


            picturebox.Width = (int)video_capture.Get(VideoCaptureProperties.FrameWidth);
            picturebox.Height  = (int)video_capture.Get(VideoCaptureProperties.FrameHeight);

            if (video_capture.Open(1))
            {
                toolstatus_label.Text = "Video OK";
            }
            else
            {
                toolstatus_label.Text = "Video Not";
            }


            Mat frame=new Mat();
            bool check = true;
            List<Mat> video_mat = new List<Mat>();
            while (check)
            {
                video_capture.Read(frame);

                //Cv2.ImShow("Live", frame);

                picturebox.Image = frame.ToBitmap();

                if (capture_video == true)
                {
                    bool savereuslt = Cv2.ImWrite($"{DateTime.Now.ToString("yyyy-MM-dd-hh시mm분ss초")}.png", frame, new ImageEncodingParam[] {
                        new ImageEncodingParam(ImwriteFlags.PngBilevel,0),
                        new ImageEncodingParam(ImwriteFlags.PngCompression,3),
                       });
                    capture_video = false;
                }

                Cv2.WaitKey(66); //fps 30 1000 / 지연시각(밀리s) 

                if (video_chk == false)
                {
                    break;
                }

                if (video_save == true)
                {
                    //if (video_write.IsOpened() == true)
                    //{
                        video_write.Write(frame);
                    //}
                    
                }

            }

            video_capture.Release();

            if (video_save == true)
            {
                video_write.Release();
            }


        }

        private void btn_videstop_Click(object sender, EventArgs e)
        {
            if (video_chk == true)
            {
                video_chk = false;
            }
            else
            {
                video_chk = true;
            }
        }

        private void btn_key_Click(object sender, EventArgs e)
        {
            Cv2.ImShow("Key Test", new Mat(100,100, MatType.CV_8UC3, new Scalar(0, 0, 255)));


            var key_value = Cv2.WaitKeyEx(1000);

            txtbox.Text = key_value.ToString();
        }

        private void btn_videsave_Click(object sender, EventArgs e)
        {

            if (video_save == true)
            {
                video_save = false;
            }
            else
            {

                video_write = new VideoWriter();
                bool wirte_result =video_write.Open($"{DateTime.Now.ToString("yyyy-MM-dd-hh시mm분ss초")}.avi", FourCC.XVID, 1000 / 66,
                        new opencvsize(640,480), true);
                //bool write_result = video_write.Open($"../../{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}.avi", FourCC.XVID, 1000 / 66,
                //        new opencvsize(video_capture.Get(VideoCaptureProperties.FrameWidth),
                //                        video_capture.Get(VideoCaptureProperties.FrameHeight)), true);

                //using (SaveFileDialog savefile = new SaveFileDialog())
                //{
                //    savefile.Filter = "files (*.*)|*.*";
                //    var dialogresult = savefile.ShowDialog();

                //    if (dialogresult == DialogResult.OK)
                //    {
                //        var filepath = savefile.FileName;
                //        video_filessave_path = filepath;
                //        video_write = new VideoWriter();
                //        bool write_result =  video_write.Open(video_filessave_path, FourCC.XVID, 1000/66 ,
                //                new opencvsize(video_capture.Get(VideoCaptureProperties.FrameWidth),
                //                                video_capture.Get(VideoCaptureProperties.FrameHeight)), true);

                //        video_save = true;
                //    }

                //}
            }
        }

        private void btn_capture_Click(object sender, EventArgs e)
        {
            if (capture_video == true)
            {
                capture_video = false;
            }
            else
            {
                capture_video = true;
            }
        }

        private void btn_colorspace_read_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openfiledialog = new OpenFileDialog())
            {
                openfiledialog.Filter = "(*.bmp;*.png;*.jpg;*.jpeg)|*.BMP;*.JPG;*.PNG;*.JPEG";
                openfiledialog.Multiselect = true;

                if (openfiledialog.ShowDialog() == DialogResult.OK)
                {
                    img_files = openfiledialog.FileNames;
                }
            }
        }

        private void btn_colorsclae_read_Click(object sender, EventArgs e)
        {
            var img =  Cv2.ImRead(img_files[0], ImreadModes.Color);

            var alpha = Cv2.ImRead(img_files[0], ImreadModes.Unchanged);

            txtbox.Text = string.Empty;

            txtbox.Text += $"{img.Rows},{img.Cols},{img.Channels()}\r\n";
            txtbox.Text += $"{alpha.Rows},{alpha.Cols},{alpha.Channels()}";

            picturebox.Width = img.Width;
            picturebox.Height = img.Height;

            picturebox.Image = img.ToBitmap();


        }

        private void btn_grayscale_Click(object sender, EventArgs e)
        {
            Mat grayscale = BitmapConverter.ToMat((Bitmap)picturebox.Image);

            picturebox.Image = grayscale.CvtColor(ColorConversionCodes.RGB2GRAY, 1).ToBitmap();
        }

        private void btn_rgbtohsv_Click(object sender, EventArgs e)
        {
            Mat red = new Mat(1, 1, MatType.CV_8UC3, Scalar.Red);
            Mat blue = new Mat(1, 1, MatType.CV_8UC3, Scalar.Blue);
            Mat green = new Mat(1, 1, MatType.CV_8UC3, Scalar.Green);
            Mat temp = new Mat(1, 1, MatType.CV_8UC3, Scalar.Yellow);


            var hsv_red = red.CvtColor(ColorConversionCodes.BGR2HSV);
            var hsv_blue = blue.CvtColor(ColorConversionCodes.BGR2HSV);
            var hsv_green = green.CvtColor(ColorConversionCodes.BGR2HSV);
            var hsv_temp = temp.CvtColor(ColorConversionCodes.BGR2HSV);

            txtbox.Text = string.Empty;
            txtbox.Text += $"HSV : \r\n";
            /*
             * HSV 색 공간 또는 HSV 모델은 색을 표현하는 하나의 방법이자, 그 방법에 따라 색을 배치하는 방식이다. 
             * 색상(Hue), 채도(Saturation), 명도(Value)의 좌표를 써서 특정한 색을 지정한다. 
             * 비슷한 것으로 HSL(Lightness), HSI(Intensity) 등이 있다.
             * 색상
이 부분의 본문은 색상입니다.
색상값 H는 가시광선 스펙트럼을 고리모양으로 배치한 색상환에서 가장 파장이 긴 빨강을 0°로 하였을 때 상대적인 배치 각도를 의미한다. 
 때문에 H 값은 0°~360°의 범위를 갖고 360°와 0°는 같은 색상 빨강을 가리킨다.
            --OpenCV 에서는 바이트 단위 값을 가지기 떄문에 180 을 넘는 경우에는 180을 가리킨다.
            빨강 : 165-180,0-15
            초록 : 45 ~ 75
            파랑 : 90 ~ 120

채도
 이 부분의 본문은 채도입니다.
채도값 S는 특정한 색상의 가장 진한 상태를 100%로 하였을 때 진함의 정도를 나타낸다. 채도값 0%는 같은 명도의 무채색을 나타낸다.
           255 일때 색상의 순수한 정도를 표현 

명도
이 부분의 본문은 명도입니다.
명도값 V는 흰색, 빨간색 등을 100%, 검은색을 0%로 하였을 때 밝은 정도를 나타낸다.
             0 어두운 상태 255 가장 밝은 상태 
             */

            txtbox.Text += $"{hsv_red.Get<Vec3b>(0).Item0},{hsv_red.Get<Vec3b>(0).Item1},{hsv_red.Get<Vec3b>(0).Item2}\r\n";
            txtbox.Text += $"{hsv_blue.Get<Vec3b>(0).Item0},{hsv_blue.Get<Vec3b>(0).Item1},{hsv_blue.Get<Vec3b>(0).Item2}\r\n";
            txtbox.Text += $"{hsv_green.Get<Vec3b>(0).Item0},{hsv_green.Get<Vec3b>(0).Item1},{hsv_green.Get<Vec3b>(0).Item2}\r\n";
            txtbox.Text += $"{hsv_temp.Get<Vec3b>(0).Item0},{hsv_temp.Get<Vec3b>(0).Item1},{hsv_temp.Get<Vec3b>(0).Item2}\r\n";


            txtbox.Text += "YUV\r\n";
            /* TV 방송에서 사용되어 왔습니다.
             * 사람이 색상을 인식할떄 밝기에 더 민감하고 색상은 상대적으로 둔감한점을 고려 
             * Y'UV 모델은 1개의 루마 컴포넌트(Y')와 2개의 색차 컴포넌트(각각 파랑의 U와 빨강의 V)의 용어를 아우르는 색 공간을 정의한다
             * luma라고도 하는 Y 구성 요소는 색의 밝기 값을 나타냅니다. 
             * Luma는 빨강, 녹색 및 파란색 구성 요소의 가중 평균을 사용하여 RGB 색에서 파생됩니다
             * 수식 : Y' = 0.299R + 0.587G + 0.114B 
             * 최근 고화질 텔레비전 Y' = 0.2125R + 0.7154G + 0.0721B
             * U = B - Y'
               V = R - Y'


             */

            Mat temp1 = new Mat(1, 1, MatType.CV_8UC3, new Scalar(0,0,0));
            Mat temp2 = new Mat(1, 1, MatType.CV_8UC3, new Scalar(127,127,127));
            Mat temp3 = new Mat(1, 1, MatType.CV_8UC3, new Scalar(255,255,255));

            var YUV_temp1 = temp1.CvtColor(ColorConversionCodes.BGR2YUV);
            var YUV_temp2 = temp2.CvtColor(ColorConversionCodes.BGR2YUV);
            var YUV_temp3 = temp3.CvtColor(ColorConversionCodes.BGR2YUV);

            txtbox.Text += $"{YUV_temp1.Get<Vec3b>(0).Item0},{YUV_temp1.Get<Vec3b>(0).Item1},{YUV_temp1.Get<Vec3b>(0).Item2}\r\n";
            txtbox.Text += $"{YUV_temp2.Get<Vec3b>(0).Item0},{YUV_temp2.Get<Vec3b>(0).Item1},{YUV_temp2.Get<Vec3b>(0).Item2}\r\n";
            txtbox.Text += $"{YUV_temp3.Get<Vec3b>(0).Item0},{YUV_temp3.Get<Vec3b>(0).Item1},{YUV_temp3.Get<Vec3b>(0).Item2}\r\n";
        }

        private void us_btn1_Click(object sender, EventArgs e)
        {
            Mat mat = Mat.Zeros(255,255, MatType.CV_8UC1); //grayscale 은 0 일때 흰색 255 흑색

            for(int i = 0; i < mat.Height; i++)
            {
                for(int j = 0; j < mat.Width; j++)
                {
                    if (i > 127)
                    {
                        mat.At<byte>(i,j) = byte.MaxValue;
                    }
                    
                }
            }

            picturebox.Size = new System.Drawing.Size(mat.Width, mat.Height);

            picturebox.Image = mat.ToBitmap();


        }
    }
}
