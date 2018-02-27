using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Download_Repeater
{
    public partial class frmDownloader : Form
    {
        Boolean isDownloading = false;
        WebClient wclient;
        string fileName;
        public frmDownloader()
        {
            InitializeComponent();
        }
        private void buttonDownloadNow_Click(object sender, EventArgs e)
        {
            //DownloadFile_old(textBoxDownloadPath.Text, textBoxSavePath.Text);
            DownloadFile(textBoxDownloadPath.Text, textBoxSavePath.Text);
        }
       
        private void checkBoxAuto_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxAuto.Enabled = !checkBoxAuto.Checked;
            if (checkBoxAuto.Checked)
            {
                timer1.Interval = (int)numericUpDownInterval.Value * 60 * 1000;
                //timer1.Interval = (int)numericUpDownInterval.Value * 60;
                timer1.Start();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isDownloading)
            {
                Debug.WriteLine(DateTime.UtcNow.ToLongDateString()+ "is downloading return");
                return;
            }

            DownloadFile(textBoxDownloadPath.Text, textBoxSavePath.Text);
        }
        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                textBoxSavePath.Text = folderBrowserDialog1.SelectedPath;
        }

        private void checkBoxUseproxy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxProxyServerIP.Text))
            {
                MessageBox.Show("Please enter proxy server IP");
                (sender as CheckBox).Checked = false;
                return;
            }
        }
        private void checkBoxUseproxy_CheckedChanged(object sender, EventArgs e)
        {
            
            groupBoxProxy.Enabled = !checkBoxUseproxy.Checked;
        }

        private void frmDownloader_Load(object sender, EventArgs e)
        {
            Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            labelversion.Text = "version: " + fvi.FileVersion;
            writelog("Download Repeater Starts");
            LoadSettings();
        }

       

        #region Download Async
        /// <summary>
        /// Download a file asynchronously in the desktop path, show the download progress and save it with the original filename.
        /// src https://ourcodeworld.com/articles/read/227/how-to-download-a-webfile-with-csharp-and-show-download-progress-synchronously-and-asynchronously
        /// </summary>
        private void DownloadFile(string url, string savePath)
        {
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                toolStripStatusLabel1.Text = "Internet available, proceed with the download";
            }
            else
            {
                MessageBox.Show("Internet is not connected");
                return;
            }
            if (!Directory.Exists(savePath))
            {
                MessageBox.Show("Save path dosn't exists");
                return;
            }

        
            fileName = getFilename(url);

            isDownloading = true;
            wclient = new WebClient();

            if (checkBoxUseproxy.Checked)
            {
                WebProxy wp = new WebProxy(textBoxProxyServerIP.Text, (int)numericUpDownPort.Value);
                if (textBoxusername.Text != string.Empty)
                {
                    wp.Credentials = new NetworkCredential(textBoxusername.Text, textBoxPassword.Text);  //These can be replaced by user input
                    wp.UseDefaultCredentials = false;
                }
                wclient.Proxy = wp;
            }
            wclient.DownloadProgressChanged += wc_DownloadProgressChanged;
            wclient.DownloadFileCompleted += wc_DownloadFileCompleted;
            //wclient.DownloadFileAsync(new Uri(url), desktopPath + "/" + filename);
            
            wclient.DownloadFileAsync(new Uri(url), Path.GetTempPath() + fileName);
            writelog("Download Start");
        }

        /// <summary>
        ///  Show the progress of the download in a progressbar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            labelProgress.Text = e.ProgressPercentage.ToString() + " %";
            toolStripStatusLabel1.Text = "Downloading ... ";
        }

        private void wc_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            isDownloading = false;
            progressBar1.Value = 0;

            if (e.Cancelled)
            {
                //MessageBox.Show("The download has been cancelled");
                toolStripStatusLabel1.Text = "The download has been cancelled";
                labelProgress.Text = "";
                writelog("The download has been cancelled");
                return;
            }

            if (e.Error != null) // We have an error! Retry a few times, then abort.
            {
                //MessageBox.Show("An error ocurred while trying to download file");
                toolStripStatusLabel1.Text = "Download Error :(";
                writelog("Download Error :( "+e.Error.Message);
                return;
            }

            //MessageBox.Show("Download completed!", "Hooray :)");
            toolStripStatusLabel1.Text = "Hooray! Download completed. :)";
            writelog("Hooray! Download completed. :)");
            //Move complete file to download folder
            File.Delete(textBoxSavePath.Text + "/" + fileName);
            File.Move(Path.GetTempPath() + "/" + fileName, textBoxSavePath.Text+"/"+fileName);
            writelog("Update file moved to update folder.");
        }
        /// </summary>
        /// <param name="hreflink"></param>
        /// <returns></returns>
        private string getFilename(string hreflink)
        {
            Uri uri = new Uri(hreflink);

            string filename = System.IO.Path.GetFileName(uri.LocalPath);

            return filename;
        }
        private void cancelDownload()
        {
            wclient.CancelAsync();
            isDownloading = false;
        }
        #endregion

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            cancelDownload();
        }

        #region download file old
        private void DownloadFile_old(string url, string savePath, string name = "Update.zip")
        {
            if (!Directory.Exists(savePath))
            {
                MessageBox.Show("Save path dosn't exists");
                return;
            }

            Uri uri = new Uri(url);
            name = System.IO.Path.GetFileName(uri.LocalPath);

            try
            {
                // Create a new WebClient instance.
                WebClient myWebClient = new WebClient();

                if (checkBoxUseproxy.Checked)
                {
                    WebProxy wp = new WebProxy(textBoxProxyServerIP.Text, (int)numericUpDownPort.Value);
                    if (textBoxusername.Text != string.Empty)
                    {
                        wp.Credentials = new NetworkCredential(textBoxusername.Text, textBoxPassword.Text);  //These can be replaced by user input
                        wp.UseDefaultCredentials = false;
                    }
                    myWebClient.Proxy = wp;
                }

                // Download the Web resource and save it into the current filesystem folder.
                myWebClient.DownloadFile(url, savePath + "\\" + name);

                MessageBox.Show("Download completed!", "Hooray :)");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in download");
            }
        }
        #endregion
        private void writelog(string log)
        {
            File.AppendAllText("DownloadRepeaterLog.txt", DateTime.Now.ToString()+"\t" +log+Environment.NewLine);
        }

        private void frmDownloader_FormClosing(object sender, FormClosingEventArgs e)
        {
            writelog("Download Repeater closed");
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void frmDownloader_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(500);
                this.Hide();
            }
        }

        #region Settings
        private void LoadSettings()
        {
            textBoxDownloadPath.Text = Properties.Settings.Default.Url;
            textBoxSavePath.Text = Properties.Settings.Default.savePath;

            checkBoxAuto.Checked = Properties.Settings.Default.auto;
            numericUpDownInterval.Value = Properties.Settings.Default.interval;

            checkBoxUseproxy.Checked = Properties.Settings.Default.useProxy;
            textBoxProxyServerIP.Text = Properties.Settings.Default.proxyIP;
            numericUpDownPort.Value = Properties.Settings.Default.proxyPort;
            textBoxusername.Text = Properties.Settings.Default.proxyUser;
            textBoxPassword.Text = Properties.Settings.Default.proxyPass;

            writelog("Settings loaded");
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Url = textBoxDownloadPath.Text;
            Properties.Settings.Default.savePath = textBoxSavePath.Text;

            Properties.Settings.Default.auto = checkBoxAuto.Checked;
            Properties.Settings.Default.interval = numericUpDownInterval.Value;

            Properties.Settings.Default.useProxy = checkBoxUseproxy.Checked;
            Properties.Settings.Default.proxyIP = textBoxProxyServerIP.Text;
            Properties.Settings.Default.proxyPort = numericUpDownPort.Value;
            Properties.Settings.Default.proxyUser = textBoxusername.Text;
            Properties.Settings.Default.proxyPass = textBoxPassword.Text;

            Properties.Settings.Default.Save();
            writelog("Settings saveded");
            MessageBox.Show("Settings Saved", "Save",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        #endregion
    }
}
