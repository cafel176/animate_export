﻿namespace animate_export
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.step1 = new System.Windows.Forms.Panel();
            this.selectFileLabel = new System.Windows.Forms.Label();
            this.selectFile = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.prevButton = new System.Windows.Forms.Button();
            this.step1Label = new System.Windows.Forms.Label();
            this.step2Label = new System.Windows.Forms.Label();
            this.step3Label = new System.Windows.Forms.Label();
            this.step4Label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.step2 = new System.Windows.Forms.Panel();
            this.listView = new System.Windows.Forms.ListView();
            this.listHeader0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.step3 = new System.Windows.Forms.Panel();
            this.canvas = new System.Windows.Forms.PictureBox();
            this.step4 = new System.Windows.Forms.Panel();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.exportButton = new System.Windows.Forms.Button();
            this.nextAnimaButton = new System.Windows.Forms.Button();
            this.lastAnimaButton = new System.Windows.Forms.Button();
            this.animaName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.step1.SuspendLayout();
            this.step2.SuspendLayout();
            this.step3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.step4.SuspendLayout();
            this.SuspendLayout();
            // 
            // step1
            // 
            this.step1.Controls.Add(this.selectFileLabel);
            this.step1.Controls.Add(this.selectFile);
            this.step1.Location = new System.Drawing.Point(36, 69);
            this.step1.Margin = new System.Windows.Forms.Padding(4);
            this.step1.Name = "step1";
            this.step1.Size = new System.Drawing.Size(429, 276);
            this.step1.TabIndex = 0;
            // 
            // selectFileLabel
            // 
            this.selectFileLabel.AutoEllipsis = true;
            this.selectFileLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.selectFileLabel.Location = new System.Drawing.Point(4, 139);
            this.selectFileLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.selectFileLabel.Name = "selectFileLabel";
            this.selectFileLabel.Size = new System.Drawing.Size(421, 29);
            this.selectFileLabel.TabIndex = 3;
            this.selectFileLabel.Text = "请选择一个Animations.rxdata文件";
            this.selectFileLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // selectFile
            // 
            this.selectFile.Location = new System.Drawing.Point(164, 86);
            this.selectFile.Margin = new System.Windows.Forms.Padding(4);
            this.selectFile.Name = "selectFile";
            this.selectFile.Size = new System.Drawing.Size(101, 34);
            this.selectFile.TabIndex = 0;
            this.selectFile.Text = "选择文件";
            this.selectFile.UseVisualStyleBackColor = true;
            this.selectFile.Click += new System.EventHandler(this.selectFile_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(365, 397);
            this.nextButton.Margin = new System.Windows.Forms.Padding(4);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(100, 29);
            this.nextButton.TabIndex = 2;
            this.nextButton.Text = "下一步";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // prevButton
            // 
            this.prevButton.Location = new System.Drawing.Point(36, 397);
            this.prevButton.Margin = new System.Windows.Forms.Padding(4);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(100, 29);
            this.prevButton.TabIndex = 1;
            this.prevButton.Text = "上一步";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
            // 
            // step1Label
            // 
            this.step1Label.AutoSize = true;
            this.step1Label.Location = new System.Drawing.Point(35, 35);
            this.step1Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.step1Label.Name = "step1Label";
            this.step1Label.Size = new System.Drawing.Size(67, 15);
            this.step1Label.TabIndex = 1;
            this.step1Label.Text = "选择文件";
            // 
            // step2Label
            // 
            this.step2Label.AutoSize = true;
            this.step2Label.Location = new System.Drawing.Point(155, 35);
            this.step2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.step2Label.Name = "step2Label";
            this.step2Label.Size = new System.Drawing.Size(67, 15);
            this.step2Label.TabIndex = 2;
            this.step2Label.Text = "选择动画";
            // 
            // step3Label
            // 
            this.step3Label.AutoSize = true;
            this.step3Label.Location = new System.Drawing.Point(275, 35);
            this.step3Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.step3Label.Name = "step3Label";
            this.step3Label.Size = new System.Drawing.Size(67, 15);
            this.step3Label.TabIndex = 3;
            this.step3Label.Text = "预览效果";
            // 
            // step4Label
            // 
            this.step4Label.AutoSize = true;
            this.step4Label.Location = new System.Drawing.Point(395, 35);
            this.step4Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.step4Label.Name = "step4Label";
            this.step4Label.Size = new System.Drawing.Size(67, 15);
            this.step4Label.TabIndex = 4;
            this.step4Label.Text = "导出动画";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(119, 35);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "→";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(239, 35);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "→";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(359, 35);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "→";
            // 
            // step2
            // 
            this.step2.Controls.Add(this.listView);
            this.step2.Location = new System.Drawing.Point(36, 69);
            this.step2.Margin = new System.Windows.Forms.Padding(4);
            this.step2.Name = "step2";
            this.step2.Size = new System.Drawing.Size(429, 276);
            this.step2.TabIndex = 4;
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.listHeader0,
            this.listHeader1,
            this.listHeader2,
            this.listHeader3});
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.FullRowSelect = true;
            this.listView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView.HideSelection = false;
            this.listView.LabelWrap = false;
            this.listView.Location = new System.Drawing.Point(0, 0);
            this.listView.Margin = new System.Windows.Forms.Padding(4);
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.ShowGroups = false;
            this.listView.Size = new System.Drawing.Size(429, 276);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // listHeader0
            // 
            this.listHeader0.Text = "编号";
            this.listHeader0.Width = 43;
            // 
            // listHeader1
            // 
            this.listHeader1.Text = "名称";
            this.listHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.listHeader1.Width = 100;
            // 
            // listHeader2
            // 
            this.listHeader2.Text = "文件名";
            this.listHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.listHeader2.Width = 100;
            // 
            // listHeader3
            // 
            this.listHeader3.Text = "帧数";
            this.listHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.listHeader3.Width = 55;
            // 
            // step3
            // 
            this.step3.BackgroundImage = global::animate_export.Properties.Resources.bg;
            this.step3.Controls.Add(this.canvas);
            this.step3.Location = new System.Drawing.Point(36, 69);
            this.step3.Margin = new System.Windows.Forms.Padding(4);
            this.step3.Name = "step3";
            this.step3.Size = new System.Drawing.Size(429, 276);
            this.step3.TabIndex = 4;
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.Color.Transparent;
            this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas.Location = new System.Drawing.Point(0, 0);
            this.canvas.Margin = new System.Windows.Forms.Padding(4);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(429, 276);
            this.canvas.TabIndex = 0;
            this.canvas.TabStop = false;
            // 
            // step4
            // 
            this.step4.Controls.Add(this.sizeLabel);
            this.step4.Controls.Add(this.comboBox1);
            this.step4.Controls.Add(this.textBox1);
            this.step4.Controls.Add(this.checkBox1);
            this.step4.Controls.Add(this.label5);
            this.step4.Controls.Add(this.label4);
            this.step4.Controls.Add(this.label1);
            this.step4.Controls.Add(this.exportButton);
            this.step4.Location = new System.Drawing.Point(36, 69);
            this.step4.Margin = new System.Windows.Forms.Padding(4);
            this.step4.Name = "step4";
            this.step4.Size = new System.Drawing.Size(429, 276);
            this.step4.TabIndex = 4;
            // 
            // sizeLabel
            // 
            this.sizeLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sizeLabel.Location = new System.Drawing.Point(208, 126);
            this.sizeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(181, 29);
            this.sizeLabel.TabIndex = 9;
            this.sizeLabel.Text = "预计大小：0.0KB";
            this.sizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "无压缩",
            "2倍压缩",
            "3倍压缩",
            "4倍压缩"});
            this.comboBox1.Location = new System.Drawing.Point(93, 127);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(95, 23);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(141, 79);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(236, 25);
            this.textBox1.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(47, 82);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(96, 20);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "导出音效";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(25, 199);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(384, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "如导出音效，请将音效文件复制到sounds目录下。";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(25, 228);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(384, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "记得在全塔属性中注册才能使用，详见文档说明。";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(25, 169);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "将导出animate格式的文件，包含图片和帧数等信息。";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(164, 28);
            this.exportButton.Margin = new System.Windows.Forms.Padding(4);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(101, 34);
            this.exportButton.TabIndex = 0;
            this.exportButton.Text = "点此导出";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // nextAnimaButton
            // 
            this.nextAnimaButton.Location = new System.Drawing.Point(254, 397);
            this.nextAnimaButton.Margin = new System.Windows.Forms.Padding(4);
            this.nextAnimaButton.Name = "nextAnimaButton";
            this.nextAnimaButton.Size = new System.Drawing.Size(100, 29);
            this.nextAnimaButton.TabIndex = 8;
            this.nextAnimaButton.Text = "下一动画";
            this.nextAnimaButton.UseVisualStyleBackColor = true;
            this.nextAnimaButton.Visible = false;
            this.nextAnimaButton.Click += new System.EventHandler(this.nextAnimaButton_Click);
            // 
            // lastAnimaButton
            // 
            this.lastAnimaButton.Location = new System.Drawing.Point(145, 397);
            this.lastAnimaButton.Margin = new System.Windows.Forms.Padding(4);
            this.lastAnimaButton.Name = "lastAnimaButton";
            this.lastAnimaButton.Size = new System.Drawing.Size(100, 29);
            this.lastAnimaButton.TabIndex = 9;
            this.lastAnimaButton.Text = "上一动画";
            this.lastAnimaButton.UseVisualStyleBackColor = true;
            this.lastAnimaButton.Visible = false;
            this.lastAnimaButton.Click += new System.EventHandler(this.lastAnimaButton_Click);
            // 
            // animaName
            // 
            this.animaName.AutoSize = true;
            this.animaName.Location = new System.Drawing.Point(253, 364);
            this.animaName.Name = "animaName";
            this.animaName.Size = new System.Drawing.Size(97, 15);
            this.animaName.TabIndex = 10;
            this.animaName.Text = "啊啊啊啊啊啊";
            this.animaName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "当前动画：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lastAnimaButton);
            this.Controls.Add(this.animaName);
            this.Controls.Add(this.nextAnimaButton);
            this.Controls.Add(this.step4);
            this.Controls.Add(this.step3);
            this.Controls.Add(this.step1);
            this.Controls.Add(this.step2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.step4Label);
            this.Controls.Add(this.step3Label);
            this.Controls.Add(this.step2Label);
            this.Controls.Add(this.step1Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RM动画导出器 By 艾之葵";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.step1.ResumeLayout(false);
            this.step2.ResumeLayout(false);
            this.step3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.step4.ResumeLayout(false);
            this.step4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel step1;
        private System.Windows.Forms.Label step1Label;
        private System.Windows.Forms.Label step2Label;
        private System.Windows.Forms.Label step3Label;
        private System.Windows.Forms.Label step4Label;
        private System.Windows.Forms.Button selectFile;
        private System.Windows.Forms.Label selectFileLabel;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel step2;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader listHeader0;
        private System.Windows.Forms.ColumnHeader listHeader1;
        private System.Windows.Forms.ColumnHeader listHeader2;
        private System.Windows.Forms.ColumnHeader listHeader3;
        private System.Windows.Forms.Panel step3;
        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Panel step4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.Button nextAnimaButton;
        private System.Windows.Forms.Button lastAnimaButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label animaName;
    }
}

