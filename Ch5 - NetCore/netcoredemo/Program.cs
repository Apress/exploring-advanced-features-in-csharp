using System;
using System.Security.Cryptography;
using System.Text;

namespace netcoredemo
{
    class Program
    {
        static void Main(string[] args)
        {           
            
            byte[] dataToEncrypt = Encoding.UTF8.GetBytes("String to encrypt");
            
            var encrData = Encrypt(out byte[] key, out byte[] nonce, out byte[] tag, dataToEncrypt);    
            Decrypt(key, nonce, tag, encrData);
            Console.ReadLine();
        }
               
        public static byte[] Encrypt(out byte[] key, out byte[] nonce, out byte[] tag, byte[] dataToEncrypt) 
        {
            key = new byte[16];
            nonce = new byte[12];
            RandomNumberGenerator.Fill(key);            
            RandomNumberGenerator.Fill(nonce);            

            tag = new byte[16];
            byte[] ciphertext = new byte[dataToEncrypt.Length];

            using (AesGcm aes = new AesGcm(key))
                aes.Encrypt(nonce, dataToEncrypt, ciphertext, tag);

            return ciphertext;
        }

        public static void Decrypt(byte[] key
            , byte[] nonce, byte[] tag
            , byte[] ciphertext)
        {
            byte[] decryptedData = new byte[ciphertext.Length];
            using (AesGcm aes = new AesGcm(key))
                aes.Decrypt(nonce, ciphertext, tag, decryptedData); 

            string decryptedText = Encoding.UTF8.GetString(decryptedData);
            Console.WriteLine(decryptedText);
        }
    }
}


