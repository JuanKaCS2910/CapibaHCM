using System.Security.Cryptography;
using System.Text;

namespace Capiba.HCM.Server.Utilitarios
{
    public class Cifrado
    {
        public byte[] key { get; set; }
        public byte[] iv { get; set; }

        public String Cifrar(String texto)
        {
            var RMCrypto = new RijndaelManaged();
            var enc = RMCrypto.CreateEncryptor(key, iv);
            byte[] cipherTextBytes;
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(texto);
            using (var memoryStream = new MemoryStream())
            {
                using (var cryptoStream = new CryptoStream(memoryStream, enc, CryptoStreamMode.Write))
                {
                    cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                    cryptoStream.FlushFinalBlock();
                    cipherTextBytes = memoryStream.ToArray();
                    cryptoStream.Close();
                }
                memoryStream.Close();
            }
            return Convert.ToBase64String(cipherTextBytes);
        }

        public String Descifrar(string texto)
        {
            var RMCrypto = new RijndaelManaged();
            byte[] cipherTextBytes = Convert.FromBase64String(texto);
            var decryptor = RMCrypto.CreateDecryptor(key, iv);
            var memoryStreams = new MemoryStream(cipherTextBytes);
            var cryptoStreams = new CryptoStream(memoryStreams, decryptor, CryptoStreamMode.Read);
            byte[] plainTextBytess = new byte[cipherTextBytes.Length];

            int decryptedByteCount = cryptoStreams.Read(plainTextBytess, 0, plainTextBytess.Length);
            memoryStreams.Close();
            cryptoStreams.Close();
            return Encoding.UTF8.GetString(plainTextBytess, 0, decryptedByteCount).TrimEnd("\0".ToCharArray());
        }

    }
}
