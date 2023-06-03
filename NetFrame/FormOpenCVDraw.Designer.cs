namespace NetFrame
{
    partial class FormOpenCVDraw
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
            this.tablepnl_main = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_txtset = new System.Windows.Forms.Button();
            this.btn_txtdraw = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_picturebox = new System.Windows.Forms.Panel();
            this.picturebox = new System.Windows.Forms.PictureBox();
            this.txtbox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_imgopen = new System.Windows.Forms.Button();
            this.btn_imgread = new System.Windows.Forms.Button();
            this.btn_lineset = new System.Windows.Forms.Button();
            this.btn_reactset = new System.Windows.Forms.Button();
            this.btn_circleset = new System.Windows.Forms.Button();
            this.btn_line = new System.Windows.Forms.Button();
            this.btn_rectdraw = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_circledraw = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.trackbarvalue = new System.Windows.Forms.ToolStripStatusLabel();
            this.tablepnl_main.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.pnl_picturebox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablepnl_main
            // 
            this.tablepnl_main.ColumnCount = 1;
            this.tablepnl_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablepnl_main.Controls.Add(this.flowLayoutPanel3, 0, 2);
            this.tablepnl_main.Controls.Add(this.flowLayoutPanel2, 0, 1);
            this.tablepnl_main.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.tablepnl_main.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tablepnl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablepnl_main.Location = new System.Drawing.Point(0, 0);
            this.tablepnl_main.Name = "tablepnl_main";
            this.tablepnl_main.RowCount = 5;
            this.tablepnl_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tablepnl_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tablepnl_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tablepnl_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablepnl_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tablepnl_main.Size = new System.Drawing.Size(1582, 853);
            this.tablepnl_main.TabIndex = 1;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel3.Controls.Add(this.trackBar);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 131);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(1576, 58);
            this.flowLayoutPanel3.TabIndex = 3;
            // 
            // trackBar
            // 
            this.trackBar.Location = new System.Drawing.Point(3, 3);
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(948, 56);
            this.trackBar.TabIndex = 0;
            this.trackBar.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel2.Controls.Add(this.btn_txtset);
            this.flowLayoutPanel2.Controls.Add(this.btn_txtdraw);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 67);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1576, 58);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // btn_txtset
            // 
            this.btn_txtset.Location = new System.Drawing.Point(3, 3);
            this.btn_txtset.Name = "btn_txtset";
            this.btn_txtset.Size = new System.Drawing.Size(100, 50);
            this.btn_txtset.TabIndex = 9;
            this.btn_txtset.Text = "txtset";
            this.btn_txtset.UseVisualStyleBackColor = true;
            this.btn_txtset.Click += new System.EventHandler(this.btn_txtset_Click);
            // 
            // btn_txtdraw
            // 
            this.btn_txtdraw.Location = new System.Drawing.Point(109, 3);
            this.btn_txtdraw.Name = "btn_txtdraw";
            this.btn_txtdraw.Size = new System.Drawing.Size(100, 50);
            this.btn_txtdraw.TabIndex = 10;
            this.btn_txtdraw.Text = "txtdraw";
            this.btn_txtdraw.UseVisualStyleBackColor = true;
            this.btn_txtdraw.Click += new System.EventHandler(this.btn_txtdraw_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.pnl_picturebox, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtbox, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 195);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1576, 623);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // pnl_picturebox
            // 
            this.pnl_picturebox.AutoScroll = true;
            this.pnl_picturebox.AutoSize = true;
            this.pnl_picturebox.Controls.Add(this.picturebox);
            this.pnl_picturebox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_picturebox.Location = new System.Drawing.Point(3, 65);
            this.pnl_picturebox.Name = "pnl_picturebox";
            this.pnl_picturebox.Size = new System.Drawing.Size(1570, 555);
            this.pnl_picturebox.TabIndex = 0;
            // 
            // picturebox
            // 
            this.picturebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picturebox.Location = new System.Drawing.Point(0, 0);
            this.picturebox.Name = "picturebox";
            this.picturebox.Size = new System.Drawing.Size(389, 198);
            this.picturebox.TabIndex = 0;
            this.picturebox.TabStop = false;
            // 
            // txtbox
            // 
            this.txtbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbox.Location = new System.Drawing.Point(3, 3);
            this.txtbox.Multiline = true;
            this.txtbox.Name = "txtbox";
            this.txtbox.Size = new System.Drawing.Size(1570, 56);
            this.txtbox.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.btn_imgopen);
            this.flowLayoutPanel1.Controls.Add(this.btn_imgread);
            this.flowLayoutPanel1.Controls.Add(this.btn_lineset);
            this.flowLayoutPanel1.Controls.Add(this.btn_reactset);
            this.flowLayoutPanel1.Controls.Add(this.btn_circleset);
            this.flowLayoutPanel1.Controls.Add(this.btn_line);
            this.flowLayoutPanel1.Controls.Add(this.btn_rectdraw);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.btn_circledraw);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1576, 58);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btn_imgopen
            // 
            this.btn_imgopen.Location = new System.Drawing.Point(3, 3);
            this.btn_imgopen.Name = "btn_imgopen";
            this.btn_imgopen.Size = new System.Drawing.Size(100, 50);
            this.btn_imgopen.TabIndex = 0;
            this.btn_imgopen.Text = "imgopen";
            this.btn_imgopen.UseVisualStyleBackColor = true;
            this.btn_imgopen.Click += new System.EventHandler(this.btn_imgRead_Click);
            // 
            // btn_imgread
            // 
            this.btn_imgread.Location = new System.Drawing.Point(109, 3);
            this.btn_imgread.Name = "btn_imgread";
            this.btn_imgread.Size = new System.Drawing.Size(100, 50);
            this.btn_imgread.TabIndex = 1;
            this.btn_imgread.Text = "imgread";
            this.btn_imgread.UseVisualStyleBackColor = true;
            this.btn_imgread.Click += new System.EventHandler(this.btn_imgOpen_Click);
            // 
            // btn_lineset
            // 
            this.btn_lineset.Location = new System.Drawing.Point(215, 3);
            this.btn_lineset.Name = "btn_lineset";
            this.btn_lineset.Size = new System.Drawing.Size(100, 50);
            this.btn_lineset.TabIndex = 3;
            this.btn_lineset.Text = "lineset";
            this.btn_lineset.UseVisualStyleBackColor = true;
            this.btn_lineset.Click += new System.EventHandler(this.btn_lineset_Click);
            // 
            // btn_reactset
            // 
            this.btn_reactset.Location = new System.Drawing.Point(321, 3);
            this.btn_reactset.Name = "btn_reactset";
            this.btn_reactset.Size = new System.Drawing.Size(100, 50);
            this.btn_reactset.TabIndex = 4;
            this.btn_reactset.Text = "rectset";
            this.btn_reactset.UseVisualStyleBackColor = true;
            this.btn_reactset.Click += new System.EventHandler(this.btn_reactset_Click);
            // 
            // btn_circleset
            // 
            this.btn_circleset.Location = new System.Drawing.Point(427, 3);
            this.btn_circleset.Name = "btn_circleset";
            this.btn_circleset.Size = new System.Drawing.Size(100, 50);
            this.btn_circleset.TabIndex = 7;
            this.btn_circleset.Text = "circleset";
            this.btn_circleset.UseVisualStyleBackColor = true;
            this.btn_circleset.Click += new System.EventHandler(this.btn_circleset_Click);
            // 
            // btn_line
            // 
            this.btn_line.Location = new System.Drawing.Point(533, 3);
            this.btn_line.Name = "btn_line";
            this.btn_line.Size = new System.Drawing.Size(100, 50);
            this.btn_line.TabIndex = 2;
            this.btn_line.Text = "linedraw";
            this.btn_line.UseVisualStyleBackColor = true;
            this.btn_line.Click += new System.EventHandler(this.btn_line_Click);
            // 
            // btn_rectdraw
            // 
            this.btn_rectdraw.Location = new System.Drawing.Point(639, 3);
            this.btn_rectdraw.Name = "btn_rectdraw";
            this.btn_rectdraw.Size = new System.Drawing.Size(100, 50);
            this.btn_rectdraw.TabIndex = 5;
            this.btn_rectdraw.Text = "rectdraw";
            this.btn_rectdraw.UseVisualStyleBackColor = true;
            this.btn_rectdraw.Click += new System.EventHandler(this.btn_rectdraw_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(745, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 50);
            this.button1.TabIndex = 6;
            this.button1.Text = "rectdraw(fill)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_circledraw
            // 
            this.btn_circledraw.Location = new System.Drawing.Point(851, 3);
            this.btn_circledraw.Name = "btn_circledraw";
            this.btn_circledraw.Size = new System.Drawing.Size(100, 50);
            this.btn_circledraw.TabIndex = 8;
            this.btn_circledraw.Text = "circledraw";
            this.btn_circledraw.UseVisualStyleBackColor = true;
            this.btn_circledraw.Click += new System.EventHandler(this.btn_circledraw_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trackbarvalue});
            this.statusStrip1.Location = new System.Drawing.Point(0, 827);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1582, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // trackbarvalue
            // 
            this.trackbarvalue.Name = "trackbarvalue";
            this.trackbarvalue.Size = new System.Drawing.Size(152, 20);
            this.trackbarvalue.Text = "toolStripStatusLabel1";
            // 
            // FormOpenCVDraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tablepnl_main);
            this.Name = "FormOpenCVDraw";
            this.Text = "FormOpenCVBasic";
            this.tablepnl_main.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.pnl_picturebox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tablepnl_main;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel pnl_picturebox;
        private System.Windows.Forms.PictureBox picturebox;
        private System.Windows.Forms.TextBox txtbox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_imgopen;
        private System.Windows.Forms.Button btn_imgread;
        private System.Windows.Forms.Button btn_line;
        private System.Windows.Forms.Button btn_lineset;
        private System.Windows.Forms.Button btn_reactset;
        private System.Windows.Forms.Button btn_rectdraw;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_circleset;
        private System.Windows.Forms.Button btn_circledraw;
        private System.Windows.Forms.Button btn_txtset;
        private System.Windows.Forms.Button btn_txtdraw;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel trackbarvalue;
    }
}