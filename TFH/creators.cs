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
    public partial class creators : Form
    {
        public creators()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable() == true)
            {
                System.Diagnostics.Process.Start("http://nanenoghli.blog.ir");
            }
            else
                MessageBox.Show("شما به اینترنت متصل نیستید ، لطفا اول به اینترنت متصل شوید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
