namespace NetFrame
{
    partial class FormOpenCVInit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnInit = new System.Windows.Forms.Button();
            this.tablepnl_Main = new System.Windows.Forms.TableLayoutPanel();
            this.menu_flowpnl = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_imgopen = new System.Windows.Forms.Button();
            this.btn_imgread = new System.Windows.Forms.Button();
            this.btn_videoopen = new System.Windows.Forms.Button();
            this.btn_videoread = new System.Windows.Forms.Button();
            this.btn_videstart = new System.Windows.Forms.Button();
            this.btn_videstop = new System.Windows.Forms.Button();
            this.btn_key = new System.Windows.Forms.Button();
            this.btn_videsave = new System.Windows.Forms.Button();
            this.btn_capture = new System.Windows.Forms.Button();
            this.tablepnl_output = new System.Windows.Forms.TableLayoutPanel();
            this.txtbox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picturebox = new System.Windows.Forms.PictureBox();
            this.submenu_flowpnl = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_colorspace_read = new System.Windows.Forms.Button();
            this.btn_colorsclae_read = new System.Windows.Forms.Button();
            this.btn_grayscale = new System.Windows.Forms.Button();
            this.btn_rgbtohsv = new System.Windows.Forms.Button();
            this.us_btn1 = new NetFrame.us_btn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolstatus_label = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tablepnl_Main.SuspendLayout();
            this.menu_flowpnl.SuspendLayout();
            this.tablepnl_output.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).BeginInit();
            this.submenu_flowpnl.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInit
            // 
            this.btnInit.Location = new System.Drawing.Point(3, 3);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(100, 50);
            this.btnInit.TabIndex = 2;
            this.btnInit.Text = "btnInit";
            this.btnInit.UseVisualStyleBackColor = true;
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // tablepnl_Main
            // 
            this.tablepnl_Main.ColumnCount = 1;
            this.tablepnl_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablepnl_Main.Controls.Add(this.menu_flowpnl, 0, 0);
            this.tablepnl_Main.Controls.Add(this.tablepnl_output, 0, 2);
            this.tablepnl_Main.Controls.Add(this.submenu_flowpnl, 0, 1);
            this.tablepnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablepnl_Main.Location = new System.Drawing.Point(0, 0);
            this.tablepnl_Main.Name = "tablepnl_Main";
            this.tablepnl_Main.RowCount = 4;
            this.tablepnl_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tablepnl_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tablepnl_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablepnl_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tablepnl_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablepnl_Main.Size = new System.Drawing.Size(1582, 853);
            this.tablepnl_Main.TabIndex = 1;
            // 
            // menu_flowpnl
            // 
            this.menu_flowpnl.Controls.Add(this.btnInit);
            this.menu_flowpnl.Controls.Add(this.btn_imgopen);
            this.menu_flowpnl.Controls.Add(this.btn_imgread);
            this.menu_flowpnl.Controls.Add(this.btn_videoopen);
            this.menu_flowpnl.Controls.Add(this.btn_videoread);
            this.menu_flowpnl.Controls.Add(this.btn_videstart);
            this.menu_flowpnl.Controls.Add(this.btn_videstop);
            this.menu_flowpnl.Controls.Add(this.btn_key);
            this.menu_flowpnl.Controls.Add(this.btn_videsave);
            this.menu_flowpnl.Controls.Add(this.btn_capture);
            this.menu_flowpnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu_flowpnl.Location = new System.Drawing.Point(0, 0);
            this.menu_flowpnl.Margin = new System.Windows.Forms.Padding(0);
            this.menu_flowpnl.Name = "menu_flowpnl";
            this.menu_flowpnl.Size = new System.Drawing.Size(1582, 64);
            this.menu_flowpnl.TabIndex = 0;
            // 
            // btn_imgopen
            // 
            this.btn_imgopen.Location = new System.Drawing.Point(109, 3);
            this.btn_imgopen.Name = "btn_imgopen";
            this.btn_imgopen.Size = new System.Drawing.Size(100, 50);
            this.btn_imgopen.TabIndex = 0;
            this.btn_imgopen.Text = "Img_open";
            this.btn_imgopen.UseVisualStyleBackColor = true;
            this.btn_imgopen.Click += new System.EventHandler(this.btnImgread_Click);
            // 
            // btn_imgread
            // 
            this.btn_imgread.Location = new System.Drawing.Point(215, 3);
            this.btn_imgread.Name = "btn_imgread";
            this.btn_imgread.Size = new System.Drawing.Size(100, 50);
            this.btn_imgread.TabIndex = 3;
            this.btn_imgread.Text = "Img_read";
            this.btn_imgread.UseVisualStyleBackColor = true;
            this.btn_imgread.Click += new System.EventHandler(this.btn_imgread_Click);
            // 
            // btn_videoopen
            // 
            this.btn_videoopen.Location = new System.Drawing.Point(321, 3);
            this.btn_videoopen.Name = "btn_videoopen";
            this.btn_videoopen.Size = new System.Drawing.Size(100, 50);
            this.btn_videoopen.TabIndex = 4;
            this.btn_videoopen.Text = "video_open";
            this.btn_videoopen.UseVisualStyleBackColor = true;
            // 
            // btn_videoread
            // 
            this.btn_videoread.Location = new System.Drawing.Point(427, 3);
            this.btn_videoread.Name = "btn_videoread";
            this.btn_videoread.Size = new System.Drawing.Size(100, 50);
            this.btn_videoread.TabIndex = 5;
            this.btn_videoread.Text = "video_read";
            this.btn_videoread.UseVisualStyleBackColor = true;
            // 
            // btn_videstart
            // 
            this.btn_videstart.Location = new System.Drawing.Point(533, 3);
            this.btn_videstart.Name = "btn_videstart";
            this.btn_videstart.Size = new System.Drawing.Size(100, 50);
            this.btn_videstart.TabIndex = 6;
            this.btn_videstart.Text = "video";
            this.btn_videstart.UseVisualStyleBackColor = true;
            this.btn_videstart.Click += new System.EventHandler(this.btn_video_Click);
            // 
            // btn_videstop
            // 
            this.btn_videstop.Location = new System.Drawing.Point(639, 3);
            this.btn_videstop.Name = "btn_videstop";
            this.btn_videstop.Size = new System.Drawing.Size(100, 50);
            this.btn_videstop.TabIndex = 8;
            this.btn_videstop.Text = "videostop";
            this.btn_videstop.UseVisualStyleBackColor = true;
            this.btn_videstop.Click += new System.EventHandler(this.btn_videstop_Click);
            // 
            // btn_key
            // 
            this.btn_key.Location = new System.Drawing.Point(745, 3);
            this.btn_key.Name = "btn_key";
            this.btn_key.Size = new System.Drawing.Size(100, 50);
            this.btn_key.TabIndex = 7;
            this.btn_key.Text = "key";
            this.btn_key.UseVisualStyleBackColor = true;
            this.btn_key.Click += new System.EventHandler(this.btn_key_Click);
            // 
            // btn_videsave
            // 
            this.btn_videsave.Location = new System.Drawing.Point(851, 3);
            this.btn_videsave.Name = "btn_videsave";
            this.btn_videsave.Size = new System.Drawing.Size(100, 50);
            this.btn_videsave.TabIndex = 9;
            this.btn_videsave.Text = "videosave";
            this.btn_videsave.UseVisualStyleBackColor = true;
            this.btn_videsave.Click += new System.EventHandler(this.btn_videsave_Click);
            // 
            // btn_capture
            // 
            this.btn_capture.Location = new System.Drawing.Point(957, 3);
            this.btn_capture.Name = "btn_capture";
            this.btn_capture.Size = new System.Drawing.Size(100, 50);
            this.btn_capture.TabIndex = 10;
            this.btn_capture.Text = "videocapture";
            this.btn_capture.UseVisualStyleBackColor = true;
            this.btn_capture.Click += new System.EventHandler(this.btn_capture_Click);
            // 
            // tablepnl_output
            // 
            this.tablepnl_output.AutoScroll = true;
            this.tablepnl_output.ColumnCount = 1;
            this.tablepnl_output.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablepnl_output.Controls.Add(this.panel3, 0, 3);
            this.tablepnl_output.Controls.Add(this.txtbox, 0, 0);
            this.tablepnl_output.Controls.Add(this.panel1, 0, 1);
            this.tablepnl_output.Controls.Add(this.panel2, 0, 2);
            this.tablepnl_output.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablepnl_output.Location = new System.Drawing.Point(3, 131);
            this.tablepnl_output.Name = "tablepnl_output";
            this.tablepnl_output.RowCount = 4;
            this.tablepnl_output.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tablepnl_output.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tablepnl_output.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tablepnl_output.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tablepnl_output.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablepnl_output.Size = new System.Drawing.Size(1576, 687);
            this.tablepnl_output.TabIndex = 1;
            // 
            // txtbox
            // 
            this.txtbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbox.Location = new System.Drawing.Point(3, 3);
            this.txtbox.Multiline = true;
            this.txtbox.Name = "txtbox";
            this.txtbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbox.Size = new System.Drawing.Size(1570, 94);
            this.txtbox.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.picturebox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1570, 189);
            this.panel1.TabIndex = 2;
            // 
            // picturebox
            // 
            this.picturebox.Location = new System.Drawing.Point(0, 0);
            this.picturebox.Name = "picturebox";
            this.picturebox.Size = new System.Drawing.Size(100, 100);
            this.picturebox.TabIndex = 1;
            this.picturebox.TabStop = false;
            // 
            // submenu_flowpnl
            // 
            this.submenu_flowpnl.Controls.Add(this.btn_colorspace_read);
            this.submenu_flowpnl.Controls.Add(this.btn_colorsclae_read);
            this.submenu_flowpnl.Controls.Add(this.btn_grayscale);
            this.submenu_flowpnl.Controls.Add(this.btn_rgbtohsv);
            this.submenu_flowpnl.Controls.Add(this.us_btn1);
            this.submenu_flowpnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.submenu_flowpnl.Location = new System.Drawing.Point(3, 67);
            this.submenu_flowpnl.Name = "submenu_flowpnl";
            this.submenu_flowpnl.Size = new System.Drawing.Size(1576, 58);
            this.submenu_flowpnl.TabIndex = 2;
            // 
            // btn_colorspace_read
            // 
            this.btn_colorspace_read.Location = new System.Drawing.Point(3, 3);
            this.btn_colorspace_read.Name = "btn_colorspace_read";
            this.btn_colorspace_read.Size = new System.Drawing.Size(200, 50);
            this.btn_colorspace_read.TabIndex = 1;
            this.btn_colorspace_read.Text = "colorsclae_open";
            this.btn_colorspace_read.UseVisualStyleBackColor = true;
            this.btn_colorspace_read.Click += new System.EventHandler(this.btn_colorspace_read_Click);
            // 
            // btn_colorsclae_read
            // 
            this.btn_colorsclae_read.Location = new System.Drawing.Point(209, 3);
            this.btn_colorsclae_read.Name = "btn_colorsclae_read";
            this.btn_colorsclae_read.Size = new System.Drawing.Size(100, 50);
            this.btn_colorsclae_read.TabIndex = 4;
            this.btn_colorsclae_read.Text = "read";
            this.btn_colorsclae_read.UseVisualStyleBackColor = true;
            this.btn_colorsclae_read.Click += new System.EventHandler(this.btn_colorsclae_read_Click);
            // 
            // btn_grayscale
            // 
            this.btn_grayscale.Location = new System.Drawing.Point(315, 3);
            this.btn_grayscale.Name = "btn_grayscale";
            this.btn_grayscale.Size = new System.Drawing.Size(100, 50);
            this.btn_grayscale.TabIndex = 5;
            this.btn_grayscale.Text = "grayscale";
            this.btn_grayscale.UseVisualStyleBackColor = true;
            this.btn_grayscale.Click += new System.EventHandler(this.btn_grayscale_Click);
            // 
            // btn_rgbtohsv
            // 
            this.btn_rgbtohsv.Location = new System.Drawing.Point(421, 3);
            this.btn_rgbtohsv.Name = "btn_rgbtohsv";
            this.btn_rgbtohsv.Size = new System.Drawing.Size(100, 50);
            this.btn_rgbtohsv.TabIndex = 6;
            this.btn_rgbtohsv.Text = "bgrtohsv";
            this.btn_rgbtohsv.UseVisualStyleBackColor = true;
            this.btn_rgbtohsv.Click += new System.EventHandler(this.btn_rgbtohsv_Click);
            // 
            // us_btn1
            // 
            this.us_btn1.Location = new System.Drawing.Point(527, 3);
            this.us_btn1.Name = "us_btn1";
            this.us_btn1.Size = new System.Drawing.Size(100, 50);
            this.us_btn1.TabIndex = 7;
            this.us_btn1.Text = "create_grayscale";
            this.us_btn1.UseVisualStyleBackColor = true;
            this.us_btn1.Click += new System.EventHandler(this.us_btn1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstatus_label});
            this.statusStrip1.Location = new System.Drawing.Point(0, 827);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1582, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolstatus_label
            // 
            this.toolstatus_label.Name = "toolstatus_label";
            this.toolstatus_label.Size = new System.Drawing.Size(75, 20);
            this.toolstatus_label.Text = "tool_label";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 298);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1570, 189);
            this.panel2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 493);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1570, 191);
            this.panel3.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // FormOpenCVInit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tablepnl_Main);
            this.Name = "FormOpenCVInit";
            this.Text = "OpenCVInit";
            this.tablepnl_Main.ResumeLayout(false);
            this.menu_flowpnl.ResumeLayout(false);
            this.tablepnl_output.ResumeLayout(false);
            this.tablepnl_output.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).EndInit();
            this.submenu_flowpnl.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.TableLayoutPanel tablepnl_Main;
        private System.Windows.Forms.FlowLayoutPanel menu_flowpnl;
        private System.Windows.Forms.Button btn_imgopen;
        private System.Windows.Forms.TableLayoutPanel tablepnl_output;
        private System.Windows.Forms.TextBox txtbox;
        private System.Windows.Forms.Button btn_imgread;
        private System.Windows.Forms.PictureBox picturebox;
        private System.Windows.Forms.Button btn_videoopen;
        private System.Windows.Forms.Button btn_videoread;
        private System.Windows.Forms.Button btn_videstart;
        private System.Windows.Forms.Button btn_key;
        private System.Windows.Forms.Button btn_videstop;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolstatus_label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_videsave;
        private System.Windows.Forms.Button btn_capture;
        private System.Windows.Forms.FlowLayoutPanel submenu_flowpnl;
        private System.Windows.Forms.Button btn_colorspace_read;
        private System.Windows.Forms.Button btn_colorsclae_read;
        private System.Windows.Forms.Button btn_grayscale;
        private System.Windows.Forms.Button btn_rgbtohsv;
        private us_btn us_btn1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}