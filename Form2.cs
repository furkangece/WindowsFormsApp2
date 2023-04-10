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

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        bool flag1 = false;
        bool flag2 = false;

        public Form2()
        {
            InitializeComponent();
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            btnStart1.Enabled = false;
            btnStop1.Enabled = true;
            flag1 = true;
            await Task.Run(() => CountUpAsync());
        }

        private async void btnStart2_Click(object sender, EventArgs e)
        {
            btnStart2.Enabled = false;
            btnStop2.Enabled = true;
            flag2 = true;
            await Task.Run(() => CountUpAsync2());
        }

        private void btnStop1_Click(object sender, EventArgs e)
        {
            btnStart1.Enabled = true;
            btnStop1.Enabled = false;
            flag1 = false;
        }

        private void btnStop2_Click(object sender, EventArgs e)
        {
            btnStart2.Enabled=true;
            btnStop2.Enabled = false;
            flag2 = false;
        }
        private async Task CountUpAsync()
        {
            while (flag1)
            {
                await Task.Run(() => up1());
                Thread.Sleep(1000);

            }
        }
        private async Task CountUpAsync2()
        {
            while (flag2)
            {
                await Task.Run(() => up2());
                Thread.Sleep(1000);
            }
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
