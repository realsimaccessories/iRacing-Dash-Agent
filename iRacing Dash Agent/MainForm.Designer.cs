namespace iRacing_Dash_Agent
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.GroupConnection1 = new System.Windows.Forms.GroupBox();
            this.RemovePort = new System.Windows.Forms.Button();
            this.labelPortStatus = new System.Windows.Forms.Label();
            this.StartPort = new System.Windows.Forms.Button();
            this.comboBoxSelectPort = new System.Windows.Forms.ComboBox();
            this.serialPort01 = new System.IO.Ports.SerialPort(this.components);
            this.startAll = new System.Windows.Forms.Button();
            this.AddPort = new System.Windows.Forms.Button();
            this.serialPort02 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort03 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort04 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort05 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort06 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort07 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort08 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort09 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort10 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort11 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort12 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort13 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort14 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort15 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort16 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort17 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort18 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort19 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort20 = new System.IO.Ports.SerialPort(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.StopPort = new System.Windows.Forms.Button();
            this.GroupConnection1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupConnection1
            // 
            this.GroupConnection1.Controls.Add(this.StopPort);
            this.GroupConnection1.Controls.Add(this.button1);
            this.GroupConnection1.Controls.Add(this.RemovePort);
            this.GroupConnection1.Controls.Add(this.labelPortStatus);
            this.GroupConnection1.Controls.Add(this.StartPort);
            this.GroupConnection1.Controls.Add(this.comboBoxSelectPort);
            this.GroupConnection1.Location = new System.Drawing.Point(25, 25);
            this.GroupConnection1.Name = "GroupConnection1";
            this.GroupConnection1.Size = new System.Drawing.Size(414, 85);
            this.GroupConnection1.TabIndex = 0;
            this.GroupConnection1.TabStop = false;
            this.GroupConnection1.Text = "Connection 1";
            // 
            // RemovePort
            // 
            this.RemovePort.Location = new System.Drawing.Point(375, 19);
            this.RemovePort.Name = "RemovePort";
            this.RemovePort.Size = new System.Drawing.Size(24, 21);
            this.RemovePort.TabIndex = 3;
            this.RemovePort.Text = "-";
            this.RemovePort.UseVisualStyleBackColor = true;
            this.RemovePort.Click += new System.EventHandler(this.RemovePort_Click);
            // 
            // labelPortStatus
            // 
            this.labelPortStatus.AutoSize = true;
            this.labelPortStatus.Location = new System.Drawing.Point(195, 38);
            this.labelPortStatus.Name = "labelPortStatus";
            this.labelPortStatus.Size = new System.Drawing.Size(56, 13);
            this.labelPortStatus.TabIndex = 2;
            this.labelPortStatus.Text = "PortStatus";
            // 
            // StartPort
            // 
            this.StartPort.Location = new System.Drawing.Point(273, 30);
            this.StartPort.Name = "StartPort";
            this.StartPort.Size = new System.Drawing.Size(76, 29);
            this.StartPort.TabIndex = 1;
            this.StartPort.Text = "Start";
            this.StartPort.UseVisualStyleBackColor = true;
            this.StartPort.Click += new System.EventHandler(this.ControlPort_Click);
            // 
            // comboBoxSelectPort
            // 
            this.comboBoxSelectPort.FormattingEnabled = true;
            this.comboBoxSelectPort.Location = new System.Drawing.Point(15, 35);
            this.comboBoxSelectPort.Name = "comboBoxSelectPort";
            this.comboBoxSelectPort.Size = new System.Drawing.Size(152, 21);
            this.comboBoxSelectPort.TabIndex = 0;
            // 
            // startAll
            // 
            this.startAll.Location = new System.Drawing.Point(499, 73);
            this.startAll.Name = "startAll";
            this.startAll.Size = new System.Drawing.Size(112, 37);
            this.startAll.TabIndex = 1;
            this.startAll.Text = "Start All";
            this.startAll.UseVisualStyleBackColor = true;
            // 
            // AddPort
            // 
            this.AddPort.Location = new System.Drawing.Point(499, 22);
            this.AddPort.Name = "AddPort";
            this.AddPort.Size = new System.Drawing.Size(111, 41);
            this.AddPort.TabIndex = 2;
            this.AddPort.Text = "Add Port";
            this.AddPort.UseVisualStyleBackColor = true;
            this.AddPort.Click += new System.EventHandler(this.AddPort_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(375, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 21);
            this.button1.TabIndex = 4;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // StopPort
            // 
            this.StopPort.Location = new System.Drawing.Point(273, 30);
            this.StopPort.Name = "StopPort";
            this.StopPort.Size = new System.Drawing.Size(76, 29);
            this.StopPort.TabIndex = 5;
            this.StopPort.Text = "Stop";
            this.StopPort.UseVisualStyleBackColor = true;
            this.StopPort.Visible = false;
            // 
            // MainForm
            // 
            this.AccessibleName = "MainForm";
            this.ClientSize = new System.Drawing.Size(672, 324);
            this.Controls.Add(this.AddPort);
            this.Controls.Add(this.startAll);
            this.Controls.Add(this.GroupConnection1);
            this.Name = "MainForm";
            this.Text = "iRacing Dash Agent";
            this.GroupConnection1.ResumeLayout(false);
            this.GroupConnection1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox GroupConnection1;
        private System.Windows.Forms.ComboBox comboBoxSelectPort;
        private System.IO.Ports.SerialPort serialPort01;
        private System.Windows.Forms.Label labelPortStatus;
        private System.Windows.Forms.Button StartPort;
        private System.Windows.Forms.Button startAll;
        private System.Windows.Forms.Button AddPort;
        private System.Windows.Forms.Button RemovePort;
        private System.IO.Ports.SerialPort serialPort02;
        private System.IO.Ports.SerialPort serialPort03;
        private System.IO.Ports.SerialPort serialPort04;
        private System.IO.Ports.SerialPort serialPort05;
        private System.IO.Ports.SerialPort serialPort06;
        private System.IO.Ports.SerialPort serialPort07;
        private System.IO.Ports.SerialPort serialPort08;
        private System.IO.Ports.SerialPort serialPort09;
        private System.IO.Ports.SerialPort serialPort10;
        private System.IO.Ports.SerialPort serialPort11;
        private System.IO.Ports.SerialPort serialPort12;
        private System.IO.Ports.SerialPort serialPort13;
        private System.IO.Ports.SerialPort serialPort14;
        private System.IO.Ports.SerialPort serialPort15;
        private System.IO.Ports.SerialPort serialPort16;
        private System.IO.Ports.SerialPort serialPort17;
        private System.IO.Ports.SerialPort serialPort18;
        private System.IO.Ports.SerialPort serialPort19;
        private System.IO.Ports.SerialPort serialPort20;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button StopPort;
    }
}

