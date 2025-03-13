using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace EncryptedNotesApp.Services
{
    public static class EncryptionService
    {
         private static readonly string Key = "0123456789ABCDEF0123456789ABCDEF"; // (256 бiт)

         private static readonly Random Random = new Random();

         public static string Encrypt(string plainText)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = Convert.FromBase64String(Key);   
                aes.IV = GenerateRandomIV();   

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter sw = new StreamWriter(cs))
                        {
                            sw.Write(plainText);
                        }
                        byte[] encryptedData = ms.ToArray();
                         return Convert.ToBase64String(aes.IV) + ":" + Convert.ToBase64String(encryptedData);
                    }
                }
            }
        }

         public static string Decrypt(string cipherText)
        {
            var parts = cipherText.Split(':');
            if (parts.Length != 2)
                throw new FormatException("Invalid cipher text format.");

            byte[] iv = Convert.FromBase64String(parts[0]);
            byte[] cipherBytes = Convert.FromBase64String(parts[1]);

            using (Aes aes = Aes.Create())
            {
                aes.Key = Convert.FromBase64String(Key);
                aes.IV = iv;

                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                using (MemoryStream ms = new MemoryStream(cipherBytes))
                {
                    using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader sr = new StreamReader(cs))
                        {
                            return sr.ReadToEnd();
                        }
                    }
                }
            }
        }

         private static byte[] GenerateRandomIV()
        {
            byte[] iv = new byte[16];  
            Random.NextBytes(iv);
            return iv;
        }

         public static void TestEncryption()
        {
            string original = "Test encryption";
            string encrypted = Encrypt(original);
            string decrypted = Decrypt(encrypted);

            Console.WriteLine($"Original: {original}");
            Console.WriteLine($"Encrypted: {encrypted}");
            Console.WriteLine($"Decrypted: {decrypted}");
        }
    }
}
