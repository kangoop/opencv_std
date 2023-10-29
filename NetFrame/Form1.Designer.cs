namespace NetFramework
{ 
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnInit = new System.Windows.Forms.Button();
            this.btnBasic = new System.Windows.Forms.Button();
            this.btnimgprocess = new System.Windows.Forms.Button();
            this.Test = new NetFrame.us_btn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip_Version = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip_Description = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnInit, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnBasic, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnimgprocess, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.Test, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(858, 517);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnInit
            // 
            this.btnInit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInit.Location = new System.Drawing.Point(3, 3);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(208, 123);
            this.btnInit.TabIndex = 1;
            this.btnInit.Text = "OpenCVInit";
            this.btnInit.UseVisualStyleBackColor = true;
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // btnBasic
            // 
            this.btnBasic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBasic.Location = new System.Drawing.Point(217, 3);
            this.btnBasic.Name = "btnBasic";
            this.btnBasic.Size = new System.Drawing.Size(208, 123);
            this.btnBasic.TabIndex = 2;
            this.btnBasic.Text = "OpenCVDraw";
            this.btnBasic.UseVisualStyleBackColor = true;
            this.btnBasic.Click += new System.EventHandler(this.btnBasic_Click);
            // 
            // btnimgprocess
            // 
            this.btnimgprocess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnimgprocess.Location = new System.Drawing.Point(431, 3);
            this.btnimgprocess.Name = "btnimgprocess";
            this.btnimgprocess.Size = new System.Drawing.Size(208, 123);
            this.btnimgprocess.TabIndex = 3;
            this.btnimgprocess.Text = "Imgprocess_basic";
            this.btnimgprocess.UseVisualStyleBackColor = true;
            this.btnimgprocess.Click += new System.EventHandler(this.btnimgprocess_Click);
            // 
            // Test
            // 
            this.Test.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Test.Location = new System.Drawing.Point(3, 390);
            this.Test.Name = "Test";
            this.Test.Size = new System.Drawing.Size(208, 124);
            this.Test.TabIndex = 4;
            this.Test.Text = "us_btn1";
            this.Test.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrip_Version,
            this.toolStrip_Description});
            this.statusStrip1.Location = new System.Drawing.Point(0, 491);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(858, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip_Version
            // 
            this.toolStrip_Version.Name = "toolStrip_Version";
            this.toolStrip_Version.Size = new System.Drawing.Size(152, 20);
            this.toolStrip_Version.Text = "toolStripStatusLabel1";
            // 
            // toolStrip_Description
            // 
            this.toolStrip_Description.Name = "toolStrip_Description";
            this.toolStrip_Description.Size = new System.Drawing.Size(152, 20);
            this.toolStrip_Description.Text = "toolStripStatusLabel1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 517);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStrip_Version;
        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.Button btnBasic;
        private System.Windows.Forms.Button btnimgprocess;
        private System.Windows.Forms.ToolStripStatusLabel toolStrip_Description;
        private NetFrame.us_btn Test;
    }
}

