using System;
using System.Diagnostics;

namespace ObjemDesktop.Shortcuts.LaunchApp
{
    public class LaunchAppShortcut : ShortcutBase
    {
        public LaunchAppShortcut(Guid guid, string name, string path) : base(guid, name)
        {
            Path = path;
        }
        public LaunchAppShortcut() { }
        public string Path {get;set;}
        public override void Execute()
        {
            var processInfo = new ProcessStartInfo("cmd.exe", $"start {Path}");
            Process.Start(processInfo);
        }
    }
}
