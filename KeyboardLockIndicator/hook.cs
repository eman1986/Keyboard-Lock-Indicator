using System;
using System.ComponentModel;
using System.Configuration;
using System.Reflection;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace KeyboardLockIndicator
{
    public class Hook
    {
        private IntPtr _Handle;
        private HookProcDelegate _Hook;
        private const int WM_KEYDOWN = 0x0100;
        private const int WH_KEYBOARD_LL = 13;

        public void Enable()
        {
            Module module = Assembly.GetExecutingAssembly().GetModules()[0];
            IntPtr moduleHandle = Marshal.GetHINSTANCE(module);
            _Hook = HookProc;
            _Handle = SetWindowsHookEx(WH_KEYBOARD_LL, _Hook, IntPtr.Zero, 0);
            if (_Handle == IntPtr.Zero)
                throw new Win32Exception(Marshal.GetLastWin32Error());
        }

        public void Disable()
        {
            bool ok = UnhookWindowsHookEx(_Handle);
            _Handle = IntPtr.Zero;
            if (!ok)
                throw new Win32Exception(Marshal.GetLastWin32Error());
        }

        private delegate int HookProcDelegate(
            int code, IntPtr wParam, IntPtr lParam);

        private int HookProc(int code, IntPtr wParam, IntPtr lParam)
        {

            if (code >= 0 && wParam == (IntPtr)WM_KEYDOWN)
            {
                int vkCode = Marshal.ReadInt32(lParam);
                Keys key = (Keys)vkCode;
                if (key == Keys.Capital)
                {
                    //
                    // CAP LOCK
                    //
                    if (Convert.ToBoolean(ConfigurationManager.AppSettings["SoundBeep"].ToString()))
                    {
                        System.Media.SystemSounds.Hand.Play();
                    }
                    LockState frmLockState = new LockState(Control.IsKeyLocked(Keys.CapsLock) ? "Cap Lock is Off" : "Cap Lock is On");
                    frmLockState.Show();
                }
                if (key == Keys.NumLock)
                {
                    //
                    // NUM LOCK
                    //
                    if (Convert.ToBoolean(ConfigurationManager.AppSettings["SoundBeep"].ToString()))
                    {
                        System.Media.SystemSounds.Hand.Play();
                    }
                    LockState frmLockState = new LockState(Control.IsKeyLocked(Keys.NumLock) ? "Num Lock is Off" : "Num Lock is On");
                    frmLockState.Show();
                }
                if (key == Keys.Scroll)
                {
                    //
                    // SCROLL LOCK
                    //
                    if (Convert.ToBoolean(ConfigurationManager.AppSettings["SoundBeep"].ToString()))
                    {
                        System.Media.SystemSounds.Hand.Play();
                    }
                    LockState frmLockState = new LockState(Control.IsKeyLocked(Keys.Scroll) ? "Scroll Lock is Off" : "Scroll Lock is On");
                    frmLockState.Show();
                }
            }

            return CallNextHookEx(_Handle, code, wParam, lParam);
        }

        #region DLL Imports
        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(
            int hookType, HookProcDelegate lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern int CallNextHookEx(
            IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);
        #endregion
    }
}