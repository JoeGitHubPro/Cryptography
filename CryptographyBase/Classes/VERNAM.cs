using System.Text;

namespace CryptographyBase.Classes
{
    public static class VERNAM
    {
        public static string Encrypt(string plainText, string key)
        {
            plainText = plainText.ToUpper();
            key = key.ToUpper();

            byte[] plainBytes = Encoding.ASCII.GetBytes(plainText.ToUpper());
            byte[] keyBytes = Encoding.ASCII.GetBytes(key.ToUpper());
            byte[] encryptedBytes = new byte[plainBytes.Length];

            for (int i = 0; i < plainBytes.Length; i++)
            {
                // XOR operation between plaintext byte and key byte
                encryptedBytes[i] = (byte)(plainBytes[i] ^ keyBytes[i % keyBytes.Length]);
            }

            return Encoding.ASCII.GetString(encryptedBytes).ToString();
        }
    }
}
