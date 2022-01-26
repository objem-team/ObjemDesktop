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
        public static Image Generate(String str,int width, int height)
        {
            var writer = new BarcodeWriter
            {
                Format = BarcodeFormat.QR_CODE,
                Options = new QrCodeEncodingOptions
                {
                    QrVersion = 5,
                    ErrorCorrection = ErrorCorrectionLevel.M,
                    CharacterSet = "UTF-8",
                    Width = width,
                    Height = height,
                    Margin = 5,
                },
            };
            return writer.Write(str);
        }
    }
}
