using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting.ChartTypes;
using System.IO.Ports;
using System.Threading;
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public delegate void AddDataCallBack(System.Windows.Forms.DataVisualization.Charting.Chart chart, double x, double y);
        public Form1()
        {
            Form.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();

            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            chart1.ChartAreas[0].AxisX.ScaleView.Size = 50;
            chart2.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            chart2.ChartAreas[0].AxisX.ScaleView.Size = 50;
            chart3.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            chart3.ChartAreas[0].AxisX.ScaleView.Size = 50;
            new Thread(SafeThread).Start();
        }
        public void SafeThread()
        {
            double x = 0;
            while (true)
            {
                AddDataToChart(chart1, x, Math.Cos(x));
                AddDataToChart(chart2, x, Math.Sin(x));
                AddDataToChart(chart3, x, Math.Tan(x));
                x += 0.1;
                Thread.Sleep(20);
            }
        }
        public void AddDataToChart(System.Windows.Forms.DataVisualization.Charting.Chart chart, double x, double y)
        {
            if (chart.InvokeRequired)
            {   
                AddDataCallBack cb = new AddDataCallBack(AddDataToChart);
                this.Invoke(cb, new object[]{chart, x,y});
            }
            else
            {
                chart.Series[0].Points.AddXY(x, y);
                if (chart.ChartAreas[0].AxisX.Maximum > chart.ChartAreas[0].AxisX.ScaleView.Size)
                    chart.ChartAreas[0].AxisX.ScaleView.Scroll(chart.ChartAreas[0].AxisX.Maximum);
                
            }
           
        }
        private void fillPortsBox()
        {

            portChooseBox.Items.Clear();

            SerialPort tmp;

            foreach (string portname in SerialPort.GetPortNames())
            {

                if (portChooseBox.Items.Contains(portname)) continue;
                tmp = new SerialPort(portname);

                try
                {
                    tmp.Open();
                    if (tmp.IsOpen)
                    {
                        tmp.Close();
                        portChooseBox.Items.Add(portname);
                    }
                }
                catch { }

            }
            portChooseBox.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fillPortsBox();
        }

        private void startBTN_Click(object sender, EventArgs e)
        {
            double heartFre;
            double elvd;
            double elvs;
            try {
                heartFre = Double.Parse(heartBox.Text);
                elvd = Double.Parse(elvdBox.Text);
                elvs = Double.Parse(elvsBox.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(this, "Invalid data");
            }
            
        }
    }
}
