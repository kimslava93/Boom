//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Security;

using System.Security.Cryptography;

namespace LINQ_test.Driver
{
    class Crypto
    {

        public static byte[] Encrypt(byte[] input, byte[] key)
        {
            var aesAlg = new AesManaged
            {
                KeySize = 128,
                Key = key,
                BlockSize = 128,
                Mode = CipherMode.ECB,
                Padding = PaddingMode.Zeros,
                IV = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }
            };

            ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
            return encryptor.TransformFinalBlock(input, 0, input.Length);
        }

        public static byte[] Decrypt(byte[] input, byte[] key)
        {
            var aesAlg = new AesManaged
            {
                KeySize = 128,
                Key = key,
                BlockSize = 128,
                Mode = CipherMode.ECB,
                Padding = PaddingMode.Zeros,
                IV = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }
            };

            ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
            return decryptor.TransformFinalBlock(input, 0, input.Length);
        }
    }
}
