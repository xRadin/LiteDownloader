using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiteDownloader.Properties;
using MetroFramework.Forms;

namespace LiteDownloader
{
    public partial class frmMain : MetroForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveAs = new SaveFileDialog();
            saveAs.Title = "Choose a Folder or Place";
            saveAs.FileName = Path.GetFileName(txtLink.Text);
            saveAs.Filter = "All Files (*.*)|*.*";
            saveAs.ShowDialog();
            txtLocation.Text = saveAs.FileName;
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            if(txtLink.Text != "")
            {
                if(txtLocation.Text != "")
                {
                    if(IsConnected() == true)
                    {
                        try
                        {
                            frmDownloader StartDownload = new frmDownloader(txtLink.Text, txtLocation.Text, DateTime.Now);
                            StartDownload.Show();
                        }
                        catch
                        {
                            MessageBox.Show("Download Panel has been Terminated.", "Download Panel Alarm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Network Connection Can't be Found. Make Sure your Internet is Connected", "Connection Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            else
            {
                if (txtLink.Text == "")
                {
                    txtLink.Style = MetroFramework.MetroColorStyle.Red;
                    MessageBox.Show("Please enter a Valid Link!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtLink.Focus();
                }
            }
            if (txtLocation.Text == "")
            {
                txtLocation.Style = MetroFramework.MetroColorStyle.Red;
                MessageBox.Show("Please enter a Valid Path!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLocation.Focus();
            }

        }

        private void txtLink_TextChanged(object sender, EventArgs e)
        {
            //string substring;
            //substring = txtLink.Text.Substring(0, txtLink.Text.Length);

            if (txtLink.Style == MetroFramework.MetroColorStyle.Red)
            {
                txtLink.Style = MetroFramework.MetroColorStyle.Black;
            }
            else if(txtLink.Text.Length == 7 || txtLink.Text.Length == 6 || txtLink.Text.Length == 5 || txtLink.Text.Length == 4 || txtLink.Text.Length == 3 || txtLink.Text.Length == 2 || txtLink.Text.Length == 1 || txtLink.Text == "")
            {
                txtLink.Text = "https://";
            }
            else if(txtLink.Text.Substring(0, 8) != "https://")
            {
                txtLink.Text = "https://";
            }
        }

        private void txtLocation_TextChanged(object sender, EventArgs e)
        {
            if (txtLocation.Style == MetroFramework.MetroColorStyle.Red)
            {
                txtLocation.Style = MetroFramework.MetroColorStyle.Black;
            }
        }

        private bool IsConnected()
        {
            try
            {
                Ping myPing = new Ping();
                String host = "google.com";
                byte[] buffer = new byte[32];
                int timeout = 1000;
                PingOptions pingOptions = new PingOptions();
                PingReply reply = myPing.Send(host, timeout, buffer, pingOptions);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
