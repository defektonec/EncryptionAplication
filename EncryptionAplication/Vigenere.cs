using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EncryptionAplication.EncryptionClasses;

namespace EncryptionAplication
{
    public partial class Vigenere : Form
    {
        private VigenereCipher vigenere = new VigenereCipher();
        public Vigenere()
        {
            InitializeComponent();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(keyInput.Text))
            {
                MessageBox.Show("Key is empty ");
                return;
            }

            string key = keyInput.Text.ToLower().Replace(" ", "");

            if (key.Any(x => char.IsDigit(x)))
            {
                MessageBox.Show("You cannot use digits as a part of key ");
                return;
            }

            if (string.IsNullOrEmpty(messageInput.Text))
            {
                MessageBox.Show("Input cannot be empty or null");
                return;
            }
            


            encryptedOutput.Text = vigenere.Encrypt(messageInput.Text, key);
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(messageInput.Text))
            {
                MessageBox.Show("Input cannot be empty or null");
                return;
            }

            if (string.IsNullOrEmpty(keyInput.Text))
            {
                MessageBox.Show("Key is empty ");
                return;
            }

            if (keyInput.Text.Any(x => char.IsDigit(x)))
            {
                MessageBox.Show("You cannot use digits as a part of key ");
                return;
            }

            string key = keyInput.Text.ToLower().Replace(" ", "");


            decryptionOutput.Text = vigenere.Decrypt(messageInput.Text, key);
        }
    }
}
