using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ObjemDesktop.Certificate
{
    class Certificate
    {
        public static X509Certificate2 CreateCACerttificate()
        {
            RSACryptoServiceProvider rsaPrivateKey = new RSACryptoServiceProvider(2048);
            CertificateRequest request = new CertificateRequest(
                "CN=objem, O=Objem, C=JP",
                rsaPrivateKey,
                HashAlgorithmName.SHA256,
                RSASignaturePadding.Pkcs1
                );
            request.CertificateExtensions.Add(new X509BasicConstraintsExtension(true, false, 0, false));
            var certificate = request.CreateSelfSigned(DateTime.UtcNow, new DateTimeOffset(DateTime.UtcNow.AddDays(365*5)));
            /*
             * 別に書く
            byte[] pfxByte = certificate.Export(X509ContentType.Pfx, "password");
            File.WriteAllBytes("CA.pfx", pfxByte);
            */
            return certificate;
        }

        public static X509Certificate2 CreateSignedServerCertificate(X509Certificate2 CAcert,IPAddress iPAddress)
        {
            RSACryptoServiceProvider rsaPrivateKey = new RSACryptoServiceProvider(2048);
            CertificateRequest request = new CertificateRequest(
                $"CN={iPAddress}, O=Objem, C=JP",
                rsaPrivateKey,
                HashAlgorithmName.SHA256,
                RSASignaturePadding.Pkcs1
            );
            SubjectAlternativeNameBuilder subjectAlternativeNameBuilder = new SubjectAlternativeNameBuilder();
            //実在するドメインを指定しないと死ぬ気がする:(
            subjectAlternativeNameBuilder.AddDnsName("objem.app");
            subjectAlternativeNameBuilder.AddIpAddress(iPAddress);
            var sans = subjectAlternativeNameBuilder.Build();
            request.CertificateExtensions.Add(sans);
            var certificate_befor = request.Create(CAcert, DateTime.UtcNow, new DateTimeOffset(DateTime.UtcNow.AddDays(365)), BitConverter.GetBytes(DateTime.Now.Ticks));
            var certificate = RSACertificateExtensions.CopyWithPrivateKey(certificate_befor, rsaPrivateKey);
            return certificate;
        }
    }
}
