using System;
using System.Runtime.InteropServices;

namespace ObjemDesktop.Shortcuts.Keyboard.Structs
{
    //<summary>
    //https://docs.microsoft.com/en-us/windows/win32/api/winuser/ns-winuser-keybdinput
    //</summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct KeyboardInput
    {
        public ushort keyCode;
        public ushort scanCode;
        public uint flags;
        public uint time;
        public IntPtr extraInfo;
    }
}
