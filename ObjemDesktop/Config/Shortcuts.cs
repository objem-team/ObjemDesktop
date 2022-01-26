using ObjemDesktop.Shortcuts;
using ObjemDesktop.Shortcuts.Command;
using ObjemDesktop.Shortcuts.Keyboard;
using ObjemDesktop.Shortcuts.LaunchApp;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace ObjemDesktop.Config
{
    //xmlシリアライズしたときにリストを保持するクラス
    public class Shortcuts
    {
        private List<ShortcutBase> _list;
        public Shortcuts()
        {
            _list = new List<ShortcutBase>();
        }


        [XmlArrayItem(Type = typeof(KeyBoardShortcut)),
        XmlArrayItem(Type = typeof(CommandShortcut)),
        XmlArrayItem(Type = typeof(LaunchAppShortcut))]
        public List<ShortcutBase> List 
        {
            get => _list ?? (_list = new List<ShortcutBase>());
            set => _list = value;
        }
    }
}
