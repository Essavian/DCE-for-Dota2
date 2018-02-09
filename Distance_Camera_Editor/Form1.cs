using Distance_Camera_Editor.Properties;
using MetroFramework.Forms;
using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace Distance_Camera_Editor
{
    public partial class mainForm : MetroForm
    {
        public string steamPath = "";

        public mainForm()
        {
            InitializeComponent();
            timer1.Tick += (EventHandler)((sender, e) =>
            {
                if ((Opacity = Opacity + 0.1) != 1.0)
                    return;
                timer1.Stop();
            });
            timer1.Interval = 30;
            timer1.Start();

            oldValueTextBox.Text = Settings.Default.oldValue;

            Count();

            newValueComboBox.Text = newValueComboBox.Items[0].ToString();

            if (Settings.Default.firstLaunch)
            {
                FirstLaunch();
            }
        }

        public void Count()
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://j92300qq.beget.tech/dce/count.php");
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                response.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void FirstLaunch()
        {
            try
            {
                Settings.Default.steamPath = GetSteamPath();
                if (new settingsForm().ShowDialog() == DialogResult.OK)
                {
                    Settings.Default.path = GetFullPath(Settings.Default.steamPath);
                }

                Settings.Default.firstLaunch = false;
                Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void infoBtn_Click(object sender, EventArgs e)
        {
            aboutForm about = new aboutForm();
            about.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            for (int index = 0; index < 10; ++index)
            {
                Thread.Sleep(20);
                this.Opacity = this.Opacity - 0.1;
            }
        }

        bool nonNumberEntered;

        private void oldValueTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            nonNumberEntered = false;
            if ((e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9) && (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9) && e.KeyCode != Keys.Back)
                this.nonNumberEntered = true;
            if (Control.ModifierKeys != Keys.Shift)
                return;
            nonNumberEntered = true;
        }

        private void oldValueTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!nonNumberEntered)
                return;
            e.Handled = true;
        }

        private void modufyBtn_Click(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName("dota2").Any())
            {
                statusTextBox.Visible = true;
                statusTextBox.ForeColor = Color.Red;
                statusTextBox.Text = "Close Dota 2!";
                return;
            }
            if ((Convert.ToInt32(oldValueTextBox.Text) < 1134 || Convert.ToInt32(oldValueTextBox.Text) > 1600))
            {
                oldValueTextBox.Focus();
                errorPic.Visible = true;
                statusTextBox.Visible = true;
                statusTextBox.ForeColor = Color.Red;
                statusTextBox.Text = "Incorrect value. 1134 <= your_value <= 1600";
            }
            else
            {
                statusTextBox.Visible = false;
                errorPic.Visible = false;
                string text1 = oldValueTextBox.Text;
                string text2 = newValueComboBox.Text;
                Settings.Default.oldValue = text2;
                Settings.Default.Save();
                FileEditor.ModifyClient(Settings.Default.path, text1, text2);
                mainPanel.Visible = false;
                successPanel.Visible = true;               
            }
        }

        public string GetPathToRightClient()
        {
            return Environment.Is64BitOperatingSystem ? "\\steamapps\\common\\dota 2 beta\\game\\dota\\bin\\win64\\" : "\\steamapps\\common\\dota 2 beta\\game\\dota\\bin\\win32\\";
        }

        public string GetSteamPath()
        {
            return Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Valve\Steam", "InstallPath", null).ToString();
        }

        public string GetFullPath()
        {
            return steamPath += GetPathToRightClient();
        }

        public string GetFullPath(string path)
        {
            return path += GetPathToRightClient();
        }

        public string GetPathToRightDota()
        {
            return Environment.Is64BitOperatingSystem ? "\\steamapps\\common\\dota 2 beta\\game\\bin\\win64\\" : "\\steamapps\\common\\dota 2 beta\\game\\bin\\win64\\";
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            if (new settingsForm().ShowDialog() == DialogResult.OK)
            {
                Settings.Default.path = GetFullPath(Settings.Default.steamPath);
            }
            Settings.Default.Save();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            mainPanel.Visible = true;
            successPanel.Visible = false;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Process.Start(Settings.Default.steamPath + GetPathToRightDota() + "dota2.exe");
            Close();
        }
    }
}
