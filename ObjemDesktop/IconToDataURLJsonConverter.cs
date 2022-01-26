using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ObjemDesktop
{
    class IconToDataUrlJsonConverter : JsonConverter<Icon>
    {
        public override Icon Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {   
            //ユースケースに無いため実装必要なし
            return null;
        }

        public override void Write(Utf8JsonWriter writer, Icon value, JsonSerializerOptions options)
        {
            var iconBase64String = ByteToBase64(IconToBytes(value));
            writer.WriteStringValue($"data:image/png;base64,{iconBase64String}");
        }

        private static string ByteToBase64(byte[] bytes)
        {
            return Convert.ToBase64String(bytes);
        }

        private static byte[] IconToBytes(Icon icon)
        {
            using (var ms = new MemoryStream())
            {
                var bitmap = icon.ToBitmap();
                bitmap.Save(ms, ImageFormat.Png);
                return ms.ToArray();
            }
        }
    }
}
