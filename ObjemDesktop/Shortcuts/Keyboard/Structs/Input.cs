using System.Runtime.InteropServices;

namespace ObjemDesktop.Shortcuts.Keyboard
{
    //<summary>
    //https://docs.microsoft.com/en-us/windows/win32/api/winuser/ns-winuser-input
    //</summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct Input
    {
        public uint type;
        public UserInput userInput;
    }
}
