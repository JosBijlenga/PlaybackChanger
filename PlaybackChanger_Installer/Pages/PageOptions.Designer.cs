namespace PlaybackChanger_Installer.Pages
{
    partial class PageOptions
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
            this.borderPanelOptions = new PlaybackChanger_Installer.Controls.BorderPanel();
            this.flatButtonOptionsCancel = new PlaybackChanger_Installer.Controls.FlatButton();
            this.flatButtonOptionsNext = new PlaybackChanger_Installer.Controls.FlatButton();
            this.checkBoxSystemStart = new System.Windows.Forms.CheckBox();
            this.labelSystemStart = new System.Windows.Forms.Label();
            this.checkBoxStartmenu = new System.Windows.Forms.CheckBox();
            this.checkBoxDesktop = new System.Windows.Forms.CheckBox();
            this.labelInstallLocation = new System.Windows.Forms.Label();
            this.borderPanelOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // borderPanelOptions
            // 
            this.borderPanelOptions.BackColor = System.Drawing.Color.White;
            this.borderPanelOptions.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.borderPanelOptions.BottomBorder = false;
            this.borderPanelOptions.BottomBorderWidth = 1;
            this.borderPanelOptions.Controls.Add(this.flatButtonOptionsCancel);
            this.borderPanelOptions.Controls.Add(this.flatButtonOptionsNext);
            this.borderPanelOptions.Controls.Add(this.checkBoxSystemStart);
            this.borderPanelOptions.Controls.Add(this.labelSystemStart);
            this.borderPanelOptions.Controls.Add(this.checkBoxStartmenu);
            this.borderPanelOptions.Controls.Add(this.checkBoxDesktop);
            this.borderPanelOptions.Controls.Add(this.labelInstallLocation);
            this.borderPanelOptions.Cursor = System.Windows.Forms.Cursors.Default;
            this.borderPanelOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.borderPanelOptions.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borderPanelOptions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.borderPanelOptions.LeftBorder = true;
            this.borderPanelOptions.LeftBorderWidth = 1;
            this.borderPanelOptions.Location = new System.Drawing.Point(0, 0);
            this.borderPanelOptions.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.borderPanelOptions.Name = "borderPanelOptions";
            this.borderPanelOptions.RightBorder = false;
            this.borderPanelOptions.RightBorderWidth = 1;
            this.borderPanelOptions.Size = new System.Drawing.Size(500, 300);
            this.borderPanelOptions.TabIndex = 8;
            this.borderPanelOptions.TopBorder = false;
            this.borderPanelOptions.TopBorderWidth = 1;
            // 
            // flatButtonOptionsCancel
            // 
            this.flatButtonOptionsCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.flatButtonOptionsCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.flatButtonOptionsCancel.FlatAppearance.BorderSize = 0;
            this.flatButtonOptionsCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.flatButtonOptionsCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(222)))), ((int)(((byte)(245)))));
            this.flatButtonOptionsCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flatButtonOptionsCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.flatButtonOptionsCancel.Location = new System.Drawing.Point(307, 256);
            this.flatButtonOptionsCancel.Margin = new System.Windows.Forms.Padding(6, 6, 3, 18);
            this.flatButtonOptionsCancel.Name = "flatButtonOptionsCancel";
            this.flatButtonOptionsCancel.Size = new System.Drawing.Size(83, 26);
            this.flatButtonOptionsCancel.TabIndex = 4;
            this.flatButtonOptionsCancel.Text = "Cancel";
            this.flatButtonOptionsCancel.UseVisualStyleBackColor = false;
            this.flatButtonOptionsCancel.Click += new System.EventHandler(this.FlatButtonOptionsCancel_Click);
            // 
            // flatButtonOptionsNext
            // 
            this.flatButtonOptionsNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.flatButtonOptionsNext.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.flatButtonOptionsNext.FlatAppearance.BorderSize = 0;
            this.flatButtonOptionsNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.flatButtonOptionsNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(222)))), ((int)(((byte)(245)))));
            this.flatButtonOptionsNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flatButtonOptionsNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.flatButtonOptionsNext.Location = new System.Drawing.Point(399, 256);
            this.flatButtonOptionsNext.Margin = new System.Windows.Forms.Padding(6, 6, 18, 18);
            this.flatButtonOptionsNext.Name = "flatButtonOptionsNext";
            this.flatButtonOptionsNext.Size = new System.Drawing.Size(83, 26);
            this.flatButtonOptionsNext.TabIndex = 3;
            this.flatButtonOptionsNext.Text = "Next";
            this.flatButtonOptionsNext.UseVisualStyleBackColor = false;
            this.flatButtonOptionsNext.Click += new System.EventHandler(this.FlatButtonOptionsNext_Click);
            // 
            // checkBoxSystemStart
            // 
            this.checkBoxSystemStart.AutoSize = true;
            this.checkBoxSystemStart.Checked = true;
            this.checkBoxSystemStart.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSystemStart.Location = new System.Drawing.Point(27, 135);
            this.checkBoxSystemStart.Name = "checkBoxSystemStart";
            this.checkBoxSystemStart.Size = new System.Drawing.Size(199, 22);
            this.checkBoxSystemStart.TabIndex = 2;
            this.checkBoxSystemStart.Text = "Start app on system start";
            this.checkBoxSystemStart.UseVisualStyleBackColor = true;
            this.checkBoxSystemStart.CheckedChanged += new System.EventHandler(this.CheckBoxSystemStart_CheckedChanged);
            // 
            // labelSystemStart
            // 
            this.labelSystemStart.AutoSize = true;
            this.labelSystemStart.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSystemStart.Location = new System.Drawing.Point(18, 112);
            this.labelSystemStart.Margin = new System.Windows.Forms.Padding(18, 18, 4, 0);
            this.labelSystemStart.Name = "labelSystemStart";
            this.labelSystemStart.Size = new System.Drawing.Size(86, 20);
            this.labelSystemStart.TabIndex = 11;
            this.labelSystemStart.Text = "System start";
            // 
            // checkBoxStartmenu
            // 
            this.checkBoxStartmenu.AutoSize = true;
            this.checkBoxStartmenu.Location = new System.Drawing.Point(27, 69);
            this.checkBoxStartmenu.Name = "checkBoxStartmenu";
            this.checkBoxStartmenu.Size = new System.Drawing.Size(98, 22);
            this.checkBoxStartmenu.TabIndex = 1;
            this.checkBoxStartmenu.Text = "Startmenu";
            this.checkBoxStartmenu.UseVisualStyleBackColor = true;
            this.checkBoxStartmenu.CheckedChanged += new System.EventHandler(this.CheckBoxStartmenu_CheckedChanged);
            // 
            // checkBoxDesktop
            // 
            this.checkBoxDesktop.AutoSize = true;
            this.checkBoxDesktop.Location = new System.Drawing.Point(27, 41);
            this.checkBoxDesktop.Name = "checkBoxDesktop";
            this.checkBoxDesktop.Size = new System.Drawing.Size(86, 22);
            this.checkBoxDesktop.TabIndex = 0;
            this.checkBoxDesktop.Text = "Desktop";
            this.checkBoxDesktop.UseVisualStyleBackColor = true;
            this.checkBoxDesktop.CheckedChanged += new System.EventHandler(this.CheckBoxDesktop_CheckedChanged);
            // 
            // labelInstallLocation
            // 
            this.labelInstallLocation.AutoSize = true;
            this.labelInstallLocation.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInstallLocation.Location = new System.Drawing.Point(18, 18);
            this.labelInstallLocation.Margin = new System.Windows.Forms.Padding(18, 18, 4, 0);
            this.labelInstallLocation.Name = "labelInstallLocation";
            this.labelInstallLocation.Size = new System.Drawing.Size(69, 20);
            this.labelInstallLocation.TabIndex = 3;
            this.labelInstallLocation.Text = "Shortcuts";
            // 
            // PageOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.borderPanelOptions);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PageOptions";
            this.Size = new System.Drawing.Size(500, 300);
            this.borderPanelOptions.ResumeLayout(false);
            this.borderPanelOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.BorderPanel borderPanelOptions;
        private System.Windows.Forms.Label labelInstallLocation;
        private System.Windows.Forms.CheckBox checkBoxDesktop;
        private System.Windows.Forms.CheckBox checkBoxStartmenu;
        private System.Windows.Forms.CheckBox checkBoxSystemStart;
        private System.Windows.Forms.Label labelSystemStart;
        private Controls.FlatButton flatButtonOptionsNext;
        private Controls.FlatButton flatButtonOptionsCancel;
    }
}
