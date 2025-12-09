using System;
using System.Management;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;
using System.IO.Ports;

namespace AT89S52_AVR8051_Programmer
{
    public partial class Port_Form : Form
    {
        public static string portName;

        bool isBrowseExe = false;
        bool isBrowseConfig = false;
        bool isPortSelected = false;
        public static bool isBrowseHex = false;
        int Pflag = 0;
        int Cflag = 0;
        int Hflag = 0;


        public Port_Form()
        {
            InitializeComponent();
        }

        private void Port_Form_Load(object sender, EventArgs e)
        {
            Gvar.count++;
            GetPortList();
        }

        private void GetPortList()
        {
            var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity WHERE Caption LIKE '%(COM%'");

            foreach (var obj in searcher.Get())
            {
                string portDescription = obj["Caption"].ToString();
                comboBox1.Items.Add(portDescription); // Add to ComboBox
            }

        }

        private bool isAllBrowse()
        {
            if (Pflag == 1 && Cflag == 1 && Hflag == 1)
                return true;
            else
                return false;
        }


        private void flash_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedItem != null)
            {
                string tempDir = Path.Combine(Path.GetTempPath(), "ProgrammerResources");
                if (!Directory.Exists(tempDir))
                {
                    Directory.CreateDirectory(tempDir);
                }

                string exePath = Path.Combine(tempDir, "Programmer.exe");
                string configPath = Path.Combine(tempDir, "ChipConfig.conf");
                string hexPath = Path.Combine(tempDir, "Default.hex");

                File.WriteAllBytes(exePath, Properties.Resources.Programmer);
                File.WriteAllBytes(configPath, Properties.Resources.ChipConfig);
                File.WriteAllBytes(hexPath, Properties.Resources.ISP);

                Gvar.ExePath = exePath;
                Gvar.ConfigPath = configPath;

                string programmer = "arduino";
                string targetChip = "m328p";

                int baudRate = 115200;
                string hexFilePath = @openFileDialog3.FileName;


                string arguments = $"-C \"{configPath}\" -c {programmer} -p {targetChip} -P {portName} -b {baudRate} -U flash:w:\"{hexFilePath}\":a";

                MessageBox.Show("Flashing process will Start.");

                Process process = Process.Start(Gvar.ExePath, arguments);
                process.WaitForExit();

                MessageBox.Show("Flashing successful.");

                Form1.isUploadHex = true;
                Form1.portFlag = 1;

                this.Hide();
            }
            else
                MessageBox.Show("Select the Com Port.");

        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedPort = comboBox1.SelectedItem.ToString();
            portName = selectedPort.Substring(selectedPort.LastIndexOf("(COM") + 1).Trim('(', ')');

        }
    }
}
