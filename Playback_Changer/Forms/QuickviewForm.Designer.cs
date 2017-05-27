namespace Playback_Changer.Forms
{
    partial class QuickviewForm
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
            this.borderPanelMain = new PlaybackChanger_Installer.Controls.BorderPanel();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.linkLabelRefresh = new System.Windows.Forms.LinkLabel();
            this.labelDevices = new System.Windows.Forms.Label();
            this.panelDevices = new System.Windows.Forms.Panel();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.exitPlaybackChangerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borderPanelMain.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // borderPanelMain
            // 
            this.borderPanelMain.BorderColor = System.Drawing.Color.Red;
            this.borderPanelMain.BottomBorder = false;
            this.borderPanelMain.BottomBorderWidth = 1;
            this.borderPanelMain.Controls.Add(this.buttonSettings);
            this.borderPanelMain.Controls.Add(this.linkLabelRefresh);
            this.borderPanelMain.Controls.Add(this.labelDevices);
            this.borderPanelMain.Controls.Add(this.panelDevices);
            this.borderPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.borderPanelMain.LeftBorder = false;
            this.borderPanelMain.LeftBorderWidth = 1;
            this.borderPanelMain.Location = new System.Drawing.Point(0, 0);
            this.borderPanelMain.Name = "borderPanelMain";
            this.borderPanelMain.RightBorder = false;
            this.borderPanelMain.RightBorderWidth = 1;
            this.borderPanelMain.Size = new System.Drawing.Size(360, 280);
            this.borderPanelMain.TabIndex = 0;
            this.borderPanelMain.TopBorder = false;
            this.borderPanelMain.TopBorderWidth = 1;
            // 
            // buttonSettings
            // 
            this.buttonSettings.BackgroundImage = global::Playback_Changer.Properties.Resources.settings_small;
            this.buttonSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonSettings.FlatAppearance.BorderSize = 0;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Location = new System.Drawing.Point(318, 1);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(32, 32);
            this.buttonSettings.TabIndex = 4;
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.ButtonSettings_Click);
            // 
            // linkLabelRefresh
            // 
            this.linkLabelRefresh.AutoSize = true;
            this.linkLabelRefresh.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelRefresh.LinkColor = System.Drawing.SystemColors.ControlText;
            this.linkLabelRefresh.Location = new System.Drawing.Point(71, 16);
            this.linkLabelRefresh.Name = "linkLabelRefresh";
            this.linkLabelRefresh.Size = new System.Drawing.Size(40, 13);
            this.linkLabelRefresh.TabIndex = 3;
            this.linkLabelRefresh.TabStop = true;
            this.linkLabelRefresh.Text = "Refresh";
            this.linkLabelRefresh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelRefresh_LinkClicked);
            // 
            // labelDevices
            // 
            this.labelDevices.AutoSize = true;
            this.labelDevices.Location = new System.Drawing.Point(6, 10);
            this.labelDevices.Margin = new System.Windows.Forms.Padding(10);
            this.labelDevices.Name = "labelDevices";
            this.labelDevices.Size = new System.Drawing.Size(63, 21);
            this.labelDevices.TabIndex = 1;
            this.labelDevices.Text = "Devices";
            // 
            // panelDevices
            // 
            this.panelDevices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDevices.AutoScroll = true;
            this.panelDevices.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.panelDevices.Location = new System.Drawing.Point(10, 33);
            this.panelDevices.Margin = new System.Windows.Forms.Padding(10);
            this.panelDevices.Name = "panelDevices";
            this.panelDevices.Size = new System.Drawing.Size(340, 240);
            this.panelDevices.TabIndex = 0;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.toolStripSeparator,
            this.exitPlaybackChangerToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(191, 54);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.SettingsToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(187, 6);
            // 
            // exitPlaybackChangerToolStripMenuItem
            // 
            this.exitPlaybackChangerToolStripMenuItem.Name = "exitPlaybackChangerToolStripMenuItem";
            this.exitPlaybackChangerToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.exitPlaybackChangerToolStripMenuItem.Text = "Exit Playback Changer";
            this.exitPlaybackChangerToolStripMenuItem.Click += new System.EventHandler(this.ExitPlaybackChangerToolStripMenuItem_Click);
            // 
            // QuickviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 280);
            this.ControlBox = false;
            this.Controls.Add(this.borderPanelMain);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(360, 280);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(360, 280);
            this.Name = "QuickviewForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Playback Changer";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.View_Activated);
            this.Deactivate += new System.EventHandler(this.View_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.View_FormClosing);
            this.Move += new System.EventHandler(this.View_Move);
            this.borderPanelMain.ResumeLayout(false);
            this.borderPanelMain.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private PlaybackChanger_Installer.Controls.BorderPanel borderPanelMain;
        private System.Windows.Forms.Label labelDevices;
        private System.Windows.Forms.Panel panelDevices;
        private System.Windows.Forms.LinkLabel linkLabelRefresh;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitPlaybackChangerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
    }
}