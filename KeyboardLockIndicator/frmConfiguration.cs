using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace KeyboardLockIndicator
{
    public partial class frmConfiguration : Form
    {

        Int32 bgA,bgR,bgG,bgB,txA,txR,txG,txB;

        public frmConfiguration()
        {
            InitializeComponent();
        }

        //[PrincipalPermission(SecurityAction.Demand, Role = @"BUILTIN\Administrators")]
        private void frmConfiguration_Load(object sender, EventArgs e)
        {
             bgA = Convert.ToInt32(ConfigurationManager.AppSettings["IndicatorBackgroundColorA"].ToString());
             bgR = Convert.ToInt32(ConfigurationManager.AppSettings["IndicatorBackgroundColorR"].ToString());
             bgG = Convert.ToInt32(ConfigurationManager.AppSettings["IndicatorBackgroundColorG"].ToString());
             bgB = Convert.ToInt32(ConfigurationManager.AppSettings["IndicatorBackgroundColorB"].ToString());
             txA = Convert.ToInt32(ConfigurationManager.AppSettings["IndicatorTextColorA"].ToString());
             txR = Convert.ToInt32(ConfigurationManager.AppSettings["IndicatorTextColorR"].ToString());
             txG = Convert.ToInt32(ConfigurationManager.AppSettings["IndicatorTextColorG"].ToString());
             txB = Convert.ToInt32(ConfigurationManager.AppSettings["IndicatorTextColorB"].ToString());
            pnlBgColor.BackColor = Color.FromArgb(bgA, bgR, bgG, bgB);
            pnlTextColor.BackColor = Color.FromArgb(txA, txR, txG, txB);
        }

        /// <summary>
        /// Button-Click event to save configuration settings.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);

            foreach (XmlElement element in xmlDoc.DocumentElement)
            {
                if (element.Name.Equals("appSettings"))
                {
                    foreach (XmlNode node in element.ChildNodes)
                    {
                        //update our config file.

                        //
                        // IndicatorBackgroundColorA
                        //
                        if (node.Attributes[0].Value.Equals("IndicatorBackgroundColorA"))
                        {
                            node.Attributes[1].Value = pnlBgColor.BackColor.A.ToString();
                        }

                        //
                        // IndicatorBackgroundColorR
                        //
                        if (node.Attributes[0].Value.Equals("IndicatorBackgroundColorR"))
                        {
                            node.Attributes[1].Value = pnlBgColor.BackColor.R.ToString();
                        }

                        //
                        // IndicatorBackgroundColorG
                        //
                        if (node.Attributes[0].Value.Equals("IndicatorBackgroundColorG"))
                        {
                            node.Attributes[1].Value = pnlBgColor.BackColor.G.ToString();
                        }

                        //
                        // IndicatorBackgroundColorB
                        //
                        if (node.Attributes[0].Value.Equals("IndicatorBackgroundColorB"))
                        {
                            node.Attributes[1].Value = pnlBgColor.BackColor.B.ToString();
                        }

                        //
                        // IndicatorTextColorA
                        //
                        if (node.Attributes[0].Value.Equals("IndicatorTextColorA"))
                        {
                            node.Attributes[1].Value = pnlTextColor.BackColor.A.ToString();
                        }

                        //
                        // IndicatorTextColorR
                        //
                        if (node.Attributes[0].Value.Equals("IndicatorTextColorR"))
                        {
                            node.Attributes[1].Value = Convert.ToString(pnlTextColor.BackColor.R.ToString());
                        }

                        //
                        // IndicatorTextColorG
                        //
                        if (node.Attributes[0].Value.Equals("IndicatorTextColorG"))
                        {
                            node.Attributes[1].Value = Convert.ToString(pnlTextColor.BackColor.G.ToString());
                        }

                        //
                        // IndicatorTextColorB
                        //
                        if (node.Attributes[0].Value.Equals("IndicatorTextColorB"))
                        {
                            node.Attributes[1].Value = Convert.ToString(pnlTextColor.BackColor.B.ToString());
                        }
                        if (node.Attributes[0].Value.Equals("SoundBeep"))
                        {
                            node.Attributes[1].Value = cbSoundBeep.Checked.ToString();
                        }
                    }
                }
            }

            xmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            ConfigurationManager.RefreshSection("appSettings");


            //let user know changes were saved.
            LockState frmLockState = new LockState("Configuration Saved");
            frmLockState.ShowDialog();
            this.Close(); //close form, its no longer needed.
        }

        private void btnBgColor_Click(object sender, EventArgs e)
        {
            cdColor.Color = Color.FromArgb(bgA, bgR, bgG, bgB);
            if (cdColor.ShowDialog() == DialogResult.OK)
            {
                pnlBgColor.BackColor = cdColor.Color;
            }
        }

        private void btnTextColor_Click(object sender, EventArgs e)
        {
            cdColor.Color = Color.FromArgb(txA, txR, txG, txB);
            if (cdColor.ShowDialog() == DialogResult.OK)
            {
                pnlTextColor.BackColor = cdColor.Color;
            }
        }

        private void btnAbort_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
