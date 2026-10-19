using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3MLIDTS_AntonioRios_06
{
    public partial class Form1 : Form
    {
        public SerialPort ArduinoPort { get;}
        public Form1()
        {
            InitializeComponent();
            ArduinoPort = new System.IO.Ports.SerialPort();
            ArduinoPort.PortName = "COM9";
            ArduinoPort.BaudRate = 9600;
            ArduinoPort.Open();
            this.FormClosing += CerrandoForm1;
            this.btnEncender.Click += btnEncender_Click;
            this.btnApagar.Click += btnApagar_Click;

        }

        private void CerrandoForm1(object sender, FormClosingEventArgs e)

        {

            if (ArduinoPort.IsOpen)
            {
                ArduinoPort.Close();
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void btnEncender_Click(object sender, EventArgs e)
        {

            ArduinoPort.Write("b");
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {

            ArduinoPort.Write("a");

        }
    }
}
