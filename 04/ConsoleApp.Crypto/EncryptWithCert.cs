using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ConsoleApp.Crypto
{
    public class EncryptWithCert
    {
        public void Run()
        {
            string plainText = "Test data to be encrypted";
            string encryptedText = string.Empty;

            // Get the certifcate to use to encrypt the key. 
            X509Certificate2 cert = GetCertificateFromStore("CN=CERT_SIGN_TEST_CERT");
            if (cert == null)
                throw new Exception("Certificate 'CN=CERT_SIGN_TEST_CERT' not found.");


            RSA publicKey = cert.GetRSAPublicKey();
            // Encrypt the file using the public key from the certificate. 
            encryptedText = EncryptFile(plainText, publicKey);

            RSA privateKey = cert.GetRSAPrivateKey();
            // Decrypt the file using the private key from the certificate. 
            string decryptedText = DecryptFile(encryptedText, privateKey);

            //Display the original data and the decrypted data. 
            Console.WriteLine("Original:   {0}", plainText);
            Console.WriteLine("Encrypted:  {0}", encryptedText);
            Console.WriteLine("Decrypted:  {0}", decryptedText);
        }

        private static X509Certificate2 GetCertificateFromStore(string certName)
        {
            // Get the certificate store for the current user. 
            X509Store store = new X509Store(StoreLocation.CurrentUser);
            try
            {
                store.Open(OpenFlags.ReadOnly);

                X509Certificate2Collection certCollection = store.Certificates;

                X509Certificate2Collection currentCerts = certCollection.Find(X509FindType.FindByTimeValid, DateTime.Now, false);

                X509Certificate2Collection signingCert = currentCerts.Find(X509FindType.FindBySubjectDistinguishedName, certName, false);

                if (signingCert.Count == 0)
                    return null;

                // Return the first certificate in the collection, has the right name and is current. 
                return signingCert[0];
            }
            finally
            {
                store.Close();
            }
        }

        // Encrypt a file using a public key. 
        private string EncryptFile(string stringToEncrypt, RSA rsaPublicKey)
        {
            if (rsaPublicKey == null || string.IsNullOrEmpty(stringToEncrypt))
                throw new Exception("A x509 certificate and string for encryption must be provided");

            byte[] bytestoEncrypt = Encoding.ASCII.GetBytes(stringToEncrypt);
            byte[] encryptedBytes = rsaPublicKey.Encrypt(bytestoEncrypt, RSAEncryptionPadding.OaepSHA1);
            return Convert.ToBase64String(encryptedBytes);
        }

        // Decrypt a file using a private key. 
        private string DecryptFile(string stringToDecrypt, RSA rsaPrivateKey)
        {
            if (rsaPrivateKey == null || string.IsNullOrEmpty(stringToDecrypt))
                throw new Exception("A x509 certificate and string for decryption must be provided");

            byte[] bytestodecrypt = Convert.FromBase64String(stringToDecrypt);
            byte[] plainbytes = rsaPrivateKey.Decrypt(bytestodecrypt, RSAEncryptionPadding.OaepSHA1);
            ASCIIEncoding enc = new ASCIIEncoding();
            return enc.GetString(plainbytes);
        }
    }
}
