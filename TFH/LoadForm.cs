using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TFH
{
    public partial class LoadForm : Form
    {
        int timeSaver = 0;
        bool closeloading = false;
        public LoadForm()
        {
            InitializeComponent();
        }

        private void LoadForm_Shown(object sender, EventArgs e)
        {
            timerLoad.Enabled = true;
        }

        private void timerLoad_Tick(object sender, EventArgs e)
        {
            timeSaver = timeSaver + 1;

            switch (timeSaver)
            {
                case 1:
                    lblLoading.Text = "Loading.";
                    break;

                case 2:
                    lblLoading.Text = "Loading..";
                    break;

                case 3:
                    lblLoading.Text = "Loading...";
                    break;

                case 4:
                    lblLoading.Text = "Loading.";
                    break;

                case 5:
                    lblLoading.Text = "Loading..";
                    break;

                case 6:
                    lblLoading.Text = "Loading...";
                    break;

                case 7:
                    lblLoading.Text = "Loading.";
                    break;

                case 8:
                    lblLoading.Text = "Loading..";
                    break;

                case 9:
                    lblLoading.Text = "Loading...";
                    break;

                case 10:
                    lblLoading.Text = "Loading.";
                    break;

                case 11:
                    lblLoading.Text = "Loading..";
                    break;

                case 12:
                    lblLoading.Text = "Loading...";
                    break;

                case 13:
                    lblLoading.Text = "Loading.";
                    break;

                case 14:
                    lblLoading.Text = "Loading..";
                    break;

                case 15:
                    lblLoading.Text = "Loading...";
                    break;

                case 16:
                    lblLoading.Text = "Loading.";
                    break;

                case 17:
                    lblLoading.Text = "Loading..";
                    break;

                case 18:
                    lblLoading.Text = "Loading...";
                    break;

                case 19:
                    lblLoading.Text = "Loading.";
                    break;

                case 20:
                    lblLoading.Text = "Loading..";
                    break;

                case 21:
                    lblLoading.Text = "Loading...";
                    break;

                case 22:
                    lblLoading.Text = "Loading.";
                    break;

                case 23:
                    lblLoading.Text = "Loading..";
                    break;

                case 24:
                    timerLoad.Stop();
                    var frm = new Form1();
                    frm.Show();
                    Hide();
                    break;
            }
        }
    }
}
