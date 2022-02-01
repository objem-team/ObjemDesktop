using System;
using System.Net;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace ObjemDesktop.Certificate
{
    internal static class Certificate
    {
        public static X509Certificate2 CreateCertificate()
        {
            var rsaPrivateKey = new RSACryptoServiceProvider(2048);
            var request = new CertificateRequest(
                "CN=objem, O=Objem, C=JP",
                rsaPrivateKey,
                HashAlgorithmName.SHA256,
                RSASignaturePadding.Pkcs1
                );
            request.CertificateExtensions.Add(new X509BasicConstraintsExtension(true, false, 0, false));
            var certificate = request.CreateSelfSigned(DateTime.UtcNow, new DateTimeOffset(DateTime.UtcNow.AddDays(365*5)));
            return certificate;
        }

        public static X509Certificate2 CreateSignedServerCertificate(X509Certificate2 caCert,IPAddress iPAddress)
        {
            var rsaPrivateKey = new RSACryptoServiceProvider(2048);
            var request = new CertificateRequest(
                $"CN={iPAddress}, O=Objem, C=JP",
                rsaPrivateKey,
                HashAlgorithmName.SHA256,
                RSASignaturePadding.Pkcs1
            );
            var subjectAlternativeNameBuilder = new SubjectAlternativeNameBuilder();
            subjectAlternativeNameBuilder.AddDnsName("objem.app");
            subjectAlternativeNameBuilder.AddIpAddress(iPAddress);
            var sans = subjectAlternativeNameBuilder.Build();
            request.CertificateExtensions.Add(sans);
            var certificateBefore = request.Create(caCert, DateTime.UtcNow, new DateTimeOffset(DateTime.UtcNow.AddDays(365)), BitConverter.GetBytes(DateTime.Now.Ticks));
            var certificate = certificateBefore.CopyWithPrivateKey(rsaPrivateKey);
            return certificate;
        }
    }
}
