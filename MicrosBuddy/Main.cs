using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace POSBuddy
{
    public partial class Main : Form
    {
        private Dictionary<string, string> HelpMenu = new Dictionary<string, string>();
        public Main()
        {
            InitializeComponent();
            Browser.Url = new Uri(new System.IO.FileInfo("Main.html").FullName);
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            
        }

        private void Browser_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            foreach (HtmlElement menu in Browser.Document.GetElementsByTagName("menu"))
            {
                menu.Style = "display:none;";
                HelpMenu.Clear();
                foreach (HtmlElement menuItem in menu.Children)
                {
                    if (menuItem.TagName == "A" && menuItem.GetAttribute("href") != "")
                    {
                        HelpMenu.Add(menuItem.InnerText, menuItem.GetAttribute("href"));
                    }
                }
                UpdateHelpMenu();
                break;
            }
        }
        private void UpdateHelpMenu()
        {
            lboxHelp.Items.Clear();
            foreach(KeyValuePair<string, string> menuItem in HelpMenu)
            {
                lboxHelp.Items.Add(menuItem.Key);
            }
        }

        private void LboxHelp_Click(object sender, EventArgs e)
        {
            if(lboxHelp.SelectedIndex != -1)
            {
                Browser.Url = new Uri(HelpMenu[lboxHelp.SelectedItem.ToString()]);
            }
        }
    }
}
