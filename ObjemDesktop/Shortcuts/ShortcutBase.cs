using System;

namespace ObjemDesktop.Shortcuts
{
    public abstract class ShortcutBase
    {
        public Guid Guid { get; set; }
        public string Name { get; set; }
        public ShortcutBase() { }
        public ShortcutBase(Guid guid, string name)
        {
            Guid = guid;
            Name = name;
        }
        public abstract void Execute();

    }
}
