using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace ObjemDesktop.Certificate
{
    internal static class CertificateUtil
    {
        public static void ExportAsPem(X509Certificate2 cert, string path)
        {
            string encodedText = ExportToPemString(cert);

            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter writer = new StreamWriter(fs))
                {
                    writer.Write(encodedText);
                }
            }
        }

        public static void ExportAsPfx(X509Certificate2 cert, string pathWithFileName, string password)
        {
            var certBytes = cert.Export(X509ContentType.Pfx, password);
            using (FileStream fs = new FileStream(pathWithFileName, FileMode.Create, FileAccess.Write))
            {
                using (var writer = new BinaryWriter(fs))
                {
                    writer.Write(certBytes);
                }
            }
        }
        public static void ExportAsPfx(X509Certificate2 cert, string path)
        {
            var certBytes = cert.Export(X509ContentType.Pfx);
            using (var fs = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                using (var writer = new BinaryWriter(fs))
                {
                    writer.Write(certBytes);
                }
            }
        }

        public static string ExportToPemString(X509Certificate2 cert)
        {
            byte[] certBytes = cert.Export(X509ContentType.Cert);

            string encodedText = "-----BEGIN CERTIFICATE-----\r\n"
                + Convert.ToBase64String(certBytes, Base64FormattingOptions.InsertLineBreaks)
                + "\r\n-----END CERTIFICATE-----";
            return encodedText;
        }

    }
}
