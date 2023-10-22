using NetFrame;
using NetStandard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Opencv_dev opencv_Dev = new Opencv_dev();

            toolStrip_Version.Text = opencv_Dev.Version;
        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            try
            {
                var Form = new FormOpenCVInit();

                var dialogresult = Form.ShowDialog();
            }
            catch
            {

            }
        }

        private void btnBasic_Click(object sender, EventArgs e)
        {
            try
            {
                var Form = new FormOpenCVDraw();

                var dialogresult = Form.ShowDialog();
            }
            catch
            {

            }
        }

        private void btnimgprocess_Click(object sender, EventArgs e)
        {
            try
            {
                var Form = new FormOpenCVimgprocessbasic();

                var dialogresult = Form.ShowDialog();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
