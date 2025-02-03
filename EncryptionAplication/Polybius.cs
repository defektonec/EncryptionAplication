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
    public partial class Polybius : Form
    {
        private PolybiusCipher polybius = new PolybiusCipher();
        public Polybius()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(messageInput.Text))
            {
                MessageBox.Show("Input cannot be empty or null");
                return;
            }
            if (messageInput.Text.Any(x => char.IsDigit(x)))
            {
                MessageBox.Show("While encrypting input cannot have any digits");
                return;
            }
            encryptedOutput.Text = polybius.EncryptHash(messageInput.Text);
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(messageInput.Text))
            {
                MessageBox.Show("Input cannot be empty or null");
                return;
            }
            decryptionOutput.Text = polybius.DecryptHash(messageInput.Text);
        }

        private void btnGenerateNewKey_Click(object sender, EventArgs e)
        {
            polybius.GenerateNewKeyHash();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
