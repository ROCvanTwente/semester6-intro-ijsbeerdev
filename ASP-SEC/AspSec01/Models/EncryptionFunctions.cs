using System.Text;

namespace AspSec01.Models
{
    public static class EncryptionFunctions
    {
        private const string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

        public static string Encrypt(string input, int key)
        {
            return Shift(input, key);
        }

        public static string Decrypt(string input, int key)
        {
            return Shift(input, -key);
        }

        private static string Shift(string input, int key)
        {
            var result = new StringBuilder();

            foreach (char c in input)
            {
                int index = Alphabet.IndexOf(c);
                if (index >= 0)
                {
                    int newIndex = (index + key + Alphabet.Length) % Alphabet.Length;
                    if (newIndex < 0)
                        newIndex += Alphabet.Length;
                    result.Append(Alphabet[newIndex]);
                }
                else
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }
    }

}
