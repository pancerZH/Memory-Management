namespace MemoryManagement
{
    partial class FormMain
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelControl = new System.Windows.Forms.Panel();
            this.buttonInit = new System.Windows.Forms.Button();
            this.radioLRU = new System.Windows.Forms.RadioButton();
            this.radioRand = new System.Windows.Forms.RadioButton();
            this.radioFIFO = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelPage4 = new System.Windows.Forms.Label();
            this.labelPage1 = new System.Windows.Forms.Label();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox0 = new System.Windows.Forms.ListBox();
            this.labelPage2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.labelPage3 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.labelEmpty = new System.Windows.Forms.Label();
            this.labelMissRate = new System.Windows.Forms.Label();
            this.labelMissTimes = new System.Windows.Forms.Label();
            this.labelAlgoName = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.labelOffsetContent = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelPageContent = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonConstant = new System.Windows.Forms.Button();
            this.buttonSingle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxTotal = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelControl.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelControl, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.listBoxTotal, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.77892F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.22108F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1390, 952);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(976, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(411, 63);
            this.label2.TabIndex = 4;
            this.label2.Text = "所有指令";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.buttonInit);
            this.panelControl.Controls.Add(this.radioLRU);
            this.panelControl.Controls.Add(this.radioRand);
            this.panelControl.Controls.Add(this.radioFIFO);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl.Location = new System.Drawing.Point(420, 3);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(550, 168);
            this.panelControl.TabIndex = 0;
            // 
            // buttonInit
            // 
            this.buttonInit.Location = new System.Drawing.Point(110, 87);
            this.buttonInit.Name = "buttonInit";
            this.buttonInit.Size = new System.Drawing.Size(332, 78);
            this.buttonInit.TabIndex = 3;
            this.buttonInit.Text = "新建";
            this.buttonInit.UseVisualStyleBackColor = true;
            this.buttonInit.Click += new System.EventHandler(this.buttonInit_Click);
            // 
            // radioLRU
            // 
            this.radioLRU.AutoSize = true;
            this.radioLRU.Location = new System.Drawing.Point(472, 35);
            this.radioLRU.Name = "radioLRU";
            this.radioLRU.Size = new System.Drawing.Size(77, 28);
            this.radioLRU.TabIndex = 2;
            this.radioLRU.TabStop = true;
            this.radioLRU.Text = "LRU";
            this.radioLRU.UseVisualStyleBackColor = true;
            this.radioLRU.CheckedChanged += new System.EventHandler(this.radioLRU_CheckedChanged);
            // 
            // radioRand
            // 
            this.radioRand.AutoSize = true;
            this.radioRand.Location = new System.Drawing.Point(237, 35);
            this.radioRand.Name = "radioRand";
            this.radioRand.Size = new System.Drawing.Size(89, 28);
            this.radioRand.TabIndex = 1;
            this.radioRand.TabStop = true;
            this.radioRand.Text = "Rand";
            this.radioRand.UseVisualStyleBackColor = true;
            this.radioRand.CheckedChanged += new System.EventHandler(this.radioRand_CheckedChanged);
            // 
            // radioFIFO
            // 
            this.radioFIFO.AutoSize = true;
            this.radioFIFO.Location = new System.Drawing.Point(2, 35);
            this.radioFIFO.Name = "radioFIFO";
            this.radioFIFO.Size = new System.Drawing.Size(89, 28);
            this.radioFIFO.TabIndex = 0;
            this.radioFIFO.TabStop = true;
            this.radioFIFO.Text = "FIFO";
            this.radioFIFO.UseVisualStyleBackColor = true;
            this.radioFIFO.CheckedChanged += new System.EventHandler(this.radioFIFO_CheckedChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.26277F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.73723F));
            this.tableLayoutPanel2.Controls.Add(this.labelPage4, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.labelPage1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.listBox3, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.listBox0, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelPage2, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.listBox1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelPage3, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.listBox2, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 177);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(411, 568);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // labelPage4
            // 
            this.labelPage4.Location = new System.Drawing.Point(299, 426);
            this.labelPage4.Name = "labelPage4";
            this.labelPage4.Size = new System.Drawing.Size(109, 127);
            this.labelPage4.TabIndex = 7;
            this.labelPage4.Text = "Page3";
            this.labelPage4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPage1
            // 
            this.labelPage1.Location = new System.Drawing.Point(299, 0);
            this.labelPage1.Name = "labelPage1";
            this.labelPage1.Size = new System.Drawing.Size(109, 128);
            this.labelPage1.TabIndex = 1;
            this.labelPage1.Text = "Page0";
            this.labelPage1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 24;
            this.listBox3.Location = new System.Drawing.Point(3, 429);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(290, 124);
            this.listBox3.TabIndex = 6;
            // 
            // listBox0
            // 
            this.listBox0.FormattingEnabled = true;
            this.listBox0.ItemHeight = 24;
            this.listBox0.Location = new System.Drawing.Point(3, 3);
            this.listBox0.Name = "listBox0";
            this.listBox0.Size = new System.Drawing.Size(290, 124);
            this.listBox0.TabIndex = 0;
            // 
            // labelPage2
            // 
            this.labelPage2.Location = new System.Drawing.Point(299, 142);
            this.labelPage2.Name = "labelPage2";
            this.labelPage2.Size = new System.Drawing.Size(109, 127);
            this.labelPage2.TabIndex = 3;
            this.labelPage2.Text = "Page1";
            this.labelPage2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(3, 145);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(290, 124);
            this.listBox1.TabIndex = 2;
            // 
            // labelPage3
            // 
            this.labelPage3.Location = new System.Drawing.Point(299, 284);
            this.labelPage3.Name = "labelPage3";
            this.labelPage3.Size = new System.Drawing.Size(109, 128);
            this.labelPage3.TabIndex = 5;
            this.labelPage3.Text = "Page2";
            this.labelPage3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 24;
            this.listBox2.Location = new System.Drawing.Point(3, 287);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(290, 124);
            this.listBox2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.Location = new System.Drawing.Point(3, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 63);
            this.label1.TabIndex = 3;
            this.label1.Text = "内存情况";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.labelEmpty, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.labelMissRate, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.labelMissTimes, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.labelAlgoName, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(420, 177);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(550, 568);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // labelEmpty
            // 
            this.labelEmpty.Location = new System.Drawing.Point(3, 426);
            this.labelEmpty.Name = "labelEmpty";
            this.labelEmpty.Size = new System.Drawing.Size(544, 129);
            this.labelEmpty.TabIndex = 3;
            this.labelEmpty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMissRate
            // 
            this.labelMissRate.Location = new System.Drawing.Point(3, 284);
            this.labelMissRate.Name = "labelMissRate";
            this.labelMissRate.Size = new System.Drawing.Size(544, 128);
            this.labelMissRate.TabIndex = 2;
            this.labelMissRate.Text = "缺页率=";
            this.labelMissRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMissTimes
            // 
            this.labelMissTimes.Location = new System.Drawing.Point(3, 142);
            this.labelMissTimes.Name = "labelMissTimes";
            this.labelMissTimes.Size = new System.Drawing.Size(544, 128);
            this.labelMissTimes.TabIndex = 1;
            this.labelMissTimes.Text = "缺页次数=";
            this.labelMissTimes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAlgoName
            // 
            this.labelAlgoName.Location = new System.Drawing.Point(3, 0);
            this.labelAlgoName.Name = "labelAlgoName";
            this.labelAlgoName.Size = new System.Drawing.Size(544, 128);
            this.labelAlgoName.TabIndex = 0;
            this.labelAlgoName.Text = "替换算法：";
            this.labelAlgoName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.labelOffsetContent, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.labelPageContent, 0, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 751);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(411, 198);
            this.tableLayoutPanel4.TabIndex = 7;
            // 
            // labelOffsetContent
            // 
            this.labelOffsetContent.Location = new System.Drawing.Point(3, 118);
            this.labelOffsetContent.Name = "labelOffsetContent";
            this.labelOffsetContent.Size = new System.Drawing.Size(405, 80);
            this.labelOffsetContent.TabIndex = 8;
            this.labelOffsetContent.Text = "偏移量：";
            this.labelOffsetContent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(405, 39);
            this.label3.TabIndex = 6;
            this.label3.Text = "当前指令位置";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPageContent
            // 
            this.labelPageContent.Location = new System.Drawing.Point(3, 39);
            this.labelPageContent.Name = "labelPageContent";
            this.labelPageContent.Size = new System.Drawing.Size(405, 79);
            this.labelPageContent.TabIndex = 7;
            this.labelPageContent.Text = "页：";
            this.labelPageContent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.buttonConstant, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.buttonSingle, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(420, 751);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(550, 198);
            this.tableLayoutPanel5.TabIndex = 8;
            // 
            // buttonConstant
            // 
            this.buttonConstant.Location = new System.Drawing.Point(278, 3);
            this.buttonConstant.Name = "buttonConstant";
            this.buttonConstant.Size = new System.Drawing.Size(269, 192);
            this.buttonConstant.TabIndex = 1;
            this.buttonConstant.Text = "执行到底";
            this.buttonConstant.UseVisualStyleBackColor = true;
            this.buttonConstant.Click += new System.EventHandler(this.buttonConstant_Click);
            // 
            // buttonSingle
            // 
            this.buttonSingle.Location = new System.Drawing.Point(3, 3);
            this.buttonSingle.Name = "buttonSingle";
            this.buttonSingle.Size = new System.Drawing.Size(269, 192);
            this.buttonSingle.TabIndex = 0;
            this.buttonSingle.Text = "单步";
            this.buttonSingle.UseVisualStyleBackColor = true;
            this.buttonSingle.Click += new System.EventHandler(this.buttonSingle_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(976, 748);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(411, 204);
            this.label4.TabIndex = 9;
            this.label4.Text = "Author：张文喆";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxTotal
            // 
            this.listBoxTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxTotal.FormattingEnabled = true;
            this.listBoxTotal.ItemHeight = 24;
            this.listBoxTotal.Location = new System.Drawing.Point(1054, 177);
            this.listBoxTotal.Name = "listBoxTotal";
            this.listBoxTotal.Size = new System.Drawing.Size(333, 556);
            this.listBoxTotal.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1390, 951);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormMain";
            this.Text = "内存管理模拟器";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.RadioButton radioLRU;
        private System.Windows.Forms.RadioButton radioRand;
        private System.Windows.Forms.RadioButton radioFIFO;
        private System.Windows.Forms.Button buttonInit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelPage4;
        private System.Windows.Forms.Label labelPage1;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox0;
        private System.Windows.Forms.Label labelPage2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label labelPage3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label labelEmpty;
        private System.Windows.Forms.Label labelMissRate;
        private System.Windows.Forms.Label labelMissTimes;
        private System.Windows.Forms.Label labelAlgoName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label labelOffsetContent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelPageContent;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button buttonConstant;
        private System.Windows.Forms.Button buttonSingle;
        private System.Windows.Forms.Label label4;
    }
}

