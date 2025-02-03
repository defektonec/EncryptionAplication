using EncryptionAplication.EncryptionClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptionAplication
{
    public partial class Caesar : Form
    {
        private CaesarCipher caesar = new CaesarCipher();
        public Caesar()
        {
            InitializeComponent();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            Close();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(messageInput.Text))
            {
                MessageBox.Show("Input cannot be empty or null");
                return;
            }
            encryptedOutput.Text = caesar.Encrypt(messageInput.Text, (int)keyInput.Value);
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(messageInput.Text))
            {
                MessageBox.Show("Input cannot be empty or null");
                return;
            }
            decryptionOutput.Text = caesar.Decrypt(messageInput.Text, (int)keyInput.Value);
        }
    }
}
