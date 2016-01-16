using System;
using System.Linq;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.Win32;
namespace imSwitcher
{
    public partial class Form : System.Windows.Forms.Form
    {
        private string UseCHT = "1";

        public Form()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Reads a key under HKEY_CURRENT_USER.
        /// </summary>
        /// <param name="SubKey">The subkey path to read.</param>
        /// <param name="KeyName">The subkey name.</param>
        /// <returns></returns>
        private string ReadReg(string SubKey, string KeyName)
        {
            RegistryKey HKCU = Registry.CurrentUser;
            RegistryKey Reg = HKCU.OpenSubKey(SubKey);
            string data = Reg.GetValue(KeyName).ToString();
            return data;
        }

        /// <summary>
        /// Writes a subkey to HKEY_CURRENT_USER
        /// </summary>
        /// <param name="SubKey">The subkey path to write.</param>
        /// <param name="KeyName">The subkey name.</param>
        /// <param name="value">Expected value.</param>
        /// <param name="type">RegistryValueKind</param>
        private void WriteReg(string SubKey, string KeyName, string value, RegistryValueKind type)
        {
            RegistryKey HKCU = Registry.CurrentUser;
            RegistryKey Reg = HKCU.OpenSubKey(SubKey, true);
            Reg.SetValue(KeyName, value, type);
        }

        /// <summary>
        /// Which checks the registry and help fill the checklist.
        /// </summary>
        private void LoadInitialSettings()
        {
            string[] a = new String[4];
            a[0] = ReadReg("SOFTWARE\\Microsoft\\InputMethod\\Settings\\CHS", "Enable Auto Correction");
            a[1] = ReadReg("SOFTWARE\\Microsoft\\InputMethod\\Settings\\CHS", "Enable Cloud Candidate");
            a[2] = ReadReg("SOFTWARE\\Microsoft\\InputMethod\\Settings\\CHS", "Enable Fuzzy Input");
            a[3] = ReadReg("SOFTWARE\\Microsoft\\InputMethod\\Settings\\CHS", "Enable Self-learning");
            for(int i=0;i<4;i++)
            {
                Settings.SetItemChecked(i, a[i] == "1");
            }
        }

        /// <summary>
        /// Prevent loading after an existing process.
        /// Load initialization value from the registry to choose the icon.
        /// </summary>
        private void Form_Load(object sender, EventArgs e)
        {
            if (System.Diagnostics.Process.GetProcessesByName("imSwitcher").ToList().Count > 1)
            {
                MessageBox.Show("There is already an instance of imSwitcher running...\nPlease notice your notify bar.");
                Visible = false;
                Application.Exit();
            }

            UseCHT = ReadReg("SOFTWARE\\Microsoft\\InputMethod\\Settings\\CHS", "Output CharSet");
            if(UseCHT == "0")
            {
                Notify.Text = "MSPY - " + "CHS";
                Notify.Icon = Properties.Resources.IconCHS;
            }

            LoadInitialSettings();
        }

        private void Form_Shown(object sender, EventArgs e)
        {
            Visible = false;
        }

        /// <summary>
        /// When LMB clicked, switch the charset.
        /// </summary>
        private void Notify_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if(UseCHT == "1")
                {
                    UseCHT = "0";
                    WriteReg("SOFTWARE\\Microsoft\\InputMethod\\Settings\\CHS", "Output CharSet", UseCHT, RegistryValueKind.DWord);
                    Notify.Text = "MSPY - " + "CHS";
                    Notify.Icon = Properties.Resources.IconCHS;
                }
                else if(UseCHT == "0")
                {
                    UseCHT = "1";
                    WriteReg("SOFTWARE\\Microsoft\\InputMethod\\Settings\\CHS", "Output CharSet", UseCHT, RegistryValueKind.DWord);
                    Notify.Text = "MSPY - " + "CHT";
                    Notify.Icon = Properties.Resources.IconCHT;
                }
            }
        }

        /// <summary>
        /// Let's do some 引流 by using a glass stick.
        /// </summary>
        private void SiteLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.nottres.com");
        }

        /// <summary>
        /// There's no way to escape,
        /// But you can hide the main window.
        /// </summary>
        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(Visible == true)
            {
                Visible = false;
                e.Cancel = true;
            }
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visible = true;
        }

        /// <summary>
        /// Shows the about dialog.
        /// </summary>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("imSwitcher\nWin 8+輸入法便捷工具\nMade by Michael\n你再也不用進行繁瑣的簡繁切換了！\nhttps://www.nottres.com", "關於 imSwitcher", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// When settings changed, apply it to the registry.
        /// </summary>
        private void Settings_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string value = e.NewValue == CheckState.Checked ? "1" : "0";
            string KeyName;
            switch (e.Index)
            {
                default: return;
                case 0:
                    KeyName = "Enable Auto Correction";
                    break;
                case 1:
                    KeyName = "Enable Cloud Candidate";
                    break;
                case 2:
                    KeyName = "Enable Fuzzy Input";
                    break;
                case 3:
                    KeyName = "Enable Self-learning";
                    break;
            }
            WriteReg("SOFTWARE\\Microsoft\\InputMethod\\Settings\\CHS", KeyName, value, RegistryValueKind.DWord);
        }
    }
}
