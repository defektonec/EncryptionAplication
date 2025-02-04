using System;
using System.Numerics;
using System.Security.Cryptography;

namespace EncryptionApplication.EncryptionClasses
{
    public class RSACipher
    {
        public BigInteger PublicKey { get; private set; }
        public BigInteger PrivateKey { get; private set; }
        public BigInteger Modulus { get; private set; }

        private const int KeySize = 512; 

        public RSACipher()
        {
            GenerateRSAKeys();
        }

        private void GenerateRSAKeys()
        {
            BigInteger p = GenerateRandomPrime(KeySize);
            BigInteger q = GenerateRandomPrime(KeySize);
            Modulus = p * q;
            BigInteger phi = (p - 1) * (q - 1);

            PublicKey = 65537; 

            if (BigInteger.GreatestCommonDivisor(PublicKey, phi) != 1)
            {
                GenerateRSAKeys();
                return;
            }

            PrivateKey = ModInverse(PublicKey, phi);
        }

        private BigInteger ModInverse(BigInteger a, BigInteger m)
        {
            BigInteger m0 = m, t, q;
            BigInteger x0 = 0, x1 = 1;

            while (a > 1)
            {
                q = a / m;
                t = m;
                m = a % m;
                a = t;
                t = x0;
                x0 = x1 - q * x0;
                x1 = t;
            }

            if (x1 < 0)
                x1 += m0;

            return x1;
        }

        private BigInteger GenerateRandomPrime(int bitLength)
        {
            while (true)
            {
                BigInteger number = GenerateLargeRandomNumber(bitLength);
                if (IsProbablyPrime(number, 10))
                    return number;
            }
        }

        private BigInteger GenerateLargeRandomNumber(int bitLength)
        {
            byte[] bytes = new byte[bitLength / 8];
            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(bytes);
            }

            bytes[0] |= 0x80;
            bytes[bytes.Length - 1] |= 1;
            return new BigInteger(bytes, isUnsigned: true, isBigEndian: true);
        }

        private bool IsProbablyPrime(BigInteger number, int iterations)
        {
            if (number < 2) return false;
            if (number == 2 || number == 3) return true;
            if (number % 2 == 0) return false;

            BigInteger d = number - 1;
            int s = 0;
            while (d % 2 == 0)
            {
                d /= 2;
                s++;
            }

            Random rng = new Random();
            for (int i = 0; i < iterations; i++)
            {
                BigInteger a = 2 + rng.Next() % (number - 3);
                BigInteger x = BigInteger.ModPow(a, d, number);
                if (x == 1 || x == number - 1)
                    continue;

                bool isComposite = true;
                for (int j = 0; j < s - 1; j++)
                {
                    x = BigInteger.ModPow(x, 2, number);
                    if (x == number - 1)
                    {
                        isComposite = false;
                        break;
                    }
                }
                if (isComposite)
                    return false;
            }
            return true;
        }

        public BigInteger Encrypt(BigInteger message)
        {
            return BigInteger.ModPow(message, PublicKey, Modulus);
        }

        public BigInteger Decrypt(BigInteger ciphertext)
        {
            return BigInteger.ModPow(ciphertext, PrivateKey, Modulus);
        }
    }
}
