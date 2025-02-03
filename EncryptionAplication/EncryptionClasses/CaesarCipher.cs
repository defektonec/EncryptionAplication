using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionAplication.EncryptionClasses
{
    public class CaesarCipher
    {
        public string Encrypt(string input, int shift)
        {
            string PolishAlphabet = "aąbcćdeęfghijklłmnńoópqrsśtuvwxyzźż";

            StringBuilder result = new StringBuilder();

            foreach (char c in input.ToLower())
            {
                if (PolishAlphabet.Contains(c))
                {
                    int oldIndex = PolishAlphabet.IndexOf(c);
                    int newIndex = (oldIndex + shift) % PolishAlphabet.Length;
                    result.Append(PolishAlphabet[newIndex]);
                }
            }
            return result.ToString();
        }
        public string Decrypt(string input, int shift)
        {
            string PolishAlphabet = "aąbcćdeęfghijklłmnńoópqrsśtuvwxyzźż";
            return Encrypt(input.ToLower(), PolishAlphabet.Length - shift % PolishAlphabet.Length);
        }
    }
}
