using NetFrame;
using NetStandard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetFramework
{
    public partial class Form1 : Form
    {
        Opencv_dev opencv_Dev;

        public Form1()
        {
            InitializeComponent();

            opencv_Dev = new Opencv_dev();

            toolStrip_Version.Text = opencv_Dev.Version;

            toolStrip_Description.Text = opencv_Dev.Description;

            
        }

        

        private void btnInit_Click(object sender, EventArgs e)
        {
            try
            {
                var Form = new FormOpenCVInit();

                var dialogresult = Form.ShowDialog();

                Utils.ParentFormWorkSetUpdate();
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

                Utils.ParentFormWorkSetUpdate();
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

                Utils.ParentFormWorkSetUpdate();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void WorkSetUpdate()
        {
            toolStrip_Description.Text = opencv_Dev.Description;
        }
    }
}
