﻿using System;
using System.IO;
using System.Security;
using System.Security.Cryptography.X509Certificates;

namespace ObjemDesktop.Certificate
{
    class CertificateUtil
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

        internal static void ExportAsPem(X509Certificate2 cert, string v, string crt)
        {
            throw new NotImplementedException();
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
        public static void ExportAsPfx(X509Certificate2 cert, string path)
        {
            byte[] certBytes = cert.Export(X509ContentType.Pfx);
            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                using (BinaryWriter writer = new BinaryWriter(fs))
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
