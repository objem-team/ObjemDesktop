using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ObjemDesktop.Config
{
    class UserShortcuts
    {
        private string  filePath = @"shortcuts.xml";

        public static UserShortcuts Instance = new UserShortcuts();
        private Shortcuts _shortcuts;

        public Shortcuts Shortcuts
        {
            get 
            {
                if(_shortcuts is null)
                {
                    return new Shortcuts();
                }
                else
                {
                    return _shortcuts;
                }
            }
            set
            {
                _shortcuts = value;
            }
        }


        private UserShortcuts()
        {
            _shortcuts = Deserialize();
        }
        public void Save()
        {
            Serialize();
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
    }
}
