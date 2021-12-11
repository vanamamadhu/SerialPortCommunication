namespace SerialPortCommunication
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.cBoxDataBits = new System.Windows.Forms.ComboBox();
            this.cBoxparityBits = new System.Windows.Forms.ComboBox();
            this.cBoxStopBits = new System.Windows.Forms.ComboBox();
            this.cBoxCOMPort = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.lblCOMStatus = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSenddata = new System.Windows.Forms.Button();
            this.tBoxDataOut = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lblDataOutLength = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.chBoxWrite = new System.Windows.Forms.CheckBox();
            this.chBoxWriteLine = new System.Windows.Forms.CheckBox();
            this.btnClearDataOut = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tBoxReceiverControl = new System.Windows.Forms.TextBox();
            this.btnClearDataIN = new System.Windows.Forms.Button();
            this.chBoxAllwaysUpdate = new System.Windows.Forms.CheckBox();
            this.chBoxAddtoOldData = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDataINLength = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cBoxBaudRate);
            this.groupBox1.Controls.Add(this.cBoxDataBits);
            this.groupBox1.Controls.Add(this.cBoxparityBits);
            this.groupBox1.Controls.Add(this.cBoxStopBits);
            this.groupBox1.Controls.Add(this.cBoxCOMPort);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 303);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Com Port Control";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "BAUD RATE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "DATA BITS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "STOP BITS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "PARITY BITS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "COM PORT";
            // 
            // cBoxBaudRate
            // 
            this.cBoxBaudRate.FormattingEnabled = true;
            this.cBoxBaudRate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600"});
            this.cBoxBaudRate.Location = new System.Drawing.Point(154, 76);
            this.cBoxBaudRate.Name = "cBoxBaudRate";
            this.cBoxBaudRate.Size = new System.Drawing.Size(215, 33);
            this.cBoxBaudRate.TabIndex = 4;
            this.cBoxBaudRate.Text = "9600";
            // 
            // cBoxDataBits
            // 
            this.cBoxDataBits.FormattingEnabled = true;
            this.cBoxDataBits.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.cBoxDataBits.Location = new System.Drawing.Point(154, 119);
            this.cBoxDataBits.Name = "cBoxDataBits";
            this.cBoxDataBits.Size = new System.Drawing.Size(215, 33);
            this.cBoxDataBits.TabIndex = 3;
            this.cBoxDataBits.Text = "8";
            // 
            // cBoxparityBits
            // 
            this.cBoxparityBits.FormattingEnabled = true;
            this.cBoxparityBits.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cBoxparityBits.Location = new System.Drawing.Point(154, 210);
            this.cBoxparityBits.Name = "cBoxparityBits";
            this.cBoxparityBits.Size = new System.Drawing.Size(215, 33);
            this.cBoxparityBits.TabIndex = 2;
            this.cBoxparityBits.Text = "None";
            // 
            // cBoxStopBits
            // 
            this.cBoxStopBits.FormattingEnabled = true;
            this.cBoxStopBits.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.cBoxStopBits.Location = new System.Drawing.Point(154, 167);
            this.cBoxStopBits.Name = "cBoxStopBits";
            this.cBoxStopBits.Size = new System.Drawing.Size(215, 33);
            this.cBoxStopBits.TabIndex = 1;
            this.cBoxStopBits.Text = "One";
            // 
            // cBoxCOMPort
            // 
            this.cBoxCOMPort.FormattingEnabled = true;
            this.cBoxCOMPort.Location = new System.Drawing.Point(154, 28);
            this.cBoxCOMPort.Name = "cBoxCOMPort";
            this.cBoxCOMPort.Size = new System.Drawing.Size(215, 33);
            this.cBoxCOMPort.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox8);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Controls.Add(this.btnOpen);
            this.groupBox2.Location = new System.Drawing.Point(12, 321);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(396, 180);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.lblCOMStatus);
            this.groupBox8.Location = new System.Drawing.Point(194, 23);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(194, 120);
            this.groupBox8.TabIndex = 3;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "COM Port Status";
            // 
            // lblCOMStatus
            // 
            this.lblCOMStatus.AutoSize = true;
            this.lblCOMStatus.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCOMStatus.Location = new System.Drawing.Point(56, 52);
            this.lblCOMStatus.Name = "lblCOMStatus";
            this.lblCOMStatus.Size = new System.Drawing.Size(67, 44);
            this.lblCOMStatus.TabIndex = 0;
            this.lblCOMStatus.Text = "OFF";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(9, 149);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(379, 25);
            this.progressBar1.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(14, 89);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(153, 55);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(14, 17);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(153, 66);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "OPEN";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSenddata
            // 
            this.btnSenddata.Location = new System.Drawing.Point(63, 28);
            this.btnSenddata.Name = "btnSenddata";
            this.btnSenddata.Size = new System.Drawing.Size(151, 41);
            this.btnSenddata.TabIndex = 2;
            this.btnSenddata.Text = "Send Data";
            this.btnSenddata.UseVisualStyleBackColor = true;
            this.btnSenddata.Click += new System.EventHandler(this.btnSenddata_Click);
            // 
            // tBoxDataOut
            // 
            this.tBoxDataOut.Location = new System.Drawing.Point(10, 30);
            this.tBoxDataOut.Multiline = true;
            this.tBoxDataOut.Name = "tBoxDataOut";
            this.tBoxDataOut.Size = new System.Drawing.Size(497, 259);
            this.tBoxDataOut.TabIndex = 3;
            this.tBoxDataOut.TextChanged += new System.EventHandler(this.tBoxDataOut_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox7);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.tBoxDataOut);
            this.groupBox3.Location = new System.Drawing.Point(420, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(517, 489);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Transmitter Control";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lblDataOutLength);
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Location = new System.Drawing.Point(11, 414);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(496, 60);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            // 
            // lblDataOutLength
            // 
            this.lblDataOutLength.AutoSize = true;
            this.lblDataOutLength.Location = new System.Drawing.Point(301, 22);
            this.lblDataOutLength.Name = "lblDataOutLength";
            this.lblDataOutLength.Size = new System.Drawing.Size(32, 25);
            this.lblDataOutLength.TabIndex = 1;
            this.lblDataOutLength.Text = "00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(138, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Data OUT Length :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.btnClearDataOut);
            this.groupBox4.Controls.Add(this.btnSenddata);
            this.groupBox4.Location = new System.Drawing.Point(11, 289);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(496, 147);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.chBoxWrite);
            this.groupBox6.Controls.Add(this.chBoxWriteLine);
            this.groupBox6.Location = new System.Drawing.Point(254, 28);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(189, 98);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            // 
            // chBoxWrite
            // 
            this.chBoxWrite.AutoSize = true;
            this.chBoxWrite.Location = new System.Drawing.Point(6, 52);
            this.chBoxWrite.Name = "chBoxWrite";
            this.chBoxWrite.Size = new System.Drawing.Size(80, 29);
            this.chBoxWrite.TabIndex = 1;
            this.chBoxWrite.Text = "Write";
            this.chBoxWrite.UseVisualStyleBackColor = true;
            this.chBoxWrite.CheckedChanged += new System.EventHandler(this.chBoxWrite_CheckedChanged);
            // 
            // chBoxWriteLine
            // 
            this.chBoxWriteLine.AutoSize = true;
            this.chBoxWriteLine.Location = new System.Drawing.Point(6, 15);
            this.chBoxWriteLine.Name = "chBoxWriteLine";
            this.chBoxWriteLine.Size = new System.Drawing.Size(111, 29);
            this.chBoxWriteLine.TabIndex = 0;
            this.chBoxWriteLine.Text = "WriteLine";
            this.chBoxWriteLine.UseVisualStyleBackColor = true;
            this.chBoxWriteLine.CheckedChanged += new System.EventHandler(this.chBoxWriteLine_CheckedChanged);
            // 
            // btnClearDataOut
            // 
            this.btnClearDataOut.Location = new System.Drawing.Point(63, 86);
            this.btnClearDataOut.Name = "btnClearDataOut";
            this.btnClearDataOut.Size = new System.Drawing.Size(151, 40);
            this.btnClearDataOut.TabIndex = 3;
            this.btnClearDataOut.Text = "Clear Data OUT";
            this.btnClearDataOut.UseVisualStyleBackColor = true;
            this.btnClearDataOut.Click += new System.EventHandler(this.btnClearDataOut_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblDataINLength);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.chBoxAddtoOldData);
            this.groupBox5.Controls.Add(this.chBoxAllwaysUpdate);
            this.groupBox5.Controls.Add(this.btnClearDataIN);
            this.groupBox5.Controls.Add(this.tBoxReceiverControl);
            this.groupBox5.Location = new System.Drawing.Point(943, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(522, 489);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Receiver Control";
            // 
            // tBoxReceiverControl
            // 
            this.tBoxReceiverControl.Location = new System.Drawing.Point(8, 30);
            this.tBoxReceiverControl.Multiline = true;
            this.tBoxReceiverControl.Name = "tBoxReceiverControl";
            this.tBoxReceiverControl.Size = new System.Drawing.Size(497, 257);
            this.tBoxReceiverControl.TabIndex = 7;
            // 
            // btnClearDataIN
            // 
            this.btnClearDataIN.Location = new System.Drawing.Point(45, 317);
            this.btnClearDataIN.Name = "btnClearDataIN";
            this.btnClearDataIN.Size = new System.Drawing.Size(131, 98);
            this.btnClearDataIN.TabIndex = 8;
            this.btnClearDataIN.Text = "Clear Data IN";
            this.btnClearDataIN.UseVisualStyleBackColor = true;
            this.btnClearDataIN.Click += new System.EventHandler(this.btnClearDataIN_Click);
            // 
            // chBoxAllwaysUpdate
            // 
            this.chBoxAllwaysUpdate.AutoSize = true;
            this.chBoxAllwaysUpdate.Location = new System.Drawing.Point(266, 329);
            this.chBoxAllwaysUpdate.Name = "chBoxAllwaysUpdate";
            this.chBoxAllwaysUpdate.Size = new System.Drawing.Size(160, 29);
            this.chBoxAllwaysUpdate.TabIndex = 9;
            this.chBoxAllwaysUpdate.Text = "Allways Update";
            this.chBoxAllwaysUpdate.UseVisualStyleBackColor = true;
            this.chBoxAllwaysUpdate.CheckedChanged += new System.EventHandler(this.chBoxAllwaysUpdate_CheckedChanged);
            // 
            // chBoxAddtoOldData
            // 
            this.chBoxAddtoOldData.AutoSize = true;
            this.chBoxAddtoOldData.Location = new System.Drawing.Point(266, 369);
            this.chBoxAddtoOldData.Name = "chBoxAddtoOldData";
            this.chBoxAddtoOldData.Size = new System.Drawing.Size(171, 29);
            this.chBoxAddtoOldData.TabIndex = 10;
            this.chBoxAddtoOldData.Text = "Add To Old Data";
            this.chBoxAddtoOldData.UseVisualStyleBackColor = true;
            this.chBoxAddtoOldData.CheckedChanged += new System.EventHandler(this.chBoxAddtoOldData_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(136, 436);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Data IN Length :";
            // 
            // lblDataINLength
            // 
            this.lblDataINLength.AutoSize = true;
            this.lblDataINLength.Location = new System.Drawing.Point(288, 436);
            this.lblDataINLength.Name = "lblDataINLength";
            this.lblDataINLength.Size = new System.Drawing.Size(32, 25);
            this.lblDataINLength.TabIndex = 12;
            this.lblDataINLength.Text = "00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1487, 522);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "COM PORT SERIAL";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cBoxBaudRate;
        private ComboBox cBoxDataBits;
        private ComboBox cBoxparityBits;
        private ComboBox cBoxStopBits;
        private ComboBox cBoxCOMPort;
        private GroupBox groupBox2;
        private ProgressBar progressBar1;
        private Button btnClose;
        private Button btnOpen;
        private Button btnSenddata;
        private TextBox tBoxDataOut;
        private GroupBox groupBox3;
        private GroupBox groupBox7;
        private Label lblDataOutLength;
        private Label label6;
        private GroupBox groupBox4;
        private GroupBox groupBox6;
        private CheckBox chBoxWrite;
        private CheckBox chBoxWriteLine;
        private Button btnClearDataOut;
        private GroupBox groupBox8;
        private Label lblCOMStatus;
        private GroupBox groupBox5;
        private Label lblDataINLength;
        private Label label7;
        private CheckBox chBoxAddtoOldData;
        private CheckBox chBoxAllwaysUpdate;
        private Button btnClearDataIN;
        private TextBox tBoxReceiverControl;
    }
}