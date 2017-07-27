using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace iRacing_Dash_Agent
{
    public partial class MainForm : Form
    {
        int groupCount = 1;
        const int gapBetween = 40;
        const int groupxPos = 25;
        const int groupyPos = 25;
        const int groupHeight = 85;
        const int groupWidth = 414;
        const int dropDownHieght = 21;
        const int dropDownWidth = 152;
        const int dropDownxPos = 21;
        const int dropDownyPos = 43;
        const int labelHeight = 13;
        const int labelWidth = 56;
        const int labelxPos = 195;
        const int labelyPos = 38;
        const int controlHeight = 29;
        const int controlWidth = 76;
        const int controlxPos = 273;
        const int controlyPos = 35;
        const int removeHeight = 21;
        const int removeWidth = 24;
        const int removexPos = 378;
        const int removeyPos = 42;

        const string labelStart = "Start";
        const string labelStop = "Stop";
        const string labelConnected = "Connected";
        const string labelDisconnected = "Disconnected";
        const string labelGroup = "Controller ";
        const string labelRemove = "-";
        const string labelSerialPort = "SerialPort";

        public MainForm()
        {
            InitializeComponent();
            comboBoxSelectPort.Items.AddRange(SerialPort.GetPortNames());
            labelPortStatus.Text = labelDisconnected;
            StartPort.Text = labelStart;
        }
 
        void addPort()
        {
            groupCount = groupCount + 1;
            int newypos = groupyPos + groupHeight + gapBetween;

            ComboBox comboBoxSelectPort = new ComboBox();
            comboBoxSelectPort.Items.AddRange(SerialPort.GetPortNames());
            comboBoxSelectPort.Visible = true;
            comboBoxSelectPort.Location = new System.Drawing.Point(dropDownxPos, dropDownyPos);
            comboBoxSelectPort.Size = new System.Drawing.Size(dropDownWidth, dropDownHieght);

            Label portStatus = new Label();
            portStatus.Text = labelDisconnected;
            portStatus.Visible = true;
            portStatus.AutoSize = true;
            portStatus.Location = new System.Drawing.Point(labelxPos, labelyPos);
            portStatus.Size = new System.Drawing.Size(labelWidth, labelHeight);

            Button control = new Button();
            control.Text = labelStart;
            control.Visible = true;
            control.Location = new System.Drawing.Point(controlxPos, controlyPos);
            control.Size = new System.Drawing.Size(controlWidth, controlHeight);
            control.Name = "control" + groupCount;

            Button remove = new Button();
            remove.Visible = true;
            remove.Text = labelRemove;
            remove.Location = new System.Drawing.Point(removexPos, removeyPos);
            remove.Size = new System.Drawing.Size(removeWidth, removeHeight);
            remove.Click += new System.EventHandler(this.RemovePort_Click);
            remove.Name = "remove" + groupCount;

            GroupBox nextConnection = new GroupBox();
            nextConnection.Name = labelGroup.Trim() + groupCount;
            nextConnection.Size = new System.Drawing.Size(groupWidth, groupHeight);
            nextConnection.Location = new System.Drawing.Point(groupxPos, newypos);
            nextConnection.Text = labelGroup + groupCount;
            nextConnection.Visible = true;
            nextConnection.Controls.Add(comboBoxSelectPort);
            nextConnection.Controls.Add(portStatus);
            nextConnection.Controls.Add(control);
            nextConnection.Controls.Add(remove);

            SerialPort newSerialPort = new SerialPort();
            newSerialPort.PortName = labelSerialPort + groupCount;

            this.Controls.Add(nextConnection);
            this.serialPort02 = new System.IO.Ports(newSerialPort);
      
            
// MainForm.ActiveForm.Size = new System.Drawing.Size(MainForm.,(MainForm.ActiveForm.Size.Height + gapBetween + groupHeight));

        }
        private void AddPort_Click(object sender, EventArgs e)
        {
            addPort();
        }

        private void RemovePort_Click(object sender, EventArgs e)
        {
            object test = sender;
            string delGroup = sender.ToString();
        }

        private void ControlPort_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    if (comboBoxSelectPort.Text == "")
                    {
                        
                        textBoxRecieve.Text = "Select a Port Dumbass!";
                    }
                    else
                    {
                        serialPort01.PortName = comboBoxSelectPort.Text;
                        serialPort01.BaudRate = 9600;
                        serialPort01.DataBits = 8;
                        serialPort01.Parity = Parity.None;
                        serialPort01.StopBits = StopBits.One;
                        serialPort01.Handshake = Handshake.None;
                        serialPort01.Encoding = System.Text.Encoding.Default;
                        serialPort01.ReadTimeout = 10000;
                        serialPort01.Open();
                        progressBarStatus.Value = 100;
                        buttonSend.Enabled = true;
                        buttonRecieve.Enabled = true;
                        textBoxSend.Enabled = true;
                        buttonStart.Enabled = false;
                        buttonStop.Enabled = true;
                        comboBoxSelectPort.Enabled = false;

                        timer1.Enabled = true;

                        textBoxRecieve.Text = textBoxRecieve.Text + readSerialPort(serialPort01);
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    textBoxRecieve.Text = "ID.10.T Error. Something Fucked up. Is the port already in use?";
                }
            }
        }
    }
}
