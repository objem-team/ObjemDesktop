using System;

namespace ObjemDesktop.Shortcuts.LaunchApp
{
    class LaunchAppShortcut : ShortcutBase
    {
        public LaunchAppShortcut(Guid guid,string name) : base(guid, name) { }
        public LaunchAppShortcut() { }
        public override void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
