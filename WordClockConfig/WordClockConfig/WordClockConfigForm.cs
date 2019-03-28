using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordClockConfig
{
    public partial class WordClockConfigForm : Form
    {
        private System.Windows.Forms.Timer m_UpdateTimeTimer;
        private bool m_TimeSetManually;

        public WordClockConfigForm()
        {
            InitializeComponent();
        }

        private void WordClockConfigForm_Load(object sender, EventArgs e)
        {
            Task.Factory.StartNew(PopulateSerialPorts);

            m_UpdateTimeTimer = new System.Windows.Forms.Timer();
            m_UpdateTimeTimer.Interval = 1000;
            m_UpdateTimeTimer.Tick += UpdateTime;
            m_UpdateTimeTimer.Enabled = true;
        }

        private void UpdateTime(object sender, EventArgs e)
        {
            if (Disposing || IsDisposed)
                return;

            if (m_TimeSetManually)
            {
                m_UpdateTimeTimer.Enabled = false;
            }
            else
            {
                m_DatePicker.Value = DateTime.Now;
                m_TimePicker.Value = DateTime.Now;
                m_TimeSetManually = false;
            }
        }

        private void PopulateSerialPorts()
        {
            var ports = SerialPort.GetPortNames();
            Invoke(new MethodInvoker(() =>
            {
                if (Disposing || IsDisposed)
                    return;
                m_PortPicker.Items.Clear();
                Array.ForEach(ports, port => m_PortPicker.Items.Add(port));
            }));
        }

        private void TimeChanged(object sender, EventArgs e)
        {
            m_TimeSetManually = true;
        }

        private void SaveConfigurationClicked(object sender, EventArgs e)
        {
            string port = m_PortPicker.Text;
            if (string.IsNullOrWhiteSpace(port))
            {
                MessageBox.Show("No port selected");
                return;
            }
            DateTime time = m_DatePicker.Value.Date + m_TimePicker.Value.TimeOfDay;

            Task.Factory.StartNew(() => SaveConfiguration(port, time));
        }

        private void SaveConfiguration(string portName, DateTime time)
        {
            try
            {
                using (SerialPort port = new SerialPort(portName))
                {
                    port.BaudRate = 115200;
                    port.Open();
                    port.WriteTimeout = 1000;
                    string timeString = time.ToString("Dyyyy,MM,dd,HH,mm,ss");
                    port.WriteLine(timeString);
                    port.Close();
                }
                Invoke(new MethodInvoker(() =>
                {
                    if (Disposing || IsDisposed)
                        return;
                    MessageBox.Show("Configuration saved");
                }));
            }
            catch (Exception ex)
            {
                Invoke(new MethodInvoker(() =>
                {
                    if (Disposing || IsDisposed)
                        return;
                    MessageBox.Show("Error saving configuration: " + ex.Message);
                }));
            }
        }
    }
}
