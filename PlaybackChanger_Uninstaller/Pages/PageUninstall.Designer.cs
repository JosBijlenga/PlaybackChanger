namespace PlaybackChanger_Uninstaller.Pages
{
    partial class PageUninstall
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.borderPanelInstall = new PlaybackChanger_Installer.Controls.BorderPanel();
            this.borderPanelProgressInstall = new PlaybackChanger_Installer.Controls.BorderPanel();
            this.progressBarInstall = new System.Windows.Forms.ProgressBar();
            this.labelProgress = new System.Windows.Forms.Label();
            this.panelConfirm = new System.Windows.Forms.Panel();
            this.labelConfirm = new System.Windows.Forms.Label();
            this.textBoxInstallLocation = new System.Windows.Forms.TextBox();
            this.labelInstallLocation = new System.Windows.Forms.Label();
            this.flatButtonUninstall = new PlaybackChanger_Installer.Controls.FlatButton();
            this.flatButtonUninstallCancel = new PlaybackChanger_Installer.Controls.FlatButton();
            this.timerCheckRunning = new System.Windows.Forms.Timer(this.components);
            this.panelErrors = new System.Windows.Forms.Panel();
            this.panelStillRunning = new System.Windows.Forms.Panel();
            this.labelStillRunning = new System.Windows.Forms.Label();
            this.pictureBoxStillRunning = new System.Windows.Forms.PictureBox();
            this.borderPanelInstall.SuspendLayout();
            this.borderPanelProgressInstall.SuspendLayout();
            this.panelConfirm.SuspendLayout();
            this.panelErrors.SuspendLayout();
            this.panelStillRunning.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStillRunning)).BeginInit();
            this.SuspendLayout();
            // 
            // borderPanelInstall
            // 
            this.borderPanelInstall.BackColor = System.Drawing.Color.White;
            this.borderPanelInstall.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.borderPanelInstall.BottomBorder = false;
            this.borderPanelInstall.BottomBorderWidth = 1;
            this.borderPanelInstall.Controls.Add(this.panelErrors);
            this.borderPanelInstall.Controls.Add(this.borderPanelProgressInstall);
            this.borderPanelInstall.Controls.Add(this.panelConfirm);
            this.borderPanelInstall.Controls.Add(this.textBoxInstallLocation);
            this.borderPanelInstall.Controls.Add(this.labelInstallLocation);
            this.borderPanelInstall.Controls.Add(this.flatButtonUninstall);
            this.borderPanelInstall.Controls.Add(this.flatButtonUninstallCancel);
            this.borderPanelInstall.Cursor = System.Windows.Forms.Cursors.Default;
            this.borderPanelInstall.Dock = System.Windows.Forms.DockStyle.Fill;
            this.borderPanelInstall.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borderPanelInstall.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.borderPanelInstall.LeftBorder = true;
            this.borderPanelInstall.LeftBorderWidth = 1;
            this.borderPanelInstall.Location = new System.Drawing.Point(0, 0);
            this.borderPanelInstall.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.borderPanelInstall.Name = "borderPanelInstall";
            this.borderPanelInstall.RightBorder = false;
            this.borderPanelInstall.RightBorderWidth = 1;
            this.borderPanelInstall.Size = new System.Drawing.Size(500, 300);
            this.borderPanelInstall.TabIndex = 11;
            this.borderPanelInstall.TopBorder = false;
            this.borderPanelInstall.TopBorderWidth = 1;
            // 
            // borderPanelProgressInstall
            // 
            this.borderPanelProgressInstall.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.borderPanelProgressInstall.BorderColor = System.Drawing.Color.Black;
            this.borderPanelProgressInstall.BottomBorder = false;
            this.borderPanelProgressInstall.BottomBorderWidth = 1;
            this.borderPanelProgressInstall.Controls.Add(this.progressBarInstall);
            this.borderPanelProgressInstall.Controls.Add(this.labelProgress);
            this.borderPanelProgressInstall.LeftBorder = false;
            this.borderPanelProgressInstall.LeftBorderWidth = 1;
            this.borderPanelProgressInstall.Location = new System.Drawing.Point(22, 196);
            this.borderPanelProgressInstall.Name = "borderPanelProgressInstall";
            this.borderPanelProgressInstall.RightBorder = false;
            this.borderPanelProgressInstall.RightBorderWidth = 1;
            this.borderPanelProgressInstall.Size = new System.Drawing.Size(464, 54);
            this.borderPanelProgressInstall.TabIndex = 6;
            this.borderPanelProgressInstall.TopBorder = false;
            this.borderPanelProgressInstall.TopBorderWidth = 1;
            this.borderPanelProgressInstall.Visible = false;
            // 
            // progressBarInstall
            // 
            this.progressBarInstall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarInstall.Location = new System.Drawing.Point(0, 27);
            this.progressBarInstall.MarqueeAnimationSpeed = 10;
            this.progressBarInstall.Name = "progressBarInstall";
            this.progressBarInstall.Size = new System.Drawing.Size(452, 23);
            this.progressBarInstall.Step = 1;
            this.progressBarInstall.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarInstall.TabIndex = 3;
            // 
            // labelProgress
            // 
            this.labelProgress.AutoSize = true;
            this.labelProgress.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProgress.Location = new System.Drawing.Point(0, 3);
            this.labelProgress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(76, 20);
            this.labelProgress.TabIndex = 2;
            this.labelProgress.Text = "Uninstalling";
            // 
            // panelConfirm
            // 
            this.panelConfirm.Controls.Add(this.labelConfirm);
            this.panelConfirm.Location = new System.Drawing.Point(22, 72);
            this.panelConfirm.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.panelConfirm.Name = "panelConfirm";
            this.panelConfirm.Size = new System.Drawing.Size(460, 62);
            this.panelConfirm.TabIndex = 5;
            // 
            // labelConfirm
            // 
            this.labelConfirm.AutoSize = true;
            this.labelConfirm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelConfirm.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.labelConfirm.Location = new System.Drawing.Point(0, 0);
            this.labelConfirm.Margin = new System.Windows.Forms.Padding(0, 18, 4, 0);
            this.labelConfirm.Name = "labelConfirm";
            this.labelConfirm.Size = new System.Drawing.Size(396, 20);
            this.labelConfirm.TabIndex = 4;
            this.labelConfirm.Text = "Are you sure you want to uninstall {0} and all files associated?";
            // 
            // textBoxInstallLocation
            // 
            this.textBoxInstallLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxInstallLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxInstallLocation.Enabled = false;
            this.textBoxInstallLocation.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInstallLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.textBoxInstallLocation.Location = new System.Drawing.Point(22, 41);
            this.textBoxInstallLocation.Margin = new System.Windows.Forms.Padding(18, 3, 3, 3);
            this.textBoxInstallLocation.Name = "textBoxInstallLocation";
            this.textBoxInstallLocation.Size = new System.Drawing.Size(460, 22);
            this.textBoxInstallLocation.TabIndex = 2;
            // 
            // labelInstallLocation
            // 
            this.labelInstallLocation.AutoSize = true;
            this.labelInstallLocation.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInstallLocation.Location = new System.Drawing.Point(18, 18);
            this.labelInstallLocation.Margin = new System.Windows.Forms.Padding(18, 18, 4, 0);
            this.labelInstallLocation.Name = "labelInstallLocation";
            this.labelInstallLocation.Size = new System.Drawing.Size(117, 20);
            this.labelInstallLocation.TabIndex = 3;
            this.labelInstallLocation.Text = "Uninstalling from";
            // 
            // flatButtonUninstall
            // 
            this.flatButtonUninstall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.flatButtonUninstall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.flatButtonUninstall.Enabled = false;
            this.flatButtonUninstall.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.flatButtonUninstall.FlatAppearance.BorderSize = 0;
            this.flatButtonUninstall.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.flatButtonUninstall.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(222)))), ((int)(((byte)(245)))));
            this.flatButtonUninstall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flatButtonUninstall.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.flatButtonUninstall.Location = new System.Drawing.Point(399, 256);
            this.flatButtonUninstall.Name = "flatButtonUninstall";
            this.flatButtonUninstall.Size = new System.Drawing.Size(83, 26);
            this.flatButtonUninstall.TabIndex = 0;
            this.flatButtonUninstall.Text = "Uninstall";
            this.flatButtonUninstall.UseVisualStyleBackColor = false;
            this.flatButtonUninstall.Click += new System.EventHandler(this.FlatButtonUninstall_Click);
            // 
            // flatButtonUninstallCancel
            // 
            this.flatButtonUninstallCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.flatButtonUninstallCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.flatButtonUninstallCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.flatButtonUninstallCancel.FlatAppearance.BorderSize = 0;
            this.flatButtonUninstallCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.flatButtonUninstallCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(222)))), ((int)(((byte)(245)))));
            this.flatButtonUninstallCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flatButtonUninstallCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.flatButtonUninstallCancel.Location = new System.Drawing.Point(307, 256);
            this.flatButtonUninstallCancel.Margin = new System.Windows.Forms.Padding(6, 6, 3, 18);
            this.flatButtonUninstallCancel.Name = "flatButtonUninstallCancel";
            this.flatButtonUninstallCancel.Size = new System.Drawing.Size(83, 26);
            this.flatButtonUninstallCancel.TabIndex = 1;
            this.flatButtonUninstallCancel.Text = "Cancel";
            this.flatButtonUninstallCancel.UseVisualStyleBackColor = false;
            this.flatButtonUninstallCancel.Click += new System.EventHandler(this.FlatButtonUninstallCancel_Click);
            // 
            // timerCheckRunning
            // 
            this.timerCheckRunning.Enabled = true;
            this.timerCheckRunning.Interval = 250;
            this.timerCheckRunning.Tick += new System.EventHandler(this.TimerCheckRunning_Tick);
            // 
            // panelErrors
            // 
            this.panelErrors.AutoSize = true;
            this.panelErrors.Controls.Add(this.panelStillRunning);
            this.panelErrors.Location = new System.Drawing.Point(22, 140);
            this.panelErrors.Name = "panelErrors";
            this.panelErrors.Size = new System.Drawing.Size(464, 54);
            this.panelErrors.TabIndex = 22;
            this.panelErrors.Visible = false;
            // 
            // panelStillRunning
            // 
            this.panelStillRunning.AutoSize = true;
            this.panelStillRunning.Controls.Add(this.labelStillRunning);
            this.panelStillRunning.Controls.Add(this.pictureBoxStillRunning);
            this.panelStillRunning.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStillRunning.Location = new System.Drawing.Point(0, 0);
            this.panelStillRunning.Name = "panelStillRunning";
            this.panelStillRunning.Size = new System.Drawing.Size(464, 17);
            this.panelStillRunning.TabIndex = 20;
            this.panelStillRunning.Visible = false;
            // 
            // labelStillRunning
            // 
            this.labelStillRunning.AutoSize = true;
            this.labelStillRunning.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStillRunning.Location = new System.Drawing.Point(17, -3);
            this.labelStillRunning.Margin = new System.Windows.Forms.Padding(0);
            this.labelStillRunning.Name = "labelStillRunning";
            this.labelStillRunning.Size = new System.Drawing.Size(432, 20);
            this.labelStillRunning.TabIndex = 3;
            this.labelStillRunning.Text = "A Playback Changer instance is still running. Close it before continuing.";
            // 
            // pictureBoxStillRunning
            // 
            this.pictureBoxStillRunning.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxStillRunning.Image = global::PlaybackChanger_Uninstaller.Properties.Resources.Incorrect;
            this.pictureBoxStillRunning.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxStillRunning.Name = "pictureBoxStillRunning";
            this.pictureBoxStillRunning.Size = new System.Drawing.Size(16, 17);
            this.pictureBoxStillRunning.TabIndex = 0;
            this.pictureBoxStillRunning.TabStop = false;
            // 
            // PageUninstall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.borderPanelInstall);
            this.Name = "PageUninstall";
            this.Size = new System.Drawing.Size(500, 300);
            this.borderPanelInstall.ResumeLayout(false);
            this.borderPanelInstall.PerformLayout();
            this.borderPanelProgressInstall.ResumeLayout(false);
            this.borderPanelProgressInstall.PerformLayout();
            this.panelConfirm.ResumeLayout(false);
            this.panelConfirm.PerformLayout();
            this.panelErrors.ResumeLayout(false);
            this.panelErrors.PerformLayout();
            this.panelStillRunning.ResumeLayout(false);
            this.panelStillRunning.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStillRunning)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PlaybackChanger_Installer.Controls.BorderPanel borderPanelInstall;
        private PlaybackChanger_Installer.Controls.FlatButton flatButtonUninstall;
        private PlaybackChanger_Installer.Controls.FlatButton flatButtonUninstallCancel;
        private System.Windows.Forms.TextBox textBoxInstallLocation;
        private System.Windows.Forms.Label labelInstallLocation;
        private System.Windows.Forms.Label labelConfirm;
        private System.Windows.Forms.Panel panelConfirm;
        private PlaybackChanger_Installer.Controls.BorderPanel borderPanelProgressInstall;
        private System.Windows.Forms.ProgressBar progressBarInstall;
        private System.Windows.Forms.Label labelProgress;
        private System.Windows.Forms.Timer timerCheckRunning;
        private System.Windows.Forms.Panel panelErrors;
        private System.Windows.Forms.Panel panelStillRunning;
        private System.Windows.Forms.Label labelStillRunning;
        private System.Windows.Forms.PictureBox pictureBoxStillRunning;
    }
}
