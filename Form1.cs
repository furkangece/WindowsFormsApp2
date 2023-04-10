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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {

        bool flag = false;

        public Form1()
        {
            InitializeComponent();
        }
        private async void btnStart_1_Click_1(object sender, EventArgs e)
        {

            btnStart.Enabled = false;
            btnStop.Enabled = true;

            flag = true;
            await Task.Run(() => CountUpAsync());


        }
        private async void stopBtn_1_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            flag = false;
        }
        private async Task CountUpAsync()
        {
            while (flag)
            {
                await Task.Run(() => up1());
                await Task.Run(() => up2());
                Thread.Sleep(1000);

            }
        }

        private void sifirla()
        {
            count1 = 0;
            count2 = 0;
            label1.Text = "";
            label2.Text = "";
        }

        private void SifirlaBtn_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            flag = false;
            sifirla();

        }

        private async Task up1()
        {
            count1++;

            if (label1.InvokeRequired)
            {
                label1.Invoke(new Action(() => label1.Text = count1.ToString()));
            }
            else
            {
                label1.Text = count1.ToString();
            }

        }
        private async Task up2()
        {
            count2 += 2;

            if (label1.InvokeRequired)
            {
                label1.Invoke(new Action(() => label2.Text = count2.ToString()));
            }
            else
            {
                label2.Text = count2.ToString();
            }
        }
    }
}
