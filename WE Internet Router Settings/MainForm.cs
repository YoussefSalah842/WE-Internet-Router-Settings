using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WE_Internet_Router_Settings
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string routerIP = GetDefaultGateway();
            if (!string.IsNullOrEmpty(routerIP))
            {
                webBrowser1.Url = new Uri("http://" + routerIP);
                toolStripStatusLabel1.Text = "Router IP: " + routerIP;
            }
            else
            {
                toolStripStatusLabel1.Text = "Unable to detect Router IP";
            }
        }

        private string GetDefaultGateway()
        {
            var gateways = NetworkInterface.GetAllNetworkInterfaces()
                .SelectMany(nic => nic.GetIPProperties().GatewayAddresses)
                .Select(gateway => gateway.Address.ToString())
                .ToList();

            return gateways.FirstOrDefault();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoBack)
            {
                webBrowser1.GoBack();
            }
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            string routerIP = GetDefaultGateway();
            if (!string.IsNullOrEmpty(routerIP))
            {
                webBrowser1.Url = new Uri("http://" + routerIP);
                toolStripStatusLabel1.Text = "Router IP: " + routerIP;
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            About AboutForm = new About();
            AboutForm.Show();
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {
            Help HelpForm = new Help();
            HelpForm.Show();
        }
    }
}

