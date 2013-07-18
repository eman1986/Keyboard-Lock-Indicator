using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace KeyboardLockIndicator
{
    class TaskTrayApplicationContext : ApplicationContext
    {
        NotifyIcon notifyIcon = new NotifyIcon();
        About AboutWindow = new About();
        frmConfiguration configWindow = new frmConfiguration();

        public TaskTrayApplicationContext()
        {
            notifyIcon.Visible = true;

            MenuItem configMenuItem = new MenuItem("Configuration", new EventHandler(ShowConfig));
            MenuItem checkLocks = new MenuItem("Lock Summary", new EventHandler(showTip));
            MenuItem About = new MenuItem("About...", new EventHandler(ShowAbout));
            MenuItem exitMenuItem = new MenuItem("Exit", new EventHandler(Exit));

            notifyIcon.Icon = KeyboardLockIndicator.Properties.Resources.keyboard;
            notifyIcon.DoubleClick += new EventHandler(ShowConfig);
            notifyIcon.ContextMenu = new ContextMenu(new MenuItem[] { checkLocks, configMenuItem, About, exitMenuItem });
        }

        void showTip(object sender, EventArgs e)
        {
            string lockInfo;

            //
            // CAP LOCK
            //
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                lockInfo = "Cap Lock is On" + System.Environment.NewLine;
            }
            else
            {
                lockInfo = "Cap Lock is Off" + System.Environment.NewLine;
            }

            //
            // NUM LOCK
            //
            if (Control.IsKeyLocked(Keys.NumLock))
            {
                lockInfo += "Num Lock is On" + System.Environment.NewLine;
            }
            else
            {
                lockInfo += "Num Lock is Off" + System.Environment.NewLine;
            }

            //
            // SCROLL LOCK
            //
            if (Control.IsKeyLocked(Keys.Scroll))
            {
                lockInfo += "Scroll Lock is On";
            }
            else
            {
                lockInfo += "Scroll Lock is Off";
            }

            //Show only if a lock was detected.
            if (lockInfo != "")
            {
                notifyIcon.ShowBalloonTip(30000, "Lock Summary", lockInfo, ToolTipIcon.Info);
            }
        }

        void ShowConfig(object sender, EventArgs e)
        {
            // If we are already showing the window, just focus it.
            if (configWindow.Visible)
                configWindow.Focus();
            else
                configWindow.ShowDialog();
        }

        void ShowAbout(object sender, EventArgs e)
        {
            // If we are already showing the window, just focus it.
            if (AboutWindow.Visible)
                AboutWindow.Focus();
            else
                AboutWindow.ShowDialog();
        }

        void Exit(object sender, EventArgs e)
        {
            notifyIcon.Visible = false;
            Application.Exit();
        }
    }
}
