namespace Playback_Changer.Forms
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.borderPanelDevices = new PlaybackChanger_Installer.Controls.BorderPanel();
            this.labelDevices = new System.Windows.Forms.Label();
            this.borderPanelDevicesInner = new PlaybackChanger_Installer.Controls.BorderPanel();
            this.borderPanelDevicesList = new PlaybackChanger_Installer.Controls.BorderPanel();
            this.borderPanelSettings = new PlaybackChanger_Installer.Controls.BorderPanel();
            this.flatButtonUnbindActivationKey = new PlaybackChanger_Installer.Controls.FlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.flatButtonActivationKey = new PlaybackChanger_Installer.Controls.FlatButton();
            this.labelActivationKey = new System.Windows.Forms.Label();
            this.labelStartOnSystemStart = new System.Windows.Forms.Label();
            this.bmToggleSwitchStartOnSystemStart = new bmControlLibrary.bmToggleSwitch();
            this.borderPanelBottom = new PlaybackChanger_Installer.Controls.BorderPanel();
            this.borderPanelDisabled = new PlaybackChanger_Installer.Controls.BorderPanel();
            this.labelLegendDisabled = new System.Windows.Forms.Label();
            this.borderPanelColorLegendDisabled = new PlaybackChanger_Installer.Controls.BorderPanel();
            this.borderPanelNotPresent = new PlaybackChanger_Installer.Controls.BorderPanel();
            this.labelLegendNotPresent = new System.Windows.Forms.Label();
            this.borderPanelColorLegendNotPresent = new PlaybackChanger_Installer.Controls.BorderPanel();
            this.flatButtonOK = new PlaybackChanger_Installer.Controls.FlatButton();
            this.borderPanelLegendActive = new PlaybackChanger_Installer.Controls.BorderPanel();
            this.labelLegendActive = new System.Windows.Forms.Label();
            this.borderPanelColorLegendActive = new PlaybackChanger_Installer.Controls.BorderPanel();
            this.borderPanelLegendDefault = new PlaybackChanger_Installer.Controls.BorderPanel();
            this.labelLegendDefault = new System.Windows.Forms.Label();
            this.borderPanelColorLegendDefault = new PlaybackChanger_Installer.Controls.BorderPanel();
            this.borderPanelLegendUnplugged = new PlaybackChanger_Installer.Controls.BorderPanel();
            this.labelLegendUnplugged = new System.Windows.Forms.Label();
            this.borderPanelColorLegendUnplugged = new PlaybackChanger_Installer.Controls.BorderPanel();
            this.borderPanelLegendIgnored = new PlaybackChanger_Installer.Controls.BorderPanel();
            this.labelLegendIgnored = new System.Windows.Forms.Label();
            this.borderPanelColorLegendIgnored = new PlaybackChanger_Installer.Controls.BorderPanel();
            this.borderPanelMain = new PlaybackChanger_Installer.Controls.BorderPanel();
            this.labelCheckUpdates = new System.Windows.Forms.Label();
            this.bmToggleSwitchCheckUpdates = new bmControlLibrary.bmToggleSwitch();
            this.borderPanelDevices.SuspendLayout();
            this.borderPanelDevicesInner.SuspendLayout();
            this.borderPanelSettings.SuspendLayout();
            this.borderPanelBottom.SuspendLayout();
            this.borderPanelDisabled.SuspendLayout();
            this.borderPanelNotPresent.SuspendLayout();
            this.borderPanelLegendActive.SuspendLayout();
            this.borderPanelLegendDefault.SuspendLayout();
            this.borderPanelLegendUnplugged.SuspendLayout();
            this.borderPanelLegendIgnored.SuspendLayout();
            this.borderPanelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // borderPanelDevices
            // 
            this.borderPanelDevices.BorderColor = System.Drawing.Color.Black;
            this.borderPanelDevices.BottomBorder = false;
            this.borderPanelDevices.BottomBorderWidth = 1;
            this.borderPanelDevices.Controls.Add(this.labelDevices);
            this.borderPanelDevices.Controls.Add(this.borderPanelDevicesInner);
            this.borderPanelDevices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.borderPanelDevices.LeftBorder = false;
            this.borderPanelDevices.LeftBorderWidth = 1;
            this.borderPanelDevices.Location = new System.Drawing.Point(0, 0);
            this.borderPanelDevices.Name = "borderPanelDevices";
            this.borderPanelDevices.RightBorder = false;
            this.borderPanelDevices.RightBorderWidth = 1;
            this.borderPanelDevices.Size = new System.Drawing.Size(401, 449);
            this.borderPanelDevices.TabIndex = 0;
            this.borderPanelDevices.TopBorder = false;
            this.borderPanelDevices.TopBorderWidth = 1;
            // 
            // labelDevices
            // 
            this.labelDevices.AutoSize = true;
            this.labelDevices.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDevices.Location = new System.Drawing.Point(18, 18);
            this.labelDevices.Margin = new System.Windows.Forms.Padding(18, 18, 4, 0);
            this.labelDevices.Name = "labelDevices";
            this.labelDevices.Size = new System.Drawing.Size(57, 20);
            this.labelDevices.TabIndex = 2;
            this.labelDevices.Text = "Devices";
            // 
            // borderPanelDevicesInner
            // 
            this.borderPanelDevicesInner.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.borderPanelDevicesInner.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.borderPanelDevicesInner.BottomBorder = true;
            this.borderPanelDevicesInner.BottomBorderWidth = 1;
            this.borderPanelDevicesInner.Controls.Add(this.borderPanelDevicesList);
            this.borderPanelDevicesInner.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borderPanelDevicesInner.LeftBorder = true;
            this.borderPanelDevicesInner.LeftBorderWidth = 1;
            this.borderPanelDevicesInner.Location = new System.Drawing.Point(19, 39);
            this.borderPanelDevicesInner.Margin = new System.Windows.Forms.Padding(10, 30, 10, 10);
            this.borderPanelDevicesInner.Name = "borderPanelDevicesInner";
            this.borderPanelDevicesInner.RightBorder = true;
            this.borderPanelDevicesInner.RightBorderWidth = 1;
            this.borderPanelDevicesInner.Size = new System.Drawing.Size(369, 397);
            this.borderPanelDevicesInner.TabIndex = 0;
            this.borderPanelDevicesInner.TopBorder = true;
            this.borderPanelDevicesInner.TopBorderWidth = 1;
            // 
            // borderPanelDevicesList
            // 
            this.borderPanelDevicesList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.borderPanelDevicesList.AutoScroll = true;
            this.borderPanelDevicesList.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.borderPanelDevicesList.BottomBorder = false;
            this.borderPanelDevicesList.BottomBorderWidth = 1;
            this.borderPanelDevicesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borderPanelDevicesList.LeftBorder = false;
            this.borderPanelDevicesList.LeftBorderWidth = 1;
            this.borderPanelDevicesList.Location = new System.Drawing.Point(1, 1);
            this.borderPanelDevicesList.Margin = new System.Windows.Forms.Padding(1);
            this.borderPanelDevicesList.Name = "borderPanelDevicesList";
            this.borderPanelDevicesList.RightBorder = false;
            this.borderPanelDevicesList.RightBorderWidth = 1;
            this.borderPanelDevicesList.Size = new System.Drawing.Size(367, 395);
            this.borderPanelDevicesList.TabIndex = 1;
            this.borderPanelDevicesList.TopBorder = false;
            this.borderPanelDevicesList.TopBorderWidth = 1;
            // 
            // borderPanelSettings
            // 
            this.borderPanelSettings.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.borderPanelSettings.BottomBorder = false;
            this.borderPanelSettings.BottomBorderWidth = 1;
            this.borderPanelSettings.Controls.Add(this.labelCheckUpdates);
            this.borderPanelSettings.Controls.Add(this.bmToggleSwitchCheckUpdates);
            this.borderPanelSettings.Controls.Add(this.flatButtonUnbindActivationKey);
            this.borderPanelSettings.Controls.Add(this.label1);
            this.borderPanelSettings.Controls.Add(this.flatButtonActivationKey);
            this.borderPanelSettings.Controls.Add(this.labelActivationKey);
            this.borderPanelSettings.Controls.Add(this.labelStartOnSystemStart);
            this.borderPanelSettings.Controls.Add(this.bmToggleSwitchStartOnSystemStart);
            this.borderPanelSettings.Dock = System.Windows.Forms.DockStyle.Right;
            this.borderPanelSettings.LeftBorder = true;
            this.borderPanelSettings.LeftBorderWidth = 1;
            this.borderPanelSettings.Location = new System.Drawing.Point(401, 0);
            this.borderPanelSettings.Name = "borderPanelSettings";
            this.borderPanelSettings.RightBorder = false;
            this.borderPanelSettings.RightBorderWidth = 1;
            this.borderPanelSettings.Size = new System.Drawing.Size(194, 449);
            this.borderPanelSettings.TabIndex = 1;
            this.borderPanelSettings.TopBorder = false;
            this.borderPanelSettings.TopBorderWidth = 1;
            // 
            // flatButtonUnbindActivationKey
            // 
            this.flatButtonUnbindActivationKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.flatButtonUnbindActivationKey.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.flatButtonUnbindActivationKey.FlatAppearance.BorderSize = 0;
            this.flatButtonUnbindActivationKey.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.flatButtonUnbindActivationKey.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(222)))), ((int)(((byte)(245)))));
            this.flatButtonUnbindActivationKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flatButtonUnbindActivationKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.flatButtonUnbindActivationKey.Location = new System.Drawing.Point(19, 150);
            this.flatButtonUnbindActivationKey.Name = "flatButtonUnbindActivationKey";
            this.flatButtonUnbindActivationKey.Size = new System.Drawing.Size(100, 30);
            this.flatButtonUnbindActivationKey.TabIndex = 11;
            this.flatButtonUnbindActivationKey.Text = "Unbind";
            this.flatButtonUnbindActivationKey.UseVisualStyleBackColor = false;
            this.flatButtonUnbindActivationKey.Click += new System.EventHandler(this.FlatButtonUnbindActivationKey_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 118);
            this.label1.Margin = new System.Windows.Forms.Padding(18, 18, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "ALT +";
            // 
            // flatButtonActivationKey
            // 
            this.flatButtonActivationKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.flatButtonActivationKey.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.flatButtonActivationKey.FlatAppearance.BorderSize = 0;
            this.flatButtonActivationKey.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.flatButtonActivationKey.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(222)))), ((int)(((byte)(245)))));
            this.flatButtonActivationKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flatButtonActivationKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.flatButtonActivationKey.Location = new System.Drawing.Point(64, 114);
            this.flatButtonActivationKey.Name = "flatButtonActivationKey";
            this.flatButtonActivationKey.Size = new System.Drawing.Size(55, 30);
            this.flatButtonActivationKey.TabIndex = 9;
            this.flatButtonActivationKey.Text = "{key}";
            this.flatButtonActivationKey.UseVisualStyleBackColor = false;
            this.flatButtonActivationKey.Click += new System.EventHandler(this.FlatButtonActivationKey_Click);
            // 
            // labelActivationKey
            // 
            this.labelActivationKey.AutoSize = true;
            this.labelActivationKey.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActivationKey.Location = new System.Drawing.Point(15, 89);
            this.labelActivationKey.Margin = new System.Windows.Forms.Padding(18, 18, 4, 0);
            this.labelActivationKey.Name = "labelActivationKey";
            this.labelActivationKey.Size = new System.Drawing.Size(161, 20);
            this.labelActivationKey.TabIndex = 8;
            this.labelActivationKey.Text = "Quickview activation key";
            // 
            // labelStartOnSystemStart
            // 
            this.labelStartOnSystemStart.AutoSize = true;
            this.labelStartOnSystemStart.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartOnSystemStart.Location = new System.Drawing.Point(15, 18);
            this.labelStartOnSystemStart.Margin = new System.Windows.Forms.Padding(18, 18, 4, 0);
            this.labelStartOnSystemStart.Name = "labelStartOnSystemStart";
            this.labelStartOnSystemStart.Size = new System.Drawing.Size(137, 20);
            this.labelStartOnSystemStart.TabIndex = 3;
            this.labelStartOnSystemStart.Text = "Start on system start";
            // 
            // bmToggleSwitchStartOnSystemStart
            // 
            this.bmToggleSwitchStartOnSystemStart.ButtonColor = System.Drawing.Color.Empty;
            this.bmToggleSwitchStartOnSystemStart.Location = new System.Drawing.Point(22, 40);
            this.bmToggleSwitchStartOnSystemStart.Name = "bmToggleSwitchStartOnSystemStart";
            this.bmToggleSwitchStartOnSystemStart.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmToggleSwitchStartOnSystemStart.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmToggleSwitchStartOnSystemStart.Size = new System.Drawing.Size(50, 19);
            this.bmToggleSwitchStartOnSystemStart.TabIndex = 0;
            this.bmToggleSwitchStartOnSystemStart.CheckedChanged += new bmControlLibrary.bmToggleSwitch.CheckedChangedDelegate(this.BmToggleSwitchStartOnSystemStart_CheckedChanged);
            // 
            // borderPanelBottom
            // 
            this.borderPanelBottom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.borderPanelBottom.BottomBorder = false;
            this.borderPanelBottom.BottomBorderWidth = 1;
            this.borderPanelBottom.Controls.Add(this.borderPanelDisabled);
            this.borderPanelBottom.Controls.Add(this.borderPanelNotPresent);
            this.borderPanelBottom.Controls.Add(this.flatButtonOK);
            this.borderPanelBottom.Controls.Add(this.borderPanelLegendActive);
            this.borderPanelBottom.Controls.Add(this.borderPanelLegendDefault);
            this.borderPanelBottom.Controls.Add(this.borderPanelLegendUnplugged);
            this.borderPanelBottom.Controls.Add(this.borderPanelLegendIgnored);
            this.borderPanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.borderPanelBottom.LeftBorder = false;
            this.borderPanelBottom.LeftBorderWidth = 1;
            this.borderPanelBottom.Location = new System.Drawing.Point(0, 449);
            this.borderPanelBottom.Name = "borderPanelBottom";
            this.borderPanelBottom.RightBorder = false;
            this.borderPanelBottom.RightBorderWidth = 1;
            this.borderPanelBottom.Size = new System.Drawing.Size(595, 61);
            this.borderPanelBottom.TabIndex = 2;
            this.borderPanelBottom.TopBorder = true;
            this.borderPanelBottom.TopBorderWidth = 1;
            // 
            // borderPanelDisabled
            // 
            this.borderPanelDisabled.BorderColor = System.Drawing.Color.Black;
            this.borderPanelDisabled.BottomBorder = false;
            this.borderPanelDisabled.BottomBorderWidth = 1;
            this.borderPanelDisabled.Controls.Add(this.labelLegendDisabled);
            this.borderPanelDisabled.Controls.Add(this.borderPanelColorLegendDisabled);
            this.borderPanelDisabled.LeftBorder = false;
            this.borderPanelDisabled.LeftBorderWidth = 1;
            this.borderPanelDisabled.Location = new System.Drawing.Point(163, 34);
            this.borderPanelDisabled.Name = "borderPanelDisabled";
            this.borderPanelDisabled.RightBorder = false;
            this.borderPanelDisabled.RightBorderWidth = 1;
            this.borderPanelDisabled.Size = new System.Drawing.Size(122, 22);
            this.borderPanelDisabled.TabIndex = 5;
            this.borderPanelDisabled.TopBorder = false;
            this.borderPanelDisabled.TopBorderWidth = 1;
            // 
            // labelLegendDisabled
            // 
            this.labelLegendDisabled.AutoSize = true;
            this.labelLegendDisabled.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelLegendDisabled.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLegendDisabled.Location = new System.Drawing.Point(26, 0);
            this.labelLegendDisabled.Margin = new System.Windows.Forms.Padding(18, 18, 4, 0);
            this.labelLegendDisabled.Name = "labelLegendDisabled";
            this.labelLegendDisabled.Size = new System.Drawing.Size(63, 20);
            this.labelLegendDisabled.TabIndex = 3;
            this.labelLegendDisabled.Text = "Disabled";
            // 
            // borderPanelColorLegendDisabled
            // 
            this.borderPanelColorLegendDisabled.BorderColor = System.Drawing.Color.Black;
            this.borderPanelColorLegendDisabled.BottomBorder = true;
            this.borderPanelColorLegendDisabled.BottomBorderWidth = 1;
            this.borderPanelColorLegendDisabled.Dock = System.Windows.Forms.DockStyle.Left;
            this.borderPanelColorLegendDisabled.LeftBorder = true;
            this.borderPanelColorLegendDisabled.LeftBorderWidth = 1;
            this.borderPanelColorLegendDisabled.Location = new System.Drawing.Point(0, 0);
            this.borderPanelColorLegendDisabled.Name = "borderPanelColorLegendDisabled";
            this.borderPanelColorLegendDisabled.RightBorder = true;
            this.borderPanelColorLegendDisabled.RightBorderWidth = 1;
            this.borderPanelColorLegendDisabled.Size = new System.Drawing.Size(26, 22);
            this.borderPanelColorLegendDisabled.TabIndex = 0;
            this.borderPanelColorLegendDisabled.TopBorder = true;
            this.borderPanelColorLegendDisabled.TopBorderWidth = 1;
            // 
            // borderPanelNotPresent
            // 
            this.borderPanelNotPresent.BorderColor = System.Drawing.Color.Black;
            this.borderPanelNotPresent.BottomBorder = false;
            this.borderPanelNotPresent.BottomBorderWidth = 1;
            this.borderPanelNotPresent.Controls.Add(this.labelLegendNotPresent);
            this.borderPanelNotPresent.Controls.Add(this.borderPanelColorLegendNotPresent);
            this.borderPanelNotPresent.LeftBorder = false;
            this.borderPanelNotPresent.LeftBorderWidth = 1;
            this.borderPanelNotPresent.Location = new System.Drawing.Point(304, 34);
            this.borderPanelNotPresent.Name = "borderPanelNotPresent";
            this.borderPanelNotPresent.RightBorder = false;
            this.borderPanelNotPresent.RightBorderWidth = 1;
            this.borderPanelNotPresent.Size = new System.Drawing.Size(122, 22);
            this.borderPanelNotPresent.TabIndex = 6;
            this.borderPanelNotPresent.TopBorder = false;
            this.borderPanelNotPresent.TopBorderWidth = 1;
            // 
            // labelLegendNotPresent
            // 
            this.labelLegendNotPresent.AutoSize = true;
            this.labelLegendNotPresent.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelLegendNotPresent.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLegendNotPresent.Location = new System.Drawing.Point(26, 0);
            this.labelLegendNotPresent.Margin = new System.Windows.Forms.Padding(18, 18, 4, 0);
            this.labelLegendNotPresent.Name = "labelLegendNotPresent";
            this.labelLegendNotPresent.Size = new System.Drawing.Size(80, 20);
            this.labelLegendNotPresent.TabIndex = 3;
            this.labelLegendNotPresent.Text = "Not present";
            // 
            // borderPanelColorLegendNotPresent
            // 
            this.borderPanelColorLegendNotPresent.BorderColor = System.Drawing.Color.Black;
            this.borderPanelColorLegendNotPresent.BottomBorder = true;
            this.borderPanelColorLegendNotPresent.BottomBorderWidth = 1;
            this.borderPanelColorLegendNotPresent.Dock = System.Windows.Forms.DockStyle.Left;
            this.borderPanelColorLegendNotPresent.LeftBorder = true;
            this.borderPanelColorLegendNotPresent.LeftBorderWidth = 1;
            this.borderPanelColorLegendNotPresent.Location = new System.Drawing.Point(0, 0);
            this.borderPanelColorLegendNotPresent.Name = "borderPanelColorLegendNotPresent";
            this.borderPanelColorLegendNotPresent.RightBorder = true;
            this.borderPanelColorLegendNotPresent.RightBorderWidth = 1;
            this.borderPanelColorLegendNotPresent.Size = new System.Drawing.Size(26, 22);
            this.borderPanelColorLegendNotPresent.TabIndex = 0;
            this.borderPanelColorLegendNotPresent.TopBorder = true;
            this.borderPanelColorLegendNotPresent.TopBorderWidth = 1;
            // 
            // flatButtonOK
            // 
            this.flatButtonOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.flatButtonOK.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.flatButtonOK.FlatAppearance.BorderSize = 0;
            this.flatButtonOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.flatButtonOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(222)))), ((int)(((byte)(245)))));
            this.flatButtonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flatButtonOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.flatButtonOK.Location = new System.Drawing.Point(508, 24);
            this.flatButtonOK.Name = "flatButtonOK";
            this.flatButtonOK.Size = new System.Drawing.Size(75, 30);
            this.flatButtonOK.TabIndex = 7;
            this.flatButtonOK.Text = "OK";
            this.flatButtonOK.UseVisualStyleBackColor = false;
            this.flatButtonOK.Click += new System.EventHandler(this.FlatButtonOK_Click);
            // 
            // borderPanelLegendActive
            // 
            this.borderPanelLegendActive.BorderColor = System.Drawing.Color.Black;
            this.borderPanelLegendActive.BottomBorder = false;
            this.borderPanelLegendActive.BottomBorderWidth = 1;
            this.borderPanelLegendActive.Controls.Add(this.labelLegendActive);
            this.borderPanelLegendActive.Controls.Add(this.borderPanelColorLegendActive);
            this.borderPanelLegendActive.LeftBorder = false;
            this.borderPanelLegendActive.LeftBorderWidth = 1;
            this.borderPanelLegendActive.Location = new System.Drawing.Point(19, 34);
            this.borderPanelLegendActive.Name = "borderPanelLegendActive";
            this.borderPanelLegendActive.RightBorder = false;
            this.borderPanelLegendActive.RightBorderWidth = 1;
            this.borderPanelLegendActive.Size = new System.Drawing.Size(122, 22);
            this.borderPanelLegendActive.TabIndex = 6;
            this.borderPanelLegendActive.TopBorder = false;
            this.borderPanelLegendActive.TopBorderWidth = 1;
            // 
            // labelLegendActive
            // 
            this.labelLegendActive.AutoSize = true;
            this.labelLegendActive.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelLegendActive.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLegendActive.Location = new System.Drawing.Point(26, 0);
            this.labelLegendActive.Margin = new System.Windows.Forms.Padding(18, 18, 4, 0);
            this.labelLegendActive.Name = "labelLegendActive";
            this.labelLegendActive.Size = new System.Drawing.Size(47, 20);
            this.labelLegendActive.TabIndex = 3;
            this.labelLegendActive.Text = "Active";
            // 
            // borderPanelColorLegendActive
            // 
            this.borderPanelColorLegendActive.BorderColor = System.Drawing.Color.Black;
            this.borderPanelColorLegendActive.BottomBorder = true;
            this.borderPanelColorLegendActive.BottomBorderWidth = 1;
            this.borderPanelColorLegendActive.Dock = System.Windows.Forms.DockStyle.Left;
            this.borderPanelColorLegendActive.LeftBorder = true;
            this.borderPanelColorLegendActive.LeftBorderWidth = 1;
            this.borderPanelColorLegendActive.Location = new System.Drawing.Point(0, 0);
            this.borderPanelColorLegendActive.Name = "borderPanelColorLegendActive";
            this.borderPanelColorLegendActive.RightBorder = true;
            this.borderPanelColorLegendActive.RightBorderWidth = 1;
            this.borderPanelColorLegendActive.Size = new System.Drawing.Size(26, 22);
            this.borderPanelColorLegendActive.TabIndex = 0;
            this.borderPanelColorLegendActive.TopBorder = true;
            this.borderPanelColorLegendActive.TopBorderWidth = 1;
            // 
            // borderPanelLegendDefault
            // 
            this.borderPanelLegendDefault.BorderColor = System.Drawing.Color.Black;
            this.borderPanelLegendDefault.BottomBorder = false;
            this.borderPanelLegendDefault.BottomBorderWidth = 1;
            this.borderPanelLegendDefault.Controls.Add(this.labelLegendDefault);
            this.borderPanelLegendDefault.Controls.Add(this.borderPanelColorLegendDefault);
            this.borderPanelLegendDefault.LeftBorder = false;
            this.borderPanelLegendDefault.LeftBorderWidth = 1;
            this.borderPanelLegendDefault.Location = new System.Drawing.Point(19, 6);
            this.borderPanelLegendDefault.Name = "borderPanelLegendDefault";
            this.borderPanelLegendDefault.RightBorder = false;
            this.borderPanelLegendDefault.RightBorderWidth = 1;
            this.borderPanelLegendDefault.Size = new System.Drawing.Size(122, 22);
            this.borderPanelLegendDefault.TabIndex = 5;
            this.borderPanelLegendDefault.TopBorder = false;
            this.borderPanelLegendDefault.TopBorderWidth = 1;
            // 
            // labelLegendDefault
            // 
            this.labelLegendDefault.AutoSize = true;
            this.labelLegendDefault.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelLegendDefault.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLegendDefault.Location = new System.Drawing.Point(26, 0);
            this.labelLegendDefault.Margin = new System.Windows.Forms.Padding(18, 18, 4, 0);
            this.labelLegendDefault.Name = "labelLegendDefault";
            this.labelLegendDefault.Size = new System.Drawing.Size(52, 20);
            this.labelLegendDefault.TabIndex = 3;
            this.labelLegendDefault.Text = "Default";
            // 
            // borderPanelColorLegendDefault
            // 
            this.borderPanelColorLegendDefault.BorderColor = System.Drawing.Color.Black;
            this.borderPanelColorLegendDefault.BottomBorder = true;
            this.borderPanelColorLegendDefault.BottomBorderWidth = 1;
            this.borderPanelColorLegendDefault.Dock = System.Windows.Forms.DockStyle.Left;
            this.borderPanelColorLegendDefault.LeftBorder = true;
            this.borderPanelColorLegendDefault.LeftBorderWidth = 1;
            this.borderPanelColorLegendDefault.Location = new System.Drawing.Point(0, 0);
            this.borderPanelColorLegendDefault.Name = "borderPanelColorLegendDefault";
            this.borderPanelColorLegendDefault.RightBorder = true;
            this.borderPanelColorLegendDefault.RightBorderWidth = 1;
            this.borderPanelColorLegendDefault.Size = new System.Drawing.Size(26, 22);
            this.borderPanelColorLegendDefault.TabIndex = 0;
            this.borderPanelColorLegendDefault.TopBorder = true;
            this.borderPanelColorLegendDefault.TopBorderWidth = 1;
            // 
            // borderPanelLegendUnplugged
            // 
            this.borderPanelLegendUnplugged.BorderColor = System.Drawing.Color.Black;
            this.borderPanelLegendUnplugged.BottomBorder = false;
            this.borderPanelLegendUnplugged.BottomBorderWidth = 1;
            this.borderPanelLegendUnplugged.Controls.Add(this.labelLegendUnplugged);
            this.borderPanelLegendUnplugged.Controls.Add(this.borderPanelColorLegendUnplugged);
            this.borderPanelLegendUnplugged.LeftBorder = false;
            this.borderPanelLegendUnplugged.LeftBorderWidth = 1;
            this.borderPanelLegendUnplugged.Location = new System.Drawing.Point(304, 6);
            this.borderPanelLegendUnplugged.Name = "borderPanelLegendUnplugged";
            this.borderPanelLegendUnplugged.RightBorder = false;
            this.borderPanelLegendUnplugged.RightBorderWidth = 1;
            this.borderPanelLegendUnplugged.Size = new System.Drawing.Size(122, 22);
            this.borderPanelLegendUnplugged.TabIndex = 4;
            this.borderPanelLegendUnplugged.TopBorder = false;
            this.borderPanelLegendUnplugged.TopBorderWidth = 1;
            // 
            // labelLegendUnplugged
            // 
            this.labelLegendUnplugged.AutoSize = true;
            this.labelLegendUnplugged.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelLegendUnplugged.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLegendUnplugged.Location = new System.Drawing.Point(26, 0);
            this.labelLegendUnplugged.Margin = new System.Windows.Forms.Padding(18, 18, 4, 0);
            this.labelLegendUnplugged.Name = "labelLegendUnplugged";
            this.labelLegendUnplugged.Size = new System.Drawing.Size(77, 20);
            this.labelLegendUnplugged.TabIndex = 3;
            this.labelLegendUnplugged.Text = "Unplugged";
            // 
            // borderPanelColorLegendUnplugged
            // 
            this.borderPanelColorLegendUnplugged.BorderColor = System.Drawing.Color.Black;
            this.borderPanelColorLegendUnplugged.BottomBorder = true;
            this.borderPanelColorLegendUnplugged.BottomBorderWidth = 1;
            this.borderPanelColorLegendUnplugged.Dock = System.Windows.Forms.DockStyle.Left;
            this.borderPanelColorLegendUnplugged.LeftBorder = true;
            this.borderPanelColorLegendUnplugged.LeftBorderWidth = 1;
            this.borderPanelColorLegendUnplugged.Location = new System.Drawing.Point(0, 0);
            this.borderPanelColorLegendUnplugged.Name = "borderPanelColorLegendUnplugged";
            this.borderPanelColorLegendUnplugged.RightBorder = true;
            this.borderPanelColorLegendUnplugged.RightBorderWidth = 1;
            this.borderPanelColorLegendUnplugged.Size = new System.Drawing.Size(26, 22);
            this.borderPanelColorLegendUnplugged.TabIndex = 0;
            this.borderPanelColorLegendUnplugged.TopBorder = true;
            this.borderPanelColorLegendUnplugged.TopBorderWidth = 1;
            // 
            // borderPanelLegendIgnored
            // 
            this.borderPanelLegendIgnored.BorderColor = System.Drawing.Color.Black;
            this.borderPanelLegendIgnored.BottomBorder = false;
            this.borderPanelLegendIgnored.BottomBorderWidth = 1;
            this.borderPanelLegendIgnored.Controls.Add(this.labelLegendIgnored);
            this.borderPanelLegendIgnored.Controls.Add(this.borderPanelColorLegendIgnored);
            this.borderPanelLegendIgnored.LeftBorder = false;
            this.borderPanelLegendIgnored.LeftBorderWidth = 1;
            this.borderPanelLegendIgnored.Location = new System.Drawing.Point(163, 6);
            this.borderPanelLegendIgnored.Name = "borderPanelLegendIgnored";
            this.borderPanelLegendIgnored.RightBorder = false;
            this.borderPanelLegendIgnored.RightBorderWidth = 1;
            this.borderPanelLegendIgnored.Size = new System.Drawing.Size(122, 22);
            this.borderPanelLegendIgnored.TabIndex = 0;
            this.borderPanelLegendIgnored.TopBorder = false;
            this.borderPanelLegendIgnored.TopBorderWidth = 1;
            // 
            // labelLegendIgnored
            // 
            this.labelLegendIgnored.AutoSize = true;
            this.labelLegendIgnored.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelLegendIgnored.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLegendIgnored.Location = new System.Drawing.Point(26, 0);
            this.labelLegendIgnored.Margin = new System.Windows.Forms.Padding(18, 18, 4, 0);
            this.labelLegendIgnored.Name = "labelLegendIgnored";
            this.labelLegendIgnored.Size = new System.Drawing.Size(57, 20);
            this.labelLegendIgnored.TabIndex = 3;
            this.labelLegendIgnored.Text = "Ignored";
            // 
            // borderPanelColorLegendIgnored
            // 
            this.borderPanelColorLegendIgnored.BorderColor = System.Drawing.Color.Black;
            this.borderPanelColorLegendIgnored.BottomBorder = true;
            this.borderPanelColorLegendIgnored.BottomBorderWidth = 1;
            this.borderPanelColorLegendIgnored.Dock = System.Windows.Forms.DockStyle.Left;
            this.borderPanelColorLegendIgnored.LeftBorder = true;
            this.borderPanelColorLegendIgnored.LeftBorderWidth = 1;
            this.borderPanelColorLegendIgnored.Location = new System.Drawing.Point(0, 0);
            this.borderPanelColorLegendIgnored.Name = "borderPanelColorLegendIgnored";
            this.borderPanelColorLegendIgnored.RightBorder = true;
            this.borderPanelColorLegendIgnored.RightBorderWidth = 1;
            this.borderPanelColorLegendIgnored.Size = new System.Drawing.Size(26, 22);
            this.borderPanelColorLegendIgnored.TabIndex = 0;
            this.borderPanelColorLegendIgnored.TopBorder = true;
            this.borderPanelColorLegendIgnored.TopBorderWidth = 1;
            // 
            // borderPanelMain
            // 
            this.borderPanelMain.BorderColor = System.Drawing.Color.Black;
            this.borderPanelMain.BottomBorder = false;
            this.borderPanelMain.BottomBorderWidth = 1;
            this.borderPanelMain.Controls.Add(this.borderPanelDevices);
            this.borderPanelMain.Controls.Add(this.borderPanelSettings);
            this.borderPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.borderPanelMain.LeftBorder = false;
            this.borderPanelMain.LeftBorderWidth = 1;
            this.borderPanelMain.Location = new System.Drawing.Point(0, 0);
            this.borderPanelMain.Name = "borderPanelMain";
            this.borderPanelMain.RightBorder = false;
            this.borderPanelMain.RightBorderWidth = 1;
            this.borderPanelMain.Size = new System.Drawing.Size(595, 449);
            this.borderPanelMain.TabIndex = 3;
            this.borderPanelMain.TopBorder = false;
            this.borderPanelMain.TopBorderWidth = 1;
            // 
            // labelCheckUpdates
            // 
            this.labelCheckUpdates.AutoSize = true;
            this.labelCheckUpdates.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCheckUpdates.Location = new System.Drawing.Point(15, 201);
            this.labelCheckUpdates.Margin = new System.Windows.Forms.Padding(18, 18, 4, 0);
            this.labelCheckUpdates.Name = "labelCheckUpdates";
            this.labelCheckUpdates.Size = new System.Drawing.Size(121, 20);
            this.labelCheckUpdates.TabIndex = 13;
            this.labelCheckUpdates.Text = "Check for updates";
            // 
            // bmToggleSwitchCheckUpdates
            // 
            this.bmToggleSwitchCheckUpdates.ButtonColor = System.Drawing.Color.Empty;
            this.bmToggleSwitchCheckUpdates.Location = new System.Drawing.Point(22, 223);
            this.bmToggleSwitchCheckUpdates.Name = "bmToggleSwitchCheckUpdates";
            this.bmToggleSwitchCheckUpdates.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmToggleSwitchCheckUpdates.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmToggleSwitchCheckUpdates.Size = new System.Drawing.Size(50, 19);
            this.bmToggleSwitchCheckUpdates.TabIndex = 12;
            this.bmToggleSwitchCheckUpdates.CheckedChanged += new bmControlLibrary.bmToggleSwitch.CheckedChangedDelegate(this.bmToggleSwitchCheckUpdates_CheckedChanged);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(595, 510);
            this.Controls.Add(this.borderPanelMain);
            this.Controls.Add(this.borderPanelBottom);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Playback Changer settings";
            this.Activated += new System.EventHandler(this.SettingsForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.borderPanelDevices.ResumeLayout(false);
            this.borderPanelDevices.PerformLayout();
            this.borderPanelDevicesInner.ResumeLayout(false);
            this.borderPanelSettings.ResumeLayout(false);
            this.borderPanelSettings.PerformLayout();
            this.borderPanelBottom.ResumeLayout(false);
            this.borderPanelDisabled.ResumeLayout(false);
            this.borderPanelDisabled.PerformLayout();
            this.borderPanelNotPresent.ResumeLayout(false);
            this.borderPanelNotPresent.PerformLayout();
            this.borderPanelLegendActive.ResumeLayout(false);
            this.borderPanelLegendActive.PerformLayout();
            this.borderPanelLegendDefault.ResumeLayout(false);
            this.borderPanelLegendDefault.PerformLayout();
            this.borderPanelLegendUnplugged.ResumeLayout(false);
            this.borderPanelLegendUnplugged.PerformLayout();
            this.borderPanelLegendIgnored.ResumeLayout(false);
            this.borderPanelLegendIgnored.PerformLayout();
            this.borderPanelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private PlaybackChanger_Installer.Controls.BorderPanel borderPanelDevices;
        private PlaybackChanger_Installer.Controls.BorderPanel borderPanelDevicesInner;
        private PlaybackChanger_Installer.Controls.BorderPanel borderPanelSettings;
        private PlaybackChanger_Installer.Controls.BorderPanel borderPanelBottom;
        private PlaybackChanger_Installer.Controls.BorderPanel borderPanelMain;
        private System.Windows.Forms.Label labelDevices;
        private PlaybackChanger_Installer.Controls.BorderPanel borderPanelDevicesList;
        private PlaybackChanger_Installer.Controls.BorderPanel borderPanelLegendIgnored;
        private System.Windows.Forms.Label labelLegendIgnored;
        private PlaybackChanger_Installer.Controls.BorderPanel borderPanelColorLegendIgnored;
        private PlaybackChanger_Installer.Controls.BorderPanel borderPanelLegendUnplugged;
        private System.Windows.Forms.Label labelLegendUnplugged;
        private PlaybackChanger_Installer.Controls.BorderPanel borderPanelColorLegendUnplugged;
        private PlaybackChanger_Installer.Controls.FlatButton flatButtonOK;
        private PlaybackChanger_Installer.Controls.BorderPanel borderPanelNotPresent;
        private System.Windows.Forms.Label labelLegendNotPresent;
        private PlaybackChanger_Installer.Controls.BorderPanel borderPanelColorLegendNotPresent;
        private PlaybackChanger_Installer.Controls.BorderPanel borderPanelLegendActive;
        private System.Windows.Forms.Label labelLegendActive;
        private PlaybackChanger_Installer.Controls.BorderPanel borderPanelColorLegendActive;
        private PlaybackChanger_Installer.Controls.BorderPanel borderPanelDisabled;
        private System.Windows.Forms.Label labelLegendDisabled;
        private PlaybackChanger_Installer.Controls.BorderPanel borderPanelColorLegendDisabled;
        private PlaybackChanger_Installer.Controls.BorderPanel borderPanelLegendDefault;
        private System.Windows.Forms.Label labelLegendDefault;
        private PlaybackChanger_Installer.Controls.BorderPanel borderPanelColorLegendDefault;
        private PlaybackChanger_Installer.Controls.FlatButton flatButtonActivationKey;
        private System.Windows.Forms.Label labelActivationKey;
        private System.Windows.Forms.Label labelStartOnSystemStart;
        private bmControlLibrary.bmToggleSwitch bmToggleSwitchStartOnSystemStart;
        private System.Windows.Forms.Label label1;
        private PlaybackChanger_Installer.Controls.FlatButton flatButtonUnbindActivationKey;
        private System.Windows.Forms.Label labelCheckUpdates;
        private bmControlLibrary.bmToggleSwitch bmToggleSwitchCheckUpdates;
    }
}