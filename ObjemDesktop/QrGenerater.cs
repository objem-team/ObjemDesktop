using System;
using ZXing;
using ZXing.QrCode;
using ZXing.QrCode.Internal;
using System.Drawing;

namespace ObjemDesktop
{
    class QrGenerater
    {   
        
        //QRコード取得
        public static Image Generate(String Str,int Width, int Height)
        {
            var Writer = new BarcodeWriter
            {
                Format = BarcodeFormat.QR_CODE,
                Options = new QrCodeEncodingOptions
                {
                    QrVersion = 5,
                    ErrorCorrection = ErrorCorrectionLevel.M,
                    CharacterSet = "UTF-8",
                    Width = Width,
                    Height = Height,
                    Margin = 5,
                },
            };
            return Writer.Write(Str);
        }
    }
}
