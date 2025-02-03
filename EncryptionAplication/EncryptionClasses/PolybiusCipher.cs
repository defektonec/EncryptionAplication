using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptionAplication.EncryptionClasses
{
    public class PolybiusCipher
    {

        Dictionary<char, (char, char)> HashTable = new Dictionary<char, (char, char)>()
        {
            { 'a', ('1', '1') }, { 'ą', ('1', '2') }, { 'b', ('1', '3') },
            { 'c', ('1', '4') }, { 'ć', ('1', '5') }, { 'd', ('1', '6') },
            { 'e', ('2', '1') }, { 'ę', ('2', '2') }, { 'f', ('2', '3') },
            { 'g', ('2', '4') }, { 'h', ('2', '5') }, { 'i', ('2', '6') },
            { 'j', ('3', '1') }, { 'k', ('3', '2') }, { 'l', ('3', '3') },
            { 'ł', ('3', '4') }, { 'm', ('3', '5') }, { 'n', ('3', '6') },
            { 'ń', ('4', '1') }, { 'o', ('4', '2') }, { 'ó', ('4', '3') },
            { 'p', ('4', '4') }, { 'r', ('4', '5') }, { 's', ('4', '6') },
            { 'ś', ('5', '1') }, { 't', ('5', '2') }, { 'u', ('5', '3') },
            { 'w', ('5', '4') }, { 'y', ('5', '5') }, { 'z', ('5', '6') },
            { 'ź', ('6', '1') }, { 'ż', ('6', '2') }, { 'v', ('6', '3') },
            { 'q', ('7', '1') }, { 'x', ('7', '2') }
        };

        public void GenerateNewKeyHash()
        {
            List<(char, char)> values = HashTable.Values.ToList();
            values = values.OrderBy(x => new Random().Next()).ToList();

            int indexer = 0;
            foreach (var key in HashTable)
            {
                HashTable[key.Key] = values[indexer];
                indexer++;
            }
        }

        public string EncryptHash(string message)
        {
            StringBuilder result = new StringBuilder();
            message = new string(new string(message.ToLower().Replace(" ", "")
                                   .Where(x => HashTable.ContainsKey(x)).ToArray()));

            foreach (char c in message)
            {
                result.Append(HashTable[c].Item1.ToString() + HashTable[c].Item2.ToString() + " ");
            }
            return EncryptFunc(result.ToString());
        }

        public string DecryptHash(string message)
        {
            if (string.IsNullOrEmpty(message)) throw new ArgumentNullException("message");

            StringBuilder result = new StringBuilder();
            string decryptedMessage = DecryptFunc(message);
            StringBuilder concatenatedMessage = new StringBuilder();

            for (int i = 0; i < decryptedMessage.Length; i++)
            {
                concatenatedMessage.Append(decryptedMessage[i]);

                if (i % 2 == 1)
                {
                    concatenatedMessage.Append(" ");
                }
            }

            List<string> messageList = concatenatedMessage.ToString()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            foreach (var item in messageList)
            {
                char firstChar = item[0];
                char secondChar = item[1];

                foreach (var pair in HashTable)
                {
                    if (pair.Value.Item1 == firstChar && pair.Value.Item2 == secondChar)
                    {
                        result.Append(pair.Key);
                        break;
                    }
                }
            }

            return result.ToString().Trim();
        }


        private string EncryptFunc(string encryptedText)
        {
            if (string.IsNullOrEmpty(encryptedText)) throw new ArgumentNullException("encryptedText");
            BigInteger result = BigInteger.Parse(encryptedText.Replace(" ", ""));
            result = result * result + 15;

            return result.ToString();
        }

        private string DecryptFunc(string encryptedText)
        {
            string concatenatedText = encryptedText.Replace(" ", "").Trim();

            if (BigInteger.TryParse(concatenatedText, out BigInteger result))
            {
                result -= 15;
                return IntegerSquareRoot(result).ToString();
            }

            return "0";
        }

        public BigInteger IntegerSquareRoot(BigInteger value)
        {
            if (value == 0 || value == 1)
                return value;

            BigInteger start = 0, end = value;
            BigInteger result = 0;

            while (start <= end)
            {
                BigInteger mid = (start + end) / 2;

                if (mid * mid == value)
                    return mid;

                if (mid * mid < value)
                {
                    start = mid + 1;
                    result = mid;
                }
                else
                {
                    end = mid - 1;
                }
            }
            return result;
        }
    }
}
