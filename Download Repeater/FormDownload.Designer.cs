namespace Download_Repeater
{
    partial class frmDownloader
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDownloader));
            this.buttonDownloadNow = new System.Windows.Forms.Button();
            this.textBoxDownloadPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownInterval = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxAuto = new System.Windows.Forms.GroupBox();
            this.checkBoxAuto = new System.Windows.Forms.CheckBox();
            this.groupBoxProxy = new System.Windows.Forms.GroupBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxusername = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxProxyServerIP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownPort = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxSavePath = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.checkBoxUseproxy = new System.Windows.Forms.CheckBox();
            this.labelversion = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.labelProgress = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInterval)).BeginInit();
            this.groupBoxAuto.SuspendLayout();
            this.groupBoxProxy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPort)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDownloadNow
            // 
            this.buttonDownloadNow.BackgroundImage = global::Download_Repeater.Properties.Resources.refresh;
            this.buttonDownloadNow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDownloadNow.Location = new System.Drawing.Point(8, 17);
            this.buttonDownloadNow.Name = "buttonDownloadNow";
            this.buttonDownloadNow.Size = new System.Drawing.Size(103, 56);
            this.buttonDownloadNow.TabIndex = 0;
            this.buttonDownloadNow.Text = "&Download Now";
            this.buttonDownloadNow.UseVisualStyleBackColor = true;
            this.buttonDownloadNow.Click += new System.EventHandler(this.buttonDownloadNow_Click);
            // 
            // textBoxDownloadPath
            // 
            this.textBoxDownloadPath.Location = new System.Drawing.Point(12, 22);
            this.textBoxDownloadPath.Name = "textBoxDownloadPath";
            this.textBoxDownloadPath.Size = new System.Drawing.Size(585, 20);
            this.textBoxDownloadPath.TabIndex = 1;
            this.textBoxDownloadPath.Text = "http://eps.update.amnpardaz.com/latest/signature.apbundle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dowload link:";
            // 
            // numericUpDownInterval
            // 
            this.numericUpDownInterval.Location = new System.Drawing.Point(51, 28);
            this.numericUpDownInterval.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDownInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownInterval.Name = "numericUpDownInterval";
            this.numericUpDownInterval.Size = new System.Drawing.Size(87, 20);
            this.numericUpDownInterval.TabIndex = 3;
            this.numericUpDownInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownInterval.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Every";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "minutes";
            // 
            // groupBoxAuto
            // 
            this.groupBoxAuto.Controls.Add(this.numericUpDownInterval);
            this.groupBoxAuto.Controls.Add(this.label3);
            this.groupBoxAuto.Controls.Add(this.label2);
            this.groupBoxAuto.Location = new System.Drawing.Point(109, 101);
            this.groupBoxAuto.Name = "groupBoxAuto";
            this.groupBoxAuto.Size = new System.Drawing.Size(209, 70);
            this.groupBoxAuto.TabIndex = 6;
            this.groupBoxAuto.TabStop = false;
            this.groupBoxAuto.Text = "Auto Download";
            // 
            // checkBoxAuto
            // 
            this.checkBoxAuto.AutoSize = true;
            this.checkBoxAuto.Location = new System.Drawing.Point(7, 101);
            this.checkBoxAuto.Name = "checkBoxAuto";
            this.checkBoxAuto.Size = new System.Drawing.Size(99, 17);
            this.checkBoxAuto.TabIndex = 7;
            this.checkBoxAuto.Text = "Auto Download";
            this.checkBoxAuto.UseVisualStyleBackColor = true;
            this.checkBoxAuto.CheckedChanged += new System.EventHandler(this.checkBoxAuto_CheckedChanged);
            // 
            // groupBoxProxy
            // 
            this.groupBoxProxy.Controls.Add(this.textBoxPassword);
            this.groupBoxProxy.Controls.Add(this.label8);
            this.groupBoxProxy.Controls.Add(this.textBoxusername);
            this.groupBoxProxy.Controls.Add(this.label7);
            this.groupBoxProxy.Controls.Add(this.textBoxProxyServerIP);
            this.groupBoxProxy.Controls.Add(this.label4);
            this.groupBoxProxy.Controls.Add(this.numericUpDownPort);
            this.groupBoxProxy.Controls.Add(this.label5);
            this.groupBoxProxy.Location = new System.Drawing.Point(81, 186);
            this.groupBoxProxy.Name = "groupBoxProxy";
            this.groupBoxProxy.Size = new System.Drawing.Size(515, 112);
            this.groupBoxProxy.TabIndex = 8;
            this.groupBoxProxy.TabStop = false;
            this.groupBoxProxy.Text = "Proxy Settings";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(318, 69);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(154, 20);
            this.textBoxPassword.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(262, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Password";
            // 
            // textBoxusername
            // 
            this.textBoxusername.Location = new System.Drawing.Point(98, 69);
            this.textBoxusername.Name = "textBoxusername";
            this.textBoxusername.Size = new System.Drawing.Size(139, 20);
            this.textBoxusername.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Proxy username";
            // 
            // textBoxProxyServerIP
            // 
            this.textBoxProxyServerIP.Location = new System.Drawing.Point(98, 25);
            this.textBoxProxyServerIP.Name = "textBoxProxyServerIP";
            this.textBoxProxyServerIP.Size = new System.Drawing.Size(287, 20);
            this.textBoxProxyServerIP.TabIndex = 6;
            this.textBoxProxyServerIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Proxy server IP";
            // 
            // numericUpDownPort
            // 
            this.numericUpDownPort.Location = new System.Drawing.Point(428, 25);
            this.numericUpDownPort.Maximum = new decimal(new int[] {
            65356,
            0,
            0,
            0});
            this.numericUpDownPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPort.Name = "numericUpDownPort";
            this.numericUpDownPort.Size = new System.Drawing.Size(75, 20);
            this.numericUpDownPort.TabIndex = 3;
            this.numericUpDownPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownPort.Value = new decimal(new int[] {
            8080,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(400, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "port";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Save path:";
            // 
            // textBoxSavePath
            // 
            this.textBoxSavePath.Location = new System.Drawing.Point(12, 65);
            this.textBoxSavePath.Name = "textBoxSavePath";
            this.textBoxSavePath.Size = new System.Drawing.Size(516, 20);
            this.textBoxSavePath.TabIndex = 9;
            this.textBoxSavePath.Text = "C:\\update";
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(534, 65);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(63, 20);
            this.buttonBrowse.TabIndex = 11;
            this.buttonBrowse.Text = "&Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // checkBoxUseproxy
            // 
            this.checkBoxUseproxy.AutoSize = true;
            this.checkBoxUseproxy.Location = new System.Drawing.Point(7, 186);
            this.checkBoxUseproxy.Name = "checkBoxUseproxy";
            this.checkBoxUseproxy.Size = new System.Drawing.Size(74, 17);
            this.checkBoxUseproxy.TabIndex = 12;
            this.checkBoxUseproxy.Text = "Use Proxy";
            this.checkBoxUseproxy.UseVisualStyleBackColor = true;
            this.checkBoxUseproxy.CheckedChanged += new System.EventHandler(this.checkBoxUseproxy_CheckedChanged);
            this.checkBoxUseproxy.Click += new System.EventHandler(this.checkBoxUseproxy_Click);
            // 
            // labelversion
            // 
            this.labelversion.AutoSize = true;
            this.labelversion.Location = new System.Drawing.Point(515, 4);
            this.labelversion.Name = "labelversion";
            this.labelversion.Size = new System.Drawing.Size(77, 13);
            this.labelversion.TabIndex = 6;
            this.labelversion.Text = "version:0.0.0.0";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.progressBar1,
            this.labelProgress});
            this.statusStrip1.Location = new System.Drawing.Point(0, 396);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(601, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(26, 17);
            this.toolStripStatusLabel1.Text = "idle";
            // 
            // progressBar1
            // 
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(200, 16);
            // 
            // labelProgress
            // 
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(0, 17);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(133, 38);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(54, 31);
            this.buttonCancel.TabIndex = 15;
            this.buttonCancel.Text = "&Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(502, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 40);
            this.button1.TabIndex = 16;
            this.button1.Text = "&Save Settings";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Download Repeater";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.buttonCancel);
            this.groupBox1.Controls.Add(this.buttonDownloadNow);
            this.groupBox1.Location = new System.Drawing.Point(7, 314);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(585, 79);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // frmDownloader
            // 
            this.AcceptButton = this.buttonDownloadNow;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(601, 418);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.labelversion);
            this.Controls.Add(this.checkBoxUseproxy);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxSavePath);
            this.Controls.Add(this.groupBoxProxy);
            this.Controls.Add(this.checkBoxAuto);
            this.Controls.Add(this.groupBoxAuto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDownloadPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmDownloader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Download Repeater";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDownloader_FormClosing);
            this.Load += new System.EventHandler(this.frmDownloader_Load);
            this.Resize += new System.EventHandler(this.frmDownloader_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInterval)).EndInit();
            this.groupBoxAuto.ResumeLayout(false);
            this.groupBoxAuto.PerformLayout();
            this.groupBoxProxy.ResumeLayout(false);
            this.groupBoxProxy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPort)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDownloadNow;
        private System.Windows.Forms.TextBox textBoxDownloadPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownInterval;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxAuto;
        private System.Windows.Forms.CheckBox checkBoxAuto;
        private System.Windows.Forms.GroupBox groupBoxProxy;
        private System.Windows.Forms.TextBox textBoxProxyServerIP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownPort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxSavePath;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.CheckBox checkBoxUseproxy;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxusername;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelversion;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ToolStripProgressBar progressBar1;
        private System.Windows.Forms.ToolStripStatusLabel labelProgress;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

