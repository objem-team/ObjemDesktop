using System;
using System.Diagnostics;
using System.IO;

namespace ObjemDesktop.Shortcuts.LaunchApp
{
    public class LaunchAppShortcut : ShortcutBase
    {
        public LaunchAppShortcut(Guid guid,string name) : base(guid, name) { }
        public LaunchAppShortcut() { }
        public string path {get;set;}
        public override void Execute()
        {
            ProcessStartInfo processInfo = new ProcessStartInfo("cmd.exe", $"start {path}");
            Process.Start(processInfo);
        }
    }
}
