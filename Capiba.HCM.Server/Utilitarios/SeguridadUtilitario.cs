using System.Security.Cryptography;
using System.Text;

namespace Capiba.HCM.Server.Utilitarios
{
    public class SeguridadUtilitario
    {
        public static string ValorNumerico(string info)
        {
            return info == "" ? "0" : info;
        }
        public static String Cifrar(String txt)
        {
            var cifrado = GetKeys();
            return cifrado.Cifrar(txt);
        }

        public static String Descifrar(String txt)
        {
            var cifrado = GetKeys();
            return cifrado.Descifrar(txt);
        }

        public static Cifrado GetKeys()
        {
            String key =
                "45|79|130|53|31|188|123|188|202|47|225|216|249|247|229|85|180|51|126|136|107|75|177|81|143|50|76|249|109|254|146|7";
            String iv = "193|114|29|223|226|103|105|8|53|210|165|6|130|112|180|134";
            var ks = key.Split('|');
            var ivs = iv.Split('|');
            byte[] ivb = new byte[ivs.Length];
            byte[] keyb = new byte[ks.Length];
            for (int i = 0; i < ivs.Length; i++)
            {
                ivb[i] = Convert.ToByte(ivs[i]);
            }
            for (int i = 0; i < ks.Length; i++)
            {
                keyb[i] = Convert.ToByte(ks[i]);
            }

            var c = new Cifrado()
            {
                key = keyb,
                iv = ivb
            };

            return c;
        }

        public static string GetSHA1(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return "";
            }
            SHA1 sha1 = SHA1Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha1.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }

    }
}
