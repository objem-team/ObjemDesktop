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
        public string Command { get; set; }
        public override void Execute()
        {
            ProcessStartInfo processInfo = new ProcessStartInfo("cmd.exe", $"/c {Command}");
            processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = false;
            processInfo.RedirectStandardOutput = true;
            processInfo.RedirectStandardError = true;
            var process = Process.Start(processInfo);
            string standardOutput = process.StandardOutput.ReadToEnd();
            string standardError = process.StandardError.ReadToEnd();
            process.Close();
            
        }
    }
}
