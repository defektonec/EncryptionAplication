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
    public partial class Playfair : Form
    {
        public Playfair()
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
                MessageBox.Show("Enter key");
                return;
            }

            PlayfairCipher playfair = new PlayfairCipher(keyInput.Text);
            encryptedOutput.Text = playfair.Encrypt(messageInput.Text);
        }

        private void keyInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(keyInput.Text))
            {
                MessageBox.Show("Enter key");
                return;
            }

            PlayfairCipher playfair = new PlayfairCipher(keyInput.Text);
            decryptionOutput.Text = playfair.Decrypt(messageInput.Text);
        }
    }
}
