namespace PlaybackChanger_Uninstaller
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.flowLayoutPanelNav = new System.Windows.Forms.FlowLayoutPanel();
            this.borderPanelInstallationSteps = new PlaybackChanger_Installer.Controls.BorderPanel();
            this.labelInstallationSteps = new System.Windows.Forms.Label();
            this.borderPanelStepOne = new PlaybackChanger_Installer.Controls.BorderPanel();
            this.labelStepOne = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.flowLayoutPanelNav.SuspendLayout();
            this.borderPanelInstallationSteps.SuspendLayout();
            this.borderPanelStepOne.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelNav
            // 
            this.flowLayoutPanelNav.AutoSize = true;
            this.flowLayoutPanelNav.Controls.Add(this.borderPanelInstallationSteps);
            this.flowLayoutPanelNav.Controls.Add(this.borderPanelStepOne);
            this.flowLayoutPanelNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanelNav.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelNav.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelNav.Name = "flowLayoutPanelNav";
            this.flowLayoutPanelNav.Size = new System.Drawing.Size(200, 300);
            this.flowLayoutPanelNav.TabIndex = 5;
            // 
            // borderPanelInstallationSteps
            // 
            this.borderPanelInstallationSteps.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.borderPanelInstallationSteps.BottomBorder = true;
            this.borderPanelInstallationSteps.BottomBorderWidth = 1;
            this.borderPanelInstallationSteps.Controls.Add(this.labelInstallationSteps);
            this.borderPanelInstallationSteps.LeftBorder = false;
            this.borderPanelInstallationSteps.LeftBorderWidth = 1;
            this.borderPanelInstallationSteps.Location = new System.Drawing.Point(0, 0);
            this.borderPanelInstallationSteps.Margin = new System.Windows.Forms.Padding(0);
            this.borderPanelInstallationSteps.Name = "borderPanelInstallationSteps";
            this.borderPanelInstallationSteps.RightBorder = false;
            this.borderPanelInstallationSteps.RightBorderWidth = 1;
            this.borderPanelInstallationSteps.Size = new System.Drawing.Size(200, 21);
            this.borderPanelInstallationSteps.TabIndex = 4;
            this.borderPanelInstallationSteps.TopBorder = false;
            this.borderPanelInstallationSteps.TopBorderWidth = 1;
            // 
            // labelInstallationSteps
            // 
            this.labelInstallationSteps.AutoSize = true;
            this.labelInstallationSteps.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInstallationSteps.Location = new System.Drawing.Point(9, 0);
            this.labelInstallationSteps.Name = "labelInstallationSteps";
            this.labelInstallationSteps.Size = new System.Drawing.Size(95, 20);
            this.labelInstallationSteps.TabIndex = 2;
            this.labelInstallationSteps.Text = "Uninstallation";
            // 
            // borderPanelStepOne
            // 
            this.borderPanelStepOne.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.borderPanelStepOne.BottomBorder = true;
            this.borderPanelStepOne.BottomBorderWidth = 1;
            this.borderPanelStepOne.Controls.Add(this.labelStepOne);
            this.borderPanelStepOne.Cursor = System.Windows.Forms.Cursors.Hand;
            this.borderPanelStepOne.LeftBorder = true;
            this.borderPanelStepOne.LeftBorderWidth = 6;
            this.borderPanelStepOne.Location = new System.Drawing.Point(0, 21);
            this.borderPanelStepOne.Margin = new System.Windows.Forms.Padding(0);
            this.borderPanelStepOne.Name = "borderPanelStepOne";
            this.borderPanelStepOne.RightBorder = false;
            this.borderPanelStepOne.RightBorderWidth = 1;
            this.borderPanelStepOne.Size = new System.Drawing.Size(200, 34);
            this.borderPanelStepOne.TabIndex = 5;
            this.borderPanelStepOne.TopBorder = false;
            this.borderPanelStepOne.TopBorderWidth = 1;
            // 
            // labelStepOne
            // 
            this.labelStepOne.AutoSize = true;
            this.labelStepOne.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelStepOne.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStepOne.Location = new System.Drawing.Point(9, 5);
            this.labelStepOne.Name = "labelStepOne";
            this.labelStepOne.Size = new System.Drawing.Size(90, 22);
            this.labelStepOne.TabIndex = 4;
            this.labelStepOne.Text = "Uninstall";
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMain.Location = new System.Drawing.Point(200, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(500, 300);
            this.panelMain.TabIndex = 6;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 300);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.flowLayoutPanelNav);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(716, 339);
            this.MinimumSize = new System.Drawing.Size(716, 339);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.flowLayoutPanelNav.ResumeLayout(false);
            this.borderPanelInstallationSteps.ResumeLayout(false);
            this.borderPanelInstallationSteps.PerformLayout();
            this.borderPanelStepOne.ResumeLayout(false);
            this.borderPanelStepOne.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelNav;
        private PlaybackChanger_Installer.Controls.BorderPanel borderPanelInstallationSteps;
        private System.Windows.Forms.Label labelInstallationSteps;
        private PlaybackChanger_Installer.Controls.BorderPanel borderPanelStepOne;
        private System.Windows.Forms.Label labelStepOne;
        private System.Windows.Forms.Panel panelMain;
    }
}

