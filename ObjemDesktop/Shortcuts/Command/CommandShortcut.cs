using System;
using System.Diagnostics;

namespace ObjemDesktop.Shortcuts.Command
{
    class CommandShortcut : ShortcutBase
    {
        public CommandShortcut(Guid guid,string name) :base(guid,name){ }
        public CommandShortcut() { }
        public string Command { get; set; }
        public override void Execute()
        {
            ProcessStartInfo processInfo = new ProcessStartInfo("cmd.exe", Command);
            Process.Start(processInfo);
        }
    }
}
