using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ObjemDesktop.Shortcuts.Keyboard.Structs;

namespace ObjemDesktop.Shortcuts.Keyboard
{
    public class KeyBoardShortcut : ShortcutBase
    {
        public ushort[] Keys { get; set; }
        public KeyBoardShortcut(Guid guid, string name, ushort[] keys) : base(guid, name) {
            Keys = keys;
        }
        public KeyBoardShortcut(Guid guid, string name, Keys[] keys) : base(guid, name)
        {
            Keys = keys.Select(k => (ushort)k).ToArray();
        }
        public KeyBoardShortcut() { }
        public override void Execute()
        {
            var inputs = KeyStrokesGenerator.Generate(Keys);
            Console.WriteLine(SendInput((uint)inputs.Length, inputs, Marshal.SizeOf(typeof(Input))));
        }

        [DllImport("user32.dll", SetLastError = true)]
        private static extern uint SendInput(uint numberOfInputs, Input[] inputs, int sizeOfInputStructure);
    }
}
