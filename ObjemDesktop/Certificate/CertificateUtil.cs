using System;
using System.IO;
using System.Security;
using System.Security.Cryptography.X509Certificates;

namespace ObjemDesktop.Certificate
{
    class CertificateUtil
    {
        public static void ExportAsPem(X509Certificate2 cert,string pathWithFileName,X509CertificateExtensionType extension,SecureString password)
        {
            byte[] certBytes = cert.Export(X509ContentType.Cert, password);

            string encodedText = "-----BEGIN CERTIFICATE-----\r\n"
                + Convert.ToBase64String(certBytes, Base64FormattingOptions.InsertLineBreaks)
                + "\r\n-----END CERTIFICATE-----";

            using(FileStream fs = new FileStream(pathWithFileName+extension, FileMode.Create, FileAccess.Write))
            {
                using(StreamWriter writer = new StreamWriter(fs))
                {
                    writer.Write(encodedText);
                }
            }

        }

        public static void ExportAsPem(X509Certificate2 cert, string pathWithFileName, X509CertificateExtensionType extension)
        {
            byte[] certBytes = cert.Export(X509ContentType.Cert);

            string encodedText = "-----BEGIN CERTIFICATE-----\r\n"
                + Convert.ToBase64String(certBytes, Base64FormattingOptions.InsertLineBreaks)
                + "\r\n-----END CERTIFICATE-----";

            using (FileStream fs = new FileStream(pathWithFileName + extension, FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter writer = new StreamWriter(fs))
                {
                    writer.Write(encodedText);
                }
            }
        }

        public static void ExportAsPfx(X509Certificate2 cert, string pathWithFileName, SecureString password)
        {
            byte[] certBytes = cert.Export(X509ContentType.Pfx, password);
            using (FileStream fs = new FileStream(pathWithFileName + ".pfx", FileMode.Create, FileAccess.Write))
            {
                using (BinaryWriter writer = new BinaryWriter(fs))
                {
                    writer.Write(certBytes);
                }
            }
        }
        public static void ExportAsPfx(X509Certificate2 cert, string pathWithFileName)
        {
            byte[] certBytes = cert.Export(X509ContentType.Pfx);
            using (FileStream fs = new FileStream(pathWithFileName + ".pfx", FileMode.Create, FileAccess.Write))
            {
                using (BinaryWriter writer = new BinaryWriter(fs))
                {
                    writer.Write(certBytes);
                }
            }
        }

    }
}
