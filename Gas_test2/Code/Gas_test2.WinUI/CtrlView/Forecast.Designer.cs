﻿namespace Gas_test2.WinUI.CtrlView
{
    partial class Forecast
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cbox1 = new System.Windows.Forms.ComboBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.btn_Err = new System.Windows.Forms.Button();
            this.btn_Para = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.zg1 = new ZedGraph.ZedGraphControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbCtrl = new System.Windows.Forms.TabControl();
            this.spCtn = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btn_FCST = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tbCtrl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spCtn)).BeginInit();
            this.spCtn.Panel1.SuspendLayout();
            this.spCtn.Panel2.SuspendLayout();
            this.spCtn.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbox1
            // 
            this.cbox1.FormattingEnabled = true;
            this.cbox1.Location = new System.Drawing.Point(22, 50);
            this.cbox1.Name = "cbox1";
            this.cbox1.Size = new System.Drawing.Size(121, 20);
            this.cbox1.TabIndex = 1;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(20, 16);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(53, 12);
            this.lbl3.TabIndex = 0;
            this.lbl3.Text = "设备号：";
            // 
            // btn_Err
            // 
            this.btn_Err.Location = new System.Drawing.Point(415, 58);
            this.btn_Err.Name = "btn_Err";
            this.btn_Err.Size = new System.Drawing.Size(153, 31);
            this.btn_Err.TabIndex = 9;
            this.btn_Err.Text = "历史误差";
            this.btn_Err.UseVisualStyleBackColor = true;
            this.btn_Err.Click += new System.EventHandler(this.btn_Err_Click);
            // 
            // btn_Para
            // 
            this.btn_Para.Location = new System.Drawing.Point(415, 4);
            this.btn_Para.Name = "btn_Para";
            this.btn_Para.Size = new System.Drawing.Size(153, 36);
            this.btn_Para.TabIndex = 8;
            this.btn_Para.Text = "参数设置";
            this.btn_Para.UseVisualStyleBackColor = true;
            this.btn_Para.Click += new System.EventHandler(this.btn_Para_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbox1);
            this.panel2.Controls.Add(this.lbl3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(151, 100);
            this.panel2.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(930, 321);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(936, 327);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "数据";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // zg1
            // 
            this.zg1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zg1.Location = new System.Drawing.Point(3, 3);
            this.zg1.Name = "zg1";
            this.zg1.ScrollGrace = 0D;
            this.zg1.ScrollMaxX = 0D;
            this.zg1.ScrollMaxY = 0D;
            this.zg1.ScrollMaxY2 = 0D;
            this.zg1.ScrollMinX = 0D;
            this.zg1.ScrollMinY = 0D;
            this.zg1.ScrollMinY2 = 0D;
            this.zg1.Size = new System.Drawing.Size(930, 321);
            this.zg1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.zg1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(936, 327);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "图表";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tbCtrl
            // 
            this.tbCtrl.Controls.Add(this.tabPage1);
            this.tbCtrl.Controls.Add(this.tabPage2);
            this.tbCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCtrl.Location = new System.Drawing.Point(0, 0);
            this.tbCtrl.Name = "tbCtrl";
            this.tbCtrl.SelectedIndex = 0;
            this.tbCtrl.Size = new System.Drawing.Size(944, 353);
            this.tbCtrl.TabIndex = 0;
            // 
            // spCtn
            // 
            this.spCtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spCtn.Location = new System.Drawing.Point(0, 0);
            this.spCtn.Name = "spCtn";
            this.spCtn.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spCtn.Panel1
            // 
            this.spCtn.Panel1.Controls.Add(this.tbCtrl);
            // 
            // spCtn.Panel2
            // 
            this.spCtn.Panel2.Controls.Add(this.panel1);
            this.spCtn.Panel2.Controls.Add(this.btn_Err);
            this.spCtn.Panel2.Controls.Add(this.btn_Para);
            this.spCtn.Panel2.Controls.Add(this.panel2);
            this.spCtn.Panel2.Controls.Add(this.btn_FCST);
            this.spCtn.Size = new System.Drawing.Size(944, 457);
            this.spCtn.SplitterDistance = 353;
            this.spCtn.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.lbl2);
            this.panel1.Controls.Add(this.lbl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(151, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 100);
            this.panel1.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(86, 50);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(112, 21);
            this.textBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(86, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(112, 21);
            this.textBox1.TabIndex = 8;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(14, 53);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(65, 12);
            this.lbl2.TabIndex = 7;
            this.lbl2.Text = "预测时长：";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(14, 16);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(65, 12);
            this.lbl1.TabIndex = 6;
            this.lbl1.Text = "当前时间：";
            // 
            // btn_FCST
            // 
            this.btn_FCST.Location = new System.Drawing.Point(598, 16);
            this.btn_FCST.Name = "btn_FCST";
            this.btn_FCST.Size = new System.Drawing.Size(126, 60);
            this.btn_FCST.TabIndex = 1;
            this.btn_FCST.Text = "预测";
            this.btn_FCST.UseVisualStyleBackColor = true;
            this.btn_FCST.Click += new System.EventHandler(this.btn_FCST_Click);
            // 
            // Forecast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.spCtn);
            this.Name = "Forecast";
            this.Size = new System.Drawing.Size(944, 457);
            this.Load += new System.EventHandler(this.Forecast_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tbCtrl.ResumeLayout(false);
            this.spCtn.Panel1.ResumeLayout(false);
            this.spCtn.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spCtn)).EndInit();
            this.spCtn.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox cbox1;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Button btn_Err;
        private System.Windows.Forms.Button btn_Para;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private ZedGraph.ZedGraphControl zg1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tbCtrl;
        private System.Windows.Forms.SplitContainer spCtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btn_FCST;
    }
}
