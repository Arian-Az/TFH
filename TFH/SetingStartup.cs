using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace TFH
{
    public partial class SetingStartup : Form
    {

        #region Set Windows( 7 , 8, 10) Startup

      //start up 
        private void SetStartup()
        {
              using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true))
              { 
                  key.SetValue("TFH", Application.ExecutablePath);
              }    
        }

        //remove start up
          public static void RemoveApplicationFromStartup()
          {
              using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true))
              {
                  key.DeleteValue("TFH", false);
              }
          }

        #endregion end of Set startup
        public SetingStartup()
        {
            InitializeComponent();
        }

        #region Moving form by Menu Picture Box
        // Moving form by Menu Picture Box
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void SetingStartup_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        // End moving form
        #endregion

        private void btnCreate_Click(object sender, EventArgs e)
        {
            SetStartup();
            var reg = Registry.CurrentUser.OpenSubKey("Software", true);
            reg = reg.CreateSubKey(@"TFH\Settings");
            reg.SetValue("CheckingStartup", 1);

            MessageBox.Show(
                "استارت آپ ساخته شد ، اگر از اکنون بهبعد نرم افزار را جا به جا و تغییر مسیر دادید لطفا بعد از تغییر مسیر نرم افزار را باز کنید و:\nروی دکمه تنظیمات کلیک کنید --> بر روی استارت آپ در منو بالا کلیک کنید --> استارت آپ را غیر فعال و سپس فعال کنید...",
                "پیام", MessageBoxButtons.OK,
                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var reg = Registry.CurrentUser.OpenSubKey("Software", true);
            reg = reg.CreateSubKey(@"TFH\Settings");
            reg.SetValue("CheckingStartup", 2);

            MessageBox.Show(
                "لغو کردن این عملیات به این معناست که شما مایل به ساخت استارت آپ نمیباشید و دیگر پیغامی در این رابطه دریافت نخواهید کرد اما شما میتوانید از طریق تنظیمات این مورد را فعال کنید",
                "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RtlReading);
            Close();
        }
    }
}
