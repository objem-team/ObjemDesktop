using ObjemDesktop.Shortcuts;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace ObjemDesktop.Config
{
    class UserShortcuts
    {
        private string  filePath = @"shortcuts.xml";

        public static UserShortcuts Instance = new UserShortcuts();
        private Shortcuts _shortcuts;

        public List<ShortcutBase> Shortcuts
        {
            get 
            {
                if(_shortcuts is null)
                {
                    _shortcuts =new Shortcuts();
                }
                return _shortcuts.List;
            }
            set => _shortcuts.List = value;
        }


        private UserShortcuts()
        {
            _shortcuts = Deserialize();
        }
        public void Save()
        {
            Serialize();
        }

        public void Reload()
        {
            _shortcuts = Deserialize();
        }

        private Shortcuts Deserialize()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Shortcuts));
                StreamReader reader = new StreamReader(filePath, new UTF8Encoding(false));
                Shortcuts shortcuts = (Shortcuts)serializer.Deserialize(reader);
                reader.Close();
                return shortcuts;
            }
            catch (FileNotFoundException)
            {
                return new Shortcuts();
            }
        }

        private void Serialize()
        {
            var serializer = new XmlSerializer(typeof(Shortcuts));
            StreamWriter writer = new StreamWriter(filePath);
            serializer.Serialize(writer, _shortcuts);
            writer.Close();
        }

        public void AddOrReplace(ShortcutBase shotcut)
        {
            var index = Shortcuts.FindIndex(s => s.Equals(shotcut));
            if (index == -1)
            {
                Shortcuts.Add(shotcut);
            }
            else
            {
                Shortcuts[index] = shotcut;
            }
        }
        
    }
}
