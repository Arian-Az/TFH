using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using TFH.ExtensionMethods;

namespace TFH.SettingsForm
{
    public partial class SetingStartUp : Form
    {
        bool tf;

        public SetingStartUp()
        {
            InitializeComponent();
            var lbl = new Label();
            lbl.Text = "برای اعمال تنظیمات از منوی بالا استفاده فرمایید.";
            lbl.Name = "lbl1";
            lbl.Location = new Point(160, 222);
            lbl.BackColor = Color.Transparent;
            lbl.AutoSize = true;
            Controls.Add(lbl);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            if (tf == false)
            {
                using (
                    RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run",
                        true))
                {
                    key.DeleteValue("TFH", false);
                }

                var reg = Registry.CurrentUser.OpenSubKey("Software", true);
                reg = reg.CreateSubKey(@"TFH\Settings");
                reg.SetValue("CheckingStartup", 2);
                SetingStartUp_Load(sender, e);
            }
            else
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true))
                {
                    key.SetValue("TFH", Application.ExecutablePath);
                }

                var reg = Registry.CurrentUser.OpenSubKey("Software", true);
                reg = reg.CreateSubKey(@"TFH\Settings");
                reg.SetValue("CheckingStartup", 1);
                SetingStartUp_Load(sender, e);
            }
        }

        private void SetingStartUp_Load(object sender, EventArgs e)
        {
            pnlStartup.Visible = true;
            var reg = Registry.CurrentUser.OpenSubKey(@"Software\TFH\Settings");
            if (reg != null)
            {
                int get = int.Parse(reg.GetValue("CheckingStartup").ToString());
                if (get == 2)
                {
                    btnSetting.Text = "فعال سازی استارت آپ";
                    btnSetting.ForeColor = Color.SteelBlue;
                    lblAlarm.Text =
                        "در حال حاضر استارت آپ برای این نرم افزار بر روی کامپیوتر شما فعال نمیباشد ، اگر میخواهید از این امکان استفاده کنید میتوانید آن را فعال سازید.";
                    tf = true;
                }
                else if (get == 1)
                {
                    btnSetting.Text = "غیر فعال سازی استارت آپ";
                    btnSetting.ForeColor = Color.Red;
                    lblAlarm.Text =
                        "در حال حاضر استارت برای این نرم افزار بر روی کامپیوتر شما فعال است ، اگر نمیخواهید از این امکان استفاده کنید میتوانید آن را غیر فعال سازید.";
                    tf = false;
                }
            }
            else
            {
                btnSetting.Text = "فعال سازی استارت آپ";
                btnSetting.ForeColor = Color.SteelBlue;
                lblAlarm.Text =
                        "در حال حاضر استارت آپ برای این نرم افزار بر روی کامپیوتر شما فعال نمیباشد ، اگر میخواهید از این امکان استفاده کنید میتوانید آن را فعال سازید.";                
                tf = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.CloseTabbed();
        }
    }
}
