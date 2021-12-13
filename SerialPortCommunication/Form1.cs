using System.Management;
using System.IO.Ports;
using System.Windows.Forms;

namespace SerialPortCommunication
{
    public partial class Form1 : Form
    {
        static SerialPort _serialPort;
        string dataOut = "";
        string sendWith = "Write";
        string dataIN = "";
        StreamWriter _streamWriter;
        string basePath = AppDomain.CurrentDomain.BaseDirectory.Split("bin")[0];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cBoxCOMPort.Items.AddRange(ports);

            btnOpen.Enabled = true;
            btnClose.Enabled = false;
            chBoxWrite.Checked = true;
            chBoxWriteLine.Checked = false;
            chBoxAddtoOldData.Checked = true;
            chBoxAllwaysUpdate.Checked = false;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try {
                // Create a new SerialPort object with default settings.
                _serialPort = new SerialPort();

                // Attach a method to be called when there
                // is data waiting in the port's buffer
                _serialPort.DataReceived += new SerialDataReceivedEventHandler(SerialPort_DataReceived);

                // Allow the user to set the appropriate properties.
                _serialPort.PortName = cBoxCOMPort.Text;
                _serialPort.BaudRate = Convert.ToInt32(cBoxBaudRate.Text);
                _serialPort.Parity = (Parity)Enum.Parse(typeof(Parity),cBoxparityBits.Text);
                _serialPort.DataBits = Convert.ToInt32(cBoxDataBits.Text);
                _serialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cBoxStopBits.Text);

                _serialPort.Open();
                progressBar1.Value = 100;
                
                btnOpen.Enabled = false;
                btnClose.Enabled = true;
                lblCOMStatus.Text = "ON";
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnOpen.Enabled = true;
                btnClose.Enabled = false;
                lblCOMStatus.Text = "OFF";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (_serialPort.IsOpen)
            {
                _serialPort.Close();
                progressBar1.Value=0;
                btnOpen.Enabled = true;
                btnClose.Enabled = false;
                lblCOMStatus.Text = "OFF";
            }

        }

        private void btnSenddata_Click(object sender, EventArgs e)
        {
            if (_serialPort.IsOpen)
            {
                dataOut = tBoxDataOut.Text;
                if (sendWith == "WriteLine")
                {
                    _serialPort.WriteLine(dataOut);
                }
                else {
                    _serialPort.Write(dataOut);
                }
            }
        }
        private void btnClearDataOut_Click(object sender, EventArgs e)
        {
            if(tBoxDataOut.Text != "")
            {
                tBoxDataOut.Text = "";
            }
        }

        private void tBoxDataOut_TextChanged(object sender, EventArgs e)
        {
            lblDataOutLength.Text = (tBoxDataOut.TextLength).ToString();
        }

        private void chBoxWriteLine_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxWriteLine.Checked)
            {
                sendWith = "WriteLine";
                chBoxWrite.Checked = false;
                chBoxWriteLine.Checked = true;
            }
        }

        private void chBoxWrite_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxWrite.Checked)
            {
                sendWith = "Write";
                chBoxWrite.Checked = true;
                chBoxWriteLine.Checked = false;
            }

        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            dataIN = _serialPort.ReadExisting();
            this.Invoke(new EventHandler(ShowData));
        }
        private void ShowData(object sender, EventArgs e) 
        {
            if (chBoxAllwaysUpdate.Checked)
            {
                tBoxReceiverControl.Text = dataIN.ToString();
            }
            else
            {
                tBoxReceiverControl.Text += dataIN.ToString();
            }
            lblDataINLength.Text = (tBoxReceiverControl.TextLength).ToString();

            try {
                string actualPath = basePath + "DataFile\\ReceiverORSenderData.txt";
                _streamWriter = new StreamWriter(actualPath);
                _streamWriter.WriteLine("-----------Data comining from out said Begin-------------------");
                _streamWriter.WriteLine(dataIN.ToString());
                _streamWriter.WriteLine("-----------Data comining from out said End-------------------");
                _streamWriter.Close();
            }
            catch (Exception ex) {
                _streamWriter.Close();
                MessageBox.Show(ex.Message);
            }

        }

        private void chBoxAllwaysUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxAllwaysUpdate.Checked)
            {
                chBoxAllwaysUpdate.Checked = true;
                chBoxAddtoOldData.Checked = false;
            }
        }

        private void chBoxAddtoOldData_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxAddtoOldData.Checked)
            {
                chBoxAddtoOldData.Checked = true;
                chBoxAllwaysUpdate.Checked = false;
            }
        }

        private void btnClearDataIN_Click(object sender, EventArgs e)
        {
            if (tBoxReceiverControl.Text != "")
            {
                tBoxReceiverControl.Text = "";
            }
        }
    }
}