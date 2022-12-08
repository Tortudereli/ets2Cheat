using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ets2Cheat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            moduleAddress();
        }
        
        public void moduleAddress()
        {
            Process process = Process.GetProcessesByName("eurotrucks2")[0]; 
            foreach (ProcessModule module in process.Modules)
            {
                if (module.FileName.IndexOf("eurotrucks2.exe") != -1)
                {
                    offsetProcess(module.BaseAddress.ToString());
                }
            }
        }

        public void offsetProcess(string moduleAddress)
        {
            VAMemory vam = new VAMemory("eurotrucks2");
            long _BaseAddress = long.Parse(moduleAddress);
            if (checkBox1.Checked == true)
            {
                long _address = vam.ReadLong((IntPtr)(_BaseAddress + 0x01C1BF28));
                long _address1 = vam.ReadLong((IntPtr)_address + 0x10);
                long _address2 = _address1 + 0x10;
                vam.WriteLong((IntPtr)_address2, 0x7EFFFFFFFFFFFFFF);
            }
            if (checkBox2.Checked == true)
            {
                long _address = vam.ReadLong((IntPtr)(_BaseAddress + 0x01C1BF28));
                long _address1 = _address + 0x195C;
                vam.WriteInt64((IntPtr)_address1, 0x32D3E940FEFFFFFF);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://www.github.com/Tortudereli") { UseShellExecute = true });
        }
    }
}
