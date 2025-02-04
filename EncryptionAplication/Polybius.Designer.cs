namespace EncryptionAplication
{
    partial class Polybius
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            messageInput = new TextBox();
            btnGoBack = new Button();
            btnDecrypt = new Button();
            btnEncrypt = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            decryptionOutput = new TextBox();
            groupEncryption = new GroupBox();
            encryptedOutput = new TextBox();
            btnGenerateNewKey = new Button();
            groupBox1.SuspendLayout();
            groupEncryption.SuspendLayout();
            SuspendLayout();
            // 
            // messageInput
            // 
            messageInput.BackColor = SystemColors.ButtonHighlight;
            messageInput.ForeColor = SystemColors.WindowText;
            messageInput.Location = new Point(25, 60);
            messageInput.Multiline = true;
            messageInput.Name = "messageInput";
            messageInput.PlaceholderText = "Insert text for encryption or decryption ...";
            messageInput.Size = new Size(316, 120);
            messageInput.TabIndex = 12;
            // 
            // btnGoBack
            // 
            btnGoBack.Location = new Point(25, 11);
            btnGoBack.Name = "btnGoBack";
            btnGoBack.Size = new Size(683, 31);
            btnGoBack.TabIndex = 13;
            btnGoBack.Text = "Go Back";
            btnGoBack.UseVisualStyleBackColor = true;
            btnGoBack.Click += btnGoBack_Click;
            // 
            // btnDecrypt
            // 
            btnDecrypt.Location = new Point(381, 101);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(327, 36);
            btnDecrypt.TabIndex = 10;
            btnDecrypt.Text = "Decrypt Text";
            btnDecrypt.UseVisualStyleBackColor = true;
            btnDecrypt.Click += btnDecrypt_Click;
            // 
            // btnEncrypt
            // 
            btnEncrypt.Location = new Point(380, 60);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(328, 36);
            btnEncrypt.TabIndex = 11;
            btnEncrypt.Text = "Encrypt Text";
            btnEncrypt.UseVisualStyleBackColor = true;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 45);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 9;
            label1.Text = "Input data:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(decryptionOutput);
            groupBox1.Location = new Point(380, 186);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(342, 134);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Decrypted Text";
            // 
            // decryptionOutput
            // 
            decryptionOutput.BackColor = SystemColors.ScrollBar;
            decryptionOutput.ForeColor = SystemColors.WindowText;
            decryptionOutput.Location = new Point(11, 22);
            decryptionOutput.Multiline = true;
            decryptionOutput.Name = "decryptionOutput";
            decryptionOutput.PlaceholderText = "Here will be decrypted text ...";
            decryptionOutput.ReadOnly = true;
            decryptionOutput.Size = new Size(316, 93);
            decryptionOutput.TabIndex = 5;
            // 
            // groupEncryption
            // 
            groupEncryption.Controls.Add(encryptedOutput);
            groupEncryption.Location = new Point(12, 186);
            groupEncryption.Name = "groupEncryption";
            groupEncryption.Size = new Size(342, 134);
            groupEncryption.TabIndex = 15;
            groupEncryption.TabStop = false;
            groupEncryption.Text = "Encrypted Text";
            // 
            // encryptedOutput
            // 
            encryptedOutput.BackColor = SystemColors.ScrollBar;
            encryptedOutput.ForeColor = SystemColors.WindowText;
            encryptedOutput.Location = new Point(11, 22);
            encryptedOutput.Multiline = true;
            encryptedOutput.Name = "encryptedOutput";
            encryptedOutput.PlaceholderText = "Here will be encrypted text ...";
            encryptedOutput.ReadOnly = true;
            encryptedOutput.Size = new Size(316, 93);
            encryptedOutput.TabIndex = 6;
            // 
            // btnGenerateNewKey
            // 
            btnGenerateNewKey.Location = new Point(381, 144);
            btnGenerateNewKey.Name = "btnGenerateNewKey";
            btnGenerateNewKey.Size = new Size(327, 36);
            btnGenerateNewKey.TabIndex = 17;
            btnGenerateNewKey.Text = "Generate New Key";
            btnGenerateNewKey.UseVisualStyleBackColor = true;
            btnGenerateNewKey.Click += btnGenerateNewKey_Click;
            // 
            // Polybius
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 341);
            Controls.Add(btnGenerateNewKey);
            Controls.Add(groupBox1);
            Controls.Add(groupEncryption);
            Controls.Add(messageInput);
            Controls.Add(btnGoBack);
            Controls.Add(btnDecrypt);
            Controls.Add(btnEncrypt);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "Polybius";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Polybius";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupEncryption.ResumeLayout(false);
            groupEncryption.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox messageInput;
        private Button btnGoBack;
        private Button btnDecrypt;
        private Button btnEncrypt;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox decryptionOutput;
        private GroupBox groupEncryption;
        private TextBox encryptedOutput;
        private Button btnGenerateNewKey;
    }
}