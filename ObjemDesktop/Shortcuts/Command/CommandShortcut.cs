using System;
using System.Diagnostics;

namespace ObjemDesktop.Shortcuts.Command
{
    public class CommandShortcut : ShortcutBase
    {
        public CommandShortcut(Guid guid, string name, string command) : base(guid, name)
        {
            Command = command;
        }
        public CommandShortcut() { }
        public string Command { get; }
        public override void Execute()
        {
            ProcessStartInfo processInfo = new ProcessStartInfo("cmd.exe", Command);
            Process.Start(processInfo);
        }
    }
}
