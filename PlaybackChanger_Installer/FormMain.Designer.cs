namespace PlaybackChanger_Installer
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
            this.borderPanelStepTwo = new PlaybackChanger_Installer.Controls.BorderPanel();
            this.labelStepTwo = new System.Windows.Forms.Label();
            this.borderPanelStepThree = new PlaybackChanger_Installer.Controls.BorderPanel();
            this.labelStepThree = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.borderPanelStepFour = new PlaybackChanger_Installer.Controls.BorderPanel();
            this.labelStepFour = new System.Windows.Forms.Label();
            this.flowLayoutPanelNav.SuspendLayout();
            this.borderPanelInstallationSteps.SuspendLayout();
            this.borderPanelStepOne.SuspendLayout();
            this.borderPanelStepTwo.SuspendLayout();
            this.borderPanelStepThree.SuspendLayout();
            this.borderPanelStepFour.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelNav
            // 
            this.flowLayoutPanelNav.AutoSize = true;
            this.flowLayoutPanelNav.Controls.Add(this.borderPanelInstallationSteps);
            this.flowLayoutPanelNav.Controls.Add(this.borderPanelStepOne);
            this.flowLayoutPanelNav.Controls.Add(this.borderPanelStepTwo);
            this.flowLayoutPanelNav.Controls.Add(this.borderPanelStepThree);
            this.flowLayoutPanelNav.Controls.Add(this.borderPanelStepFour);
            this.flowLayoutPanelNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanelNav.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelNav.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelNav.Name = "flowLayoutPanelNav";
            this.flowLayoutPanelNav.Size = new System.Drawing.Size(200, 300);
            this.flowLayoutPanelNav.TabIndex = 3;
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
            this.labelInstallationSteps.Size = new System.Drawing.Size(115, 20);
            this.labelInstallationSteps.TabIndex = 2;
            this.labelInstallationSteps.Text = "Installation steps";
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
            this.borderPanelStepOne.Click += new System.EventHandler(this.StepOne_Click);
            // 
            // labelStepOne
            // 
            this.labelStepOne.AutoSize = true;
            this.labelStepOne.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelStepOne.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStepOne.Location = new System.Drawing.Point(9, 5);
            this.labelStepOne.Name = "labelStepOne";
            this.labelStepOne.Size = new System.Drawing.Size(91, 22);
            this.labelStepOne.TabIndex = 4;
            this.labelStepOne.Text = "Location";
            this.labelStepOne.Click += new System.EventHandler(this.StepOne_Click);
            // 
            // borderPanelStepTwo
            // 
            this.borderPanelStepTwo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.borderPanelStepTwo.BottomBorder = true;
            this.borderPanelStepTwo.BottomBorderWidth = 1;
            this.borderPanelStepTwo.Controls.Add(this.labelStepTwo);
            this.borderPanelStepTwo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.borderPanelStepTwo.LeftBorder = true;
            this.borderPanelStepTwo.LeftBorderWidth = 3;
            this.borderPanelStepTwo.Location = new System.Drawing.Point(0, 55);
            this.borderPanelStepTwo.Margin = new System.Windows.Forms.Padding(0);
            this.borderPanelStepTwo.Name = "borderPanelStepTwo";
            this.borderPanelStepTwo.RightBorder = false;
            this.borderPanelStepTwo.RightBorderWidth = 1;
            this.borderPanelStepTwo.Size = new System.Drawing.Size(200, 34);
            this.borderPanelStepTwo.TabIndex = 6;
            this.borderPanelStepTwo.TopBorder = false;
            this.borderPanelStepTwo.TopBorderWidth = 1;
            this.borderPanelStepTwo.Click += new System.EventHandler(this.StepTwo_Click);
            // 
            // labelStepTwo
            // 
            this.labelStepTwo.AutoSize = true;
            this.labelStepTwo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelStepTwo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStepTwo.Location = new System.Drawing.Point(9, 5);
            this.labelStepTwo.Name = "labelStepTwo";
            this.labelStepTwo.Size = new System.Drawing.Size(83, 22);
            this.labelStepTwo.TabIndex = 4;
            this.labelStepTwo.Text = "Options";
            this.labelStepTwo.Click += new System.EventHandler(this.StepTwo_Click);
            // 
            // borderPanelStepThree
            // 
            this.borderPanelStepThree.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.borderPanelStepThree.BottomBorder = true;
            this.borderPanelStepThree.BottomBorderWidth = 1;
            this.borderPanelStepThree.Controls.Add(this.labelStepThree);
            this.borderPanelStepThree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.borderPanelStepThree.LeftBorder = true;
            this.borderPanelStepThree.LeftBorderWidth = 3;
            this.borderPanelStepThree.Location = new System.Drawing.Point(0, 89);
            this.borderPanelStepThree.Margin = new System.Windows.Forms.Padding(0);
            this.borderPanelStepThree.Name = "borderPanelStepThree";
            this.borderPanelStepThree.RightBorder = false;
            this.borderPanelStepThree.RightBorderWidth = 1;
            this.borderPanelStepThree.Size = new System.Drawing.Size(200, 34);
            this.borderPanelStepThree.TabIndex = 7;
            this.borderPanelStepThree.TopBorder = false;
            this.borderPanelStepThree.TopBorderWidth = 1;
            this.borderPanelStepThree.Click += new System.EventHandler(this.StepThree_Click);
            // 
            // labelStepThree
            // 
            this.labelStepThree.AutoSize = true;
            this.labelStepThree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelStepThree.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStepThree.Location = new System.Drawing.Point(9, 5);
            this.labelStepThree.Name = "labelStepThree";
            this.labelStepThree.Size = new System.Drawing.Size(65, 22);
            this.labelStepThree.TabIndex = 4;
            this.labelStepThree.Text = "Install";
            this.labelStepThree.Click += new System.EventHandler(this.StepThree_Click);
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(200, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(500, 300);
            this.panelMain.TabIndex = 4;
            // 
            // borderPanelStepFour
            // 
            this.borderPanelStepFour.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.borderPanelStepFour.BottomBorder = true;
            this.borderPanelStepFour.BottomBorderWidth = 1;
            this.borderPanelStepFour.Controls.Add(this.labelStepFour);
            this.borderPanelStepFour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.borderPanelStepFour.LeftBorder = true;
            this.borderPanelStepFour.LeftBorderWidth = 3;
            this.borderPanelStepFour.Location = new System.Drawing.Point(0, 123);
            this.borderPanelStepFour.Margin = new System.Windows.Forms.Padding(0);
            this.borderPanelStepFour.Name = "borderPanelStepFour";
            this.borderPanelStepFour.RightBorder = false;
            this.borderPanelStepFour.RightBorderWidth = 1;
            this.borderPanelStepFour.Size = new System.Drawing.Size(200, 34);
            this.borderPanelStepFour.TabIndex = 8;
            this.borderPanelStepFour.TopBorder = false;
            this.borderPanelStepFour.TopBorderWidth = 1;
            this.borderPanelStepFour.Visible = false;
            // 
            // labelStepFour
            // 
            this.labelStepFour.AutoSize = true;
            this.labelStepFour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelStepFour.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStepFour.Location = new System.Drawing.Point(9, 5);
            this.labelStepFour.Name = "labelStepFour";
            this.labelStepFour.Size = new System.Drawing.Size(90, 22);
            this.labelStepFour.TabIndex = 4;
            this.labelStepFour.Text = "Uninstall";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 300);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.flowLayoutPanelNav);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(716, 339);
            this.MinimumSize = new System.Drawing.Size(716, 339);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Playback Changer installer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.flowLayoutPanelNav.ResumeLayout(false);
            this.borderPanelInstallationSteps.ResumeLayout(false);
            this.borderPanelInstallationSteps.PerformLayout();
            this.borderPanelStepOne.ResumeLayout(false);
            this.borderPanelStepOne.PerformLayout();
            this.borderPanelStepTwo.ResumeLayout(false);
            this.borderPanelStepTwo.PerformLayout();
            this.borderPanelStepThree.ResumeLayout(false);
            this.borderPanelStepThree.PerformLayout();
            this.borderPanelStepFour.ResumeLayout(false);
            this.borderPanelStepFour.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelNav;
        private System.Windows.Forms.Panel panelMain;
        private Controls.BorderPanel borderPanelInstallationSteps;
        private System.Windows.Forms.Label labelInstallationSteps;
        private Controls.BorderPanel borderPanelStepOne;
        private System.Windows.Forms.Label labelStepOne;
        private Controls.BorderPanel borderPanelStepTwo;
        private System.Windows.Forms.Label labelStepTwo;
        private Controls.BorderPanel borderPanelStepThree;
        private System.Windows.Forms.Label labelStepThree;
        private Controls.BorderPanel borderPanelStepFour;
        private System.Windows.Forms.Label labelStepFour;
    }
}

