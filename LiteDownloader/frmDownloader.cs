using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace LiteDownloader
{
    public partial class frmDownloader : MetroForm
    {
        public frmDownloader(string Link, string Location, DateTime dt)
        {
            InitializeComponent();
            lblStartTime.Text = dt.ToString();
            try
            {
                Uri link = new Uri(Link);
                WebClient w = new WebClient();
                w.DownloadFileCompleted += new AsyncCompletedEventHandler(Complete);
                w.DownloadProgressChanged += new DownloadProgressChangedEventHandler(progress);
                w.DownloadFileAsync(link, Location);
            }
            catch
            {
                MessageBox.Show("Invalid Link has been founded. Please make sure that is a Valid Link.\nOr Paste URL with \"https://\" Prefix", "Invalid Link Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void frmDownloader_Load(object sender, EventArgs e)
        {
            /*
            if (lblPercent.Text == "N/A" || lblDownloaded.Text == "N/A")
            {
                DialogResult x;
                x = MessageBox.Show("An Unexepted error has been found\nThis should be for Invalid URL or UnSupported File\nDo you want to continue Downloading?", "Unexepted Error!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (x == DialogResult.Yes)
                {

                }
                else
                {
                    this.Close();
                }
            }
            */
        }

        private void Complete(object sender, AsyncCompletedEventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Download Has Successfuly finished!", "Congatulation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        private void progress(object sender, DownloadProgressChangedEventArgs e)
        {
            PrgDownload.Value = e.ProgressPercentage;
            
            lblSize.Text = e.TotalBytesToReceive.ToString();
            float s;
            s = float.Parse(lblSize.Text);

            if (s > 1000)
            {
                s = float.Parse(lblSize.Text);
                s = ((s / 1024) / 1024) / 1024;
                lblSize.Text = s.ToString().Substring(0, 4) + " Gb";
            }
            else
            {
                s = float.Parse(lblSize.Text);
                s = (s / 1024) / 1024;
                lblSize.Text = s.ToString() + " Mb";
            }

            lblDownloaded.Text = e.BytesReceived.ToString();
            float d;
            d = float.Parse(lblDownloaded.Text);
            d = (d / 1024) / 1024;
            try
            {
                lblDownloaded.Text = d.ToString().Substring(0, 5) + " Mb";
            }
            catch
            {
                lblDownloaded.Text = d.ToString() + " Mb";
            }

            int p = Convert.ToInt32(PrgDownload.Value);
            lblPercent.Text = p.ToString() + "%";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Are you sure to exit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr == DialogResult.Yes)
                this.Close();
        }
    }
}
