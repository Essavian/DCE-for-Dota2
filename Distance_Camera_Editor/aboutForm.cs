using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distance_Camera_Editor
{
    public partial class aboutForm : MetroForm
    {
        public aboutForm()
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
        }

        private void telegramLink_Click(object sender, EventArgs e)
        {
            Process.Start("https://telegram.me/Essavian");
        }

        private void steamLink_Click(object sender, EventArgs e)
        {
            Process.Start("http://steamcommunity.com/id/essavian/");
        }

        private void d2ruLink_Click(object sender, EventArgs e)
        {
            Process.Start("https://dota2.ru/forum/members/essavian.511976/");
        }

        private void aboutForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            for (int index = 0; index < 10; ++index)
            {
                Thread.Sleep(20);
                this.Opacity = this.Opacity - 0.1;
            }
        }
    }
}
