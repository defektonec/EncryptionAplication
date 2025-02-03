using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionAplication.EncryptionClasses
{
    public class PlayfairCipher
    {
        private readonly char[,] keySquare;
        private const int Rows = 5;
        private const int Cols = 7;
        private static readonly string PolishAlphabet = "AĄBCĆDEĘFGHIJKLŁMNŃOÓPQRSŚTUVWXYZŹŻ";

        public PlayfairCipher(string key)
        {
            keySquare = GenerateKeySquare(key);
        }

        private char[,] GenerateKeySquare(string key)
        {
            string uniqueKey = new string(key.ToUpper().Distinct().Where(c => PolishAlphabet.Contains(c)).ToArray());
            string remainingLetters = new string(PolishAlphabet.Where(c => !uniqueKey.Contains(c)).ToArray());
            string fullKey = uniqueKey + remainingLetters;

            char[,] square = new char[Rows, Cols];

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    int index = i * Cols + j;
                    square[i, j] = fullKey[index];
                }
            }
            return square;
        }

        private (int, int) FindPosition(char letter)
        {
            for (int row = 0; row < Rows; row++)
            {
                for (int col = 0; col < Cols; col++)
                {
                    if (keySquare[row, col] == letter)
                        return (row, col);
                }
            }
            return (-1, -1);
        }

        public string Encrypt(string plaintext)
        {
            return ProcessText(plaintext, true);
        }

        public string Decrypt(string ciphertext)
        {
            return ProcessText(ciphertext, false);
        }

        private string ProcessText(string input, bool encrypt)
        {
            StringBuilder processedText = new StringBuilder();
            string formattedText = FormatInput(input);

            for (int i = 0; i < formattedText.Length; i += 2)
            {
                char first = formattedText[i];
                char second = (i + 1 < formattedText.Length) ? formattedText[i + 1] : 'X';
                if (first == second) second = first == 'X' ? 'Y' : 'X';

                (int row1, int col1) = FindPosition(first);
                (int row2, int col2) = FindPosition(second);

                if (row1 == row2)
                {
                    col1 = (col1 + (encrypt ? 1 : Cols - 1)) % Cols;
                    col2 = (col2 + (encrypt ? 1 : Cols - 1)) % Cols;
                }
                else if (col1 == col2)
                {
                    row1 = (row1 + (encrypt ? 1 : Rows - 1)) % Rows;
                    row2 = (row2 + (encrypt ? 1 : Rows - 1)) % Rows;
                }
                else
                {
                    (col1, col2) = (col2, col1);
                }

                processedText.Append(keySquare[row1, col1]);
                processedText.Append(keySquare[row2, col2]);
            }
            return processedText.ToString();
        }

        private string FormatInput(string input)
        {
            StringBuilder formattedText = new StringBuilder();
            string upperInput = new string(input.ToUpper().Where(c => PolishAlphabet.Contains(c)).ToArray());

            for (int i = 0; i < upperInput.Length; i++)
            {
                formattedText.Append(upperInput[i]);
                if (i < upperInput.Length - 1 && upperInput[i] == upperInput[i + 1])
                {
                    formattedText.Append('X');
                }
            }
            if (formattedText.Length % 2 != 0)
            {
                formattedText.Append('X');
            }
            return formattedText.ToString();
        }
    }
}
