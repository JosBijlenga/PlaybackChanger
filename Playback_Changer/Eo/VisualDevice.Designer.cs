namespace Playback_Changer.Eo
{
    partial class VisualDevice
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
            this.borderPanelMain = new PlaybackChanger_Installer.Controls.BorderPanel();
            this.labelHotkey = new System.Windows.Forms.Label();
            this.buttonPopover = new System.Windows.Forms.Button();
            this.labelDeviceName = new System.Windows.Forms.Label();
            this.bmToggleSwitchDefault = new bmControlLibrary.bmToggleSwitch();
            this.contextMenuStripDevice = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hotkeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.f1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.f2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.f3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ignoredToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borderPanelMain.SuspendLayout();
            this.contextMenuStripDevice.SuspendLayout();
            this.SuspendLayout();
            // 
            // borderPanelMain
            // 
            this.borderPanelMain.BorderColor = System.Drawing.Color.Green;
            this.borderPanelMain.BottomBorder = false;
            this.borderPanelMain.BottomBorderWidth = 1;
            this.borderPanelMain.Controls.Add(this.labelHotkey);
            this.borderPanelMain.Controls.Add(this.buttonPopover);
            this.borderPanelMain.Controls.Add(this.labelDeviceName);
            this.borderPanelMain.Controls.Add(this.bmToggleSwitchDefault);
            this.borderPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.borderPanelMain.LeftBorder = true;
            this.borderPanelMain.LeftBorderWidth = 6;
            this.borderPanelMain.Location = new System.Drawing.Point(0, 0);
            this.borderPanelMain.Name = "borderPanelMain";
            this.borderPanelMain.RightBorder = false;
            this.borderPanelMain.RightBorderWidth = 1;
            this.borderPanelMain.Size = new System.Drawing.Size(345, 50);
            this.borderPanelMain.TabIndex = 0;
            this.borderPanelMain.TopBorder = false;
            this.borderPanelMain.TopBorderWidth = 1;
            // 
            // labelHotkey
            // 
            this.labelHotkey.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHotkey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.labelHotkey.Location = new System.Drawing.Point(66, 5);
            this.labelHotkey.Margin = new System.Windows.Forms.Padding(3, 0, 12, 0);
            this.labelHotkey.Name = "labelHotkey";
            this.labelHotkey.Size = new System.Drawing.Size(32, 40);
            this.labelHotkey.TabIndex = 6;
            this.labelHotkey.Text = "F1";
            this.labelHotkey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonPopover
            // 
            this.buttonPopover.BackgroundImage = global::Playback_Changer.Properties.Resources.popover;
            this.buttonPopover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonPopover.FlatAppearance.BorderSize = 0;
            this.buttonPopover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPopover.Location = new System.Drawing.Point(300, 0);
            this.buttonPopover.Margin = new System.Windows.Forms.Padding(3, 0, 12, 0);
            this.buttonPopover.Name = "buttonPopover";
            this.buttonPopover.Size = new System.Drawing.Size(26, 50);
            this.buttonPopover.TabIndex = 5;
            this.buttonPopover.TabStop = false;
            this.buttonPopover.UseVisualStyleBackColor = false;
            this.buttonPopover.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonPopover_MouseDown);
            // 
            // labelDeviceName
            // 
            this.labelDeviceName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeviceName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.labelDeviceName.Location = new System.Drawing.Point(103, 5);
            this.labelDeviceName.Margin = new System.Windows.Forms.Padding(3, 0, 12, 0);
            this.labelDeviceName.Name = "labelDeviceName";
            this.labelDeviceName.Size = new System.Drawing.Size(182, 40);
            this.labelDeviceName.TabIndex = 4;
            this.labelDeviceName.Text = "{DeviceName}";
            // 
            // bmToggleSwitchDefault
            // 
            this.bmToggleSwitchDefault.AnimationStep = 5;
            this.bmToggleSwitchDefault.ButtonColor = System.Drawing.Color.Empty;
            this.bmToggleSwitchDefault.GrayWhenDisabled = false;
            this.bmToggleSwitchDefault.Location = new System.Drawing.Point(12, 12);
            this.bmToggleSwitchDefault.Margin = new System.Windows.Forms.Padding(12);
            this.bmToggleSwitchDefault.Name = "bmToggleSwitchDefault";
            this.bmToggleSwitchDefault.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmToggleSwitchDefault.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmToggleSwitchDefault.Size = new System.Drawing.Size(47, 26);
            this.bmToggleSwitchDefault.TabIndex = 0;
            this.bmToggleSwitchDefault.TabStop = false;
            this.bmToggleSwitchDefault.CheckedChanged += new bmControlLibrary.bmToggleSwitch.CheckedChangedDelegate(this.BmToggleSwitchDefault_CheckedChanged);
            // 
            // contextMenuStripDevice
            // 
            this.contextMenuStripDevice.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hotkeyToolStripMenuItem,
            this.ignoredToolStripMenuItem});
            this.contextMenuStripDevice.Name = "contextMenuStripDevice";
            this.contextMenuStripDevice.Size = new System.Drawing.Size(116, 48);
            // 
            // hotkeyToolStripMenuItem
            // 
            this.hotkeyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.f1ToolStripMenuItem,
            this.f2ToolStripMenuItem,
            this.f3ToolStripMenuItem,
            this.noneToolStripMenuItem});
            this.hotkeyToolStripMenuItem.Name = "hotkeyToolStripMenuItem";
            this.hotkeyToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.hotkeyToolStripMenuItem.Text = "Hotkey";
            // 
            // f1ToolStripMenuItem
            // 
            this.f1ToolStripMenuItem.Name = "f1ToolStripMenuItem";
            this.f1ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.f1ToolStripMenuItem.Text = "F1";
            this.f1ToolStripMenuItem.Click += new System.EventHandler(this.F1ToolStripMenuItem_Click);
            // 
            // f2ToolStripMenuItem
            // 
            this.f2ToolStripMenuItem.Name = "f2ToolStripMenuItem";
            this.f2ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.f2ToolStripMenuItem.Text = "F2";
            this.f2ToolStripMenuItem.Click += new System.EventHandler(this.F2ToolStripMenuItem_Click);
            // 
            // f3ToolStripMenuItem
            // 
            this.f3ToolStripMenuItem.Name = "f3ToolStripMenuItem";
            this.f3ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.f3ToolStripMenuItem.Text = "F3";
            this.f3ToolStripMenuItem.Click += new System.EventHandler(this.F3ToolStripMenuItem_Click);
            // 
            // noneToolStripMenuItem
            // 
            this.noneToolStripMenuItem.Name = "noneToolStripMenuItem";
            this.noneToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.noneToolStripMenuItem.Text = "None";
            this.noneToolStripMenuItem.Click += new System.EventHandler(this.NoneToolStripMenuItem_Click);
            // 
            // ignoredToolStripMenuItem
            // 
            this.ignoredToolStripMenuItem.Name = "ignoredToolStripMenuItem";
            this.ignoredToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.ignoredToolStripMenuItem.Text = "Ignored";
            this.ignoredToolStripMenuItem.Click += new System.EventHandler(this.IgnoredToolStripMenuItem_Click);
            // 
            // VisualDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.borderPanelMain);
            this.Name = "VisualDevice";
            this.Size = new System.Drawing.Size(345, 50);
            this.borderPanelMain.ResumeLayout(false);
            this.contextMenuStripDevice.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private PlaybackChanger_Installer.Controls.BorderPanel borderPanelMain;
        private bmControlLibrary.bmToggleSwitch bmToggleSwitchDefault;
        private System.Windows.Forms.Button buttonPopover;
        private System.Windows.Forms.Label labelDeviceName;
        private System.Windows.Forms.Label labelHotkey;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripDevice;
        private System.Windows.Forms.ToolStripMenuItem hotkeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem f1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem f2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem f3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ignoredToolStripMenuItem;
    }
}
