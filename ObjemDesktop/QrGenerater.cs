using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZXing;
using ZXing.QrCode;
using ZXing.QrCode.Internal;
using System.Drawing.Imaging;
using System.IO;
using System.Drawing;
using System.Net;

namespace ObjemDesktop
{
    class QrGenerater
    {   
        
        //QRコード取得
        public Image Generate(String Str,int Width, int Height)
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
