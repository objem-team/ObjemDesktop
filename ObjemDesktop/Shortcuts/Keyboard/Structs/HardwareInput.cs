using System.Runtime.InteropServices;

namespace ObjemDesktop.Shortcuts.Keyboard
{
    //<summary>
    //https://docs.microsoft.com/en-us/windows/win32/api/winuser/ns-winuser-hardwareinput
    //</summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct HardwareInput
    {
        public int message;
        public short paramL;
        public short paramH;
    }
}
