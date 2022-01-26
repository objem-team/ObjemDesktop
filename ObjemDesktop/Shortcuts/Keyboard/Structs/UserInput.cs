using System.Runtime.InteropServices;

namespace ObjemDesktop.Shortcuts.Keyboard.Structs
{
    //<summary>
    //https://docs.microsoft.com/en-us/windows/win32/api/winuser/ns-winuser-input
    //</summary>
    [StructLayout(LayoutKind.Explicit)]
    public struct UserInput
    {
        [FieldOffset(0)]
        public MouseInput mouseInput;

        [FieldOffset(0)]
        public KeyboardInput keyboardInput;

        [FieldOffset(0)]
        public HardwareInput hardwareInput;
    }
}
