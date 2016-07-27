using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;
using MccDaq;

namespace WindowsFormsApplication1
{
    class DataIOProcessor
    {
        private Form1 myForm;
        private Thread readThread;
        private SerialPort arduinoPort;
        private SerialPort omgPort;
        public DataIOProcessor(String choosePort)
        {
            arduinoPort = new SerialPort(choosePort, 9600);
            arduinoPort.Open();
        }
        public void readValue()
        {
            while (true)
            {
                arduinoPort.ReadLine();
            }
        }
        public void Write(double heartFre, double elvd, double elvs)
        {
            String outputString = "start/" + heartFre + "/" + elvd + "/" + elvs;
            arduinoPort.WriteLine(outputString);
        }
        public void setForm(Form1 form)
        {
            this.myForm = form;
        }

        

    }
}
