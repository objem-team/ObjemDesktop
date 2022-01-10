using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ObjemDesktop
{
    class IconToDataURLJsonConverter : JsonConverter<Icon>
    {
        public override Icon Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {   
            //ユースケースに無いため実装必要なし
            throw new NotImplementedException();
        }

        public override void Write(Utf8JsonWriter writer, Icon value, JsonSerializerOptions options)
        {
            string IconBase64String = ByteToBase64(IconToBytes(value));
            writer.WriteStringValue($"data:image/png;base64,{IconBase64String}");
        }

        public string ByteToBase64(byte[] bytes)
        {
            return Convert.ToBase64String(bytes);
        }

        public static byte[] IconToBytes(Icon icon)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                Bitmap bitmap = icon.ToBitmap();
                bitmap.Save(ms, ImageFormat.Png);
                return ms.ToArray();
            }
        }
    }
}
