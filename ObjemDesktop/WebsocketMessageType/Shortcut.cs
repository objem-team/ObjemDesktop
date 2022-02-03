using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjemDesktop.WebsocketMessageType
{
    class Shortcut
    {
        public Guid Guid { get; set; }
        public Bitmap Icon { get; set; }

        public Shortcut(Guid guid, Bitmap icon) {
            Guid = guid;
            Icon = icon;
        }
    }
}
