namespace temperature_sensor_GUI
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.listLEDGrn = new System.Windows.Forms.ListBox();
            this.listLEDYlw = new System.Windows.Forms.ListBox();
            this.listLEDRed = new System.Windows.Forms.ListBox();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.chrtTemp = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnLEDGrn = new System.Windows.Forms.Button();
            this.btnInitiate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.graphWorker = new System.ComponentModel.BackgroundWorker();
            this.msgLabel = new System.Windows.Forms.Label();
            this.btnLEDYlw = new System.Windows.Forms.Button();
            this.btnLEDRed = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.chrtTemp)).BeginInit();
            this.SuspendLayout();
            // 
            // listLEDGrn
            // 
            this.listLEDGrn.FormattingEnabled = true;
            this.listLEDGrn.ItemHeight = 16;
            this.listLEDGrn.Items.AddRange(new object[] {
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "30"});
            this.listLEDGrn.Location = new System.Drawing.Point(657, 118);
            this.listLEDGrn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listLEDGrn.Name = "listLEDGrn";
            this.listLEDGrn.Size = new System.Drawing.Size(120, 84);
            this.listLEDGrn.TabIndex = 1;
            this.listLEDGrn.SelectedIndexChanged += new System.EventHandler(this.listLEDGrn_SelectedIndexChanged);
            // 
            // listLEDYlw
            // 
            this.listLEDYlw.FormattingEnabled = true;
            this.listLEDYlw.ItemHeight = 16;
            this.listLEDYlw.Items.AddRange(new object[] {
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "30"});
            this.listLEDYlw.Location = new System.Drawing.Point(657, 254);
            this.listLEDYlw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listLEDYlw.Name = "listLEDYlw";
            this.listLEDYlw.Size = new System.Drawing.Size(120, 84);
            this.listLEDYlw.TabIndex = 2;
            // 
            // listLEDRed
            // 
            this.listLEDRed.FormattingEnabled = true;
            this.listLEDRed.ItemHeight = 16;
            this.listLEDRed.Items.AddRange(new object[] {
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "30"});
            this.listLEDRed.Location = new System.Drawing.Point(657, 384);
            this.listLEDRed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listLEDRed.Name = "listLEDRed";
            this.listLEDRed.Size = new System.Drawing.Size(120, 84);
            this.listLEDRed.TabIndex = 3;
            // 
            // btnSwitch
            // 
            this.btnSwitch.Location = new System.Drawing.Point(403, 542);
            this.btnSwitch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(141, 49);
            this.btnSwitch.TabIndex = 4;
            this.btnSwitch.Text = "Switch Function";
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // chrtTemp
            // 
            chartArea2.Name = "tmpArea";
            this.chrtTemp.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chrtTemp.Legends.Add(legend2);
            this.chrtTemp.Location = new System.Drawing.Point(63, 55);
            this.chrtTemp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chrtTemp.Name = "chrtTemp";
            series2.ChartArea = "tmpArea";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Temp";
            this.chrtTemp.Series.Add(series2);
            this.chrtTemp.Size = new System.Drawing.Size(481, 414);
            this.chrtTemp.TabIndex = 5;
            this.chrtTemp.Text = "Temperature";
            this.chrtTemp.Click += new System.EventHandler(this.chart1_Click);
            // 
            // btnLEDGrn
            // 
            this.btnLEDGrn.Location = new System.Drawing.Point(788, 139);
            this.btnLEDGrn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLEDGrn.Name = "btnLEDGrn";
            this.btnLEDGrn.Size = new System.Drawing.Size(120, 49);
            this.btnLEDGrn.TabIndex = 6;
            this.btnLEDGrn.Text = "Set Green LED";
            this.btnLEDGrn.UseVisualStyleBackColor = true;
            this.btnLEDGrn.Click += new System.EventHandler(this.btnLED_Click);
            // 
            // btnInitiate
            // 
            this.btnInitiate.Location = new System.Drawing.Point(63, 542);
            this.btnInitiate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInitiate.Name = "btnInitiate";
            this.btnInitiate.Size = new System.Drawing.Size(141, 49);
            this.btnInitiate.TabIndex = 7;
            this.btnInitiate.Text = "Initiate";
            this.btnInitiate.UseVisualStyleBackColor = true;
            this.btnInitiate.Click += new System.EventHandler(this.btnInitiate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(233, 542);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(141, 49);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save Data";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // graphWorker
            // 
            this.graphWorker.WorkerSupportsCancellation = true;
            this.graphWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // msgLabel
            // 
            this.msgLabel.AutoSize = true;
            this.msgLabel.Location = new System.Drawing.Point(653, 55);
            this.msgLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.msgLabel.Name = "msgLabel";
            this.msgLabel.Size = new System.Drawing.Size(31, 17);
            this.msgLabel.TabIndex = 9;
            this.msgLabel.Text = "N/A";
            // 
            // btnLEDYlw
            // 
            this.btnLEDYlw.Location = new System.Drawing.Point(788, 271);
            this.btnLEDYlw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLEDYlw.Name = "btnLEDYlw";
            this.btnLEDYlw.Size = new System.Drawing.Size(120, 49);
            this.btnLEDYlw.TabIndex = 10;
            this.btnLEDYlw.Text = "Set Yellow LED";
            this.btnLEDYlw.UseVisualStyleBackColor = true;
            this.btnLEDYlw.Click += new System.EventHandler(this.btnLEDYlw_Click);
            // 
            // btnLEDRed
            // 
            this.btnLEDRed.Location = new System.Drawing.Point(788, 402);
            this.btnLEDRed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLEDRed.Name = "btnLEDRed";
            this.btnLEDRed.Size = new System.Drawing.Size(120, 49);
            this.btnLEDRed.TabIndex = 11;
            this.btnLEDRed.Text = "Set Red LED";
            this.btnLEDRed.UseVisualStyleBackColor = true;
            this.btnLEDRed.Click += new System.EventHandler(this.btnLEDRed_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 713);
            this.Controls.Add(this.btnLEDRed);
            this.Controls.Add(this.btnLEDYlw);
            this.Controls.Add(this.msgLabel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnInitiate);
            this.Controls.Add(this.btnLEDGrn);
            this.Controls.Add(this.chrtTemp);
            this.Controls.Add(this.btnSwitch);
            this.Controls.Add(this.listLEDRed);
            this.Controls.Add(this.listLEDYlw);
            this.Controls.Add(this.listLEDGrn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Arduino Central";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chrtTemp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listLEDGrn;
        private System.Windows.Forms.ListBox listLEDYlw;
        private System.Windows.Forms.ListBox listLEDRed;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtTemp;
        private System.Windows.Forms.Button btnLEDGrn;
        private System.Windows.Forms.Button btnInitiate;
        private System.Windows.Forms.Button btnSave;
        private System.ComponentModel.BackgroundWorker graphWorker;
        private System.Windows.Forms.Label msgLabel;
        private System.Windows.Forms.Button btnLEDYlw;
        private System.Windows.Forms.Button btnLEDRed;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

