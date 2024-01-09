using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;
using Newtonsoft.Json.Linq;

namespace ets2Cheat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        JObject json, versionListjson;
        VAMemory vam = new VAMemory("eurotrucks2");
        long moneyAddress, tpAdress, speedAdress, damage0, damage1, damage2, damage3, damage4, damage5, damage6, damage7, damage8, damage9, damage10, damage11, damage12, damage13, damage14, damage15;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                vam.WriteLong((IntPtr)moneyAddress, 0x7EFFFFFFFFFFFFFF);
            }
            catch (Exception)
            {
                MessageBox.Show("Unsuccessful", "Opps", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                MessageBox.Show("Successful", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        public void moduleAddress()
        {
            try
            {
                Process process = Process.GetProcessesByName("eurotrucks2")[0];
                foreach (ProcessModule module in process.Modules)
                {
                    if (module.FileName.IndexOf("eurotrucks2.exe") != -1)
                    {
                        getOffsetProcess(module.BaseAddress.ToString());
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("I guess the game is not open. Run the game after you open it.", "Opps", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        public void getOffsetProcess(string moduleAddress)
        {
            try
            {

                long _BaseAddress = long.Parse(moduleAddress);

                long _moneyAddress = vam.ReadLong((IntPtr)_BaseAddress + Convert.ToInt32(json["baseAddress"].ToString(), 16));
                long _moneyAddress1 = vam.ReadLong((IntPtr)_moneyAddress + Convert.ToInt32(json["money"]["offset1"].ToString(), 16));
                moneyAddress = _moneyAddress1 + Convert.ToInt32(json["money"]["offset2"].ToString(), 16);

                long _tpAddress = vam.ReadLong((IntPtr)_BaseAddress + Convert.ToInt32(json["baseAddress"].ToString(), 16));
                tpAdress = _tpAddress + Convert.ToInt32(json["tp"]["offset1"].ToString(), 16);

                long _speedAdress = vam.ReadLong((IntPtr)_BaseAddress + Convert.ToInt32(json["speed"]["speedBaseAdress"].ToString(), 16));
                long _speedAdress1 = vam.ReadLong((IntPtr)_speedAdress + Convert.ToInt32(json["speed"]["offset1"].ToString(), 16));
                long _speedAdress2 = vam.ReadLong((IntPtr)_speedAdress1 + Convert.ToInt32(json["speed"]["offset2"].ToString(), 16));
                long _speedAdress3 = vam.ReadLong((IntPtr)_speedAdress2 + Convert.ToInt32(json["speed"]["offset3"].ToString(), 16));
                speedAdress = _speedAdress3 + Convert.ToInt32(json["speed"]["offset4"].ToString(), 16);

                long _damage0 = vam.ReadLong((IntPtr)_BaseAddress + Convert.ToInt32(json["baseAddress"].ToString(), 16));
                long _damage01 = vam.ReadLong((IntPtr)_damage0 + Convert.ToInt32(json["damage0"]["offset1"].ToString(), 16));
                long _damage02 = vam.ReadLong((IntPtr)_damage01 + Convert.ToInt32(json["damage0"]["offset2"].ToString(), 16));
                damage0 = _damage02 + Convert.ToInt32(json["damage0"]["offset3"].ToString(), 16);

                long _damage1 = vam.ReadLong((IntPtr)_BaseAddress + Convert.ToInt32(json["baseAddress"].ToString(), 16));
                long _damage11 = vam.ReadLong((IntPtr)_damage1 + Convert.ToInt32(json["damage1"]["offset1"].ToString(), 16));
                long _damage12 = vam.ReadLong((IntPtr)_damage11 + Convert.ToInt32(json["damage1"]["offset2"].ToString(), 16));
                damage1 = _damage12 + Convert.ToInt32(json["damage1"]["offset3"].ToString(), 16);

                long _damage2 = vam.ReadLong((IntPtr)_BaseAddress + Convert.ToInt32(json["baseAddress"].ToString(), 16));
                long _damage21 = vam.ReadLong((IntPtr)_damage2 + Convert.ToInt32(json["damage2"]["offset1"].ToString(), 16));
                long _damage22 = vam.ReadLong((IntPtr)_damage21 + Convert.ToInt32(json["damage2"]["offset2"].ToString(), 16));
                damage2 = _damage22 + Convert.ToInt32(json["damage2"]["offset3"].ToString(), 16);

                long _damage3 = vam.ReadLong((IntPtr)_BaseAddress + Convert.ToInt32(json["baseAddress"].ToString(), 16));
                long _damage31 = vam.ReadLong((IntPtr)_damage3 + Convert.ToInt32(json["damage3"]["offset1"].ToString(), 16));
                long _damage32 = vam.ReadLong((IntPtr)_damage31 + Convert.ToInt32(json["damage3"]["offset2"].ToString(), 16));
                long _damage33 = vam.ReadLong((IntPtr)_damage32 + Convert.ToInt32(json["damage3"]["offset3"].ToString(), 16));
                damage3 = _damage33 + Convert.ToInt32(json["damage3"]["offset4"].ToString(), 16);

                long _damage4 = vam.ReadLong((IntPtr)_BaseAddress + Convert.ToInt32(json["baseAddress"].ToString(), 16));
                long _damage41 = vam.ReadLong((IntPtr)_damage4 + Convert.ToInt32(json["damage4"]["offset1"].ToString(), 16));
                long _damage42 = vam.ReadLong((IntPtr)_damage41 + Convert.ToInt32(json["damage4"]["offset2"].ToString(), 16));
                long _damage43 = vam.ReadLong((IntPtr)_damage42 + Convert.ToInt32(json["damage4"]["offset3"].ToString(), 16));
                damage4 = _damage43 + Convert.ToInt32(json["damage4"]["offset4"].ToString(), 16);

                long _damage5 = vam.ReadLong((IntPtr)_BaseAddress + Convert.ToInt32(json["baseAddress"].ToString(), 16));
                long _damage51 = vam.ReadLong((IntPtr)_damage5 + Convert.ToInt32(json["damage5"]["offset1"].ToString(), 16));
                long _damage52 = vam.ReadLong((IntPtr)_damage51 + Convert.ToInt32(json["damage5"]["offset2"].ToString(), 16));
                long _damage53 = vam.ReadLong((IntPtr)_damage52 + Convert.ToInt32(json["damage5"]["offset3"].ToString(), 16));
                damage5 = _damage53 + Convert.ToInt32(json["damage5"]["offset4"].ToString(), 16);

                long _damage6 = vam.ReadLong((IntPtr)_BaseAddress + Convert.ToInt32(json["baseAddress"].ToString(), 16));
                long _damage61 = vam.ReadLong((IntPtr)_damage6 + Convert.ToInt32(json["damage6"]["offset1"].ToString(), 16));
                long _damage62 = vam.ReadLong((IntPtr)_damage61 + Convert.ToInt32(json["damage6"]["offset2"].ToString(), 16));
                long _damage63 = vam.ReadLong((IntPtr)_damage62 + Convert.ToInt32(json["damage6"]["offset3"].ToString(), 16));
                damage6 = _damage63 + Convert.ToInt32(json["damage6"]["offset4"].ToString(), 16);

                long _damage7 = vam.ReadLong((IntPtr)_BaseAddress + Convert.ToInt32(json["baseAddress"].ToString(), 16));
                long _damage71 = vam.ReadLong((IntPtr)_damage7 + Convert.ToInt32(json["damage7"]["offset1"].ToString(), 16));
                long _damage72 = vam.ReadLong((IntPtr)_damage71 + Convert.ToInt32(json["damage7"]["offset2"].ToString(), 16));
                long _damage73 = vam.ReadLong((IntPtr)_damage72 + Convert.ToInt32(json["damage7"]["offset3"].ToString(), 16));
                damage7 = _damage73 + Convert.ToInt32(json["damage7"]["offset4"].ToString(), 16);

                long _damage8 = vam.ReadLong((IntPtr)_BaseAddress + Convert.ToInt32(json["baseAddress"].ToString(), 16));
                long _damage81 = vam.ReadLong((IntPtr)_damage8 + Convert.ToInt32(json["damage8"]["offset1"].ToString(), 16));
                long _damage82 = vam.ReadLong((IntPtr)_damage81 + Convert.ToInt32(json["damage8"]["offset2"].ToString(), 16));
                long _damage83 = vam.ReadLong((IntPtr)_damage82 + Convert.ToInt32(json["damage8"]["offset3"].ToString(), 16));
                damage8 = _damage83 + Convert.ToInt32(json["damage8"]["offset4"].ToString(), 16);

                long _damage9 = vam.ReadLong((IntPtr)_BaseAddress + Convert.ToInt32(json["baseAddress"].ToString(), 16));
                long _damage91 = vam.ReadLong((IntPtr)_damage9 + Convert.ToInt32(json["damage9"]["offset1"].ToString(), 16));
                long _damage92 = vam.ReadLong((IntPtr)_damage91 + Convert.ToInt32(json["damage9"]["offset2"].ToString(), 16));
                long _damage93 = vam.ReadLong((IntPtr)_damage92 + Convert.ToInt32(json["damage9"]["offset3"].ToString(), 16));
                damage9 = _damage93 + Convert.ToInt32(json["damage9"]["offset4"].ToString(), 16);

                long _damageA = vam.ReadLong((IntPtr)_BaseAddress + Convert.ToInt32(json["baseAddress"].ToString(), 16));
                long _damageA1 = vam.ReadLong((IntPtr)_damageA + Convert.ToInt32(json["damage10"]["offset1"].ToString(), 16));
                long _damageA2 = vam.ReadLong((IntPtr)_damageA1 + Convert.ToInt32(json["damage10"]["offset2"].ToString(), 16));
                long _damageA3 = vam.ReadLong((IntPtr)_damageA2 + Convert.ToInt32(json["damage10"]["offset3"].ToString(), 16));
                damage10 = _damageA3 + Convert.ToInt32(json["damage10"]["offset4"].ToString(), 16);

                long _damageB = vam.ReadLong((IntPtr)_BaseAddress + Convert.ToInt32(json["baseAddress"].ToString(), 16));
                long _damageB1 = vam.ReadLong((IntPtr)_damageB + Convert.ToInt32(json["damage11"]["offset1"].ToString(), 16));
                long _damageB2 = vam.ReadLong((IntPtr)_damageB1 + Convert.ToInt32(json["damage11"]["offset2"].ToString(), 16));
                damage11 = _damageB2 + Convert.ToInt32(json["damage11"]["offset3"].ToString(), 16);

                long _damageC = vam.ReadLong((IntPtr)_BaseAddress + Convert.ToInt32(json["baseAddress"].ToString(), 16));
                long _damageC1 = vam.ReadLong((IntPtr)_damageC + Convert.ToInt32(json["damage12"]["offset1"].ToString(), 16));
                long _damageC2 = vam.ReadLong((IntPtr)_damageC1 + Convert.ToInt32(json["damage12"]["offset2"].ToString(), 16));
                damage12 = _damageC2 + Convert.ToInt32(json["damage12"]["offset3"].ToString(), 16);

                long _damageD = vam.ReadLong((IntPtr)_BaseAddress + Convert.ToInt32(json["baseAddress"].ToString(), 16));
                long _damageD1 = vam.ReadLong((IntPtr)_damageD + Convert.ToInt32(json["damage13"]["offset1"].ToString(), 16));
                long _damageD2 = vam.ReadLong((IntPtr)_damageD1 + Convert.ToInt32(json["damage13"]["offset2"].ToString(), 16));
                damage13 = _damageD2 + Convert.ToInt32(json["damage13"]["offset3"].ToString(), 16);

                long _damageE = vam.ReadLong((IntPtr)_BaseAddress + Convert.ToInt32(json["baseAddress"].ToString(), 16));
                long _damageE1 = vam.ReadLong((IntPtr)_damageE + Convert.ToInt32(json["damage14"]["offset1"].ToString(), 16));
                long _damageE2 = vam.ReadLong((IntPtr)_damageE1 + Convert.ToInt32(json["damage14"]["offset2"].ToString(), 16));
                damage14 = _damageE2 + Convert.ToInt32(json["damage14"]["offset3"].ToString(), 16);

                long _damageF = vam.ReadLong((IntPtr)_BaseAddress + Convert.ToInt32(json["baseAddress"].ToString(), 16));
                long _damageF1 = vam.ReadLong((IntPtr)_damageF + Convert.ToInt32(json["damage15"]["offset1"].ToString(), 16));
                long _damageF2 = vam.ReadLong((IntPtr)_damageF1 + Convert.ToInt32(json["damage15"]["offset2"].ToString(), 16));
                damage15 = _damageF2 + Convert.ToInt32(json["damage15"]["offset3"].ToString(), 16);
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred while pulling addresses", "Opps", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://www.github.com/Tortudereli") { UseShellExecute = true });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                vam.WriteUInt32((IntPtr)tpAdress, 0xFEFFFFFF);
            }
            catch (Exception)
            {
                MessageBox.Show("Unsuccessful", "Opps", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                MessageBox.Show("Successful", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            versionListjson = JObject.Parse(new WebClient().DownloadString("https://raw.githubusercontent.com/Tortudereli/ets2Cheat/main/versionList.json"));
            foreach (var item in versionListjson)
            {
                comboBox1.Items.Add(item.Key.ToString());
            }
            comboBox1.SelectedIndex = 0;
            json = JObject.Parse(new WebClient().DownloadString(versionListjson[comboBox1.SelectedItem].ToString()));
            moduleAddress();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                MessageBox.Show("It only works on your own truck and trailer.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                timer1.Start();
            }
            else
            {
                timer1.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            vam.WriteInt32((IntPtr)damage0, 0x0);
            vam.WriteInt32((IntPtr)damage1, 0x0);
            vam.WriteInt32((IntPtr)damage2, 0x0);
            vam.WriteInt32((IntPtr)damage3, 0x0);
            vam.WriteInt32((IntPtr)damage4, 0x0);
            vam.WriteInt32((IntPtr)damage5, 0x0);
            vam.WriteInt32((IntPtr)damage6, 0x0);
            vam.WriteInt32((IntPtr)damage7, 0x0);
            vam.WriteInt32((IntPtr)damage8, 0x0);
            vam.WriteInt32((IntPtr)damage9, 0x0);
            vam.WriteInt32((IntPtr)damage10, 0x0);
            vam.WriteInt32((IntPtr)damage11, 0x0);
            vam.WriteInt32((IntPtr)damage12, 0x0);
            vam.WriteInt32((IntPtr)damage13, 0x0);
            vam.WriteInt32((IntPtr)damage14, 0x0);
            vam.WriteInt32((IntPtr)damage15, 0x0);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            json = JObject.Parse(new WebClient().DownloadString(versionListjson[comboBox1.SelectedItem].ToString()));
            moduleAddress();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                timer2.Start();
            }
            else
            {
                timer2.Stop();
                vam.WriteFloat((IntPtr)damage0, 150);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            vam.WriteFloat((IntPtr)speedAdress, 200);
        }
    }
}
