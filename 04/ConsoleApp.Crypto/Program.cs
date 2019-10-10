using System;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ConsoleApp.Crypto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            //string @string = "Super string master blaster!!!!";
            //Console.WriteLine($"Plain text          {@string}");
            //Console.WriteLine($"One way Hash MD5    {ComputeHashMD5(@string)}");

            //Console.ReadKey();
            //return;



            string planText = "text to encrypt";

            EncryptWithCert encryptWithCert = new EncryptWithCert();
            encryptWithCert.Run();

            return;

            

            Console.WriteLine();

            string encrypted = EncrypHMAC(planText, "HAHAHAHAHAHAHAHAHA");
            Console.WriteLine($"EncrypHMAC {encrypted}");

            Console.WriteLine();

            //Create a UnicodeEncoder to convert between byte array and string.
            UnicodeEncoding ByteConverter = new UnicodeEncoding();

            //Create a new instance of RSACryptoServiceProvider to generate
            //public and private key data.
            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
            {
                //Pass the data to ENCRYPT, the public key information 
                //(using RSACryptoServiceProvider.ExportParameters(false),
                //and a boolean flag specifying no OAEP padding.
                var encryptedData = RSAEncrypt(ByteConverter.GetBytes("Data to Encrypt"), RSA.ExportParameters(false), false);

                Console.WriteLine("Encrypted plaintext: {0}", ByteConverter.GetString(encryptedData));

                //Pass the data to DECRYPT, the private key information 
                //(using RSACryptoServiceProvider.ExportParameters(true),
                //and a boolean flag specifying no OAEP padding.
                var decryptedData = RSADecrypt(encryptedData, RSA.ExportParameters(true), false);

                //Display the decrypted plaintext to the console. 
                Console.WriteLine("Decrypted plaintext: {0}", ByteConverter.GetString(decryptedData));
                Console.WriteLine();
            }

            Console.ReadKey();
        }

        static string ComputeHashMD5(string input)
        {
            using (var md5Hash = MD5.Create())
            {
                byte[] rawStringBytes = Encoding.UTF8.GetBytes(input);

                byte[] data = md5Hash.ComputeHash(rawStringBytes);

                StringBuilder sBuilder = new StringBuilder();

                for (int i = 0; i < data.Length; i++)
                    sBuilder.Append(data[i].ToString("x2"));

                return sBuilder.ToString();
            }
        }

        static string EncrypHMAC(string input, string secretKey)
        {
            var rawInput = Encoding.UTF8.GetBytes(input);
            var rawSecret = Encoding.UTF8.GetBytes(secretKey);

            using (var hashAlgorithm = new HMACSHA1(rawSecret))
            {
                using (var bufferStream = new MemoryStream(rawInput))
                {
                    var bytesEncrypted = hashAlgorithm.ComputeHash(bufferStream);

                    return Encoding.UTF8.GetString(bytesEncrypted);
                }
            }
        }

        public static byte[] RSAEncrypt(byte[] DataToEncrypt, RSAParameters RSAKeyInfo, bool DoOAEPPadding)
        {
            try
            {
                byte[] encryptedData;
                //Create a new instance of RSACryptoServiceProvider.
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    //Import the RSA Key information. This only needs
                    //toinclude the public key information.
                    RSA.ImportParameters(RSAKeyInfo);

                    //Encrypt the passed byte array and specify OAEP padding.  
                    //OAEP padding is only available on Microsoft Windows XP or
                    //later.  
                    encryptedData = RSA.Encrypt(DataToEncrypt, DoOAEPPadding);
                }
                return encryptedData;
            }
            //Catch and display a CryptographicException  
            //to the console.
            catch (CryptographicException e)
            {
                Console.WriteLine(e.Message);

                return null;
            }
        }

        public static byte[] RSADecrypt(byte[] DataToDecrypt, RSAParameters RSAKeyInfo, bool DoOAEPPadding)
        {
            try
            {
                byte[] decryptedData;
                //Create a new instance of RSACryptoServiceProvider.
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    //Import the RSA Key information. This needs
                    //to include the private key information.
                    RSA.ImportParameters(RSAKeyInfo);

                    //Decrypt the passed byte array and specify OAEP padding.  
                    //OAEP padding is only available on Microsoft Windows XP or
                    //later.  
                    decryptedData = RSA.Decrypt(DataToDecrypt, DoOAEPPadding);
                }
                return decryptedData;
            }
            //Catch and display a CryptographicException  
            //to the console.
            catch (CryptographicException e)
            {
                Console.WriteLine(e.ToString());

                return null;
            }
        }

        static void ShowCerts()
        {
            var store = new X509Store(StoreName.My, StoreLocation.CurrentUser);
            store.Open(OpenFlags.ReadOnly);

            foreach (var item in store.Certificates)
            {
                Console.WriteLine($"Cert Subject {item.Subject} Thumbprint {item.Thumbprint}");
            }

            store.Close();
        }


        public static byte[] EncryptDataOaepSha1(X509Certificate2 cert, string input)
        {
            // GetRSAPublicKey returns an object with an independent lifetime, so it should be
            // handled via a using statement.
            using (RSA rsa = cert.GetRSAPublicKey())
            {
                byte[] dataBytes = Encoding.UTF8.GetBytes(input);

                // OAEP allows for multiple hashing algorithms, what was formermly just "OAEP" is
                // now OAEP-SHA1.
                return rsa.Encrypt(dataBytes, RSAEncryptionPadding.OaepSHA1);
            }
        }

        public static byte[] DecryptDataOaepSha1(X509Certificate2 cert, string input)
        {
            // GetRSAPrivateKey returns an object with an independent lifetime, so it should be
            // handled via a using statement.
            using (RSA rsa = cert.GetRSAPrivateKey())
            {
                byte[] dataBytes = Encoding.UTF8.GetBytes(input);

                return rsa.Decrypt(dataBytes, RSAEncryptionPadding.OaepSHA1);
            }
        }
    }
}
