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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            ((System.ComponentModel.ISupportInitialize)(this.chrtTemp)).BeginInit();
            this.SuspendLayout();
            // 
            // listLEDGrn
            // 
            this.listLEDGrn.FormattingEnabled = true;
            this.listLEDGrn.Items.AddRange(new object[] {
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "30"});
            this.listLEDGrn.Location = new System.Drawing.Point(493, 96);
            this.listLEDGrn.Margin = new System.Windows.Forms.Padding(2);
            this.listLEDGrn.Name = "listLEDGrn";
            this.listLEDGrn.Size = new System.Drawing.Size(91, 69);
            this.listLEDGrn.TabIndex = 1;
            this.listLEDGrn.SelectedIndexChanged += new System.EventHandler(this.listLEDGrn_SelectedIndexChanged);
            // 
            // listLEDYlw
            // 
            this.listLEDYlw.FormattingEnabled = true;
            this.listLEDYlw.Items.AddRange(new object[] {
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "30"});
            this.listLEDYlw.Location = new System.Drawing.Point(493, 206);
            this.listLEDYlw.Margin = new System.Windows.Forms.Padding(2);
            this.listLEDYlw.Name = "listLEDYlw";
            this.listLEDYlw.Size = new System.Drawing.Size(91, 69);
            this.listLEDYlw.TabIndex = 2;
            // 
            // listLEDRed
            // 
            this.listLEDRed.FormattingEnabled = true;
            this.listLEDRed.Items.AddRange(new object[] {
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "30"});
            this.listLEDRed.Location = new System.Drawing.Point(493, 312);
            this.listLEDRed.Margin = new System.Windows.Forms.Padding(2);
            this.listLEDRed.Name = "listLEDRed";
            this.listLEDRed.Size = new System.Drawing.Size(91, 69);
            this.listLEDRed.TabIndex = 3;
            // 
            // btnSwitch
            // 
            this.btnSwitch.Location = new System.Drawing.Point(302, 440);
            this.btnSwitch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(106, 40);
            this.btnSwitch.TabIndex = 4;
            this.btnSwitch.Text = "Switch Function";
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // chrtTemp
            // 
            chartArea3.Name = "tmpArea";
            this.chrtTemp.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chrtTemp.Legends.Add(legend3);
            this.chrtTemp.Location = new System.Drawing.Point(47, 45);
            this.chrtTemp.Margin = new System.Windows.Forms.Padding(2);
            this.chrtTemp.Name = "chrtTemp";
            series3.ChartArea = "tmpArea";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Temp";
            this.chrtTemp.Series.Add(series3);
            this.chrtTemp.Size = new System.Drawing.Size(361, 336);
            this.chrtTemp.TabIndex = 5;
            this.chrtTemp.Text = "Temperature";
            this.chrtTemp.Click += new System.EventHandler(this.chart1_Click);
            // 
            // btnLEDGrn
            // 
            this.btnLEDGrn.Location = new System.Drawing.Point(591, 113);
            this.btnLEDGrn.Margin = new System.Windows.Forms.Padding(2);
            this.btnLEDGrn.Name = "btnLEDGrn";
            this.btnLEDGrn.Size = new System.Drawing.Size(90, 40);
            this.btnLEDGrn.TabIndex = 6;
            this.btnLEDGrn.Text = "Set Green LED";
            this.btnLEDGrn.UseVisualStyleBackColor = true;
            this.btnLEDGrn.Click += new System.EventHandler(this.btnLED_Click);
            // 
            // btnInitiate
            // 
            this.btnInitiate.Location = new System.Drawing.Point(47, 440);
            this.btnInitiate.Margin = new System.Windows.Forms.Padding(2);
            this.btnInitiate.Name = "btnInitiate";
            this.btnInitiate.Size = new System.Drawing.Size(106, 40);
            this.btnInitiate.TabIndex = 7;
            this.btnInitiate.Text = "Initiate";
            this.btnInitiate.UseVisualStyleBackColor = true;
            this.btnInitiate.Click += new System.EventHandler(this.btnInitiate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(175, 440);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 40);
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
            this.msgLabel.Location = new System.Drawing.Point(490, 45);
            this.msgLabel.Name = "msgLabel";
            this.msgLabel.Size = new System.Drawing.Size(27, 13);
            this.msgLabel.TabIndex = 9;
            this.msgLabel.Text = "N/A";
            // 
            // btnLEDYlw
            // 
            this.btnLEDYlw.Location = new System.Drawing.Point(591, 220);
            this.btnLEDYlw.Margin = new System.Windows.Forms.Padding(2);
            this.btnLEDYlw.Name = "btnLEDYlw";
            this.btnLEDYlw.Size = new System.Drawing.Size(90, 40);
            this.btnLEDYlw.TabIndex = 10;
            this.btnLEDYlw.Text = "Set Yellow LED";
            this.btnLEDYlw.UseVisualStyleBackColor = true;
            this.btnLEDYlw.Click += new System.EventHandler(this.btnLEDYlw_Click);
            // 
            // btnLEDRed
            // 
            this.btnLEDRed.Location = new System.Drawing.Point(591, 327);
            this.btnLEDRed.Margin = new System.Windows.Forms.Padding(2);
            this.btnLEDRed.Name = "btnLEDRed";
            this.btnLEDRed.Size = new System.Drawing.Size(90, 40);
            this.btnLEDRed.TabIndex = 11;
            this.btnLEDRed.Text = "Set Red LED";
            this.btnLEDRed.UseVisualStyleBackColor = true;
            this.btnLEDRed.Click += new System.EventHandler(this.btnLEDRed_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 579);
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
            this.Margin = new System.Windows.Forms.Padding(2);
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
    }
}

