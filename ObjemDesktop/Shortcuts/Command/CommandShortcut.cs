using System;

namespace ObjemDesktop.Shortcuts.Command
{
    class CommandShortcut : ShortcutBase
    {
        public CommandShortcut(Guid guid,string name) :base(guid,name){ }
        public CommandShortcut() { }
        public override void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
