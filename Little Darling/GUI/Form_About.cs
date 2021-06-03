using System;
using System.Windows.Forms;
using CSCore.SoundOut;
using System.Reflection;
using LittleDarling.Properties;
using System.Diagnostics;

namespace LittleDarling
{
    public partial class Form_About : Form
    {
        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }
        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }
        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public Form_About()
        {
            InitializeComponent();
            label_nameVersion.Text = String.Format("{0} {1}", AssemblyProduct, AssemblyVersion);
            label_copyright.Text = AssemblyCopyright;
            linkLabel_email.Text = Resources.Email;
            linkLabel_website.Text = Resources.Website;
            textBox_thirdPartyLicenses.Text = Resources.ThirdPartyLicenses;
        }

        private void linkLabel_email_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(string.Format(
                "https://mail.google.com/mail/u/0/?view=cm&fs=1&tf=1&to={1}",
                Resources.Email));
        }

        private void linkLabel_website_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(Resources.Website);
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
