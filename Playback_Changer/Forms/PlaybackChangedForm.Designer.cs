namespace Playback_Changer.Forms
{
    partial class PlaybackChangedForm
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
            this.labelDevice = new System.Windows.Forms.Label();
            this.labelBodyDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDevice
            // 
            this.labelDevice.AutoSize = true;
            this.labelDevice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDevice.Location = new System.Drawing.Point(19, 47);
            this.labelDevice.Margin = new System.Windows.Forms.Padding(10);
            this.labelDevice.Name = "labelDevice";
            this.labelDevice.Size = new System.Drawing.Size(62, 21);
            this.labelDevice.TabIndex = 2;
            this.labelDevice.Text = "Device";
            // 
            // labelBodyDescription
            // 
            this.labelBodyDescription.AutoSize = true;
            this.labelBodyDescription.Location = new System.Drawing.Point(19, 19);
            this.labelBodyDescription.Margin = new System.Windows.Forms.Padding(10);
            this.labelBodyDescription.Name = "labelBodyDescription";
            this.labelBodyDescription.Size = new System.Drawing.Size(142, 21);
            this.labelBodyDescription.TabIndex = 3;
            this.labelBodyDescription.Text = "Switched to device:";
            // 
            // PlaybackChangedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 100);
            this.ControlBox = false;
            this.Controls.Add(this.labelBodyDescription);
            this.Controls.Add(this.labelDevice);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(360, 100);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(360, 100);
            this.Name = "PlaybackChangedForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Device changed";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDevice;
        private System.Windows.Forms.Label labelBodyDescription;
    }
}