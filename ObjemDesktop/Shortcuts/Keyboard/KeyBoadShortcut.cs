using System;
using System.Runtime.InteropServices;

namespace ObjemDesktop.Shortcuts.Keyboard
{
    public class KeyBoadShortcut : ShortcutBase
    {
        public KeyBoadShortcut(Guid guid, string name) : base(guid, name) { }
        public KeyBoadShortcut() { }
        public override void Execute()
        {
            var inputs = KeyStrokesGenerator.Generate(new ushort[] { 0x5b, 0x44 });
            Console.WriteLine(SendInput((uint)inputs.Length, inputs, Marshal.SizeOf(typeof(Input))));
        }

        [DllImport("user32.dll", SetLastError = true)]
        public static extern uint SendInput(uint numberOfInputs, Input[] inputs, int sizeOfInputStructure);
    }
}
