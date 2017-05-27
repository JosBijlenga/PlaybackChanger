using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Playback_Changer.Controllers;

namespace Playback_Changer.Helpers
{
    // From: https://blogs.msdn.microsoft.com/toub/2006/05/03/low-level-keyboard-hook-in-c/
    public class KeyboardHook
    {
        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x0100;
        private const int WM_SYSKEYDOWN = 0x0104;
        private LowLevelKeyboardProc _proc;
        private IntPtr _hookID = IntPtr.Zero;

        public KeyboardHook()
        {
            _proc = HookCallback;
            _hookID = SetHook(_proc);
        }

        public void Unhook()
        {
            UnhookWindowsHookEx(_hookID);
        }

        private IntPtr SetHook(LowLevelKeyboardProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                return SetWindowsHookEx(WH_KEYBOARD_LL, proc, GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        private IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && wParam == (IntPtr)WM_SYSKEYDOWN)
            {
                int vkCode = Marshal.ReadInt32(lParam);
                switch ((Keys)vkCode)
                {
                    case Keys.F1:
                    case Keys.F2:
                    case Keys.F3:
                        hotkeyEvent = new HotkeyEventArgs((Keys)vkCode);
                        HotkeyPressed?.Invoke(hotkeyEvent);
                        break;
                    default: break;
                }

                if (SettingsManager.Settings.ActivateKey == (Keys)vkCode)
                {
                    activedEvent = new ActivatedEventArgs();
                    Activated?.Invoke(activedEvent);
                    // Processed the message so return nonzero value to prevent passing value to the rest of the hook chain.
                    return IntPtr.Add(IntPtr.Zero, 1);
                }
            }
            return CallNextHookEx(_hookID, nCode, wParam, lParam);
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        #region ActivatedEvent

        public ActivatedEventArgs activedEvent = null;
        public delegate void ActivatedEventHandler(ActivatedEventArgs e);
        public event ActivatedEventHandler Activated;

        public class ActivatedEventArgs : EventArgs
        {

        }

        #endregion ActivatedEvent

        #region HotkeyEvent

        public HotkeyEventArgs hotkeyEvent = null;
        public delegate void HotkeyEventEventHandler(HotkeyEventArgs e);
        public event HotkeyEventEventHandler HotkeyPressed;

        public class HotkeyEventArgs : EventArgs
        {
            private Keys _key;
            public Keys Key
            {
                get { return _key; }
            }

            public HotkeyEventArgs(Keys key)
            {
                _key = key;
            }
        }

        #endregion HotkeyEvent

    }
}
