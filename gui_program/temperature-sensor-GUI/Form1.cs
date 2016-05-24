using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Diagnostics;
using System.IO.Ports;
using System.Threading;

namespace temperature_sensor_GUI
{
    public partial class Form1 : Form
    {
        int tmpDataLoc = 0;
        List<string> tmpData = new List<string>();
        SerialPort arduinoBoard = new SerialPort("COM3");
        string boardFunction = "one";
        public Form1()
        {
            InitializeComponent();
            if (!arduinoBoard.IsOpen)
            {
                arduinoBoard.Open();
            }
            else
            {
                throw new InvalidOperationException("The Serial Port is already open!");
            }
            listLEDGrn.SetSelected(2, true);
            listLEDYlw.SetSelected(3, true);
            listLEDRed.SetSelected(4, true);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();

            //List<string> saveData = tmpData;
            //for (int i = 0; i < saveData.Capacity; i++)
            //{

            //}
            //System.IO.File.WriteAllLines(@"%USERPROFILE%\Desktop\tmp.txt", saveData);
        }

        public void tester()
        {
            if (tmpDataLoc < 15)
            {
                chrtTemp.Series["Temp"].Points.AddY(tmpData[tmpDataLoc]); //needs editing
                msgLabel.Text = tmpDataLoc.ToString();
                //msgLabel.Text = tmpData[tmpDataLoc];
            }
            else if (tmpDataLoc >= 15)
            {
                chrtTemp.Series["Temp"].Points.RemoveAt(0);
                chrtTemp.Series["Temp"].Points.AddY(tmpData[tmpDataLoc]);
                msgLabel.Text = tmpDataLoc.ToString();
                //msgLabel.Text = tmpData[tmpDataLoc];
            }
        }

        public void tester2()
        {
            chrtTemp.Series["Temp"].Points.AddY(tmpData[tmpDataLoc]);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Stopwatch stopWatch = new Stopwatch();
            //stopWatch.Start();
            //var time = (int)stopWatch.Elapsed.TotalSeconds;
            chrtTemp.ChartAreas["tmpArea"].AxisX.Minimum = 0;
            chrtTemp.ChartAreas["tmpArea"].AxisX.Maximum = 15;
            chrtTemp.ChartAreas["tmpArea"].AxisX.Interval = 1;
            chrtTemp.ChartAreas["tmpArea"].AxisY.Minimum = 0;
            chrtTemp.ChartAreas["tmpArea"].AxisY.Maximum = 30;
            chrtTemp.ChartAreas["tmpArea"].AxisY.Interval = 1;
            chrtTemp.ChartAreas["tmpArea"].AxisX.Title = "Time [s]";
            chrtTemp.ChartAreas["tmpArea"].AxisY.Title = "Temperature [°C]";
        }

        private void btnInitiate_Click(object sender, EventArgs e)
        {
            if (!graphWorker.IsBusy)
            {
                graphWorker.RunWorkerAsync();
                btnInitiate.Text = "Stop";
            }
            else if (graphWorker.IsBusy)
            {
                graphWorker.CancelAsync();
                btnInitiate.Text = "Initiate";
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (arduinoBoard.IsOpen)
            {
                tmpData.Add(arduinoBoard.ReadExisting());
                //chrtTemp.Series["Temp"].Points.AddY(tmpData[tmpDataLoc]); //needs editing
                MethodInvoker updateGraphDelegate = new MethodInvoker(tester);
                Invoke(updateGraphDelegate);
                tmpDataLoc++;
                Thread.Sleep(1000);
                if (graphWorker.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listLEDGrn_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLED_Click(object sender, EventArgs e)
        {
            int setLEDGrn = int.Parse(listLEDGrn.SelectedItem.ToString());
            if (arduinoBoard.IsOpen)
            {
                arduinoBoard.Write("Grn" + setLEDGrn);
            }
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            if (arduinoBoard.IsOpen && boardFunction == "one")
            {
                string lala = "two";
                arduinoBoard.Write(lala);
                boardFunction = lala;
            }
            else if (arduinoBoard.IsOpen && boardFunction == "two")
            {
                string dada = "one";
                arduinoBoard.Write(dada);
                boardFunction = dada;
            }
        }

        private void btnLEDYlw_Click(object sender, EventArgs e)
        {
            int setLEDYlw = int.Parse(listLEDYlw.SelectedItem.ToString());
            if (arduinoBoard.IsOpen)
            {
                arduinoBoard.Write("Ylw" + setLEDYlw);
            }
        }

        private void btnLEDRed_Click(object sender, EventArgs e)
        {
            int setLEDRed = int.Parse(listLEDRed.SelectedItem.ToString());
            if (arduinoBoard.IsOpen)
            {
                arduinoBoard.Write("Red" + setLEDRed);
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            List<string> saveData = tmpData;
            string fileName = saveFileDialog1.FileName;
            System.IO.File.WriteAllLines(fileName, saveData);
        }
    }
}
