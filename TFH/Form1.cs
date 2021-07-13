using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using Microsoft.Win32;
using System.Security.Principal;
using System.IO;

namespace TFH
{
    
    public partial class Form1 : Form
    {
        int Time1 = 0;
        int Time2 = 0;
        int Time3 = 0;
        bool b = true;
        SoundPlayer player = new SoundPlayer();

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            // if client need enable start up
            var reg = Registry.CurrentUser.OpenSubKey(@"Software\TFH\Settings");
            if (reg == null)
            {
                var setstartup = new SetingStartup();
                setstartup.ShowDialog();
            }
        }

        // Timer And Alarms
        private void timer1_Tick(object sender, EventArgs e)
        {
            Time1 = Time1 +1;
            lbltime1.Text = Convert.ToString(Time1);
            if (Time1 == 60)
            {
                Time1 = -1;
                lbltime1.Text = Convert.ToString(0);

                Time2 = Time2 + 1;
                lbltimer2.Text = Convert.ToString(Time2);
                Time1 = Time1 + 1;
                lbltime1.Text = Convert.ToString(Time1);       
            }
            if(Time2 ==60)
            {
                Time2 = -1;
                lbltimer2.Text = Convert.ToString(0);
                Time3 = Time3 + 1;
                lbltimer3.Text = Convert.ToString(Time3);
                Time2 = Time2 + 1;
                lbltimer2.Text = Convert.ToString(Time2);
            }

            // Send Alarm
                if (Time2 == 30 && Time1==0 || Time2 == 59 && Time1 == 59)
                {
                
                timer1.Stop();
                player.Play();
               DialogResult CS = MessageBox.Show("شما زمان زیادی را صرف نشستن پشت کامپیوتر کرده اید به شما پیشنهاد می کنیم 5 دقیقه استراحت کنید ،،، آیا مایل به ادامه شمارش زمان هستید؟", "پیام",MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (CS == DialogResult.Yes)
                {
                    timer1.Start();
                    player.Stop();
                }
                else if (CS == DialogResult.No)
                {
                    btncontinue.Focus();
                    player.Stop();
                } 
                    
                    
            }
            
        }
        //End of Timer


        //Buttons' Codes
        #region All of Buttons' Codes In Form1
        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnhowwork_Click(object sender, EventArgs e)
        {
            Form aboutp = new aboutProgram();
            aboutp.ShowDialog();
        }

        private void btnsettings_Click(object sender, EventArgs e)
        {
            var frm = new Settings();
            frm.ShowDialog();
        }

        private void btncredit_Click(object sender, EventArgs e)
        {
            Form creator = new creators();
            creator.ShowDialog();
        }

        private void btnversion_Click(object sender, EventArgs e)
        {
            Form version = new version();
            version.ShowDialog();
        }
        #region Timer Stop and Start(Continue) 
        private void btnstop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void btncontinue_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            Time1 = 0;
            Time2 = 0;
            Time3 = 0;
            lbltime1.Text = Convert.ToString(0);
            lbltimer2.Text = Convert.ToString(0);
            lbltimer3.Text = Convert.ToString(0);
        }

        #endregion

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnwebsite_Click(object sender, EventArgs e)
        {
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                Process.Start("http://nanenoghli.blog.ir/post/time-for-health-v3");
            }
            else
                MessageBox.Show("شما به اینترنت متصل نیستید ، لطفا اول به اینترنت متصل شوید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string str = Application.ExecutablePath+ @"data\music\alarm.wav";
            str = str.Replace("Time for health.EXE", "");
            str = str.Replace("Time for health.exe", "");
            player.SoundLocation = str;
        }
        #endregion
        //End of Buttons' Codes
    }
}
