namespace KeyboardLockIndicator
{
    partial class LockState
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LockState));
            this.lblLockState = new System.Windows.Forms.Label();
            this.tFadeout = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblLockState
            // 
            this.lblLockState.AutoSize = true;
            this.lblLockState.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLockState.Location = new System.Drawing.Point(133, 14);
            this.lblLockState.Name = "lblLockState";
            this.lblLockState.Size = new System.Drawing.Size(219, 37);
            this.lblLockState.TabIndex = 0;
            this.lblLockState.Text = "Cap lock is on";
            // 
            // tFadeout
            // 
            this.tFadeout.Interval = 1000;
            // 
            // LockState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(539, 67);
            this.ControlBox = false;
            this.Controls.Add(this.lblLockState);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LockState";
            this.Opacity = 0.8D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LockState";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLockState;
        private System.Windows.Forms.Timer tFadeout;
    }
}