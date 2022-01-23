using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ObjemDesktop.Shortcuts.Keyboard
{
    public class KeyBoadShortcut : ShortcutBase
    {
        public ushort[] Keys { get; set; }
        public KeyBoadShortcut(Guid guid, string name, ushort[] keys) : base(guid, name) {
            Keys = keys;
        }
        public KeyBoadShortcut(Guid guid, string name, Keys[] keys) : base(guid, name)
        {
            Keys = keys.Select(k => (ushort)k).ToArray();
        }
        public KeyBoadShortcut() { }
        public override void Execute()
        {
            var inputs = KeyStrokesGenerator.Generate(Keys);
            Console.WriteLine(SendInput((uint)inputs.Length, inputs, Marshal.SizeOf(typeof(Input))));
        }

        [DllImport("user32.dll", SetLastError = true)]
        public static extern uint SendInput(uint numberOfInputs, Input[] inputs, int sizeOfInputStructure);
    }
}
