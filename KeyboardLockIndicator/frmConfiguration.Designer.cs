namespace KeyboardLockIndicator
{
    partial class frmConfiguration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfiguration));
            this.cdColor = new System.Windows.Forms.ColorDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblConfigurationTitle = new System.Windows.Forms.Label();
            this.btnBgColor = new System.Windows.Forms.Button();
            this.pnlBgColor = new System.Windows.Forms.Panel();
            this.btnTextColor = new System.Windows.Forms.Button();
            this.pnlTextColor = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAbort = new System.Windows.Forms.Button();
            this.cbSoundBeep = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cdColor
            // 
            this.cdColor.FullOpen = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblConfigurationTitle
            // 
            this.lblConfigurationTitle.AutoSize = true;
            this.lblConfigurationTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfigurationTitle.Location = new System.Drawing.Point(67, 27);
            this.lblConfigurationTitle.Name = "lblConfigurationTitle";
            this.lblConfigurationTitle.Size = new System.Drawing.Size(104, 20);
            this.lblConfigurationTitle.TabIndex = 1;
            this.lblConfigurationTitle.Text = "Configuration";
            // 
            // btnBgColor
            // 
            this.btnBgColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBgColor.Location = new System.Drawing.Point(13, 98);
            this.btnBgColor.Name = "btnBgColor";
            this.btnBgColor.Size = new System.Drawing.Size(180, 23);
            this.btnBgColor.TabIndex = 2;
            this.btnBgColor.Text = "Lock Indicator Background Color";
            this.btnBgColor.UseVisualStyleBackColor = true;
            this.btnBgColor.Click += new System.EventHandler(this.btnBgColor_Click);
            // 
            // pnlBgColor
            // 
            this.pnlBgColor.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pnlBgColor.Location = new System.Drawing.Point(226, 98);
            this.pnlBgColor.Name = "pnlBgColor";
            this.pnlBgColor.Size = new System.Drawing.Size(55, 23);
            this.pnlBgColor.TabIndex = 3;
            // 
            // btnTextColor
            // 
            this.btnTextColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTextColor.Location = new System.Drawing.Point(13, 127);
            this.btnTextColor.Name = "btnTextColor";
            this.btnTextColor.Size = new System.Drawing.Size(180, 23);
            this.btnTextColor.TabIndex = 4;
            this.btnTextColor.Text = "Lock Indicator Text Color";
            this.btnTextColor.UseVisualStyleBackColor = true;
            this.btnTextColor.Click += new System.EventHandler(this.btnTextColor_Click);
            // 
            // pnlTextColor
            // 
            this.pnlTextColor.BackColor = System.Drawing.Color.Black;
            this.pnlTextColor.Location = new System.Drawing.Point(226, 127);
            this.pnlTextColor.Name = "pnlTextColor";
            this.pnlTextColor.Size = new System.Drawing.Size(55, 23);
            this.pnlTextColor.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Location = new System.Drawing.Point(206, 203);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAbort
            // 
            this.btnAbort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAbort.Location = new System.Drawing.Point(117, 203);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(75, 23);
            this.btnAbort.TabIndex = 6;
            this.btnAbort.Text = "Cancel";
            this.btnAbort.UseVisualStyleBackColor = true;
            this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
            // 
            // cbSoundBeep
            // 
            this.cbSoundBeep.AutoSize = true;
            this.cbSoundBeep.Location = new System.Drawing.Point(13, 157);
            this.cbSoundBeep.Name = "cbSoundBeep";
            this.cbSoundBeep.Size = new System.Drawing.Size(209, 17);
            this.cbSoundBeep.TabIndex = 7;
            this.cbSoundBeep.Text = "Play a sound when lock key is pressed";
            this.cbSoundBeep.UseVisualStyleBackColor = true;
            // 
            // frmConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 238);
            this.Controls.Add(this.cbSoundBeep);
            this.Controls.Add(this.btnAbort);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pnlTextColor);
            this.Controls.Add(this.btnTextColor);
            this.Controls.Add(this.pnlBgColor);
            this.Controls.Add(this.btnBgColor);
            this.Controls.Add(this.lblConfigurationTitle);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmConfiguration";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmConfiguration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog cdColor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblConfigurationTitle;
        private System.Windows.Forms.Button btnBgColor;
        private System.Windows.Forms.Panel pnlBgColor;
        private System.Windows.Forms.Button btnTextColor;
        private System.Windows.Forms.Panel pnlTextColor;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAbort;
        private System.Windows.Forms.CheckBox cbSoundBeep;
    }
}