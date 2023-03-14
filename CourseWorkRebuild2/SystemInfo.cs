using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CourseWorkRebuild2
{
    public partial class SystemInfo : Form
    {
        public SystemInfo()
        {
            InitializeComponent();
        }

        private void SystemInfo_Load(object sender, EventArgs e)
        {
            label1.Text = "";

            // Get operating system information
            OperatingSystem os = Environment.OSVersion;
            string osInfo = string.Format("Operating System: {0} {1} {2}\n",
                                          os.Platform.ToString(), os.Version.ToString(), os.ServicePack.ToString());
            label1.Text = osInfo;

            // Get processor information
            string processorInfo = string.Format("Processor: {0}\n", Environment.GetEnvironmentVariable("PROCESSOR_IDENTIFIER"));
            label2.Text = processorInfo;

            // Get memory information
            ManagementObjectSearcher memorySearcher = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMemory");
            ulong totalMemory = 0;
            foreach (ManagementObject memory in memorySearcher.Get())
            {
                totalMemory += Convert.ToUInt64(memory["Capacity"]);
            }
            string memoryInfo = string.Format("Memory: {0} GB\n", (double)totalMemory / (1024 * 1024 * 1024));
            label3.Text = memoryInfo;

            // Get .NET framework version information
            string runtimeVersion = Environment.Version.ToString();
            string frameworkVersion = string.Format(".NET Framework Version: {0}\n", runtimeVersion);
            label4.Text = frameworkVersion;
        }
    }
}
