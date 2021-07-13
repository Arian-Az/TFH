using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TFH.ExtensionMethods;
using TFH.SettingsForm;

namespace TFH
{
    public partial class Settings : Form
    {
        bool tf;

        public Settings()
        {
            InitializeComponent();
            //var lbl = new Label();
            //lbl.Text = "برای اعمال تنظیمات از منوی بالا استفاده فرمایید.";
            //lbl.Name = "lbl1";
            //lbl.Location = new Point(160, 222);
            //lbl.BackColor = Color.Transparent;
            //lbl.AutoSize = true;
            //tabControl1.Controls.Add(lbl);
        }

        private void صفحهاصلیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
        }

        private void tsmiStartup_Click(object sender, EventArgs e)
        {
            var frm = new SetingStartUp();
            frm.ShowTabbed(tabControl1);
        }

        private void Settings_Load(object sender, EventArgs e)
        {
        }

      
    }
}
