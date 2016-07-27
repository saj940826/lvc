namespace WindowsFormsApplication1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.startBTN = new System.Windows.Forms.Button();
            this.pLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.portChooseBox = new System.Windows.Forms.ComboBox();
            this.quantityData = new System.Windows.Forms.Label();
            this.volumeData = new System.Windows.Forms.Label();
            this.press2Data = new System.Windows.Forms.Label();
            this.press1Data = new System.Windows.Forms.Label();
            this.elvsLabel = new System.Windows.Forms.Label();
            this.elvdLabel = new System.Windows.Forms.Label();
            this.heartLabel = new System.Windows.Forms.Label();
            this.elvsBox = new System.Windows.Forms.TextBox();
            this.elvdBox = new System.Windows.Forms.TextBox();
            this.heartBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(654, 425);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(609, 362);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea5.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart2.Legends.Add(legend5);
            this.chart2.Location = new System.Drawing.Point(12, 425);
            this.chart2.Name = "chart2";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chart2.Series.Add(series5);
            this.chart2.Size = new System.Drawing.Size(636, 362);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            // 
            // chart3
            // 
            chartArea6.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart3.Legends.Add(legend6);
            this.chart3.Location = new System.Drawing.Point(654, 12);
            this.chart3.Name = "chart3";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Test1";
            this.chart3.Series.Add(series6);
            this.chart3.Size = new System.Drawing.Size(609, 407);
            this.chart3.TabIndex = 2;
            this.chart3.Text = "chart3";
            // 
            // startBTN
            // 
            this.startBTN.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.startBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.startBTN.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.startBTN.FlatAppearance.BorderSize = 3;
            this.startBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.startBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.startBTN.Font = new System.Drawing.Font("宋体", 25F);
            this.startBTN.Location = new System.Drawing.Point(302, 278);
            this.startBTN.Name = "startBTN";
            this.startBTN.Size = new System.Drawing.Size(267, 42);
            this.startBTN.TabIndex = 3;
            this.startBTN.Text = "Start";
            this.startBTN.UseVisualStyleBackColor = false;
            this.startBTN.Click += new System.EventHandler(this.startBTN_Click);
            // 
            // pLabel
            // 
            this.pLabel.AutoSize = true;
            this.pLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pLabel.Font = new System.Drawing.Font("宋体", 20F);
            this.pLabel.Location = new System.Drawing.Point(341, 35);
            this.pLabel.Name = "pLabel";
            this.pLabel.Size = new System.Drawing.Size(124, 27);
            this.pLabel.TabIndex = 4;
            this.pLabel.Text = "Press 1:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.portChooseBox);
            this.panel1.Controls.Add(this.quantityData);
            this.panel1.Controls.Add(this.volumeData);
            this.panel1.Controls.Add(this.press2Data);
            this.panel1.Controls.Add(this.press1Data);
            this.panel1.Controls.Add(this.elvsLabel);
            this.panel1.Controls.Add(this.elvdLabel);
            this.panel1.Controls.Add(this.heartLabel);
            this.panel1.Controls.Add(this.elvsBox);
            this.panel1.Controls.Add(this.elvdBox);
            this.panel1.Controls.Add(this.heartBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pLabel);
            this.panel1.Controls.Add(this.startBTN);
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 407);
            this.panel1.TabIndex = 5;
            // 
            // portChooseBox
            // 
            this.portChooseBox.Font = new System.Drawing.Font("宋体", 15F);
            this.portChooseBox.FormattingEnabled = true;
            this.portChooseBox.Location = new System.Drawing.Point(64, 278);
            this.portChooseBox.Name = "portChooseBox";
            this.portChooseBox.Size = new System.Drawing.Size(166, 28);
            this.portChooseBox.TabIndex = 12;
            // 
            // quantityData
            // 
            this.quantityData.AutoSize = true;
            this.quantityData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.quantityData.Font = new System.Drawing.Font("宋体", 20F);
            this.quantityData.Location = new System.Drawing.Point(471, 183);
            this.quantityData.MinimumSize = new System.Drawing.Size(98, 29);
            this.quantityData.Name = "quantityData";
            this.quantityData.Size = new System.Drawing.Size(98, 29);
            this.quantityData.TabIndex = 11;
            this.quantityData.Text = "label1";
            // 
            // volumeData
            // 
            this.volumeData.AutoSize = true;
            this.volumeData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.volumeData.Font = new System.Drawing.Font("宋体", 20F);
            this.volumeData.Location = new System.Drawing.Point(471, 134);
            this.volumeData.MinimumSize = new System.Drawing.Size(98, 29);
            this.volumeData.Name = "volumeData";
            this.volumeData.Size = new System.Drawing.Size(98, 29);
            this.volumeData.TabIndex = 11;
            this.volumeData.Text = "label1";
            // 
            // press2Data
            // 
            this.press2Data.AutoSize = true;
            this.press2Data.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.press2Data.Font = new System.Drawing.Font("宋体", 20F);
            this.press2Data.Location = new System.Drawing.Point(471, 82);
            this.press2Data.MinimumSize = new System.Drawing.Size(98, 29);
            this.press2Data.Name = "press2Data";
            this.press2Data.Size = new System.Drawing.Size(98, 29);
            this.press2Data.TabIndex = 11;
            this.press2Data.Text = "Label1";
            // 
            // press1Data
            // 
            this.press1Data.AutoSize = true;
            this.press1Data.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.press1Data.Font = new System.Drawing.Font("宋体", 20F);
            this.press1Data.Location = new System.Drawing.Point(471, 33);
            this.press1Data.MinimumSize = new System.Drawing.Size(98, 29);
            this.press1Data.Name = "press1Data";
            this.press1Data.Size = new System.Drawing.Size(98, 29);
            this.press1Data.TabIndex = 11;
            this.press1Data.Text = "label1";
            // 
            // elvsLabel
            // 
            this.elvsLabel.AutoSize = true;
            this.elvsLabel.Font = new System.Drawing.Font("宋体", 20F);
            this.elvsLabel.Location = new System.Drawing.Point(109, 145);
            this.elvsLabel.Name = "elvsLabel";
            this.elvsLabel.Size = new System.Drawing.Size(82, 27);
            this.elvsLabel.TabIndex = 10;
            this.elvsLabel.Text = "Elvs:";
            // 
            // elvdLabel
            // 
            this.elvdLabel.AutoSize = true;
            this.elvdLabel.Font = new System.Drawing.Font("宋体", 20F);
            this.elvdLabel.Location = new System.Drawing.Point(109, 88);
            this.elvdLabel.Name = "elvdLabel";
            this.elvdLabel.Size = new System.Drawing.Size(82, 27);
            this.elvdLabel.TabIndex = 9;
            this.elvdLabel.Text = "Elvd:";
            // 
            // heartLabel
            // 
            this.heartLabel.AutoSize = true;
            this.heartLabel.Font = new System.Drawing.Font("宋体", 20F);
            this.heartLabel.Location = new System.Drawing.Point(39, 33);
            this.heartLabel.Name = "heartLabel";
            this.heartLabel.Size = new System.Drawing.Size(152, 27);
            this.heartLabel.TabIndex = 8;
            this.heartLabel.Text = "Heart Fre:";
            // 
            // elvsBox
            // 
            this.elvsBox.Font = new System.Drawing.Font("宋体", 15F);
            this.elvsBox.Location = new System.Drawing.Point(197, 142);
            this.elvsBox.Name = "elvsBox";
            this.elvsBox.Size = new System.Drawing.Size(100, 30);
            this.elvsBox.TabIndex = 7;
            // 
            // elvdBox
            // 
            this.elvdBox.Font = new System.Drawing.Font("宋体", 15F);
            this.elvdBox.Location = new System.Drawing.Point(197, 85);
            this.elvdBox.Name = "elvdBox";
            this.elvdBox.Size = new System.Drawing.Size(100, 30);
            this.elvdBox.TabIndex = 6;
            // 
            // heartBox
            // 
            this.heartBox.Font = new System.Drawing.Font("宋体", 15F);
            this.heartBox.Location = new System.Drawing.Point(197, 30);
            this.heartBox.Name = "heartBox";
            this.heartBox.Size = new System.Drawing.Size(100, 30);
            this.heartBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("宋体", 20F);
            this.label3.Location = new System.Drawing.Point(327, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantity:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("宋体", 20F);
            this.label2.Location = new System.Drawing.Point(354, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Volume:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("宋体", 20F);
            this.label1.Location = new System.Drawing.Point(341, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Press 2:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 799);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.Button startBTN;
        private System.Windows.Forms.Label pLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label elvsLabel;
        private System.Windows.Forms.Label elvdLabel;
        private System.Windows.Forms.Label heartLabel;
        private System.Windows.Forms.TextBox elvsBox;
        private System.Windows.Forms.TextBox elvdBox;
        private System.Windows.Forms.TextBox heartBox;
        private System.Windows.Forms.Label quantityData;
        private System.Windows.Forms.Label volumeData;
        private System.Windows.Forms.Label press2Data;
        private System.Windows.Forms.Label press1Data;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox portChooseBox;

    }
}

