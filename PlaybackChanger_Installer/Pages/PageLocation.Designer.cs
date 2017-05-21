namespace PlaybackChanger_Installer.Pages
{
    partial class PageLocation
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
            this.borderPanelLocation = new PlaybackChanger_Installer.Controls.BorderPanel();
            this.panelIncorrectPath = new System.Windows.Forms.Panel();
            this.labelIncorrectPath = new System.Windows.Forms.Label();
            this.pictureBoxIncorrectPath = new System.Windows.Forms.PictureBox();
            this.flatButtonLocationCancel = new PlaybackChanger_Installer.Controls.FlatButton();
            this.flatButtonLocationNext = new PlaybackChanger_Installer.Controls.FlatButton();
            this.flatButtonBrowse = new PlaybackChanger_Installer.Controls.FlatButton();
            this.textBoxInstallLocation = new System.Windows.Forms.TextBox();
            this.labelInstallLocation = new System.Windows.Forms.Label();
            this.borderPanelLocation.SuspendLayout();
            this.panelIncorrectPath.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIncorrectPath)).BeginInit();
            this.SuspendLayout();
            // 
            // borderPanelLocation
            // 
            this.borderPanelLocation.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.borderPanelLocation.BottomBorder = false;
            this.borderPanelLocation.BottomBorderWidth = 1;
            this.borderPanelLocation.Controls.Add(this.panelIncorrectPath);
            this.borderPanelLocation.Controls.Add(this.flatButtonLocationCancel);
            this.borderPanelLocation.Controls.Add(this.flatButtonLocationNext);
            this.borderPanelLocation.Controls.Add(this.flatButtonBrowse);
            this.borderPanelLocation.Controls.Add(this.textBoxInstallLocation);
            this.borderPanelLocation.Controls.Add(this.labelInstallLocation);
            this.borderPanelLocation.Cursor = System.Windows.Forms.Cursors.Default;
            this.borderPanelLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.borderPanelLocation.LeftBorder = true;
            this.borderPanelLocation.LeftBorderWidth = 1;
            this.borderPanelLocation.Location = new System.Drawing.Point(0, 0);
            this.borderPanelLocation.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.borderPanelLocation.Name = "borderPanelLocation";
            this.borderPanelLocation.RightBorder = false;
            this.borderPanelLocation.RightBorderWidth = 1;
            this.borderPanelLocation.Size = new System.Drawing.Size(500, 300);
            this.borderPanelLocation.TabIndex = 7;
            this.borderPanelLocation.TopBorder = false;
            this.borderPanelLocation.TopBorderWidth = 1;
            // 
            // panelIncorrectPath
            // 
            this.panelIncorrectPath.Controls.Add(this.labelIncorrectPath);
            this.panelIncorrectPath.Controls.Add(this.pictureBoxIncorrectPath);
            this.panelIncorrectPath.Location = new System.Drawing.Point(22, 72);
            this.panelIncorrectPath.Name = "panelIncorrectPath";
            this.panelIncorrectPath.Size = new System.Drawing.Size(256, 20);
            this.panelIncorrectPath.TabIndex = 8;
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
            this.pictureBoxIncorrectPath.Size = new System.Drawing.Size(16, 20);
            this.pictureBoxIncorrectPath.TabIndex = 0;
            this.pictureBoxIncorrectPath.TabStop = false;
            // 
            // flatButtonLocationCancel
            // 
            this.flatButtonLocationCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.flatButtonLocationCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.flatButtonLocationCancel.FlatAppearance.BorderSize = 0;
            this.flatButtonLocationCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.flatButtonLocationCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(222)))), ((int)(((byte)(245)))));
            this.flatButtonLocationCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flatButtonLocationCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.flatButtonLocationCancel.Location = new System.Drawing.Point(307, 256);
            this.flatButtonLocationCancel.Margin = new System.Windows.Forms.Padding(6, 6, 3, 18);
            this.flatButtonLocationCancel.Name = "flatButtonLocationCancel";
            this.flatButtonLocationCancel.Size = new System.Drawing.Size(83, 26);
            this.flatButtonLocationCancel.TabIndex = 3;
            this.flatButtonLocationCancel.Text = "Cancel";
            this.flatButtonLocationCancel.UseVisualStyleBackColor = false;
            this.flatButtonLocationCancel.Click += new System.EventHandler(this.FlatButtonLocationCancel_Click);
            // 
            // flatButtonLocationNext
            // 
            this.flatButtonLocationNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.flatButtonLocationNext.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.flatButtonLocationNext.FlatAppearance.BorderSize = 0;
            this.flatButtonLocationNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.flatButtonLocationNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(222)))), ((int)(((byte)(245)))));
            this.flatButtonLocationNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flatButtonLocationNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.flatButtonLocationNext.Location = new System.Drawing.Point(399, 256);
            this.flatButtonLocationNext.Margin = new System.Windows.Forms.Padding(6, 6, 18, 18);
            this.flatButtonLocationNext.Name = "flatButtonLocationNext";
            this.flatButtonLocationNext.Size = new System.Drawing.Size(83, 26);
            this.flatButtonLocationNext.TabIndex = 2;
            this.flatButtonLocationNext.Text = "Next";
            this.flatButtonLocationNext.UseVisualStyleBackColor = false;
            this.flatButtonLocationNext.Click += new System.EventHandler(this.FlatButtonLocationNext_Click);
            // 
            // flatButtonBrowse
            // 
            this.flatButtonBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.flatButtonBrowse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.flatButtonBrowse.FlatAppearance.BorderSize = 0;
            this.flatButtonBrowse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.flatButtonBrowse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(222)))), ((int)(((byte)(245)))));
            this.flatButtonBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flatButtonBrowse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.flatButtonBrowse.Location = new System.Drawing.Point(399, 72);
            this.flatButtonBrowse.Margin = new System.Windows.Forms.Padding(6, 6, 18, 6);
            this.flatButtonBrowse.Name = "flatButtonBrowse";
            this.flatButtonBrowse.Size = new System.Drawing.Size(83, 26);
            this.flatButtonBrowse.TabIndex = 1;
            this.flatButtonBrowse.Text = "Browse...";
            this.flatButtonBrowse.UseVisualStyleBackColor = false;
            this.flatButtonBrowse.Click += new System.EventHandler(this.FlatButtonBrowse_Click);
            // 
            // textBoxInstallLocation
            // 
            this.textBoxInstallLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxInstallLocation.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInstallLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.textBoxInstallLocation.Location = new System.Drawing.Point(22, 41);
            this.textBoxInstallLocation.Margin = new System.Windows.Forms.Padding(18, 3, 3, 3);
            this.textBoxInstallLocation.Name = "textBoxInstallLocation";
            this.textBoxInstallLocation.Size = new System.Drawing.Size(460, 22);
            this.textBoxInstallLocation.TabIndex = 0;
            this.textBoxInstallLocation.TextChanged += new System.EventHandler(this.TextBoxInstallLocation_TextChanged);
            this.textBoxInstallLocation.Leave += new System.EventHandler(this.TextBoxInstallLocation_Leave);
            // 
            // labelInstallLocation
            // 
            this.labelInstallLocation.AutoSize = true;
            this.labelInstallLocation.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInstallLocation.Location = new System.Drawing.Point(18, 18);
            this.labelInstallLocation.Margin = new System.Windows.Forms.Padding(18, 18, 4, 0);
            this.labelInstallLocation.Name = "labelInstallLocation";
            this.labelInstallLocation.Size = new System.Drawing.Size(101, 20);
            this.labelInstallLocation.TabIndex = 1;
            this.labelInstallLocation.Text = "Install location";
            // 
            // PageLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.borderPanelLocation);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PageLocation";
            this.Size = new System.Drawing.Size(500, 300);
            this.borderPanelLocation.ResumeLayout(false);
            this.borderPanelLocation.PerformLayout();
            this.panelIncorrectPath.ResumeLayout(false);
            this.panelIncorrectPath.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIncorrectPath)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.BorderPanel borderPanelLocation;
        private System.Windows.Forms.Label labelInstallLocation;
        private Controls.FlatButton flatButtonBrowse;
        private System.Windows.Forms.TextBox textBoxInstallLocation;
        private Controls.FlatButton flatButtonLocationNext;
        private Controls.FlatButton flatButtonLocationCancel;
        private System.Windows.Forms.Panel panelIncorrectPath;
        private System.Windows.Forms.PictureBox pictureBoxIncorrectPath;
        private System.Windows.Forms.Label labelIncorrectPath;
    }
}
