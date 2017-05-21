namespace PlaybackChanger_Installer.Pages
{
    partial class PageInstall
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
            this.timerCheckRunning = new System.Windows.Forms.Timer(this.components);
            this.borderPanelInstall = new PlaybackChanger_Installer.Controls.BorderPanel();
            this.panelErrors = new System.Windows.Forms.Panel();
            this.panelNoPackage = new System.Windows.Forms.Panel();
            this.labelNoPackage = new System.Windows.Forms.Label();
            this.pictureBoxNoPackage = new System.Windows.Forms.PictureBox();
            this.panelIncorrectPath = new System.Windows.Forms.Panel();
            this.labelIncorrectPath = new System.Windows.Forms.Label();
            this.pictureBoxIncorrectPath = new System.Windows.Forms.PictureBox();
            this.panelStillRunning = new System.Windows.Forms.Panel();
            this.labelStillRunning = new System.Windows.Forms.Label();
            this.pictureBoxStillRunning = new System.Windows.Forms.PictureBox();
            this.checkBoxStartOnFinish = new System.Windows.Forms.CheckBox();
            this.flatButtonInstall = new PlaybackChanger_Installer.Controls.FlatButton();
            this.labelOverview = new System.Windows.Forms.Label();
            this.borderPanelOverview = new PlaybackChanger_Installer.Controls.BorderPanel();
            this.labelSystemStart = new System.Windows.Forms.Label();
            this.labelDesktop = new System.Windows.Forms.Label();
            this.checkBoxSystemStart = new System.Windows.Forms.CheckBox();
            this.checkBoxStartmenu = new System.Windows.Forms.CheckBox();
            this.checkBoxDesktop = new System.Windows.Forms.CheckBox();
            this.labelInstallLocation = new System.Windows.Forms.Label();
            this.textBoxInstallLocation = new System.Windows.Forms.TextBox();
            this.flatButtonInstallCancel = new PlaybackChanger_Installer.Controls.FlatButton();
            this.borderPanelProgressInstall = new PlaybackChanger_Installer.Controls.BorderPanel();
            this.progressBarInstall = new System.Windows.Forms.ProgressBar();
            this.labelProgress = new System.Windows.Forms.Label();
            this.borderPanelInstall.SuspendLayout();
            this.panelErrors.SuspendLayout();
            this.panelNoPackage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNoPackage)).BeginInit();
            this.panelIncorrectPath.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIncorrectPath)).BeginInit();
            this.panelStillRunning.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStillRunning)).BeginInit();
            this.borderPanelOverview.SuspendLayout();
            this.borderPanelProgressInstall.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerCheckRunning
            // 
            this.timerCheckRunning.Enabled = true;
            this.timerCheckRunning.Interval = 250;
            this.timerCheckRunning.Tick += new System.EventHandler(this.TimerCheckRunning_Tick);
            // 
            // borderPanelInstall
            // 
            this.borderPanelInstall.BackColor = System.Drawing.Color.White;
            this.borderPanelInstall.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.borderPanelInstall.BottomBorder = false;
            this.borderPanelInstall.BottomBorderWidth = 1;
            this.borderPanelInstall.Controls.Add(this.panelErrors);
            this.borderPanelInstall.Controls.Add(this.checkBoxStartOnFinish);
            this.borderPanelInstall.Controls.Add(this.flatButtonInstall);
            this.borderPanelInstall.Controls.Add(this.labelOverview);
            this.borderPanelInstall.Controls.Add(this.borderPanelOverview);
            this.borderPanelInstall.Controls.Add(this.flatButtonInstallCancel);
            this.borderPanelInstall.Controls.Add(this.borderPanelProgressInstall);
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
            this.borderPanelInstall.TabIndex = 10;
            this.borderPanelInstall.TopBorder = false;
            this.borderPanelInstall.TopBorderWidth = 1;
            // 
            // panelErrors
            // 
            this.panelErrors.AutoSize = true;
            this.panelErrors.Controls.Add(this.panelNoPackage);
            this.panelErrors.Controls.Add(this.panelIncorrectPath);
            this.panelErrors.Controls.Add(this.panelStillRunning);
            this.panelErrors.Location = new System.Drawing.Point(18, 194);
            this.panelErrors.Name = "panelErrors";
            this.panelErrors.Size = new System.Drawing.Size(464, 54);
            this.panelErrors.TabIndex = 21;
            this.panelErrors.Visible = false;
            // 
            // panelNoPackage
            // 
            this.panelNoPackage.AutoSize = true;
            this.panelNoPackage.Controls.Add(this.labelNoPackage);
            this.panelNoPackage.Controls.Add(this.pictureBoxNoPackage);
            this.panelNoPackage.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNoPackage.Location = new System.Drawing.Point(0, 34);
            this.panelNoPackage.Name = "panelNoPackage";
            this.panelNoPackage.Size = new System.Drawing.Size(464, 17);
            this.panelNoPackage.TabIndex = 21;
            this.panelNoPackage.Visible = false;
            // 
            // labelNoPackage
            // 
            this.labelNoPackage.AutoSize = true;
            this.labelNoPackage.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoPackage.Location = new System.Drawing.Point(17, -3);
            this.labelNoPackage.Margin = new System.Windows.Forms.Padding(0);
            this.labelNoPackage.Name = "labelNoPackage";
            this.labelNoPackage.Size = new System.Drawing.Size(302, 20);
            this.labelNoPackage.TabIndex = 3;
            this.labelNoPackage.Text = "Could not locate the install package \'Package.7z\'";
            // 
            // pictureBoxNoPackage
            // 
            this.pictureBoxNoPackage.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxNoPackage.Image = global::PlaybackChanger_Installer.Properties.Resources.Incorrect;
            this.pictureBoxNoPackage.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxNoPackage.Name = "pictureBoxNoPackage";
            this.pictureBoxNoPackage.Size = new System.Drawing.Size(16, 17);
            this.pictureBoxNoPackage.TabIndex = 0;
            this.pictureBoxNoPackage.TabStop = false;
            // 
            // panelIncorrectPath
            // 
            this.panelIncorrectPath.AutoSize = true;
            this.panelIncorrectPath.Controls.Add(this.labelIncorrectPath);
            this.panelIncorrectPath.Controls.Add(this.pictureBoxIncorrectPath);
            this.panelIncorrectPath.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelIncorrectPath.Location = new System.Drawing.Point(0, 17);
            this.panelIncorrectPath.Name = "panelIncorrectPath";
            this.panelIncorrectPath.Size = new System.Drawing.Size(464, 17);
            this.panelIncorrectPath.TabIndex = 19;
            this.panelIncorrectPath.Visible = false;
            // 
            // labelIncorrectPath
            // 
            this.labelIncorrectPath.AutoSize = true;
            this.labelIncorrectPath.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIncorrectPath.Location = new System.Drawing.Point(17, -3);
            this.labelIncorrectPath.Margin = new System.Windows.Forms.Padding(0);
            this.labelIncorrectPath.Name = "labelIncorrectPath";
            this.labelIncorrectPath.Size = new System.Drawing.Size(234, 20);
            this.labelIncorrectPath.TabIndex = 3;
            this.labelIncorrectPath.Text = "Please choose a valid install location.";
            // 
            // pictureBoxIncorrectPath
            // 
            this.pictureBoxIncorrectPath.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxIncorrectPath.Image = global::PlaybackChanger_Installer.Properties.Resources.Incorrect;
            this.pictureBoxIncorrectPath.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxIncorrectPath.Name = "pictureBoxIncorrectPath";
            this.pictureBoxIncorrectPath.Size = new System.Drawing.Size(16, 17);
            this.pictureBoxIncorrectPath.TabIndex = 0;
            this.pictureBoxIncorrectPath.TabStop = false;
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
            this.pictureBoxStillRunning.Image = global::PlaybackChanger_Installer.Properties.Resources.Incorrect;
            this.pictureBoxStillRunning.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxStillRunning.Name = "pictureBoxStillRunning";
            this.pictureBoxStillRunning.Size = new System.Drawing.Size(16, 17);
            this.pictureBoxStillRunning.TabIndex = 0;
            this.pictureBoxStillRunning.TabStop = false;
            // 
            // checkBoxStartOnFinish
            // 
            this.checkBoxStartOnFinish.AutoSize = true;
            this.checkBoxStartOnFinish.Checked = true;
            this.checkBoxStartOnFinish.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxStartOnFinish.Location = new System.Drawing.Point(26, 259);
            this.checkBoxStartOnFinish.Name = "checkBoxStartOnFinish";
            this.checkBoxStartOnFinish.Size = new System.Drawing.Size(192, 22);
            this.checkBoxStartOnFinish.TabIndex = 20;
            this.checkBoxStartOnFinish.Text = "Start Playback Changer";
            this.checkBoxStartOnFinish.UseVisualStyleBackColor = true;
            // 
            // flatButtonInstall
            // 
            this.flatButtonInstall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.flatButtonInstall.Enabled = false;
            this.flatButtonInstall.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.flatButtonInstall.FlatAppearance.BorderSize = 0;
            this.flatButtonInstall.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.flatButtonInstall.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(222)))), ((int)(((byte)(245)))));
            this.flatButtonInstall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flatButtonInstall.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.flatButtonInstall.Location = new System.Drawing.Point(399, 256);
            this.flatButtonInstall.Name = "flatButtonInstall";
            this.flatButtonInstall.Size = new System.Drawing.Size(83, 26);
            this.flatButtonInstall.TabIndex = 0;
            this.flatButtonInstall.Text = "Install";
            this.flatButtonInstall.UseVisualStyleBackColor = false;
            this.flatButtonInstall.Click += new System.EventHandler(this.FlatButtonInstall_Click);
            // 
            // labelOverview
            // 
            this.labelOverview.AutoSize = true;
            this.labelOverview.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOverview.Location = new System.Drawing.Point(18, 18);
            this.labelOverview.Margin = new System.Windows.Forms.Padding(27, 25, 4, 0);
            this.labelOverview.Name = "labelOverview";
            this.labelOverview.Size = new System.Drawing.Size(65, 20);
            this.labelOverview.TabIndex = 1;
            this.labelOverview.Text = "Overview";
            // 
            // borderPanelOverview
            // 
            this.borderPanelOverview.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.borderPanelOverview.BottomBorder = true;
            this.borderPanelOverview.BottomBorderWidth = 1;
            this.borderPanelOverview.Controls.Add(this.labelSystemStart);
            this.borderPanelOverview.Controls.Add(this.labelDesktop);
            this.borderPanelOverview.Controls.Add(this.checkBoxSystemStart);
            this.borderPanelOverview.Controls.Add(this.checkBoxStartmenu);
            this.borderPanelOverview.Controls.Add(this.checkBoxDesktop);
            this.borderPanelOverview.Controls.Add(this.labelInstallLocation);
            this.borderPanelOverview.Controls.Add(this.textBoxInstallLocation);
            this.borderPanelOverview.Enabled = false;
            this.borderPanelOverview.LeftBorder = true;
            this.borderPanelOverview.LeftBorderWidth = 1;
            this.borderPanelOverview.Location = new System.Drawing.Point(18, 38);
            this.borderPanelOverview.Name = "borderPanelOverview";
            this.borderPanelOverview.RightBorder = true;
            this.borderPanelOverview.RightBorderWidth = 1;
            this.borderPanelOverview.Size = new System.Drawing.Size(464, 152);
            this.borderPanelOverview.TabIndex = 10;
            this.borderPanelOverview.TopBorder = true;
            this.borderPanelOverview.TopBorderWidth = 1;
            // 
            // labelSystemStart
            // 
            this.labelSystemStart.AutoSize = true;
            this.labelSystemStart.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSystemStart.ForeColor = System.Drawing.Color.Black;
            this.labelSystemStart.Location = new System.Drawing.Point(4, 107);
            this.labelSystemStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSystemStart.Name = "labelSystemStart";
            this.labelSystemStart.Size = new System.Drawing.Size(86, 20);
            this.labelSystemStart.TabIndex = 18;
            this.labelSystemStart.Text = "System start";
            // 
            // labelDesktop
            // 
            this.labelDesktop.AutoSize = true;
            this.labelDesktop.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDesktop.ForeColor = System.Drawing.Color.Black;
            this.labelDesktop.Location = new System.Drawing.Point(4, 48);
            this.labelDesktop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDesktop.Name = "labelDesktop";
            this.labelDesktop.Size = new System.Drawing.Size(69, 20);
            this.labelDesktop.TabIndex = 4;
            this.labelDesktop.Text = "Shortcuts";
            // 
            // checkBoxSystemStart
            // 
            this.checkBoxSystemStart.AutoSize = true;
            this.checkBoxSystemStart.Checked = true;
            this.checkBoxSystemStart.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSystemStart.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSystemStart.ForeColor = System.Drawing.Color.Black;
            this.checkBoxSystemStart.Location = new System.Drawing.Point(17, 130);
            this.checkBoxSystemStart.Name = "checkBoxSystemStart";
            this.checkBoxSystemStart.Size = new System.Drawing.Size(175, 20);
            this.checkBoxSystemStart.TabIndex = 17;
            this.checkBoxSystemStart.Text = "Start app on system start";
            this.checkBoxSystemStart.UseVisualStyleBackColor = true;
            // 
            // checkBoxStartmenu
            // 
            this.checkBoxStartmenu.AutoSize = true;
            this.checkBoxStartmenu.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxStartmenu.ForeColor = System.Drawing.Color.Black;
            this.checkBoxStartmenu.Location = new System.Drawing.Point(17, 86);
            this.checkBoxStartmenu.Name = "checkBoxStartmenu";
            this.checkBoxStartmenu.Size = new System.Drawing.Size(87, 20);
            this.checkBoxStartmenu.TabIndex = 15;
            this.checkBoxStartmenu.Text = "Startmenu";
            this.checkBoxStartmenu.UseVisualStyleBackColor = true;
            // 
            // checkBoxDesktop
            // 
            this.checkBoxDesktop.AutoSize = true;
            this.checkBoxDesktop.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDesktop.ForeColor = System.Drawing.Color.Black;
            this.checkBoxDesktop.Location = new System.Drawing.Point(17, 67);
            this.checkBoxDesktop.Name = "checkBoxDesktop";
            this.checkBoxDesktop.Size = new System.Drawing.Size(75, 20);
            this.checkBoxDesktop.TabIndex = 14;
            this.checkBoxDesktop.Text = "Desktop";
            this.checkBoxDesktop.UseVisualStyleBackColor = true;
            // 
            // labelInstallLocation
            // 
            this.labelInstallLocation.AutoSize = true;
            this.labelInstallLocation.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInstallLocation.ForeColor = System.Drawing.Color.Black;
            this.labelInstallLocation.Location = new System.Drawing.Point(4, 1);
            this.labelInstallLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInstallLocation.Name = "labelInstallLocation";
            this.labelInstallLocation.Size = new System.Drawing.Size(101, 20);
            this.labelInstallLocation.TabIndex = 7;
            this.labelInstallLocation.Text = "Install location";
            // 
            // textBoxInstallLocation
            // 
            this.textBoxInstallLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxInstallLocation.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInstallLocation.ForeColor = System.Drawing.Color.Black;
            this.textBoxInstallLocation.Location = new System.Drawing.Point(8, 23);
            this.textBoxInstallLocation.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
            this.textBoxInstallLocation.Name = "textBoxInstallLocation";
            this.textBoxInstallLocation.Size = new System.Drawing.Size(448, 22);
            this.textBoxInstallLocation.TabIndex = 6;
            // 
            // flatButtonInstallCancel
            // 
            this.flatButtonInstallCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.flatButtonInstallCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.flatButtonInstallCancel.FlatAppearance.BorderSize = 0;
            this.flatButtonInstallCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.flatButtonInstallCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(222)))), ((int)(((byte)(245)))));
            this.flatButtonInstallCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flatButtonInstallCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.flatButtonInstallCancel.Location = new System.Drawing.Point(307, 256);
            this.flatButtonInstallCancel.Margin = new System.Windows.Forms.Padding(6, 6, 3, 18);
            this.flatButtonInstallCancel.Name = "flatButtonInstallCancel";
            this.flatButtonInstallCancel.Size = new System.Drawing.Size(83, 26);
            this.flatButtonInstallCancel.TabIndex = 1;
            this.flatButtonInstallCancel.Text = "Cancel";
            this.flatButtonInstallCancel.UseVisualStyleBackColor = false;
            this.flatButtonInstallCancel.Click += new System.EventHandler(this.FlatButtonInstallCancel_Click);
            // 
            // borderPanelProgressInstall
            // 
            this.borderPanelProgressInstall.BorderColor = System.Drawing.Color.Black;
            this.borderPanelProgressInstall.BottomBorder = false;
            this.borderPanelProgressInstall.BottomBorderWidth = 1;
            this.borderPanelProgressInstall.Controls.Add(this.progressBarInstall);
            this.borderPanelProgressInstall.Controls.Add(this.labelProgress);
            this.borderPanelProgressInstall.LeftBorder = false;
            this.borderPanelProgressInstall.LeftBorderWidth = 1;
            this.borderPanelProgressInstall.Location = new System.Drawing.Point(18, 194);
            this.borderPanelProgressInstall.Name = "borderPanelProgressInstall";
            this.borderPanelProgressInstall.RightBorder = false;
            this.borderPanelProgressInstall.RightBorderWidth = 1;
            this.borderPanelProgressInstall.Size = new System.Drawing.Size(464, 54);
            this.borderPanelProgressInstall.TabIndex = 4;
            this.borderPanelProgressInstall.TopBorder = false;
            this.borderPanelProgressInstall.TopBorderWidth = 1;
            this.borderPanelProgressInstall.Visible = false;
            // 
            // progressBarInstall
            // 
            this.progressBarInstall.Location = new System.Drawing.Point(8, 26);
            this.progressBarInstall.MarqueeAnimationSpeed = 10;
            this.progressBarInstall.Name = "progressBarInstall";
            this.progressBarInstall.Size = new System.Drawing.Size(448, 23);
            this.progressBarInstall.Step = 1;
            this.progressBarInstall.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarInstall.TabIndex = 3;
            // 
            // labelProgress
            // 
            this.labelProgress.AutoSize = true;
            this.labelProgress.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProgress.Location = new System.Drawing.Point(4, 3);
            this.labelProgress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(60, 20);
            this.labelProgress.TabIndex = 2;
            this.labelProgress.Text = "Installing";
            // 
            // PageInstall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.borderPanelInstall);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PageInstall";
            this.Size = new System.Drawing.Size(500, 300);
            this.VisibleChanged += new System.EventHandler(this.PageInstall_VisibleChanged);
            this.borderPanelInstall.ResumeLayout(false);
            this.borderPanelInstall.PerformLayout();
            this.panelErrors.ResumeLayout(false);
            this.panelErrors.PerformLayout();
            this.panelNoPackage.ResumeLayout(false);
            this.panelNoPackage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNoPackage)).EndInit();
            this.panelIncorrectPath.ResumeLayout(false);
            this.panelIncorrectPath.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIncorrectPath)).EndInit();
            this.panelStillRunning.ResumeLayout(false);
            this.panelStillRunning.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStillRunning)).EndInit();
            this.borderPanelOverview.ResumeLayout(false);
            this.borderPanelOverview.PerformLayout();
            this.borderPanelProgressInstall.ResumeLayout(false);
            this.borderPanelProgressInstall.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.BorderPanel borderPanelInstall;
        private System.Windows.Forms.Label labelProgress;
        private System.Windows.Forms.Label labelOverview;
        private Controls.BorderPanel borderPanelProgressInstall;
        private System.Windows.Forms.ProgressBar progressBarInstall;
        private Controls.FlatButton flatButtonInstallCancel;
        private Controls.BorderPanel borderPanelOverview;
        private System.Windows.Forms.TextBox textBoxInstallLocation;
        private System.Windows.Forms.Label labelInstallLocation;
        private System.Windows.Forms.Label labelSystemStart;
        private System.Windows.Forms.Label labelDesktop;
        private System.Windows.Forms.CheckBox checkBoxSystemStart;
        private System.Windows.Forms.CheckBox checkBoxStartmenu;
        private System.Windows.Forms.CheckBox checkBoxDesktop;
        private Controls.FlatButton flatButtonInstall;
        private System.Windows.Forms.Panel panelIncorrectPath;
        private System.Windows.Forms.Label labelIncorrectPath;
        private System.Windows.Forms.PictureBox pictureBoxIncorrectPath;
        private System.Windows.Forms.CheckBox checkBoxStartOnFinish;
        private System.Windows.Forms.Panel panelStillRunning;
        private System.Windows.Forms.Label labelStillRunning;
        private System.Windows.Forms.PictureBox pictureBoxStillRunning;
        private System.Windows.Forms.Panel panelErrors;
        private System.Windows.Forms.Timer timerCheckRunning;
        private System.Windows.Forms.Panel panelNoPackage;
        private System.Windows.Forms.Label labelNoPackage;
        private System.Windows.Forms.PictureBox pictureBoxNoPackage;
    }
}
