using NetStandard;
using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetFrame
{
    public partial class Popup : Form
    {
        private int _type;

        public Popup(int type=0)
        {
            _type = type;

            InitializeComponent();

            var linetypes = new OpenCvSharp.LineTypes();

            combox_linetype.DataSource =  Enum.GetValues(typeof(LineTypes));

            combox_linetype.SelectedIndex = 0;

            switch (type)
            {
                case 3:
                    var hersheyfont = new OpenCvSharp.HersheyFonts();

                    combox_hersheyfont.DataSource = Enum.GetValues(typeof(HersheyFonts));
                    combox_hersheyfont.SelectedIndex = 0;
                    break;
            }

            txtbox_thickness.Text = "1";
            txtbox_pt1.Text = "250,250";
            txtbox_color.Text = "255,0,0";
            txtbox_fontsize.Text= "1";
            txtbox_msg.Text = "Hello world";
        }

        public DrawLine drawline { get; set; }
        public DrawCircle drawcircle { get; set; }
        public DrawTxt DrawTxt { get; set; }

        public bool Cancle { get; set; } = true;

        private void btn_save_Click(object sender, EventArgs e)
        {
            switch (_type)
            {
                case 1: //rect
                    {
                        string[] pt1 = txtbox_pt1.Text.Split(',');
                        string[] pt2 = txtbox_pt2.Text.Split(',');
                        string[] color = txtbox_color.Text.Split(',');
                        string setthickness = txtbox_thickness.Text == string.Empty ? "1" : txtbox_thickness.Text;
                        var linetype = (LineTypes)combox_linetype.SelectedItem;

                        drawline = new DrawLine()
                        {
                            pt1x = Convert.ToInt32(pt1[0]),
                            pt1y = Convert.ToInt32(pt1[1]),
                            pt2x = Convert.ToInt32(pt2[0]),
                            pt2y = Convert.ToInt32(pt2[1]),
                            red = Convert.ToInt32(color[0]),
                            green = Convert.ToInt32(color[1]),
                            blue = Convert.ToInt32(color[2]),
                            thickness = Convert.ToInt32(setthickness),
                            types = linetype
                        };
                    }
                    break;

                case 2: //cricle
                    {
                        string[] pt1 = txtbox_pt1.Text.Split(',');
                        string[] color = txtbox_color.Text.Split(',');
                        string setthickness = txtbox_thickness.Text == string.Empty ? "1" : txtbox_thickness.Text;
                        var linetype = (LineTypes)combox_linetype.SelectedItem;
                        string setradius = txtbox_radius.Text;

                        drawcircle = new DrawCircle()
                        {
                            pt1x = Convert.ToInt32(pt1[0]),
                            pt1y = Convert.ToInt32(pt1[1]),
                            red = Convert.ToInt32(color[0]==string.Empty?"255": color[0]),
                            green = Convert.ToInt32(color[1] == string.Empty ? "255" : color[1]),
                            blue = Convert.ToInt32(color[2] == string.Empty ? "255" : color[2]),
                            thickness = Convert.ToInt32(setthickness),
                            types = linetype,
                            radius = Convert.ToInt32(setradius)
                        };
                    }
                    break;
                case 3: //txt draw
                    {
                        string[] pt1 = txtbox_pt1.Text.Split(',');
                        string[] color = txtbox_color.Text.Split(',');
                        string setthickness = txtbox_thickness.Text == string.Empty ? "1" : txtbox_thickness.Text;
                        var linetype = (LineTypes)combox_linetype.SelectedItem;
                        string fontsclae = txtbox_fontsize.Text;
                        var hersheyfont = (HersheyFonts)combox_hersheyfont.SelectedItem;

                        DrawTxt = new DrawTxt()
                        {
                            px = Convert.ToInt32(pt1[0]),
                            py = Convert.ToInt32(pt1[1]),
                            fontsize = double.Parse(fontsclae),
                            hersheyFonts = hersheyfont,
                            red = Convert.ToInt32(color[0] == string.Empty ? "255" : color[0]),
                            green = Convert.ToInt32(color[1] == string.Empty ? "255" : color[1]),
                            blue = Convert.ToInt32(color[2] == string.Empty ? "255" : color[2]),
                            thickness = Convert.ToInt32(setthickness),
                            types = linetype,
                            Txt = txtbox_msg.Text

                        };
                    }
                    break;
                default:
                    {
                        string[] pt1 = txtbox_pt1.Text.Split(',');
                        string[] pt2 = txtbox_pt2.Text.Split(',');
                        string[] color = txtbox_color.Text.Split(',');
                        string setthickness = txtbox_thickness.Text == string.Empty ? "1" : txtbox_thickness.Text;
                        var linetype = (LineTypes)combox_linetype.SelectedItem;

                        drawline = new DrawLine()
                        {
                            pt1x = Convert.ToInt32(pt1[0]),
                            pt1y = Convert.ToInt32(pt1[1]),
                            pt2x = Convert.ToInt32(pt2[0]),
                            pt2y = Convert.ToInt32(pt2[1]),
                            red = Convert.ToInt32(color[0]),
                            green = Convert.ToInt32(color[1]),
                            blue = Convert.ToInt32(color[2]),
                            thickness = Convert.ToInt32(setthickness),
                            types = linetype
                        };
                    }
                    break;
            }

            Cancle = true;


        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
