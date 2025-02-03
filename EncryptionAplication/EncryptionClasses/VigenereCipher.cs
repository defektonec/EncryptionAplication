using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionAplication
{
    public class VigenereCipher
    {
        private char[,] table = new char[polishAlphabet.Length + 1, polishAlphabet.Length + 1];

        private static string polishAlphabet = "aąbcćdeęfghijklłmnńoópqrsśtuvwxyzźż";

        public VigenereCipher()
        {
            // Set the top-left corner to be empty
            table[0, 0] = ' ';

            // Fill the first row and column with the alphabet
            for (int i = 1; i <= polishAlphabet.Length; i++)
            {
                table[0, i] = polishAlphabet[i - 1]; // Fill top row (headers)
                table[i, 0] = polishAlphabet[i - 1]; // Fill left column (headers)
            }

            // Fill the Vigenere table with shifted alphabet values
            for (int i = 1; i <= polishAlphabet.Length; i++)
            {
                for (int j = 1; j <= polishAlphabet.Length; j++)
                {
                    table[i, j] = polishAlphabet[(i + j - 2) % polishAlphabet.Length];
                }
            }
        }

        public string Encrypt(string message, string key)
        {
            //Check if key is digit and not null, and check if message is not null
            if (string.IsNullOrEmpty(message) || string.IsNullOrEmpty(key)) throw new ArgumentNullException();
            if (key.Any(x => char.IsDigit(x))) throw new ArgumentOutOfRangeException();

            message = message.Replace(" ", "").ToLower();
            StringBuilder sb = new StringBuilder();


            //Check if key lenght is lesser than message lenght
            if (message.Length > key.Length)
            {
                AdjustifyKey(ref key, message.Length);
            }


            for (int i = 0; i < message.Length; i++)
            {
                if (!polishAlphabet.Contains(message[i])) continue;

                int indexOfRow = -1;
                int indexOfColumn = -1;

                //Looking for col index
                for (int col = 1; col <= polishAlphabet.Length; col++)
                {
                    if (message[i] == table[0, col])
                    {
                        indexOfColumn = col;
                        break;
                    }
                }

                //Looking for row index
                for (int row = 1; row <= polishAlphabet.Length; row++)
                {
                    if (key[i] == table[row, 0])
                    {
                        indexOfRow = row;
                        break;
                    }
                }

                if (indexOfRow != -1 && indexOfColumn != -1)
                    sb.Append(table[indexOfRow, indexOfColumn].ToString());

            }

            return sb.ToString();
        }

        public string Decrypt(string message, string key)
        {
            //Check if key is digit and not null, and check if message is not null
            if (string.IsNullOrEmpty(message) || string.IsNullOrEmpty(key)) throw new ArgumentNullException();
            if (key.Any(x => char.IsDigit(x))) throw new ArgumentOutOfRangeException();

            StringBuilder sb = new StringBuilder();
            //Check if key lenght is lesser than message lenght
            if (message.Length > key.Length)
            {
                AdjustifyKey(ref key, message.Length);
            }

            for (int i = 0; i < message.Length; i++)
            {
                int indexOfRow = -1;

                for (int row = 1; row < polishAlphabet.Length; row++)
                {
                    if (table[row, 0] == key[i])
                    {
                        indexOfRow = row;
                        break;
                    }
                }

                for (int col = 1; col < polishAlphabet.Length; col++)
                {
                    if (table[indexOfRow, col] == message[i])
                    {
                        sb.Append(table[0, col]);
                        break;
                    }
                }
            }

            return sb.ToString();
        }

        public void AdjustifyKey(ref string key, int lenght)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < lenght; i++)
            {
                sb.Append(key[i % key.Length]);
            }

            key = sb.ToString();
        }
    }
}
