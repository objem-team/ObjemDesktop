using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace ObjemDesktop.window
{
    class ForegroundHandler
    {
        public event EventHandler<Process> ForegroundWindowChange;
        private delegate void WinEventDelegate(IntPtr hWinEventHook, uint eventType, IntPtr hwnd, int idObject, int idChild, uint dwEventThread, uint dwmsEventTime);
        private const uint WINEVENT_OUTOFCONTEXT = 0;
        private const uint EVENT_SYSTEM_FOREGROUND = 3;
        WinEventDelegate dele = null;
        public IntPtr m_hook = IntPtr.Zero;

        public ForegroundHandler()
        {
            dele = new WinEventDelegate(WinEventProc);
            m_hook = SetWinEventHook(EVENT_SYSTEM_FOREGROUND, EVENT_SYSTEM_FOREGROUND, IntPtr.Zero, dele, 0, 0, WINEVENT_OUTOFCONTEXT);
        }

        [DllImport("user32.dll")]
        static extern IntPtr SetWinEventHook(uint eventMin, uint eventMax, IntPtr hmodWinEventProc, WinEventDelegate lpfnWinEventProc, uint idProcess, uint idThread, uint dwFlags);

        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowThreadProcessId(IntPtr hWnd, out uint ProcessId);



        private uint GetActiveWindowProcessID()
        {
            GetWindowThreadProcessId(GetForegroundWindow(), out var pid);
            return pid;
        }

        public void WinEventProc(IntPtr hWinEventHook, uint eventType, IntPtr hwnd, int idObject, int idChild, uint dwEventThread, uint dwmsEventTime)
        {
            ForegroundWindowChange?.Invoke(this,Process.GetProcessById((int)GetActiveWindowProcessID()));
        }
    }
}
