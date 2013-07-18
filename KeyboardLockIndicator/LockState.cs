using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KeyboardLockIndicator
{
    public partial class LockState : Form
    {
        public LockState(string labelText)
        {
            InitializeComponent();
            tFadeout.Enabled = true;
            tFadeout.Start();
            tFadeout.Tick += new EventHandler(tFadeout_Tick);

            Int32 bgA = Convert.ToInt32(ConfigurationManager.AppSettings["IndicatorBackgroundColorA"].ToString());
            Int32 bgR = Convert.ToInt32(ConfigurationManager.AppSettings["IndicatorBackgroundColorR"].ToString());
            Int32 bgG = Convert.ToInt32(ConfigurationManager.AppSettings["IndicatorBackgroundColorG"].ToString());
            Int32 bgB = Convert.ToInt32(ConfigurationManager.AppSettings["IndicatorBackgroundColorB"].ToString());
            Int32 txA = Convert.ToInt32(ConfigurationManager.AppSettings["IndicatorTextColorA"].ToString());
            Int32 txR = Convert.ToInt32(ConfigurationManager.AppSettings["IndicatorTextColorR"].ToString());
            Int32 txG = Convert.ToInt32(ConfigurationManager.AppSettings["IndicatorTextColorG"].ToString());
            Int32 txB = Convert.ToInt32(ConfigurationManager.AppSettings["IndicatorTextColorB"].ToString());

            this.BackColor = Color.FromArgb(bgA, bgR, bgG, bgB);
            this.lblLockState.ForeColor = Color.FromArgb(txA, txR, txG, txB);
            this.lblLockState.Text = labelText;
        }

        private void tFadeout_Tick(object sender, EventArgs e)
        {
            tFadeout.Stop(); // so that we only fire the timer message once
            this.Close();
        }

    }
}
