namespace NetFrame
{
    partial class FormBasic
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_picturebox = new System.Windows.Forms.Panel();
            this.picturebox = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.tablepnl_main = new System.Windows.Forms.TableLayoutPanel();
            this.us_btn1 = new NetFrame.us_btn();
            this.us_btn2 = new NetFrame.us_btn();
            this.us_btn3 = new NetFrame.us_btn();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.pnl_picturebox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).BeginInit();
            this.tablepnl_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.us_btn1);
            this.flowLayoutPanel1.Controls.Add(this.us_btn2);
            this.flowLayoutPanel1.Controls.Add(this.us_btn3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1576, 58);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.pnl_picturebox, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBox1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 195);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1576, 623);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // pnl_picturebox
            // 
            this.pnl_picturebox.AutoScroll = true;
            this.pnl_picturebox.Controls.Add(this.picturebox);
            this.pnl_picturebox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_picturebox.Location = new System.Drawing.Point(3, 314);
            this.pnl_picturebox.Name = "pnl_picturebox";
            this.pnl_picturebox.Size = new System.Drawing.Size(1570, 306);
            this.pnl_picturebox.TabIndex = 0;
            this.pnl_picturebox.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_picturebox_Paint);
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
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1570, 305);
            this.textBox1.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 67);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1576, 58);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 131);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(1576, 58);
            this.flowLayoutPanel3.TabIndex = 3;
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
            this.tablepnl_main.TabIndex = 0;
            // 
            // us_btn1
            // 
            this.us_btn1.Location = new System.Drawing.Point(3, 3);
            this.us_btn1.Name = "us_btn1";
            this.us_btn1.Size = new System.Drawing.Size(100, 50);
            this.us_btn1.TabIndex = 0;
            this.us_btn1.Text = "us_btn1";
            this.us_btn1.UseVisualStyleBackColor = true;
            // 
            // us_btn2
            // 
            this.us_btn2.Location = new System.Drawing.Point(109, 3);
            this.us_btn2.Name = "us_btn2";
            this.us_btn2.Size = new System.Drawing.Size(100, 50);
            this.us_btn2.TabIndex = 1;
            this.us_btn2.Text = "us_btn2";
            this.us_btn2.UseVisualStyleBackColor = true;
            // 
            // us_btn3
            // 
            this.us_btn3.Location = new System.Drawing.Point(215, 3);
            this.us_btn3.Name = "us_btn3";
            this.us_btn3.Size = new System.Drawing.Size(100, 50);
            this.us_btn3.TabIndex = 2;
            this.us_btn3.Text = "us_btn3";
            this.us_btn3.UseVisualStyleBackColor = true;
            // 
            // FormBasic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.tablepnl_main);
            this.Name = "FormBasic";
            this.Text = "FormBasic";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.pnl_picturebox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).EndInit();
            this.tablepnl_main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel pnl_picturebox;
        private System.Windows.Forms.PictureBox picturebox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tablepnl_main;
        private us_btn us_btn1;
        private us_btn us_btn2;
        private us_btn us_btn3;
    }
}