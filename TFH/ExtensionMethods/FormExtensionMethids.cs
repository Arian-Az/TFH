using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TFH.ExtensionMethods
{
    public static class FormExtensionMethids
    {
        public static void ShowTabbed(this Form frm, TabControl tab)
        {
            var page = new TabPage
            {
                Text = frm.Text
            };
            tab.TabPages.Add(page);
            tab.SelectedTab = page;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Parent = page;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        public static void CloseTabbed(this Form frm)
        {
            var page = frm.Parent as TabPage;
            var tab = page.Parent as TabControl;
            tab.TabPages.Remove(page);
        }
    }
}
