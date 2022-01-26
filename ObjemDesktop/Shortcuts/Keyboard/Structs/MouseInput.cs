using System;
using System.Runtime.InteropServices;

namespace ObjemDesktop.Shortcuts.Keyboard.Structs
{
    //<summary>
    //https://docs.microsoft.com/en-us/windows/win32/api/winuser/ns-winuser-mouseinput
    //</summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct MouseInput
    {
        public int x;
        public int y;
        public uint mouseData;
        public uint flags;
        public uint time;
        public IntPtr extraInfo;
    }
}
