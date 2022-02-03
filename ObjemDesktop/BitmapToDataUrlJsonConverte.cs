using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ObjemDesktop
{
    public class BitmapToDataUrlJsonConverte:JsonConverter<Bitmap>
    {
        public override Bitmap Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {   
            //ユースケースに無いため実装必要なし
            return null;
        }

        public override void Write(Utf8JsonWriter writer, Bitmap value, JsonSerializerOptions options)
        {
            var iconBase64String = ByteToBase64(IconToBytes(value));
            writer.WriteStringValue($"data:image/png;base64,{iconBase64String}");
        }

        private static string ByteToBase64(byte[] bytes)
        {
            return Convert.ToBase64String(bytes);
        }

        private static byte[] IconToBytes(Bitmap bitmap)
        {
            using (var ms = new MemoryStream())
            {
                bitmap.Save(ms, ImageFormat.Png);
                return ms.ToArray();
            }
        }
    }
}