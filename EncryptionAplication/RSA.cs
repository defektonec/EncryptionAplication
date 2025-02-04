using EncryptionApplication.EncryptionClasses;
using System;
using System.Numerics;
using System.Text;
using System.Windows.Forms;

namespace EncryptionAplication
{
    public partial class RSA : Form
    {
        private RSACipher rsa;

        public RSA()
        {
            InitializeComponent();
            rsa = new RSACipher();

            txtPublicKey.Text = rsa.PublicKey.ToString();
            txtPrivateKey.Text = rsa.PrivateKey.ToString();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                string message = txtMessage.Text;
                if (string.IsNullOrEmpty(message))
                {
                    MessageBox.Show("Please enter a message to encrypt.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                byte[] messageBytes = Encoding.UTF8.GetBytes(message);
                BigInteger messageBigInt = new BigInteger(messageBytes, isUnsigned: true, isBigEndian: true);

                BigInteger encryptedMessage = rsa.Encrypt(messageBigInt);

                txtEncrypted.Text = encryptedMessage.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Encryption Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMessage.Text))
                {
                    MessageBox.Show("Please enter an encrypted message to decrypt.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                BigInteger encryptedMessage = BigInteger.Parse(txtMessage.Text);

                BigInteger decryptedBigInt = rsa.Decrypt(encryptedMessage);

                byte[] decryptedBytes = decryptedBigInt.ToByteArray();
                string decryptedMessage = Encoding.UTF8.GetString(decryptedBytes).TrimEnd('\0');

                StringBuilder decryptedMessageReversed = new StringBuilder();

                for (int i = decryptedMessage.Length - 1; i > -1; i--)
                {
                    decryptedMessageReversed.Append(decryptedMessage[i]);
                }

                txtDecrypted.Text = decryptedMessageReversed.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Decryption Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
