using Distance_Camera_Editor.Properties;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distance_Camera_Editor
{
    public partial class settingsForm : MetroForm
    {
        public settingsForm()
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

            steamPathTextBox.Text = Settings.Default.steamPath;

        }

        private void settingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            for (int index = 0; index < 10; ++index)
            {
                Thread.Sleep(20);
                this.Opacity = this.Opacity - 0.1;
            }
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
                {
                    Settings.Default.steamPath = steamPathTextBox.Text;
                }
                else
                {
                    steamPathTextBox.Text = Settings.Default.steamPath = folderBrowserDialog.SelectedPath;
                }
            }
            
            Settings.Default.Save();
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
